namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/group/delete 接口的请求。</para>
    /// </summary>
    public class CgibinExmailGroupDeleteRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置邮件群组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groupid")]
        [System.Text.Json.Serialization.JsonPropertyName("groupid")]
        public string GroupId { get; set; } = string.Empty;
    }
}
