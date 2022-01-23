using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace ApiLib.Metrics;

public class Metrics : IMetrics
{
    public HashSet<long> TotalRequests => _totalRequests;
    public HashSet<long> TotalResponses => _totalResponses;
    public long TotalExecutionMs => _totalExecutionMs;
    public decimal MeanExecutionMs => (TotalResponses.Count > 0) ? (decimal)TotalExecutionMs / TotalResponses.Count : 0;

    public HashSet<long> QueuedRequests => _queuedRequests;

    public HashSet<ActiveRequest> ActiveRequests => _activeRequests;

    public HashSet<string> ThreadPool => _threadPool;

    private HashSet<long> _totalRequests;
    private HashSet<long> _totalResponses;
    private long _totalExecutionMs;
    private HashSet<long> _queuedRequests;
    private HashSet<ActiveRequest> _activeRequests;
    private HashSet<string> _threadPool;
    private readonly ILogger<Metrics> _logger;

    public event EventHandler MetricsChanged;

    public Metrics(ILogger<Metrics> logger)
    {
        _logger = logger;
        Reset(new List<IThread>());
    }

    public void QueueRequest(long id)
    {
        _logger.LogInformation("Queuing {id}", id);
        _totalRequests.Add(id);
        _queuedRequests.Add(id);
        _logger.LogDebug("{metrics}", this);
        MetricsChanged?.Invoke(this, EventArgs.Empty);
    }

    public void StartRequest(ActiveRequest request)
    {
        _logger.LogInformation("Starting {request}", request);
        _activeRequests.Add(request);
        _queuedRequests.Remove(request.RequestId);
        MetricsChanged?.Invoke(this, EventArgs.Empty);
    }

    public void CompleteRequest(long executionMs,long id)
    {
        _logger.LogInformation("Completing {id}", id);
        _totalResponses.Add(id);
        _activeRequests.RemoveWhere(x => x.RequestId==id);
        _totalExecutionMs += executionMs;
        _logger.LogDebug("{metrics}", this);
        MetricsChanged?.Invoke(this, EventArgs.Empty);
    }

    public void AllocateThread(IEnumerable<IThread> threads, ActiveRequest request)
    {
        _logger.LogInformation("Allocating {request}", request);
        foreach (ActiveRequest activeRequest in _activeRequests.Where(x => x.RequestId == request.RequestId))
        {
            activeRequest.Thread = request.Thread;
        }
        UpdateThreadPool(threads);
    }


    public void ReleaseThread(IEnumerable<IThread> threads, IThread threadReleased)
    {
        _logger.LogInformation("Releasing {thread}", threadReleased);
        foreach (ActiveRequest request in _activeRequests.Where(x => x.Thread?.Id == threadReleased.Id))
        {
            request.Thread = null;
        }
        UpdateThreadPool(threads);
    }

    public void UpdateThreadPool(IEnumerable<IThread> threads)
    {
        _threadPool = threads.Select(x => x.Id).ToHashSet();
        MetricsChanged?.Invoke(this, EventArgs.Empty);
    }

    public void Reset(IEnumerable<IThread> threads)
    {
        _totalRequests = new HashSet<long>();
        _totalResponses = new HashSet<long>();
        _totalExecutionMs = 0;
        _activeRequests = new HashSet<ActiveRequest>();
        _queuedRequests = new HashSet<long>();
        UpdateThreadPool(threads);
    }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this,new JsonSerializerOptions { WriteIndented=true });
    }
}
