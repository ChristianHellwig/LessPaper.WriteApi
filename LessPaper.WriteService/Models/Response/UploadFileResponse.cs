using System;
using System.Text.Json.Serialization;
using LessPaper.Shared.Interfaces.WriteApi.WriteObjectApi;

namespace LessPaper.WriteService.Models.Response
{
    public class UploadFileResponse : IUploadMetadata
    {
        public UploadFileResponse(string objectName, string objectId, uint sizeInBytes, DateTime latestChangeDate, DateTime latestViewDate, uint quickNumber)
        {
            ObjectName = objectName;
            ObjectId = objectId;
            SizeInBytes = sizeInBytes;
            LatestChangeDate = latestChangeDate;
            LatestViewDate = latestViewDate;
            QuickNumber = quickNumber;
        }

        /// <inheritdoc />
        [JsonPropertyName("object_name")]
        public string ObjectName { get; }

        /// <inheritdoc />
        [JsonPropertyName("object_id")]
        public string ObjectId { get; }

        /// <inheritdoc />
        [JsonPropertyName("size_in_bytes")]
        public uint SizeInBytes { get; }

        /// <inheritdoc />
        [JsonPropertyName("latest_change_date")]
        public DateTime LatestChangeDate { get; }

        /// <inheritdoc />
        [JsonPropertyName("latest_view_date")]
        public DateTime LatestViewDate { get; }

        /// <inheritdoc />
        [JsonPropertyName("quick_number")]
        public uint QuickNumber { get; }
    }
}
