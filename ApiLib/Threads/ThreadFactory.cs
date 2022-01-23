using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLib.Threads;

public class ThreadFactory : IThreadFactory
{
    public IThread CreateThread(int synchronousTimeMs, int ioTimeMs, IoBehavior ioBehavior,string id)
    {
        return ioBehavior switch
        {
            IoBehavior.Sync => new ThreadSync(synchronousTimeMs,ioTimeMs,id),
            IoBehavior.Async => new ThreadAsync(synchronousTimeMs,ioTimeMs,id),
            _ => throw new NotImplementedException(),
        };
    }
}
