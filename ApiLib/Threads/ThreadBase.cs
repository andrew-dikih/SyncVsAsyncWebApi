using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLib.Threads;

internal abstract class ThreadBase
{
    public int SynchronousTimeMs { get;  }
    public int IoTimeMs { get; }

    public string Id { get; }

    public ThreadBase(int synchronousTimeMs,int ioTimeMs, string id)
    {
        SynchronousTimeMs = synchronousTimeMs;
        IoTimeMs = ioTimeMs;
        Id = id;
    }

    public override string ToString()
    {
        return $"Thread {Id}";
    }
}
