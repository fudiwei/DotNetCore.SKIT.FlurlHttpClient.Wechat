﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/room/updatecomment 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoomUpdateCommentRequest : WechatApiRequest, IInferable<WxaApiBroadcastRoomUpdateCommentRequest, WxaApiBroadcastRoomUpdateCommentResponse>
    {
        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomId")]
        [System.Text.Json.Serialization.JsonPropertyName("roomId")]
        public long RoomId { get; set; }

        /// <summary>
        /// 获取或设置是否禁言。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("banComment")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("banComment")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool IsBanComment { get; set; }
    }
}
