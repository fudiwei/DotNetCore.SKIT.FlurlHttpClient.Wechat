namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/room/updatereplay 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoomUpdateReplayRequest : WechatApiRequest, IInferable<WxaApiBroadcastRoomUpdateReplayRequest, WxaApiBroadcastRoomUpdateReplayResponse>
    {
        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomId")]
        [System.Text.Json.Serialization.JsonPropertyName("roomId")]
        public long RoomId { get; set; }

        /// <summary>
        /// 获取或设置是否关闭回放。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("closeReplay")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("closeReplay")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
        public bool IsCloseReplay { get; set; }
    }
}
