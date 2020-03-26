using System;
using System.IO;
using LessPaper.Shared.Enums;
using LessPaper.Shared.Interfaces.Buckets;
using LessPaper.Shared.Interfaces.GuardApi;
using LessPaper.WriteService.Controllers;
using LessPaper.WriteService.Controllers.v1;
using LessPaper.WriteService.Options;
using Microsoft.Extensions.Options;
using Moq;
using Xunit;

namespace LessPaper.WriteService.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void FileUpload()
        {
            var appSettings = new AppSettings();
            var optionsMock = new Mock<IOptions<AppSettings>>();
            optionsMock.Setup(options => options.Value).Returns(appSettings);

            var guard = new Mock<IGuardApi>();
            guard.Setup(api => api.AddFile(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<int>(),
                It.IsAny<string>(),
                It.IsAny<DocumentLanguage>(),
                It.IsAny<ExtensionType>()));
            

            var bucketMock = new Mock<IBucket>();
            bucketMock.Setup(x => x.UploadFileEncrypted(
                It.IsAny<string>(), 
                It.IsAny<string>(), 
                It.IsAny<int>(), 
                It.IsAny<byte[]>(), It.IsAny<Stream>()));


            var e = new WriteObjectsController(optionsMock.Object, guard.Object, null, null);
        }
    }
}
