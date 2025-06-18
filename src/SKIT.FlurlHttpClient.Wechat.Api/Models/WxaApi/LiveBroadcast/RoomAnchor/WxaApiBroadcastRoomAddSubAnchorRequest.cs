﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/room/addsubanchor 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoomAddSubAnchorRequest : WechatApiRequest, IInferable<WxaApiBroadcastRoomAddSubAnchorRequest, WxaApiBroadcastRoomAddSubAnchorResponse>
    {
        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomId")]
        [System.Text.Json.Serialization.JsonPropertyName("roomId")]
        public long RoomId { get; set; }

        /// <summary>
        /// 获取或设置用户微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("username")]
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        public string Username { get; set; } = string.Empty;
    }
}
