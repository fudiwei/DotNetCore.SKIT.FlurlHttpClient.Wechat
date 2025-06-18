namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/rooms/call 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingRoomsCallResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置呼叫 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invite_id")]
        [System.Text.Json.Serialization.JsonPropertyName("invite_id")]
        public string InviteId { get; set; } = default!;
    }
}
