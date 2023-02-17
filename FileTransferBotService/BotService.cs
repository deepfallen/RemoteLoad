namespace FileTransferBotService
{
    public class BotService : BackgroundService
    {
        private readonly ILogger<BotService> _logger;

        public BotService(ILogger<BotService> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}