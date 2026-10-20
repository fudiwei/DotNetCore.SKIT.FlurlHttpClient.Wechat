namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/room/updatekf 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoomUpdateKfRequest : WechatApiRequest, IInferable<WxaApiBroadcastRoomUpdateKfRequest, WxaApiBroadcastRoomUpdateKfResponse>
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
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("closeKf")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
        public bool IsCloseKf { get; set; }
    }
}
