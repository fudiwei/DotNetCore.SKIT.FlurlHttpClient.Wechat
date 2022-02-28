namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/room/deleteroom 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoomDeleteRoomRequest : WechatApiRequest, IInferable<WxaApiBroadcastRoomDeleteRoomRequest, WxaApiBroadcastRoomDeleteRoomResponse>
    {
        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public long RoomId { get; set; }
    }
}
