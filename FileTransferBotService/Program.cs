namespace FileTransferBotService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddHostedService<BotService>();
                })
                .Build();

            host.Run();
        }
    }
}