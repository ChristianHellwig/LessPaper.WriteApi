namespace LessPaper.WriteService.Options
{
    public class AppSettings
    {
        public ValidationRules ValidationRules { get; set; }

        public ExternalServices ExternalServices { get; set; }
    }

    public class ExternalServices
    {
        public string MinioServerUrl { get; set; }

        public string MinioServerAccessKey { get; set; }

        public string MinioServerSecretKey { get; set; }

        public string MinioBucketName { get; set; }

        public string RabbitMqHost { get; set; }

        public string RabbitMqUsername { get; set; }
        public string RabbitMqPassword { get; set;  }
        public string RabbitMqServerIdentity { get; set; }
    }

    public class ValidationRules
    {

        public int MaxFileSizeInBytes { get; set; }
    }
}
