using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LessPaper.Shared.Queueing.Interfaces.RabbitMq;
using LessPaper.WriteService.Options;
using Microsoft.Extensions.Options;

namespace LessPaper.WriteService.Models
{
    public class RabbitMqSettings: IRabbitMqSettings
    {
        public RabbitMqSettings(IOptions<AppSettings> config)
        {
            Host = config.Value.ExternalServices.RabbitMqHost;
            Username = config.Value.ExternalServices.RabbitMqUsername;
            Password = config.Value.ExternalServices.RabbitMqPassword;
            ServerIdentity = config.Value.ExternalServices.RabbitMqServerIdentity;
        }
        public string Host { get; }
        public string Username { get; }
        public string Password { get; }
        public string ServerIdentity { get; }
    }
}
