﻿using circles.NET.Enums;
using Newtonsoft.Json;

namespace circles.NET.Models
{
    /// <summary>
    /// A class representing an osu! score from a play done recently returned by API
    /// </summary>
    public sealed class APIUserRecent
    {
        [JsonProperty(PropertyName = "beatmap_id")]
        public long BeatmapId { get; set; }

        [JsonProperty(PropertyName = "score")]
        public long Score { get; set; }

        [JsonProperty(PropertyName = "maxcombo")]
        public int MaxCombo { get; set; }

        [JsonProperty(PropertyName = "count50")]
        public int Count50s { get; set; }

        [JsonProperty(PropertyName = "count100")]
        public int Count100s { get; set; }

        [JsonProperty(PropertyName = "count300")]
        public int Count300s { get; set; }

        [JsonProperty(PropertyName = "countmiss")]
        public int CountMisses { get; set; }

        [JsonProperty(PropertyName = "countkatu")]
        public int CountKatu { get; set; }

        [JsonProperty(PropertyName = "countgeki")]
        public int CountGeki { get; set; }

        [JsonProperty(PropertyName = "perfect")]
        public string Perfect { get; set; }

        [JsonProperty(PropertyName = "enabled_mods")]
        [JsonConverter(typeof(ModsJSONDeserializer))]
        public Mods[] Mods { get; set; }

        [JsonProperty(PropertyName = "user_id")]
        public long UserId { get; set; }

        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "rank")]
        public string Rank { get; set; }

        [JsonProperty(PropertyName = "pp")]
        public float Pp { get; set; }

        [JsonProperty(PropertyName = "accuracy")]
        public float Accuracy { get; set; }
    }
}