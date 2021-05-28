using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/getwxagameroominfo 接口的响应。</para>
    /// </summary>
    public class WxaGetWxaGameRoomInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Member
                    {
                        /// <summary>
                        /// 获取或设置玩家准备状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_ready")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_ready")]
                        public bool IsReady { get; set; }

                        /// <summary>
                        /// 获取或设置玩家角色。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("role")]
                        [System.Text.Json.Serialization.JsonPropertyName("role")]
                        public int Role { get; set; }

                        /// <summary>
                        /// 获取或设置用户在房间内的唯一标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("client_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("client_id")]
                        public int ClientId { get; set; }

                        /// <summary>
                        /// 获取或设置座位号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pos_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("pos_num")]
                        public int PositionNumber { get; set; }

                        /// <summary>
                        /// 获取或设置用户头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("headimg")]
                        [System.Text.Json.Serialization.JsonPropertyName("headimg")]
                        public string? HeadImageUrl { get; set; }

                        /// <summary>
                        /// 获取或设置用户昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                        public string? Nickname { get; set; }

                        /// <summary>
                        /// 获取或设置是否已做好游戏开始准备。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enable_to_start")]
                        [System.Text.Json.Serialization.JsonPropertyName("enable_to_start")]
                        public bool EnableToStart { get; set; }

                        /// <summary>
                        /// 获取或设置第三方自定义的玩家信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("member_ext_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("member_ext_info")]
                        public string MemberExt { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置房间 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("room_id_str")]
                [System.Text.Json.Serialization.JsonPropertyName("room_id_str")]
                public string RoomId { get; set; } = default!;

                /// <summary>
                /// 获取或设置房间状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("room_state")]
                [System.Text.Json.Serialization.JsonPropertyName("room_state")]
                public int RoomState { get; set; }

                /// <summary>
                /// 获取或设置房间最大可容纳人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_member_num")]
                [System.Text.Json.Serialization.JsonPropertyName("max_member_num")]
                public int MaxMemberCount { get; set; }

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
                /// 获取或设置游戏对局时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("game_last_time")]
                [System.Text.Json.Serialization.JsonPropertyName("game_last_time")]
                public int GameLastTime { get; set; }

                /// <summary>
                /// 获取或设置第三方自定义的游戏版本号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("game_version")]
                [System.Text.Json.Serialization.JsonPropertyName("game_version")]
                public int GameVersion { get; set; }

                /// <summary>
                /// 获取或设置房间或对局访问凭证。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                public string AccessInformation { get; set; } = default!;

                /// <summary>
                /// 获取或设置第三方自定义的房间信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("room_ext_info")]
                [System.Text.Json.Serialization.JsonPropertyName("room_ext_info")]
                public string RoomExt { get; set; } = default!;

                /// <summary>
                /// 获取或设置游戏随机种子。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seed")]
                [System.Text.Json.Serialization.JsonPropertyName("seed")]
                public string Seed { get; set; } = default!;

                /// <summary>
                /// 获取或设置成员列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("member_list")]
                [System.Text.Json.Serialization.JsonPropertyName("member_list")]
                public Types.Member[] MemberList { get; set; } = default!;

                /// <summary>
                /// 获取或设置最近更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_timestamp")]
                [System.Text.Json.Serialization.JsonPropertyName("update_timestamp")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_timestamp")]
                [System.Text.Json.Serialization.JsonPropertyName("create_timestamp")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置房间或对局信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
