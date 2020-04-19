using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LessPaper.Shared.Enums;
using LessPaper.Shared.Interfaces.GuardApi;
using LessPaper.Shared.Interfaces.GuardApi.Response;
using LessPaper.Shared.Interfaces.WriteApi.WriteObjectApi;

namespace LessPaper.WriteService.Models
{
    public class GuardApi : IGuardApi
    {
        public Task<bool> RegisterNewUser(string email, string passwordHash, string salt, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ICredentialsResponse> GetUserCredentials(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IPermissionResponse> GetObjectsPermissions(string userId, string[] objectIds)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddDirectory(string parentDirectoryId, string directoryName, string newDirectoryId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteObject(string objectId)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddFile(string directoryId, string fileId, int fileSize, string encryptedKey, DocumentLanguage documentLanguage,
            ExtensionType fileExtension)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateObjectMetadata(string objectId, IMetadataUpdate updatedMetadata)
        {
            throw new NotImplementedException();
        }
    }
}
