using System.Text.Json.Serialization;
using LessPaper.Shared.Interfaces.General;

namespace LessPaper.WriteService.Models.Response
{
    public class MinimalDirectoryMetadataResponse : ObjectResponse, IMinimalDirectoryMetadata
    {
        /// <inheritdoc />
        public MinimalDirectoryMetadataResponse(IMinimalDirectoryMetadata minimalDirectoryMetadata) : base(minimalDirectoryMetadata)
        {
            NumberOfChilds = minimalDirectoryMetadata.NumberOfChilds;
        }

        /// <inheritdoc />
        [JsonPropertyName("number_of_childs")]
        public uint NumberOfChilds { get; }
    }
}
