﻿using System;
using System.Text.Json.Serialization;
using LessPaper.Shared.Interfaces.WriteApi.WriteObjectApi;

namespace LessPaper.WriteService.Models.Response
{
    public class UploadFileResponse : IUploadMetadata
    {
        public UploadFileResponse(IUploadMetadata uploadMetadata)
        {
            ObjectName = uploadMetadata.ObjectName;
            ObjectId = uploadMetadata.ObjectId;
            SizeInByte = uploadMetadata.SizeInByte;
            QuickNumber = uploadMetadata.QuickNumber;
            LatestChangeDate = uploadMetadata.LatestChangeDate;
            LatestViewDate = uploadMetadata.LatestViewDate;
        }

        /// <inheritdoc />
        [JsonPropertyName("object_name")]
        public string ObjectName { get; }

        /// <inheritdoc />
        [JsonPropertyName("object_id")]
        public string ObjectId { get; }

        /// <inheritdoc />
        [JsonPropertyName("size_in_bytes")]
        public uint SizeInByte { get; }

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
