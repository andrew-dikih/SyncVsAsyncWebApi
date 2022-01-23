using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLib;

public interface IWebServer
{
    IEnumerable<IThread> ThreadPool { get; set; }
    void Start();
    void Receive(WebRequest request,CancellationToken cancellationToken);
}
