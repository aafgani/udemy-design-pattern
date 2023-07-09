﻿using Builder.FluentBuilder;
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

            var person = BuildPerson.New
                .Called("Andrya")
                .WorksAsA("Software Engineer")
                .Build();

            logger.LogInformation(person.ToString());

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Stopped");
            return Task.CompletedTask;  
        }
    }
}
