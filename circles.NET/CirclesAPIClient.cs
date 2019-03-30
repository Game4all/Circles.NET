﻿using circles.NET.Enums;
using circles.NET.Exceptions;
using circles.NET.HTTP;
using circles.NET.Models;
using System;
using System.Text;
using System.Threading.Tasks;

namespace circles.NET
{
    /// <summary>
    /// An asynchronous client wrapper class for the osu! api v1
    /// </summary>
    public class CirclesAPIClient
    {
        /// <summary>
        /// Gets the underlying <see cref="CirclesHttpClient"/> Http client backing this <see cref="CirclesAPIClient"/> instance
        /// </summary>
        public CirclesHttpClient Client { get; }

        private CirclesAPIClient()
        {
            Client = new CirclesHttpClient(this);
        }

        public CirclesAPIClient(string apiKey)
            : this()
        {
            APIKey = apiKey;
        }

        /// <summary>
        /// Gets or sets the API Key for this <see cref="CirclesAPIClient"/> instance
        /// </summary>
        public string APIKey
        {
            get => ApiKey;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new InvalidAPIKeyException(value);
                ApiKey = value;
            }
        }

        protected string ApiKey;

        //GetUsersAsync overloads

        public async Task<APIUser[]> GetUsersAsync(string name, Gamemode mode = Gamemode.Standard)
            => await Client.GetFromJSON<APIUser[]>(CreateURL("get_user", "k", APIKey, "u", name, "m", (int)mode));

        public async Task<APIUser[]> GetUsersAsync(int id, Gamemode mode = Gamemode.Standard)
            => await Client.GetFromJSON<APIUser[]>(CreateURL("get_user", "k", APIKey, "u", id, "m", (int)mode, "type", "id"));

        //GetScoresAsync overloads

        public async Task<APIScore[]> GetScoresAsync(long beatmapId, string username = null, Gamemode mode = Gamemode.Standard, Mods? mods = null, int? limit = null)
            => await Client.GetFromJSON<APIScore[]>(CreateURL("get_scores", "k", APIKey, "b", beatmapId, "u", username, "mode", (int)mode, "mods", (int?)mods, "limit", limit));

        //GetUserBestAsync overloads

        public async Task<APIUserBest[]> GetUserBestAsync(string username, Gamemode mode = Gamemode.Standard, int? limit = null)
            => await Client.GetFromJSON<APIUserBest[]>(CreateURL("get_user_best", "k", APIKey, "u", username, "mode", (int)mode, "limit", limit));

        //GetUserRecent overloads

        public async Task<APIUserRecent[]> GetUserRecentAsync(string username, Gamemode mode = Gamemode.Standard, int? limit = null)
            => await Client.GetFromJSON<APIUserRecent[]>(CreateURL("get_user_recent", "k", APIKey, "u", username, "mode", (int)mode, "limit", limit));

        //GetBeatmapsAsync overloads

        public async Task<APIBeatmap[]> GetBeatmapsByMapsetAsync(long? mapset_id = null, DateTime? since = null, string creator = null, Gamemode? gamemode = null, Conversions? includeConversions = null, string hash = null, int? limit = null)
            => await Client.GetFromJSON<APIBeatmap[]>(CreateURL("get_beatmaps", "k", APIKey, "since", since?.ToString("s"), "u", creator, "m", (int?)gamemode, "a", (int?)includeConversions, "h", hash, "m", mapset_id, "limit", limit));

        public async Task<APIBeatmap[]> GetBeatmapsByIdAsync(long? beatmap_id = null, DateTime? since = null, string creator = null, Gamemode? gamemode = null, Conversions? includeConversions = null, string hash = null, int? limit = null)
            => await Client.GetFromJSON<APIBeatmap[]>(CreateURL("get_beatmaps", "k", APIKey, "since", since?.ToString("s"), "u", creator, "m", (int?)gamemode, "a", (int?)includeConversions, "h", hash, "b", beatmap_id, "limit", limit));

        //GetReplayAsync overloads

        public async Task<APIReplay> GetReplayAsync(string username, long beatmapId, Gamemode mode)
        {
            try
            {
                var replay = await Client.GetFromJSON<APIReplay>(CreateURL("get_replay", "k", APIKey, "u", username, "b", beatmapId, "m", (int)mode));
                return replay;
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        //GetMatchAsync overloads

        public async Task<APIMultiplayerRoom> GetMultiplayerRoomsAsync(long roomId)
        => await Client.GetFromJSON<APIMultiplayerRoom>(CreateURL("get_replay", "k", APIKey, "mp", roomId));

        /// <summary>
        /// The defaut address to which API requests are made.
        /// <para>Override this if you need to pass API requests to eg: Ripple API</para>
        /// </summary>
        protected virtual string BaseEndpoint => $"https://osu.ppy.sh/api/";

        /// <summary>
        /// Returns a complete URL to the API
        /// </summary>
        /// <param name="endpoint">The endpoint</param>
        /// <param name="queryStrings">The query strings</param>
        /// <returns></returns>
        protected string CreateURL(string endpoint, params object[] queryStrings)
        {
            var sb = new StringBuilder();
            sb.Append(BaseEndpoint);
            sb.Append(endpoint);

            for (int i = 0; i < queryStrings.Length; i += 2) //query strings are given this way [0] = QueryStringName, [1] = QueryStringValue
            {
                if (i == 0) //first parameter should always be API key
                {
                    sb.Append($"?{queryStrings[i].ToString()}={queryStrings[i + 1].ToString()}");
                    continue;
                }

                if (queryStrings[i + 1] != null) //if the query string value is != null , let's add it to the url
                    sb.Append($"&{queryStrings[i].ToString()}={queryStrings[i + 1].ToString()}");
            }
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }
    }
}