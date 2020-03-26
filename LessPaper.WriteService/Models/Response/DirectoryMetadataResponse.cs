using System.Linq;
using System.Text.Json.Serialization;
using LessPaper.Shared.Interfaces.General;

namespace LessPaper.WriteService.Models.Response
{
    public class DirectoryMetadataResponse : MinimalDirectoryMetadataResponse, IDirectoryMetadata
    {
        public DirectoryMetadataResponse(IDirectoryMetadata directoryMetadata) : base(directoryMetadata)
        {
            FileChilds = directoryMetadata.FileChilds.Select(x => new FileMetadataResponse(x)).ToArray();
            DirectoryChilds = directoryMetadata.DirectoryChilds.Select(x => new MinimalDirectoryMetadataResponse(x)).ToArray();
        }

        /// <inheritdoc />
        [JsonPropertyName("file_childs")]
        public IFileMetadata[] FileChilds { get; }

        /// <inheritdoc />
        [JsonPropertyName("directory_childs")]
        public IMinimalDirectoryMetadata[] DirectoryChilds { get; }
    }
}
