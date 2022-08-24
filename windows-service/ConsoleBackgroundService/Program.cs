using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleBackgroundService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder().Build().Run();
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices(
                    (ctx, services) =>
                    {
                        services.AddHostedService<WorkerService>();
                    });
        }
    }
}
