namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/getagreestatus/room 接口的请求。</para>
    /// </summary>
    public class CgibinChatDataGetAgreeStatusRoomRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置群 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chatid")]
        [System.Text.Json.Serialization.JsonPropertyName("chatid")]
        public string GroupChatId { get; set; } = string.Empty;
    }
}
