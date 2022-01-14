namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/room/modifyassistant 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoomModifyAssistantRequest : WechatApiRequest
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

        /// <summary>
        /// 获取或设置用户昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string Nickname { get; set; } = string.Empty;
    }
}
