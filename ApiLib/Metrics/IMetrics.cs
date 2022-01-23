namespace ApiLib.Metrics;

public interface IMetrics
{
    event EventHandler MetricsChanged;
    HashSet<long> TotalRequests { get; }
    HashSet<long> TotalResponses { get; }
    decimal MeanExecutionMs { get; }
    long TotalExecutionMs { get; }
    HashSet<long> QueuedRequests { get; }
    HashSet<ActiveRequest> ActiveRequests { get; }
    HashSet<string> ThreadPool { get; }
    void Reset(IEnumerable<IThread> threads);
    void QueueRequest(long id);
    void StartRequest(ActiveRequest request);
    void UpdateThreadPool(IEnumerable<IThread> threads);
    void AllocateThread(IEnumerable<IThread> threads, ActiveRequest request);
    void ReleaseThread(IEnumerable<IThread> threads,IThread threadReleased);
    void CompleteRequest(long executionMs, long id);
}