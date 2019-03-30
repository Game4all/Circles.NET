﻿using Newtonsoft.Json;
using System;

namespace circles.NET.Models
{
    /// <summary>
    /// Information about an ongoing or finished <see cref="APIMultiplayerRoom"/>
    /// </summary>
    public sealed class APIMultiplayerRoomInfo
    {
        /// <summary>
        /// The ID of this multiplayer room
        /// </summary>
        [JsonProperty(PropertyName = "match_id")]
        public long MatchId { get; set; }

        /// <summary>
        /// The display name of this multiplayer room
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The time at which this room was created
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The time at which this room was deleted (can be null if it's still ongoing)
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public DateTime? EndTime { get; set; }
    }
}