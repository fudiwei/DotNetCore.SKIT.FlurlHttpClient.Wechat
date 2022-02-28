namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/room/updatefeedpublic 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoomUpdateFeedPublicRequest : WechatApiRequest, IInferable<WxaApiBroadcastRoomUpdateFeedPublicRequest, WxaApiBroadcastRoomUpdateFeedPublicResponse>
    {
        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomId")]
        [System.Text.Json.Serialization.JsonPropertyName("roomId")]
        public long RoomId { get; set; }

        /// <summary>
        /// 获取或设置是否开启官方收录。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isFeedsPublic")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("isFeedsPublic")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsFeedsPublic { get; set; }
    }
}
