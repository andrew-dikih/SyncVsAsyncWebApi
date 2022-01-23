using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLib;

public interface IWebClient
{
    Task StartSendingAsync(IWebServer webServer, TimeSpan interval,CancellationToken cancellationToken);
}
