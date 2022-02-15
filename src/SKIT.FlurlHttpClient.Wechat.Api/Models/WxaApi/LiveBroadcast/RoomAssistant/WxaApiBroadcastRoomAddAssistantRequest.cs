using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/room/addassistant 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoomAddAssistantRequest : WechatApiRequest, IMapResponse<WxaApiBroadcastRoomAddAssistantRequest, WxaApiBroadcastRoomAddAssistantResponse>
    {
        public static class Types
        {
            public class Assistant
            {
                /// <summary>
                /// 获取或设置用户微信号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("username")]
                [System.Text.Json.Serialization.JsonPropertyName("username")]
                public string Username { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置用户昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomId")]
        [System.Text.Json.Serialization.JsonPropertyName("roomId")]
        public long RoomId { get; set; }

        /// <summary>
        /// 获取或设置小助手列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("users")]
        [System.Text.Json.Serialization.JsonPropertyName("users")]
        public IList<Types.Assistant> AssistantList { get; set; } = new List<Types.Assistant>();
    }
}
