using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLib.Threads;

internal class ThreadAsync : ThreadBase, IThread
{
    public ThreadAsync(int synchronousTimeMs,int ioTimeMs, string id) : base(synchronousTimeMs, ioTimeMs, id)
    {

    }

    public async Task<IThread> ExecuteAsync(Func<Task<IThread>> getThread, Action<IThread> releaseThread, CancellationToken cancellationToken)
    {
        await Task.Delay(SynchronousTimeMs);
        releaseThread(this);//Simulate an async IO operation releasing the current thread context, 
        await Task.Delay(IoTimeMs);//running the async IO operations,
        IThread thread=await getThread();// and requesting a new thread context to finish synchronous operations.
        await Task.Delay(SynchronousTimeMs);
        return thread;
    }
}
