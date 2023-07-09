using Builder.FluentBuilder;
using Builder.FunctionalBuilder;
using Builder.StepwiseBuilder;
using domain.Entity;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class HostBuilder : IHostedService
    {
        private readonly ILogger<HostBuilder> logger;

        public HostBuilder(ILogger<HostBuilder> logger)
        {
            this.logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Started");

            #region FluentBuilder
            var person = BuildPerson.New
                .Called("Andrya")
                .WorksAsA("Software Engineer")
                .Build();

            logger.LogInformation(person.ToString());
            #endregion

            #region Stepwise builder
            var car = CarBuilder.Create()
                .OfType(CarType.Sedan)
                .WithWeels(10)
                .Build();

            logger.LogInformation(car.ToString());
            #endregion

            #region functional builder
            var book = new BookBuilder()
                .Titled("Novelku")
                .AuthoredBy("Andrya")
                .ReleaseYear(2023)
                .Build();

            logger.LogInformation(book.ToString());
            #endregion

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Stopped");
            return Task.CompletedTask;  
        }
    }
}
