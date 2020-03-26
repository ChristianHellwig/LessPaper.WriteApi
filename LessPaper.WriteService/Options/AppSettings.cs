namespace LessPaper.WriteService.Options
{
    public class AppSettings
    {
        public JwtSettings JwtSettings { get; set; }

        public ValidationRules ValidationRules { get; set; }

        public ExternalServices ExternalServices { get; set; }
    }

    public class ExternalServices
    {
        public string MinioServerUrl { get; set; }

        public string MinioServerAccessKey { get; set; }

        public string MinioServerSecretKey { get; set; }

        public string MinioBucketName { get; set; }
        
    }

    public class JwtSettings {

        // TODO Determine better way to handle the jwt secret
        public string Secret { get; set; }
    }

    public class ValidationRules
    {
        public uint MinimumPasswordLength { get; set; }

        public int MaxFileSizeInBytes { get; set; }
    }
}
