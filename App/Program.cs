using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddHostedServices();
                })
                .ConfigureLogging(logging =>
                {
                    logging.AddConsole();
                })
                .Build()
                .Run();
        }
    }
}