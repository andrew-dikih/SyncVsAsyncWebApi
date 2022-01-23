using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLib.Threads;

internal class ThreadSync : ThreadBase, IThread
{
    public ThreadSync(int synchronousTimeMs,int ioTimeMs, string id) : base(synchronousTimeMs, ioTimeMs,id)
    {

    }

    public async Task<IThread> ExecuteAsync(Func<Task<IThread>> getThread, Action<IThread> releaseThread, CancellationToken cancellationToken)
    {
        await Task.Delay(SynchronousTimeMs);
        await Task.Delay(IoTimeMs);
        await Task.Delay(SynchronousTimeMs);
        return this;
    }
}
