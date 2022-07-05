using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleBackgroundService
{
    internal class WorkerService : BackgroundService
    {
        private readonly ILogger<WorkerService> _logger;
        public WorkerService(ILogger<WorkerService> logger)
        {
            this._logger = logger;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(!stoppingToken.IsCancellationRequested)
            {
                _logger.Log(LogLevel.Information, $"Running service - current time {DateTime.Now}");
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
