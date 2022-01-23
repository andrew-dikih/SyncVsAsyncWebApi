using ApiLib;
using ApiLib.Metrics;
using ApiLib.Threads;
using ApiLib.WebServer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            IHost host=Host.CreateDefaultBuilder().ConfigureServices(services =>
                services
                    .AddSingleton<IMetrics,Metrics>()
                    .AddTransient<IWebClient, WebClient>()
                    .AddTransient<IThreadFactory, ThreadFactory>()
                    .AddTransient<IWebServer,WebServer>()
                    .AddTransient<SyncVsAsyncForm>()
            )
            .Build();
            Form form = host.Services.GetRequiredService<SyncVsAsyncForm>();
            Application.Run(form);
        }
    }
}