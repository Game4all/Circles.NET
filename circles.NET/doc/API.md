<a name='assembly'></a>
# circles.NET

## Contents

- [APIBeatmap](#T-circles-NET-Models-APIBeatmap 'circles.NET.Models.APIBeatmap')
  - [AR](#P-circles-NET-Models-APIBeatmap-AR 'circles.NET.Models.APIBeatmap.AR')
  - [AimRating](#P-circles-NET-Models-APIBeatmap-AimRating 'circles.NET.Models.APIBeatmap.AimRating')
  - [ApprovedDate](#P-circles-NET-Models-APIBeatmap-ApprovedDate 'circles.NET.Models.APIBeatmap.ApprovedDate')
  - [ApprovedStatus](#P-circles-NET-Models-APIBeatmap-ApprovedStatus 'circles.NET.Models.APIBeatmap.ApprovedStatus')
  - [Artist](#P-circles-NET-Models-APIBeatmap-Artist 'circles.NET.Models.APIBeatmap.Artist')
  - [AudioUnavalaible](#P-circles-NET-Models-APIBeatmap-AudioUnavalaible 'circles.NET.Models.APIBeatmap.AudioUnavalaible')
  - [BeatmapId](#P-circles-NET-Models-APIBeatmap-BeatmapId 'circles.NET.Models.APIBeatmap.BeatmapId')
  - [Bpm](#P-circles-NET-Models-APIBeatmap-Bpm 'circles.NET.Models.APIBeatmap.Bpm')
  - [CS](#P-circles-NET-Models-APIBeatmap-CS 'circles.NET.Models.APIBeatmap.CS')
  - [Creator](#P-circles-NET-Models-APIBeatmap-Creator 'circles.NET.Models.APIBeatmap.Creator')
  - [Difficulty](#P-circles-NET-Models-APIBeatmap-Difficulty 'circles.NET.Models.APIBeatmap.Difficulty')
  - [DownloadUnavalaible](#P-circles-NET-Models-APIBeatmap-DownloadUnavalaible 'circles.NET.Models.APIBeatmap.DownloadUnavalaible')
  - [FavouriteCount](#P-circles-NET-Models-APIBeatmap-FavouriteCount 'circles.NET.Models.APIBeatmap.FavouriteCount')
  - [Gamemode](#P-circles-NET-Models-APIBeatmap-Gamemode 'circles.NET.Models.APIBeatmap.Gamemode')
  - [Genre](#P-circles-NET-Models-APIBeatmap-Genre 'circles.NET.Models.APIBeatmap.Genre')
  - [HP](#P-circles-NET-Models-APIBeatmap-HP 'circles.NET.Models.APIBeatmap.HP')
  - [Language](#P-circles-NET-Models-APIBeatmap-Language 'circles.NET.Models.APIBeatmap.Language')
  - [LastUpdate](#P-circles-NET-Models-APIBeatmap-LastUpdate 'circles.NET.Models.APIBeatmap.LastUpdate')
  - [MD5](#P-circles-NET-Models-APIBeatmap-MD5 'circles.NET.Models.APIBeatmap.MD5')
  - [MapsetId](#P-circles-NET-Models-APIBeatmap-MapsetId 'circles.NET.Models.APIBeatmap.MapsetId')
  - [MaxCombo](#P-circles-NET-Models-APIBeatmap-MaxCombo 'circles.NET.Models.APIBeatmap.MaxCombo')
  - [NormalObjectCount](#P-circles-NET-Models-APIBeatmap-NormalObjectCount 'circles.NET.Models.APIBeatmap.NormalObjectCount')
  - [OD](#P-circles-NET-Models-APIBeatmap-OD 'circles.NET.Models.APIBeatmap.OD')
  - [Passcount](#P-circles-NET-Models-APIBeatmap-Passcount 'circles.NET.Models.APIBeatmap.Passcount')
  - [PlaybableLength](#P-circles-NET-Models-APIBeatmap-PlaybableLength 'circles.NET.Models.APIBeatmap.PlaybableLength')
  - [Playcount](#P-circles-NET-Models-APIBeatmap-Playcount 'circles.NET.Models.APIBeatmap.Playcount')
  - [Rating](#P-circles-NET-Models-APIBeatmap-Rating 'circles.NET.Models.APIBeatmap.Rating')
  - [SliderObjectCount](#P-circles-NET-Models-APIBeatmap-SliderObjectCount 'circles.NET.Models.APIBeatmap.SliderObjectCount')
  - [Source](#P-circles-NET-Models-APIBeatmap-Source 'circles.NET.Models.APIBeatmap.Source')
  - [SpeedRating](#P-circles-NET-Models-APIBeatmap-SpeedRating 'circles.NET.Models.APIBeatmap.SpeedRating')
  - [SpinnerObjectCount](#P-circles-NET-Models-APIBeatmap-SpinnerObjectCount 'circles.NET.Models.APIBeatmap.SpinnerObjectCount')
  - [StarRating](#P-circles-NET-Models-APIBeatmap-StarRating 'circles.NET.Models.APIBeatmap.StarRating')
  - [SubmissionDate](#P-circles-NET-Models-APIBeatmap-SubmissionDate 'circles.NET.Models.APIBeatmap.SubmissionDate')
  - [Tags](#P-circles-NET-Models-APIBeatmap-Tags 'circles.NET.Models.APIBeatmap.Tags')
  - [Title](#P-circles-NET-Models-APIBeatmap-Title 'circles.NET.Models.APIBeatmap.Title')
  - [TotalLength](#P-circles-NET-Models-APIBeatmap-TotalLength 'circles.NET.Models.APIBeatmap.TotalLength')
- [APIMultiplayerGame](#T-circles-NET-Models-APIMultiplayerGame 'circles.NET.Models.APIMultiplayerGame')
  - [BeatmapId](#P-circles-NET-Models-APIMultiplayerGame-BeatmapId 'circles.NET.Models.APIMultiplayerGame.BeatmapId')
  - [EndTime](#P-circles-NET-Models-APIMultiplayerGame-EndTime 'circles.NET.Models.APIMultiplayerGame.EndTime')
  - [GameId](#P-circles-NET-Models-APIMultiplayerGame-GameId 'circles.NET.Models.APIMultiplayerGame.GameId')
  - [Gamemode](#P-circles-NET-Models-APIMultiplayerGame-Gamemode 'circles.NET.Models.APIMultiplayerGame.Gamemode')
  - [Mods](#P-circles-NET-Models-APIMultiplayerGame-Mods 'circles.NET.Models.APIMultiplayerGame.Mods')
  - [Scores](#P-circles-NET-Models-APIMultiplayerGame-Scores 'circles.NET.Models.APIMultiplayerGame.Scores')
  - [StartTime](#P-circles-NET-Models-APIMultiplayerGame-StartTime 'circles.NET.Models.APIMultiplayerGame.StartTime')
- [APIMultiplayerRoom](#T-circles-NET-Models-APIMultiplayerRoom 'circles.NET.Models.APIMultiplayerRoom')
  - [Games](#P-circles-NET-Models-APIMultiplayerRoom-Games 'circles.NET.Models.APIMultiplayerRoom.Games')
  - [Info](#P-circles-NET-Models-APIMultiplayerRoom-Info 'circles.NET.Models.APIMultiplayerRoom.Info')
- [APIMultiplayerRoomInfo](#T-circles-NET-Models-APIMultiplayerRoomInfo 'circles.NET.Models.APIMultiplayerRoomInfo')
  - [EndTime](#P-circles-NET-Models-APIMultiplayerRoomInfo-EndTime 'circles.NET.Models.APIMultiplayerRoomInfo.EndTime')
  - [MatchId](#P-circles-NET-Models-APIMultiplayerRoomInfo-MatchId 'circles.NET.Models.APIMultiplayerRoomInfo.MatchId')
  - [Name](#P-circles-NET-Models-APIMultiplayerRoomInfo-Name 'circles.NET.Models.APIMultiplayerRoomInfo.Name')
  - [StartTime](#P-circles-NET-Models-APIMultiplayerRoomInfo-StartTime 'circles.NET.Models.APIMultiplayerRoomInfo.StartTime')
- [APIReplay](#T-circles-NET-Models-APIReplay 'circles.NET.Models.APIReplay')
- [APIScore](#T-circles-NET-Models-APIScore 'circles.NET.Models.APIScore')
  - [Count100s](#P-circles-NET-Models-APIScore-Count100s 'circles.NET.Models.APIScore.Count100s')
  - [Count300s](#P-circles-NET-Models-APIScore-Count300s 'circles.NET.Models.APIScore.Count300s')
  - [Count50s](#P-circles-NET-Models-APIScore-Count50s 'circles.NET.Models.APIScore.Count50s')
  - [CountGeki](#P-circles-NET-Models-APIScore-CountGeki 'circles.NET.Models.APIScore.CountGeki')
  - [CountKatu](#P-circles-NET-Models-APIScore-CountKatu 'circles.NET.Models.APIScore.CountKatu')
  - [CountMisses](#P-circles-NET-Models-APIScore-CountMisses 'circles.NET.Models.APIScore.CountMisses')
  - [Date](#P-circles-NET-Models-APIScore-Date 'circles.NET.Models.APIScore.Date')
  - [ID](#P-circles-NET-Models-APIScore-ID 'circles.NET.Models.APIScore.ID')
  - [MaxCombo](#P-circles-NET-Models-APIScore-MaxCombo 'circles.NET.Models.APIScore.MaxCombo')
  - [Mods](#P-circles-NET-Models-APIScore-Mods 'circles.NET.Models.APIScore.Mods')
  - [Perfect](#P-circles-NET-Models-APIScore-Perfect 'circles.NET.Models.APIScore.Perfect')
  - [Pp](#P-circles-NET-Models-APIScore-Pp 'circles.NET.Models.APIScore.Pp')
  - [Rank](#P-circles-NET-Models-APIScore-Rank 'circles.NET.Models.APIScore.Rank')
  - [ReplayAvalaible](#P-circles-NET-Models-APIScore-ReplayAvalaible 'circles.NET.Models.APIScore.ReplayAvalaible')
  - [Score](#P-circles-NET-Models-APIScore-Score 'circles.NET.Models.APIScore.Score')
  - [UserId](#P-circles-NET-Models-APIScore-UserId 'circles.NET.Models.APIScore.UserId')
  - [Username](#P-circles-NET-Models-APIScore-Username 'circles.NET.Models.APIScore.Username')
- [APIUser](#T-circles-NET-Models-APIUser 'circles.NET.Models.APIUser')
  - [Accuracy](#P-circles-NET-Models-APIUser-Accuracy 'circles.NET.Models.APIUser.Accuracy')
  - [Count100](#P-circles-NET-Models-APIUser-Count100 'circles.NET.Models.APIUser.Count100')
  - [Count300](#P-circles-NET-Models-APIUser-Count300 'circles.NET.Models.APIUser.Count300')
  - [Count50](#P-circles-NET-Models-APIUser-Count50 'circles.NET.Models.APIUser.Count50')
  - [CountRankA](#P-circles-NET-Models-APIUser-CountRankA 'circles.NET.Models.APIUser.CountRankA')
  - [CountRankS](#P-circles-NET-Models-APIUser-CountRankS 'circles.NET.Models.APIUser.CountRankS')
  - [CountRankSH](#P-circles-NET-Models-APIUser-CountRankSH 'circles.NET.Models.APIUser.CountRankSH')
  - [CountRankSS](#P-circles-NET-Models-APIUser-CountRankSS 'circles.NET.Models.APIUser.CountRankSS')
  - [CountRankXH](#P-circles-NET-Models-APIUser-CountRankXH 'circles.NET.Models.APIUser.CountRankXH')
  - [Country](#P-circles-NET-Models-APIUser-Country 'circles.NET.Models.APIUser.Country')
  - [JoinDate](#P-circles-NET-Models-APIUser-JoinDate 'circles.NET.Models.APIUser.JoinDate')
  - [Level](#P-circles-NET-Models-APIUser-Level 'circles.NET.Models.APIUser.Level')
  - [Playcount](#P-circles-NET-Models-APIUser-Playcount 'circles.NET.Models.APIUser.Playcount')
  - [PpCountryRank](#P-circles-NET-Models-APIUser-PpCountryRank 'circles.NET.Models.APIUser.PpCountryRank')
  - [PpRank](#P-circles-NET-Models-APIUser-PpRank 'circles.NET.Models.APIUser.PpRank')
  - [PpRaw](#P-circles-NET-Models-APIUser-PpRaw 'circles.NET.Models.APIUser.PpRaw')
  - [RankedScore](#P-circles-NET-Models-APIUser-RankedScore 'circles.NET.Models.APIUser.RankedScore')
  - [TimePlayed](#P-circles-NET-Models-APIUser-TimePlayed 'circles.NET.Models.APIUser.TimePlayed')
  - [TotalScore](#P-circles-NET-Models-APIUser-TotalScore 'circles.NET.Models.APIUser.TotalScore')
  - [UserId](#P-circles-NET-Models-APIUser-UserId 'circles.NET.Models.APIUser.UserId')
  - [Username](#P-circles-NET-Models-APIUser-Username 'circles.NET.Models.APIUser.Username')
- [APIUserBest](#T-circles-NET-Models-APIUserBest 'circles.NET.Models.APIUserBest')
  - [BeatmapId](#P-circles-NET-Models-APIUserBest-BeatmapId 'circles.NET.Models.APIUserBest.BeatmapId')
  - [Count100s](#P-circles-NET-Models-APIUserBest-Count100s 'circles.NET.Models.APIUserBest.Count100s')
  - [Count300s](#P-circles-NET-Models-APIUserBest-Count300s 'circles.NET.Models.APIUserBest.Count300s')
  - [Count50s](#P-circles-NET-Models-APIUserBest-Count50s 'circles.NET.Models.APIUserBest.Count50s')
  - [CountGeki](#P-circles-NET-Models-APIUserBest-CountGeki 'circles.NET.Models.APIUserBest.CountGeki')
  - [CountKatu](#P-circles-NET-Models-APIUserBest-CountKatu 'circles.NET.Models.APIUserBest.CountKatu')
  - [CountMisses](#P-circles-NET-Models-APIUserBest-CountMisses 'circles.NET.Models.APIUserBest.CountMisses')
  - [Date](#P-circles-NET-Models-APIUserBest-Date 'circles.NET.Models.APIUserBest.Date')
  - [ID](#P-circles-NET-Models-APIUserBest-ID 'circles.NET.Models.APIUserBest.ID')
  - [MaxCombo](#P-circles-NET-Models-APIUserBest-MaxCombo 'circles.NET.Models.APIUserBest.MaxCombo')
  - [Mods](#P-circles-NET-Models-APIUserBest-Mods 'circles.NET.Models.APIUserBest.Mods')
  - [Perfect](#P-circles-NET-Models-APIUserBest-Perfect 'circles.NET.Models.APIUserBest.Perfect')
  - [Pp](#P-circles-NET-Models-APIUserBest-Pp 'circles.NET.Models.APIUserBest.Pp')
  - [Rank](#P-circles-NET-Models-APIUserBest-Rank 'circles.NET.Models.APIUserBest.Rank')
  - [Score](#P-circles-NET-Models-APIUserBest-Score 'circles.NET.Models.APIUserBest.Score')
  - [UserId](#P-circles-NET-Models-APIUserBest-UserId 'circles.NET.Models.APIUserBest.UserId')
- [APIUserRecent](#T-circles-NET-Models-APIUserRecent 'circles.NET.Models.APIUserRecent')
  - [Accuracy](#P-circles-NET-Models-APIUserRecent-Accuracy 'circles.NET.Models.APIUserRecent.Accuracy')
  - [BeatmapId](#P-circles-NET-Models-APIUserRecent-BeatmapId 'circles.NET.Models.APIUserRecent.BeatmapId')
  - [Count100s](#P-circles-NET-Models-APIUserRecent-Count100s 'circles.NET.Models.APIUserRecent.Count100s')
  - [Count300s](#P-circles-NET-Models-APIUserRecent-Count300s 'circles.NET.Models.APIUserRecent.Count300s')
  - [Count50s](#P-circles-NET-Models-APIUserRecent-Count50s 'circles.NET.Models.APIUserRecent.Count50s')
  - [CountGeki](#P-circles-NET-Models-APIUserRecent-CountGeki 'circles.NET.Models.APIUserRecent.CountGeki')
  - [CountKatu](#P-circles-NET-Models-APIUserRecent-CountKatu 'circles.NET.Models.APIUserRecent.CountKatu')
  - [CountMisses](#P-circles-NET-Models-APIUserRecent-CountMisses 'circles.NET.Models.APIUserRecent.CountMisses')
  - [Date](#P-circles-NET-Models-APIUserRecent-Date 'circles.NET.Models.APIUserRecent.Date')
  - [MaxCombo](#P-circles-NET-Models-APIUserRecent-MaxCombo 'circles.NET.Models.APIUserRecent.MaxCombo')
  - [Mods](#P-circles-NET-Models-APIUserRecent-Mods 'circles.NET.Models.APIUserRecent.Mods')
  - [Perfect](#P-circles-NET-Models-APIUserRecent-Perfect 'circles.NET.Models.APIUserRecent.Perfect')
  - [Pp](#P-circles-NET-Models-APIUserRecent-Pp 'circles.NET.Models.APIUserRecent.Pp')
  - [Rank](#P-circles-NET-Models-APIUserRecent-Rank 'circles.NET.Models.APIUserRecent.Rank')
  - [Score](#P-circles-NET-Models-APIUserRecent-Score 'circles.NET.Models.APIUserRecent.Score')
  - [UserId](#P-circles-NET-Models-APIUserRecent-UserId 'circles.NET.Models.APIUserRecent.UserId')
- [CirclesAPIClient](#T-circles-NET-CirclesAPIClient 'circles.NET.CirclesAPIClient')
  - [Constructor(apiKey)](#M-circles-NET-CirclesAPIClient-#ctor-System-String- 'circles.NET.CirclesAPIClient.#ctor(System.String)')
  - [Constructor(apiKey,handler,DisposeHandler)](#M-circles-NET-CirclesAPIClient-#ctor-System-String,System-Net-Http-HttpMessageHandler,System-Boolean- 'circles.NET.CirclesAPIClient.#ctor(System.String,System.Net.Http.HttpMessageHandler,System.Boolean)')
  - [APIKey](#P-circles-NET-CirclesAPIClient-APIKey 'circles.NET.CirclesAPIClient.APIKey')
  - [BaseEndpoint](#P-circles-NET-CirclesAPIClient-BaseEndpoint 'circles.NET.CirclesAPIClient.BaseEndpoint')
  - [Client](#P-circles-NET-CirclesAPIClient-Client 'circles.NET.CirclesAPIClient.Client')
  - [CreateURL(endpoint,queryStrings)](#M-circles-NET-CirclesAPIClient-CreateURL-System-String,System-Object[]- 'circles.NET.CirclesAPIClient.CreateURL(System.String,System.Object[])')
  - [GetBeatmapsByIdAsync(beatmap_id,since,creator,gamemode,includeConversions,hash,limit)](#M-circles-NET-CirclesAPIClient-GetBeatmapsByIdAsync-System-Nullable{System-Int64},System-Nullable{System-DateTime},System-String,System-Nullable{circles-NET-Enums-Gamemode},System-Nullable{circles-NET-Enums-Conversions},System-String,System-Nullable{System-Int32}- 'circles.NET.CirclesAPIClient.GetBeatmapsByIdAsync(System.Nullable{System.Int64},System.Nullable{System.DateTime},System.String,System.Nullable{circles.NET.Enums.Gamemode},System.Nullable{circles.NET.Enums.Conversions},System.String,System.Nullable{System.Int32})')
  - [GetBeatmapsByMapsetAsync(mapset_id,since,creator,gamemode,includeConversions,hash,limit)](#M-circles-NET-CirclesAPIClient-GetBeatmapsByMapsetAsync-System-Nullable{System-Int64},System-Nullable{System-DateTime},System-String,System-Nullable{circles-NET-Enums-Gamemode},System-Nullable{circles-NET-Enums-Conversions},System-String,System-Nullable{System-Int32}- 'circles.NET.CirclesAPIClient.GetBeatmapsByMapsetAsync(System.Nullable{System.Int64},System.Nullable{System.DateTime},System.String,System.Nullable{circles.NET.Enums.Gamemode},System.Nullable{circles.NET.Enums.Conversions},System.String,System.Nullable{System.Int32})')
  - [GetMultiplayerRoomsAsync(roomId)](#M-circles-NET-CirclesAPIClient-GetMultiplayerRoomsAsync-System-Int64- 'circles.NET.CirclesAPIClient.GetMultiplayerRoomsAsync(System.Int64)')
  - [GetRawAsync\<T>(endPoint,queryStrings)](#M-circles-NET-CirclesAPIClient-GetRawAsync``1-System-String,System-Object[]- 'circles.NET.CirclesAPIClient.GetRawAsync``1(System.String,System.Object[])')
  - [GetReplayAsync(username,beatmapId,mode)](#M-circles-NET-CirclesAPIClient-GetReplayAsync-System-String,System-Int64,circles-NET-Enums-Gamemode- 'circles.NET.CirclesAPIClient.GetReplayAsync(System.String,System.Int64,circles.NET.Enums.Gamemode)')
  - [GetScoresAsync(beatmapId,username,mode,mods,limit)](#M-circles-NET-CirclesAPIClient-GetScoresAsync-System-Int64,System-String,circles-NET-Enums-Gamemode,System-Nullable{circles-NET-Enums-Mods},System-Nullable{System-Int32}- 'circles.NET.CirclesAPIClient.GetScoresAsync(System.Int64,System.String,circles.NET.Enums.Gamemode,System.Nullable{circles.NET.Enums.Mods},System.Nullable{System.Int32})')
  - [GetUserBestAsync(username,mode,limit)](#M-circles-NET-CirclesAPIClient-GetUserBestAsync-System-String,circles-NET-Enums-Gamemode,System-Nullable{System-Int32}- 'circles.NET.CirclesAPIClient.GetUserBestAsync(System.String,circles.NET.Enums.Gamemode,System.Nullable{System.Int32})')
  - [GetUserRecentAsync(username,mode,limit)](#M-circles-NET-CirclesAPIClient-GetUserRecentAsync-System-String,circles-NET-Enums-Gamemode,System-Nullable{System-Int32}- 'circles.NET.CirclesAPIClient.GetUserRecentAsync(System.String,circles.NET.Enums.Gamemode,System.Nullable{System.Int32})')
  - [GetUsersAsync(name,mode)](#M-circles-NET-CirclesAPIClient-GetUsersAsync-System-String,circles-NET-Enums-Gamemode- 'circles.NET.CirclesAPIClient.GetUsersAsync(System.String,circles.NET.Enums.Gamemode)')
  - [GetUsersAsync(name,mode)](#M-circles-NET-CirclesAPIClient-GetUsersAsync-System-Int32,circles-NET-Enums-Gamemode- 'circles.NET.CirclesAPIClient.GetUsersAsync(System.Int32,circles.NET.Enums.Gamemode)')
- [CirclesHttpClient](#T-circles-NET-HTTP-CirclesHttpClient 'circles.NET.HTTP.CirclesHttpClient')
- [ModsEnumExtensions](#T-circles-NET-Enums-ModsEnumExtensions 'circles.NET.Enums.ModsEnumExtensions')
  - [GetFromBitflag(flags)](#M-circles-NET-Enums-ModsEnumExtensions-GetFromBitflag-circles-NET-Enums-Mods- 'circles.NET.Enums.ModsEnumExtensions.GetFromBitflag(circles.NET.Enums.Mods)')
  - [ToBitflag(mods)](#M-circles-NET-Enums-ModsEnumExtensions-ToBitflag-System-Collections-Generic-IEnumerable{circles-NET-Enums-Mods}- 'circles.NET.Enums.ModsEnumExtensions.ToBitflag(System.Collections.Generic.IEnumerable{circles.NET.Enums.Mods})')
  - [ToShortString(mod)](#M-circles-NET-Enums-ModsEnumExtensions-ToShortString-circles-NET-Enums-Mods- 'circles.NET.Enums.ModsEnumExtensions.ToShortString(circles.NET.Enums.Mods)')
  - [ToShortString(mod)](#M-circles-NET-Enums-ModsEnumExtensions-ToShortString-System-Collections-Generic-IEnumerable{circles-NET-Enums-Mods}- 'circles.NET.Enums.ModsEnumExtensions.ToShortString(System.Collections.Generic.IEnumerable{circles.NET.Enums.Mods})')

<a name='T-circles-NET-Models-APIBeatmap'></a>
## APIBeatmap `type`

##### Namespace

circles.NET.Models

##### Summary

A class representing an osu! beatmap returned by API

<a name='P-circles-NET-Models-APIBeatmap-AR'></a>
### AR `property`

##### Summary

Approach Rate

<a name='P-circles-NET-Models-APIBeatmap-AimRating'></a>
### AimRating `property`

##### Summary

The difficulty star rating for raw aim

<a name='P-circles-NET-Models-APIBeatmap-ApprovedDate'></a>
### ApprovedDate `property`

##### Summary

The date this beatmap was approved

<a name='P-circles-NET-Models-APIBeatmap-ApprovedStatus'></a>
### ApprovedStatus `property`

##### Summary

The [ApprovedStatus](#P-circles-NET-Models-APIBeatmap-ApprovedStatus 'circles.NET.Models.APIBeatmap.ApprovedStatus') of this beatmap

<a name='P-circles-NET-Models-APIBeatmap-Artist'></a>
### Artist `property`

##### Summary

Compositor of the beatmap's music

<a name='P-circles-NET-Models-APIBeatmap-AudioUnavalaible'></a>
### AudioUnavalaible `property`

##### Summary

An bool indicating whether the audio for this beatmap set is unavalaible (DMCA takedown ?)

<a name='P-circles-NET-Models-APIBeatmap-BeatmapId'></a>
### BeatmapId `property`

##### Summary

The ID of this beatmap

<a name='P-circles-NET-Models-APIBeatmap-Bpm'></a>
### Bpm `property`

##### Summary

BPM of the beatmap

<a name='P-circles-NET-Models-APIBeatmap-CS'></a>
### CS `property`

##### Summary

Circle Size

<a name='P-circles-NET-Models-APIBeatmap-Creator'></a>
### Creator `property`

##### Summary

Creator of the beatmap

<a name='P-circles-NET-Models-APIBeatmap-Difficulty'></a>
### Difficulty `property`

##### Summary

The name of this beatmap's difficulty

<a name='P-circles-NET-Models-APIBeatmap-DownloadUnavalaible'></a>
### DownloadUnavalaible `property`

##### Summary

An bool indicating whether the download for this beatmap (set) is unavalaible (DMCA takedown ?)

<a name='P-circles-NET-Models-APIBeatmap-FavouriteCount'></a>
### FavouriteCount `property`

##### Summary

Number of times this beatmap has been favourited

<a name='P-circles-NET-Models-APIBeatmap-Gamemode'></a>
### Gamemode `property`

##### Summary

The gamemode of this beatmap

<a name='P-circles-NET-Models-APIBeatmap-Genre'></a>
### Genre `property`

##### Summary

The genre of this beatmap (set)

<a name='P-circles-NET-Models-APIBeatmap-HP'></a>
### HP `property`

##### Summary

HP Drain

<a name='P-circles-NET-Models-APIBeatmap-Language'></a>
### Language `property`

##### Summary

The language of this beatmap (set)

<a name='P-circles-NET-Models-APIBeatmap-LastUpdate'></a>
### LastUpdate `property`

##### Summary

The date this beatmap was last updated

<a name='P-circles-NET-Models-APIBeatmap-MD5'></a>
### MD5 `property`

##### Summary

The MD5 hash of this beatmap

<a name='P-circles-NET-Models-APIBeatmap-MapsetId'></a>
### MapsetId `property`

##### Summary

The ID of the mapset this beatmap belongs to

<a name='P-circles-NET-Models-APIBeatmap-MaxCombo'></a>
### MaxCombo `property`

##### Summary

The max achievable combo on this map

<a name='P-circles-NET-Models-APIBeatmap-NormalObjectCount'></a>
### NormalObjectCount `property`

##### Summary

The number of "normal" hitobjects in this beatmap.

<a name='P-circles-NET-Models-APIBeatmap-OD'></a>
### OD `property`

##### Summary

Overall Difficulty

<a name='P-circles-NET-Models-APIBeatmap-Passcount'></a>
### Passcount `property`

##### Summary

Number of times people passed this beatmap

<a name='P-circles-NET-Models-APIBeatmap-PlaybableLength'></a>
### PlaybableLength `property`

##### Summary

The playable length (in seconds) of this beatmap

<a name='P-circles-NET-Models-APIBeatmap-Playcount'></a>
### Playcount `property`

##### Summary

Number of times this beamap has been played

<a name='P-circles-NET-Models-APIBeatmap-Rating'></a>
### Rating `property`

##### Summary

The rating for this map

<a name='P-circles-NET-Models-APIBeatmap-SliderObjectCount'></a>
### SliderObjectCount `property`

##### Summary

The number of "slider" hitobjects in this beatmap.

<a name='P-circles-NET-Models-APIBeatmap-Source'></a>
### Source `property`

##### Summary

Source of the beatmap's music

<a name='P-circles-NET-Models-APIBeatmap-SpeedRating'></a>
### SpeedRating `property`

##### Summary

The difficulty star rating for raw speed

<a name='P-circles-NET-Models-APIBeatmap-SpinnerObjectCount'></a>
### SpinnerObjectCount `property`

##### Summary

The number of "spinner" hitobjects in this beatmap.

<a name='P-circles-NET-Models-APIBeatmap-StarRating'></a>
### StarRating `property`

##### Summary

The difficulty star rating of this beatmap

<a name='P-circles-NET-Models-APIBeatmap-SubmissionDate'></a>
### SubmissionDate `property`

##### Summary

The date this beatmap was submitted

<a name='P-circles-NET-Models-APIBeatmap-Tags'></a>
### Tags `property`

##### Summary

Tags of the beatmap

<a name='P-circles-NET-Models-APIBeatmap-Title'></a>
### Title `property`

##### Summary

Title name of the beatmap's music

<a name='P-circles-NET-Models-APIBeatmap-TotalLength'></a>
### TotalLength `property`

##### Summary

The total length (in seconds) of this beatmap

<a name='T-circles-NET-Models-APIMultiplayerGame'></a>
## APIMultiplayerGame `type`

##### Namespace

circles.NET.Models

##### Summary

A class representing an osu! ongoing or finished multiplayer game returned by API

<a name='P-circles-NET-Models-APIMultiplayerGame-BeatmapId'></a>
### BeatmapId `property`

##### Summary

The ID of the beatmap (NOT BeatmapSet) currently played

<a name='P-circles-NET-Models-APIMultiplayerGame-EndTime'></a>
### EndTime `property`

##### Summary

The time at which this game ended (can be null if it's ongoing)

<a name='P-circles-NET-Models-APIMultiplayerGame-GameId'></a>
### GameId `property`

##### Summary

The ID of this game

<a name='P-circles-NET-Models-APIMultiplayerGame-Gamemode'></a>
### Gamemode `property`

##### Summary

The gamemode in which this beatmap is played in

<a name='P-circles-NET-Models-APIMultiplayerGame-Mods'></a>
### Mods `property`

##### Summary

Mods combination for this game

<a name='P-circles-NET-Models-APIMultiplayerGame-Scores'></a>
### Scores `property`

##### Summary

List of [APIScore](#T-circles-NET-Models-APIScore 'circles.NET.Models.APIScore')s for all people who played during this game

<a name='P-circles-NET-Models-APIMultiplayerGame-StartTime'></a>
### StartTime `property`

##### Summary

The time at which this game began

<a name='T-circles-NET-Models-APIMultiplayerRoom'></a>
## APIMultiplayerRoom `type`

##### Namespace

circles.NET.Models

##### Summary

A class representing an osu! ongoing or finished multiplayer room returned by API

<a name='P-circles-NET-Models-APIMultiplayerRoom-Games'></a>
### Games `property`

##### Summary

List of pasts and ongoing games

<a name='P-circles-NET-Models-APIMultiplayerRoom-Info'></a>
### Info `property`

##### Summary

Info about this [APIMultiplayerRoom](#T-circles-NET-Models-APIMultiplayerRoom 'circles.NET.Models.APIMultiplayerRoom')

<a name='T-circles-NET-Models-APIMultiplayerRoomInfo'></a>
## APIMultiplayerRoomInfo `type`

##### Namespace

circles.NET.Models

##### Summary

Information about an ongoing or finished [APIMultiplayerRoom](#T-circles-NET-Models-APIMultiplayerRoom 'circles.NET.Models.APIMultiplayerRoom')

<a name='P-circles-NET-Models-APIMultiplayerRoomInfo-EndTime'></a>
### EndTime `property`

##### Summary

The time at which this room was deleted (can be null if it's still ongoing)

<a name='P-circles-NET-Models-APIMultiplayerRoomInfo-MatchId'></a>
### MatchId `property`

##### Summary

The ID of this multiplayer room

<a name='P-circles-NET-Models-APIMultiplayerRoomInfo-Name'></a>
### Name `property`

##### Summary

The display name of this multiplayer room

<a name='P-circles-NET-Models-APIMultiplayerRoomInfo-StartTime'></a>
### StartTime `property`

##### Summary

The time at which this room was created

<a name='T-circles-NET-Models-APIReplay'></a>
## APIReplay `type`

##### Namespace

circles.NET.Models

##### Summary

A class representing replay data returned by API

<a name='T-circles-NET-Models-APIScore'></a>
## APIScore `type`

##### Namespace

circles.NET.Models

##### Summary

A class representing an osu! score returned from API

<a name='P-circles-NET-Models-APIScore-Count100s'></a>
### Count100s `property`

##### Summary

Number of 100s hits

<a name='P-circles-NET-Models-APIScore-Count300s'></a>
### Count300s `property`

##### Summary

Number of 300s hits

<a name='P-circles-NET-Models-APIScore-Count50s'></a>
### Count50s `property`

##### Summary

Number of 50s hits

<a name='P-circles-NET-Models-APIScore-CountGeki'></a>
### CountGeki `property`

##### Summary

Number of gekis hits

<a name='P-circles-NET-Models-APIScore-CountKatu'></a>
### CountKatu `property`

##### Summary

Number of katus hits

<a name='P-circles-NET-Models-APIScore-CountMisses'></a>
### CountMisses `property`

##### Summary

Number of missed hits

<a name='P-circles-NET-Models-APIScore-Date'></a>
### Date `property`

##### Summary

The date on which this score was achieved

<a name='P-circles-NET-Models-APIScore-ID'></a>
### ID `property`

##### Summary

The ID of this score

<a name='P-circles-NET-Models-APIScore-MaxCombo'></a>
### MaxCombo `property`

##### Summary

Max combo achieved in this score

<a name='P-circles-NET-Models-APIScore-Mods'></a>
### Mods `property`

##### Summary

Mods enabled for this score

<a name='P-circles-NET-Models-APIScore-Perfect'></a>
### Perfect `property`

##### Summary

A bool indicating whether this score is a perfect

<a name='P-circles-NET-Models-APIScore-Pp'></a>
### Pp `property`

##### Summary

The pp awarded for this score

<a name='P-circles-NET-Models-APIScore-Rank'></a>
### Rank `property`

##### Summary

The grade achieved on this score

<a name='P-circles-NET-Models-APIScore-ReplayAvalaible'></a>
### ReplayAvalaible `property`

##### Summary

A bool indicating whether the replay for this score is avalaible for download.

<a name='P-circles-NET-Models-APIScore-Score'></a>
### Score `property`

##### Summary

Total score awarded on this map

<a name='P-circles-NET-Models-APIScore-UserId'></a>
### UserId `property`

##### Summary

The UserID of the player who achieved this score

<a name='P-circles-NET-Models-APIScore-Username'></a>
### Username `property`

##### Summary

Username of the played who achieved the score

<a name='T-circles-NET-Models-APIUser'></a>
## APIUser `type`

##### Namespace

circles.NET.Models

##### Summary

A class representing an osu! user returned from API

<a name='P-circles-NET-Models-APIUser-Accuracy'></a>
### Accuracy `property`

##### Summary

Accuracy of this player

<a name='P-circles-NET-Models-APIUser-Count100'></a>
### Count100 `property`

##### Summary

Total 100s hits

<a name='P-circles-NET-Models-APIUser-Count300'></a>
### Count300 `property`

##### Summary

Total 300s hits

<a name='P-circles-NET-Models-APIUser-Count50'></a>
### Count50 `property`

##### Summary

Total 50s hits

<a name='P-circles-NET-Models-APIUser-CountRankA'></a>
### CountRankA `property`

##### Summary

Total number of As

<a name='P-circles-NET-Models-APIUser-CountRankS'></a>
### CountRankS `property`

##### Summary

Total number of Ses

<a name='P-circles-NET-Models-APIUser-CountRankSH'></a>
### CountRankSH `property`

##### Summary

Total number of Ses with HD enabled (=> SH)

<a name='P-circles-NET-Models-APIUser-CountRankSS'></a>
### CountRankSS `property`

##### Summary

Total number of SSes

<a name='P-circles-NET-Models-APIUser-CountRankXH'></a>
### CountRankXH `property`

##### Summary

Total number of SSes with HD enabled (=> XH)

<a name='P-circles-NET-Models-APIUser-Country'></a>
### Country `property`

##### Summary

Player's country code

<a name='P-circles-NET-Models-APIUser-JoinDate'></a>
### JoinDate `property`

##### Summary

The date on which the user joined us :)

<a name='P-circles-NET-Models-APIUser-Level'></a>
### Level `property`

##### Summary

Level of this player

<a name='P-circles-NET-Models-APIUser-Playcount'></a>
### Playcount `property`

##### Summary

Playcount

<a name='P-circles-NET-Models-APIUser-PpCountryRank'></a>
### PpCountryRank `property`

##### Summary

Player's rank in his country leaderboard

<a name='P-circles-NET-Models-APIUser-PpRank'></a>
### PpRank `property`

##### Summary

Player's Rank in global leaderboard

<a name='P-circles-NET-Models-APIUser-PpRaw'></a>
### PpRaw `property`

##### Summary

Raw PP of this player

<a name='P-circles-NET-Models-APIUser-RankedScore'></a>
### RankedScore `property`

##### Summary

Total ranked score

<a name='P-circles-NET-Models-APIUser-TimePlayed'></a>
### TimePlayed `property`

##### Summary

The total time played

<a name='P-circles-NET-Models-APIUser-TotalScore'></a>
### TotalScore `property`

##### Summary

Total (unranked) score

<a name='P-circles-NET-Models-APIUser-UserId'></a>
### UserId `property`

##### Summary

The UserID for this user

<a name='P-circles-NET-Models-APIUser-Username'></a>
### Username `property`

##### Summary

The username of this user

<a name='T-circles-NET-Models-APIUserBest'></a>
## APIUserBest `type`

##### Namespace

circles.NET.Models

##### Summary

A class representing an osu! score from one of player top scores

<a name='P-circles-NET-Models-APIUserBest-BeatmapId'></a>
### BeatmapId `property`

##### Summary

The ID of the beatmap (not BeatmapSet) this score was achieved on

<a name='P-circles-NET-Models-APIUserBest-Count100s'></a>
### Count100s `property`

##### Summary

Number of 100s hits

<a name='P-circles-NET-Models-APIUserBest-Count300s'></a>
### Count300s `property`

##### Summary

Number of 300s hits

<a name='P-circles-NET-Models-APIUserBest-Count50s'></a>
### Count50s `property`

##### Summary

Number of 50s hits

<a name='P-circles-NET-Models-APIUserBest-CountGeki'></a>
### CountGeki `property`

##### Summary

Number of gekis hits

<a name='P-circles-NET-Models-APIUserBest-CountKatu'></a>
### CountKatu `property`

##### Summary

Number of katus hits

<a name='P-circles-NET-Models-APIUserBest-CountMisses'></a>
### CountMisses `property`

##### Summary

Number of missed hits

<a name='P-circles-NET-Models-APIUserBest-Date'></a>
### Date `property`

##### Summary

The date on which this score was achieved

<a name='P-circles-NET-Models-APIUserBest-ID'></a>
### ID `property`

##### Summary

The ID of this score

<a name='P-circles-NET-Models-APIUserBest-MaxCombo'></a>
### MaxCombo `property`

##### Summary

Max combo achieved in this score

<a name='P-circles-NET-Models-APIUserBest-Mods'></a>
### Mods `property`

##### Summary

Mods enabled for this score

<a name='P-circles-NET-Models-APIUserBest-Perfect'></a>
### Perfect `property`

##### Summary

A bool indicating whether this score is a perfect

<a name='P-circles-NET-Models-APIUserBest-Pp'></a>
### Pp `property`

##### Summary

The pp awarded for this score

<a name='P-circles-NET-Models-APIUserBest-Rank'></a>
### Rank `property`

##### Summary

The grade achieved on this score

<a name='P-circles-NET-Models-APIUserBest-Score'></a>
### Score `property`

##### Summary

Total score awarded on this map

<a name='P-circles-NET-Models-APIUserBest-UserId'></a>
### UserId `property`

##### Summary

The UserID of the player who achieved this score

<a name='T-circles-NET-Models-APIUserRecent'></a>
## APIUserRecent `type`

##### Namespace

circles.NET.Models

##### Summary

A class representing an osu! score from a play done recently returned by API

<a name='P-circles-NET-Models-APIUserRecent-Accuracy'></a>
### Accuracy `property`

##### Summary

The accuracy for this score

<a name='P-circles-NET-Models-APIUserRecent-BeatmapId'></a>
### BeatmapId `property`

##### Summary

The ID of the beatmap (not beatmapSet) this score was achieved on

<a name='P-circles-NET-Models-APIUserRecent-Count100s'></a>
### Count100s `property`

##### Summary

Number of 100s hits

<a name='P-circles-NET-Models-APIUserRecent-Count300s'></a>
### Count300s `property`

##### Summary

Number of 300s hits

<a name='P-circles-NET-Models-APIUserRecent-Count50s'></a>
### Count50s `property`

##### Summary

Number of 50s hits

<a name='P-circles-NET-Models-APIUserRecent-CountGeki'></a>
### CountGeki `property`

##### Summary

Number of gekis hits

<a name='P-circles-NET-Models-APIUserRecent-CountKatu'></a>
### CountKatu `property`

##### Summary

Number of katus hits

<a name='P-circles-NET-Models-APIUserRecent-CountMisses'></a>
### CountMisses `property`

##### Summary

Number of missed hits

<a name='P-circles-NET-Models-APIUserRecent-Date'></a>
### Date `property`

##### Summary

The date on which this score was achieved

<a name='P-circles-NET-Models-APIUserRecent-MaxCombo'></a>
### MaxCombo `property`

##### Summary

Max combo achieved in this score

<a name='P-circles-NET-Models-APIUserRecent-Mods'></a>
### Mods `property`

##### Summary

Mods enabled for this score

<a name='P-circles-NET-Models-APIUserRecent-Perfect'></a>
### Perfect `property`

##### Summary

A bool indicating whether this score is a perfect

<a name='P-circles-NET-Models-APIUserRecent-Pp'></a>
### Pp `property`

##### Summary

The pp awarded for this score

<a name='P-circles-NET-Models-APIUserRecent-Rank'></a>
### Rank `property`

##### Summary

The grade achieved on this score (can be F if player didn't completed the whole map)

<a name='P-circles-NET-Models-APIUserRecent-Score'></a>
### Score `property`

##### Summary

Total score awarded on this map

<a name='P-circles-NET-Models-APIUserRecent-UserId'></a>
### UserId `property`

##### Summary

The UserID of the player who achieved this score

<a name='T-circles-NET-CirclesAPIClient'></a>
## CirclesAPIClient `type`

##### Namespace

circles.NET

##### Summary

An asynchronous client wrapper class for the osu! api v1

<a name='M-circles-NET-CirclesAPIClient-#ctor-System-String-'></a>
### Constructor(apiKey) `constructor`

##### Summary

Constructs an instance of [CirclesAPIClient](#T-circles-NET-CirclesAPIClient 'circles.NET.CirclesAPIClient') with the API key given as parameter

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-circles-NET-CirclesAPIClient-#ctor-System-String,System-Net-Http-HttpMessageHandler,System-Boolean-'></a>
### Constructor(apiKey,handler,DisposeHandler) `constructor`

##### Summary

Constructs an instance of [CirclesAPIClient](#T-circles-NET-CirclesAPIClient 'circles.NET.CirclesAPIClient') with the API key given as parameter and using the given [HttpMessageHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMessageHandler 'System.Net.Http.HttpMessageHandler') for handling http requests.
Use this ctor if you need to implement request caching.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| apiKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| handler | [System.Net.Http.HttpMessageHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMessageHandler 'System.Net.Http.HttpMessageHandler') | The [HttpMessageHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMessageHandler 'System.Net.Http.HttpMessageHandler') to use for this [CirclesAPIClient](#T-circles-NET-CirclesAPIClient 'circles.NET.CirclesAPIClient') |
| DisposeHandler | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Bool indicating if the attached [HttpMessageHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMessageHandler 'System.Net.Http.HttpMessageHandler') should be disposed on [CirclesAPIClient](#T-circles-NET-CirclesAPIClient 'circles.NET.CirclesAPIClient') disposal |

<a name='F-circles-NET-CirclesAPIClient-API_V1_URL'></a>
### API_V1_URL `constants`

##### Summary

The https path to the official osu! api v1

<a name='P-circles-NET-CirclesAPIClient-APIKey'></a>
### APIKey `property`

##### Summary

Gets or sets the API Key for this [CirclesAPIClient](#T-circles-NET-CirclesAPIClient 'circles.NET.CirclesAPIClient') instance

<a name='P-circles-NET-CirclesAPIClient-BaseEndpoint'></a>
### BaseEndpoint `property`

##### Summary

The address of the API server to which API requests are made against.

Defaults to the official osu! v1 api server url

<a name='P-circles-NET-CirclesAPIClient-Client'></a>
### Client `property`

##### Summary

Gets the underlying [CirclesHttpClient](#T-circles-NET-HTTP-CirclesHttpClient 'circles.NET.HTTP.CirclesHttpClient') Http client backing this [CirclesAPIClient](#T-circles-NET-CirclesAPIClient 'circles.NET.CirclesAPIClient') instance

<a name='M-circles-NET-CirclesAPIClient-CreateURL-System-String,System-Object[]-'></a>
### CreateURL(endpoint,queryStrings) `method`

##### Summary

Returns a partial url to the given endpoint with the given query strings serialized into the url

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpoint | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The endpoint |
| queryStrings | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | The query strings |

<a name='M-circles-NET-CirclesAPIClient-GetBeatmapsByIdAsync-System-Nullable{System-Int64},System-Nullable{System-DateTime},System-String,System-Nullable{circles-NET-Enums-Gamemode},System-Nullable{circles-NET-Enums-Conversions},System-String,System-Nullable{System-Int32}-'></a>
### GetBeatmapsByIdAsync(beatmap_id,since,creator,gamemode,includeConversions,hash,limit) `method`

##### Summary

Gets a list of beatmaps matching the given beatmapId and parameters asynchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| beatmap_id | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') |  |
| since | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') |  |
| creator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| gamemode | [System.Nullable{circles.NET.Enums.Gamemode}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{circles.NET.Enums.Gamemode}') |  |
| includeConversions | [System.Nullable{circles.NET.Enums.Conversions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{circles.NET.Enums.Conversions}') |  |
| hash | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') |  |

<a name='M-circles-NET-CirclesAPIClient-GetBeatmapsByMapsetAsync-System-Nullable{System-Int64},System-Nullable{System-DateTime},System-String,System-Nullable{circles-NET-Enums-Gamemode},System-Nullable{circles-NET-Enums-Conversions},System-String,System-Nullable{System-Int32}-'></a>
### GetBeatmapsByMapsetAsync(mapset_id,since,creator,gamemode,includeConversions,hash,limit) `method`

##### Summary

Gets a list of beatmaps matching the given mapsetId and parameters asynchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mapset_id | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int64}') | The mapset id (required) |
| since | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') |  |
| creator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| gamemode | [System.Nullable{circles.NET.Enums.Gamemode}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{circles.NET.Enums.Gamemode}') |  |
| includeConversions | [System.Nullable{circles.NET.Enums.Conversions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{circles.NET.Enums.Conversions}') |  |
| hash | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') |  |

<a name='M-circles-NET-CirclesAPIClient-GetMultiplayerRoomsAsync-System-Int64-'></a>
### GetMultiplayerRoomsAsync(roomId) `method`

##### Summary

Gets data about a multiplayer room asynchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| roomId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The Room Id |

<a name='M-circles-NET-CirclesAPIClient-GetRawAsync``1-System-String,System-Object[]-'></a>
### GetRawAsync\<T>(endPoint,queryStrings) `method`

##### Summary

Performs a custom request against the given end_point with custom queryStrings

NOTE that the queryStrings already contains APIKey by default

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endPoint | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| queryStrings | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-circles-NET-CirclesAPIClient-GetReplayAsync-System-String,System-Int64,circles-NET-Enums-Gamemode-'></a>
### GetReplayAsync(username,beatmapId,mode) `method`

##### Summary

Gets replay data from a specific play from a specific user asynchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| beatmapId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') |  |
| mode | [circles.NET.Enums.Gamemode](#T-circles-NET-Enums-Gamemode 'circles.NET.Enums.Gamemode') |  |

<a name='M-circles-NET-CirclesAPIClient-GetScoresAsync-System-Int64,System-String,circles-NET-Enums-Gamemode,System-Nullable{circles-NET-Enums-Mods},System-Nullable{System-Int32}-'></a>
### GetScoresAsync(beatmapId,username,mode,mods,limit) `method`

##### Summary

Gets a list of scores for the given beatmap id matching given parameters asynchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| beatmapId | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The beatmap id to return scores from |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the user to return score from ([](#!-null 'null') by default) |
| mode | [circles.NET.Enums.Gamemode](#T-circles-NET-Enums-Gamemode 'circles.NET.Enums.Gamemode') | The gamemode (defaults to [Standard](#F-circles-NET-Enums-Gamemode-Standard 'circles.NET.Enums.Gamemode.Standard')) |
| mods | [System.Nullable{circles.NET.Enums.Mods}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{circles.NET.Enums.Mods}') | A mods bitflag (defaults to null) |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | A limit of results to return (returns first 500 results by default) |

<a name='M-circles-NET-CirclesAPIClient-GetUserBestAsync-System-String,circles-NET-Enums-Gamemode,System-Nullable{System-Int32}-'></a>
### GetUserBestAsync(username,mode,limit) `method`

##### Summary

Gets a list of top plays for the given username asynchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The username of the player to return top plays from |
| mode | [circles.NET.Enums.Gamemode](#T-circles-NET-Enums-Gamemode 'circles.NET.Enums.Gamemode') | The gamemode (defaults to [Standard](#F-circles-NET-Enums-Gamemode-Standard 'circles.NET.Enums.Gamemode.Standard')) |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | A limit of results to return (returns first 500 results by default) |

<a name='M-circles-NET-CirclesAPIClient-GetUserRecentAsync-System-String,circles-NET-Enums-Gamemode,System-Nullable{System-Int32}-'></a>
### GetUserRecentAsync(username,mode,limit) `method`

##### Summary

Gets a list of recent plays for the given username asynchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The username of the player to return recent plays from |
| mode | [circles.NET.Enums.Gamemode](#T-circles-NET-Enums-Gamemode 'circles.NET.Enums.Gamemode') | The gamemode (defaults to [Standard](#F-circles-NET-Enums-Gamemode-Standard 'circles.NET.Enums.Gamemode.Standard')) |
| limit | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | A limit of results to return (returns first 500 results by default) |

<a name='M-circles-NET-CirclesAPIClient-GetUsersAsync-System-String,circles-NET-Enums-Gamemode-'></a>
### GetUsersAsync(name,mode) `method`

##### Summary

Gets a [](#!-APIUser[] 'APIUser[]') matching given parameters asynchronously

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The username to search for |
| mode | [circles.NET.Enums.Gamemode](#T-circles-NET-Enums-Gamemode 'circles.NET.Enums.Gamemode') | The gamemode |

<a name='M-circles-NET-CirclesAPIClient-GetUsersAsync-System-Int32,circles-NET-Enums-Gamemode-'></a>
### GetUsersAsync(name,mode) `method`

##### Summary

Same as [GetUsersAsync](#M-circles-NET-CirclesAPIClient-GetUsersAsync-System-String,circles-NET-Enums-Gamemode- 'circles.NET.CirclesAPIClient.GetUsersAsync(System.String,circles.NET.Enums.Gamemode)') but takes UserID instead of username

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The UserID to search for |
| mode | [circles.NET.Enums.Gamemode](#T-circles-NET-Enums-Gamemode 'circles.NET.Enums.Gamemode') | The gamemode (defaults to [Standard](#F-circles-NET-Enums-Gamemode-Standard 'circles.NET.Enums.Gamemode.Standard')) |

<a name='T-circles-NET-HTTP-CirclesHttpClient'></a>
## CirclesHttpClient `type`

##### Namespace

circles.NET.HTTP

##### Summary

A [HttpClient](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpClient 'System.Net.Http.HttpClient') with methods for deserializing directly API requests content into usable objects

Intended to be only used by [CirclesAPIClient](#T-circles-NET-CirclesAPIClient 'circles.NET.CirclesAPIClient')

<a name='T-circles-NET-Enums-ModsEnumExtensions'></a>
## ModsEnumExtensions `type`

##### Namespace

circles.NET.Enums

<a name='M-circles-NET-Enums-ModsEnumExtensions-GetFromBitflag-circles-NET-Enums-Mods-'></a>
### GetFromBitflag(flags) `method`

##### Summary

Converts a bitflag representation into an array of [Mods](#T-circles-NET-Enums-Mods 'circles.NET.Enums.Mods')

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| flags | [circles.NET.Enums.Mods](#T-circles-NET-Enums-Mods 'circles.NET.Enums.Mods') |  |

<a name='M-circles-NET-Enums-ModsEnumExtensions-ToBitflag-System-Collections-Generic-IEnumerable{circles-NET-Enums-Mods}-'></a>
### ToBitflag(mods) `method`

##### Summary

Converts an [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') to a [Mods](#T-circles-NET-Enums-Mods 'circles.NET.Enums.Mods') bitflag representation

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mods | [System.Collections.Generic.IEnumerable{circles.NET.Enums.Mods}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{circles.NET.Enums.Mods}') |  |

<a name='M-circles-NET-Enums-ModsEnumExtensions-ToShortString-circles-NET-Enums-Mods-'></a>
### ToShortString(mod) `method`

##### Summary

Gets a short string representation of the given [Mods](#T-circles-NET-Enums-Mods 'circles.NET.Enums.Mods') bitflag / value

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mod | [circles.NET.Enums.Mods](#T-circles-NET-Enums-Mods 'circles.NET.Enums.Mods') |  |

<a name='M-circles-NET-Enums-ModsEnumExtensions-ToShortString-System-Collections-Generic-IEnumerable{circles-NET-Enums-Mods}-'></a>
### ToShortString(mod) `method`

##### Summary

Gets a short string representation of the given [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of [Mods](#T-circles-NET-Enums-Mods 'circles.NET.Enums.Mods')

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mod | [System.Collections.Generic.IEnumerable{circles.NET.Enums.Mods}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{circles.NET.Enums.Mods}') |  |
