using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLib;

public class WebClient : IWebClient
{
    public async Task StartSendingAsync(IWebServer webServer, TimeSpan interval, CancellationToken cancellationToken)
    {
        long id = 0;
        while(!cancellationToken.IsCancellationRequested)
        {
            webServer.Receive(new WebRequest(id++),cancellationToken);
            await Task.Delay(interval);
        }
    }
}
