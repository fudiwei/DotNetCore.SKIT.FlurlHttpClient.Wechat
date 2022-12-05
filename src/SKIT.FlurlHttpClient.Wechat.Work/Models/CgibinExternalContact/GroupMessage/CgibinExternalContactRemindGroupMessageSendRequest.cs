namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/remind_groupmsg_send 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactRemindGroupMessageSendRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置群发消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgid")]
        [System.Text.Json.Serialization.JsonPropertyName("msgid")]
        public string MessageId { get; set; } = string.Empty;
    }
}
