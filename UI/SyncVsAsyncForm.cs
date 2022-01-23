using ApiLib;
using ApiLib.Metrics;

namespace UI;

public partial class SyncVsAsyncForm : Form
{
    private const int MILLISECONDS_PER_SECOND = 1_000;
    private readonly IThreadFactory _threadFactory;
    private readonly IWebClient _webClient;
    private IWebServer _webServer;
    private CancellationTokenSource _cancellationTokenSource;
    private IMetrics _metrics;

    public SyncVsAsyncForm(IWebServer webServer,IThreadFactory threadFactory,IWebClient webClient,IMetrics metrics)
    {
        InitializeComponent();
        _metrics = metrics;
        _threadFactory = threadFactory;
        _webClient = webClient;
        _webServer = webServer;
        _cancellationTokenSource = new CancellationTokenSource();
        _cancellationTokenSource.Cancel();
        _metrics.MetricsChanged += WireUi;
    }

    private void SyncVsAsyncForm_Load(object sender, EventArgs e)
    {
        _webServer.Start();
        numericCountThreads.Value = 10;
    }

    private void butRun_Click(object sender, EventArgs e)
    {
        butRun.Text = _cancellationTokenSource.IsCancellationRequested ? "Stop" : "Start";
        if (!_cancellationTokenSource.IsCancellationRequested)
        {
            _cancellationTokenSource.Cancel();
            EnableUi(true);
            return;
        }
        _cancellationTokenSource = new CancellationTokenSource();
        Reset(_webServer.ThreadPool);
        TimeSpan sendInterval = TimeSpan.FromMilliseconds((int)numericClientIntervalMs.Value);
        _webClient.StartSendingAsync(_webServer, sendInterval, _cancellationTokenSource.Token);//fire and forget
    }

    public string GetLetter(long value)
    {
        char letter = (char)('A' - 1 + value);
        return letter.ToString();
    }

    private void WireUi(object? sender, EventArgs e)
    {
        if(this.InvokeRequired)
        {
            this.Invoke(WireUi,sender, e);
            return;
        }
        numericRequestCount.Value = _metrics.TotalRequests.Count;
        numericResponseCount.Value = _metrics.TotalResponses.Count;
        numericResponseMeanMs.Value = _metrics.MeanExecutionMs / MILLISECONDS_PER_SECOND;
        groupThreadPool.Text = $"Thread Pool ({_metrics.ThreadPool.Count})";
        groupQueuedRequests.Text = $"Queued Requests ({_metrics.QueuedRequests.Count})";
        groupActiveRequests.Text = $"Active Requests ({_metrics.ActiveRequests.Count})";
    }

    private void EnableUi(bool isEnabled)
    {
        groupWebClient.Enabled = isEnabled;
        groupWebServer.Enabled = isEnabled;
    }

    private void Reset(IEnumerable<IThread> threads)
    {
        _metrics.Reset(threads);
        EnableUi(false);
    }

    private void groupThreadPool_Paint(object sender, PaintEventArgs e)
    {
        DrawItems(e, new List<string>(_metrics.ThreadPool.OrderBy(x => x)));
    }

    private void groupQueuedRequests_Paint(object sender, PaintEventArgs e)
    {
        DrawItems(e, new List<long>(_metrics.QueuedRequests.OrderBy(x => x)));
    }

    private void groupActiveRequests_Paint(object sender, PaintEventArgs e)
    {
        DrawItems(e, new List<ActiveRequest>(_metrics.ActiveRequests.OrderBy(x => x.RequestId)));
    }

    private void DrawItems<T>(PaintEventArgs args, IEnumerable<T> hashSet)
    {
        Graphics graphics = args.Graphics;
        int width = args.ClipRectangle.Width;
        int rectWidth = 80;
        int rectHeight = 30;
        int buffer = 10;
        int size = rectWidth + buffer;
        int y = buffer + 10;
        int countDrawn = 0;
        Font font = new Font("Arial", 12);
        int totalItems = hashSet.Count();
        while (countDrawn < totalItems)
        {
            for (int x = buffer; (x < (width-size) && countDrawn < totalItems); x += size)
            {
                T id = hashSet.ElementAt(countDrawn);
                Color color = GetUniqueColor(id);
                using Brush brush = new SolidBrush(color);
                graphics.FillRectangle(brush, new Rectangle(x, y, rectWidth, rectHeight));
                int ratio = 8;
                Point point = new Point(x + (rectWidth / ratio), y + (rectWidth / ratio));
                graphics.DrawString(id?.ToString(), font, Brushes.White, point);
                countDrawn++;
            }
            y += rectHeight+buffer;
        }
    }

    private Color GetUniqueColor<T>(T id)
    {
        return Color.Red;
        //byte red = (byte)(id & 0x000000FF);
        //byte green = (byte)((id & 0x0000FF00) >> 08);
        //byte blue = (byte)((id & 0x00FF0000) >> 16);
        //return Color.FromArgb(red, green, blue);
    }

    private void numericCountThreads_ValueChanged(object sender, EventArgs e)
    {
        UpdateThreads();
    }

    private void radioSync_CheckedChanged(object sender, EventArgs e)
    {
        UpdateThreads();
    }

    private void numericResponseMs_ValueChanged(object sender, EventArgs e)
    {
        UpdateThreads();
        CalculateExpectedResponseMs();
    }

    private void numericSynchMs_ValueChanged(object sender, EventArgs e)
    {
        UpdateThreads();
        CalculateExpectedResponseMs();
    }

    private void CalculateExpectedResponseMs()
    {
        numericExpectedMs.Value = (numericIoMs.Value + (numericSynchMs.Value * 2))/ MILLISECONDS_PER_SECOND;
    }

    private void UpdateThreads()
    {
        IoBehavior ioBehavior = radioAsync.Checked ? IoBehavior.Async : IoBehavior.Sync;
        int synchronousTimeMs = (int)numericSynchMs.Value;
        int ioTimeMs = (int)numericIoMs.Value;
        IEnumerable<IThread> threads = Enumerable.Range(1, (int)numericCountThreads.Value)
            .Select(x => _threadFactory.CreateThread(synchronousTimeMs, ioTimeMs, ioBehavior, GetLetter(x)));
        _webServer.ThreadPool = threads;
    }
}
