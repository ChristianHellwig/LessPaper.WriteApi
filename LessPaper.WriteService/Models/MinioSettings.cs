using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LessPaper.Shared.MinIO.Interfaces;
using LessPaper.WriteService.Options;
using MassTransit;
using Microsoft.Extensions.Options;

namespace LessPaper.WriteService.Models
{
    public class MinioSettings: IMinioSettings
    {
        public MinioSettings(IOptions<AppSettings> config)
        {
            Hostname = config.Value.ExternalServices.MinioServerUrl;
            AccessKey = config.Value.ExternalServices.MinioServerAccessKey;
            SecretKey = config.Value.ExternalServices.MinioServerSecretKey;
        }
        public string Hostname { get; }
        public string AccessKey { get; }
        public string SecretKey { get; }
    }
}
