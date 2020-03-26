﻿using System;
using System.Text.Json.Serialization;
using LessPaper.Shared.Interfaces.General;

namespace LessPaper.WriteService.Models.Response
{
    public class ObjectResponse : IMetadata
    {
        public ObjectResponse(IMetadata metadata)
        {
            ObjectName = metadata.ObjectName;
            ObjectId = metadata.ObjectId;
            SizeInByte = metadata.SizeInByte;
            LatestChangeDate = metadata.LatestChangeDate;
            LatestViewDate = metadata.LatestViewDate;
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
    }
}
