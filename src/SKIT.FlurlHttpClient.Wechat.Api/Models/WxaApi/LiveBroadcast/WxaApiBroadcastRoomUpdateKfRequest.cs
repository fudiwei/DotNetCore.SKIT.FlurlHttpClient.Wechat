namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/room/updatekf 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoomUpdateKfRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomId")]
        [System.Text.Json.Serialization.JsonPropertyName("roomId")]
        public long RoomId { get; set; }

        /// <summary>
        /// 获取或设置是否关闭客服。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("closeKf")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("closeKf")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsCloseKf { get; set; }
    }
}
