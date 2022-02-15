using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/room/deletesubanchor 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoomDeleteSubAnchorRequest : WechatApiRequest, IMapResponse<WxaApiBroadcastRoomDeleteSubAnchorRequest, WxaApiBroadcastRoomDeleteSubAnchorResponse>
    {
        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomId")]
        [System.Text.Json.Serialization.JsonPropertyName("roomId")]
        public long RoomId { get; set; }
    }
}
