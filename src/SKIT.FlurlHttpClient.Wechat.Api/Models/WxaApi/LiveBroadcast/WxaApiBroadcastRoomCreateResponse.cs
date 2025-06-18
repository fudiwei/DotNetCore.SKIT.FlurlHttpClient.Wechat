namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/room/create 接口的响应。</para>
    /// </summary>
    public class WxaApiBroadcastRoomCreateResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomId")]
        [System.Text.Json.Serialization.JsonPropertyName("roomId")]
        public long RoomId { get; set; }

        /// <summary>
        /// 获取或设置小程序码 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_url")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_url")]
        public string? QrcodeUrl { get; set; }
    }
}
