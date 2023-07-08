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