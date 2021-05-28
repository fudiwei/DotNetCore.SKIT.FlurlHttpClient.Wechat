using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/broadcast/room/getassistantlist 接口的响应。</para>
    /// </summary>
    public class WxaApiBroadcastRoomGetAssistantListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Assistant
            {
                /// <summary>
                /// 获取或设置用户微信号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("alias")]
                [System.Text.Json.Serialization.JsonPropertyName("alias")]
                public string Username { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("headimg")]
                [System.Text.Json.Serialization.JsonPropertyName("headimg")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置修改时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("timestamp")]
                [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
                public long UpdateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置小助手列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Assistant[] AssistantList { get; set; } = default!;

        /// <summary>
        /// 获取或设置小助手个数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// 获取或设置小助手最大个数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxCount")]
        [System.Text.Json.Serialization.JsonPropertyName("maxCount")]
        public int MaxCount { get; set; }
    }
}
