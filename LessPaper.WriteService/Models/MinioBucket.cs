using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LessPaper.Shared.Interfaces.Buckets;
using LessPaper.WriteService.Options;
using Microsoft.Extensions.Options;
using Minio;
using Minio.DataModel;

namespace LessPaper.WriteService.Models
{
    public class MinioBucket : IBucket
    {
        private readonly MinioClient minio;

        public MinioBucket(IOptions<AppSettings> settings)
        {
            minio = new MinioClient(
                settings.Value.ExternalServices.MinioServerUrl, 
                settings.Value.ExternalServices.MinioServerAccessKey, 
                settings.Value.ExternalServices.MinioServerSecretKey).WithSSL();
            
        }

        public async Task<bool> UploadFileEncrypted(string bucketName, string fileId, int fileSize, byte[] plaintextKey, Stream fileStream)
        {
            try
            {
                var serverSideEncryption = new SSEC(plaintextKey);

                await minio.PutObjectAsync(
                    bucketName,
                    fileId,
                    fileStream,
                    fileSize,
                    "application/octet-stream",
                    null,
                    serverSideEncryption,
                    CancellationToken.None);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }


        public Task<bool> UploadFile(string bucketName, string fileId, int fileSize, Stream fileStream)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DownloadFile(string bucketName, string fileId, int fileSize, Stream fileStream)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DownloadFileDecrypted(string bucketName, string fileId, int fileSize, byte[] plaintextKey, Stream fileStream)
        {
            throw new NotImplementedException();
        }
    }
}
