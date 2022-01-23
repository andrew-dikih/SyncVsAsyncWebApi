using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLib;

public interface IThread
{
    string Id { get; }
    int IoTimeMs { get; }
    Task<IThread> ExecuteAsync(Func<Task<IThread>> getThread,Action<IThread> releaseThread,CancellationToken cancellationToken);
}
