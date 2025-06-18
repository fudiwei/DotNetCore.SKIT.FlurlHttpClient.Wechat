﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/gamematch/getallmatchrule 接口的响应。</para>
    /// </summary>
    public class WxaBusinessGameMatchGetAllMatchRuleResponse : WechatApiResponse
    {
        public static class Types
        {
            public class MatchRule
            {
                public static class Types
                {
                    public class GameRoom
                    {
                        /// <summary>
                        /// 获取或设置后台下发游戏逻辑帧的周期（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("game_tick")]
                        [System.Text.Json.Serialization.JsonPropertyName("game_tick")]
                        public int GameTick { get; set; }

                        /// <summary>
                        /// 获取或设置发送开始游戏指令的玩家达到比例后开始游戏。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_percent")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_percent")]
                        public int StartPercent { get; set; }

                        /// <summary>
                        /// 获取或设置使用的 UDP 可靠性策略。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("udp_reliability_strategy")]
                        [System.Text.Json.Serialization.JsonPropertyName("udp_reliability_strategy")]
                        public int UdpReliabilityStrategy { get; set; }

                        /// <summary>
                        /// 获取或设置是否需要用户的头像昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("need_user_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("need_user_info")]
                        public bool RequireUserInformation { get; set; }

                        /// <summary>
                        /// 获取或设置游戏对局时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("game_last_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("game_last_time")]
                        public int GameLastTime { get; set; }

                        /// <summary>
                        /// 获取或设置是否需要在创建房间时同时生成一个随机的游戏种子。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("need_game_seed")]
                        [System.Text.Json.Serialization.JsonPropertyName("need_game_seed")]
                        public bool RequireGameSeed { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置匹配池对应的 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("match_id")]
                [System.Text.Json.Serialization.JsonPropertyName("match_id")]
                public string MatchId { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置打开状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_state")]
                [System.Text.Json.Serialization.JsonPropertyName("open_state")]
                public int OpenState { get; set; }

                /// <summary>
                /// 获取或设置队伍数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("team_count")]
                [System.Text.Json.Serialization.JsonPropertyName("team_count")]
                public int TeamCount { get; set; }

                /// <summary>
                /// 获取或设置每个队伍对应的成员数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("team_member_count")]
                [System.Text.Json.Serialization.JsonPropertyName("team_member_count")]
                public int TeamMemberCount { get; set; }

                /// <summary>
                /// 获取或设置是否需要在下发匹配结果时同步创建帧同步房间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_room_service_info")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("need_room_service_info")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool? RequireRoomService { get; set; }

                /// <summary>
                /// 获取或设置创建帧同步房间时的房间信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("game_room_info")]
                [System.Text.Json.Serialization.JsonPropertyName("game_room_info")]
                public Types.GameRoom? GameRoom { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置游戏规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("match_rule_list")]
        [System.Text.Json.Serialization.JsonPropertyName("match_rule_list")]
        public Types.MatchRule[]? MatchRuleList { get; set; } = default!;
    }
}
