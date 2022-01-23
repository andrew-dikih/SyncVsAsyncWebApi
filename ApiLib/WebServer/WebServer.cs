using System.Collections.Concurrent;
using System.Diagnostics;
using ApiLib.Metrics;

namespace ApiLib.WebServer;

public class WebServer : IWebServer
{
    public IEnumerable<IThread> ThreadPool {
        get
        {
            return _threadPool??new List<IThread>();
        }
        set
        {
            _threadPool = value;
            _threadPoolAvailable=new ConcurrentQueue<IThread>(_threadPool);
            _metrics.UpdateThreadPool(_threadPoolAvailable);
        }
    }
    private IEnumerable<IThread>? _threadPool;
    private ConcurrentQueue<IThread> _threadPoolAvailable=new ConcurrentQueue<IThread>();
    private ConcurrentQueue<Func<IThread,Task>> _requestQueue=new ConcurrentQueue<Func<IThread,Task>>();
    private readonly IMetrics _metrics;

    public WebServer(IMetrics metrics)
    {
        _metrics = metrics;
    }

    public void Receive(WebRequest request,CancellationToken cancellationToken)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        _metrics.QueueRequest(request.Id);
        _requestQueue.Enqueue(thread => ProcessRequest(request,thread,stopwatch, cancellationToken));
        
    }

    private async Task ProcessRequest(WebRequest request,IThread thread,Stopwatch stopwatch,CancellationToken cancellationToken)
    {
        _metrics.StartRequest(new ActiveRequest { Thread = thread, RequestId = request.Id });
        thread = await thread.ExecuteAsync(() => GetThread(request.Id), ReleaseThread, cancellationToken);
        ReleaseThread(thread);
        stopwatch.Stop();
        _metrics.CompleteRequest(stopwatch.ElapsedMilliseconds, request.Id);
    }

    private async Task<IThread> GetThread(long id)
    {
        IThread? thread;
        while (!_threadPoolAvailable.TryDequeue(out thread))
        {
            await Task.Delay(TimeSpan.FromTicks(1));
        }
        _metrics.AllocateThread(_threadPoolAvailable,new ActiveRequest { Thread=thread,RequestId=id });
        return thread;
    }

    private void ReleaseThread(IThread thread)
    {
        _threadPoolAvailable.Enqueue(thread);
        _metrics.ReleaseThread(_threadPoolAvailable.Select(x => x),thread);
    }

    public void Start()
    {
        Task.Run(async () =>
        {
            while (true)
            {
                //Process requests in the order they were received.
                if (_requestQueue.TryDequeue(out Func<IThread, Task>? process))
                {
                    IThread thread = await GetThread(-1);//not great, but doesn't really do anything.
                    process(thread);//Fire and forget
                }
            }
        });
    }
}
