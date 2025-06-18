namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/app/update_email_alias 接口的请求。</para>
    /// </summary>
    public class CgibinExmailAppUpdateEmailAliasRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置新的应用邮箱帐号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_email")]
        [System.Text.Json.Serialization.JsonPropertyName("new_email")]
        public string NewEmail { get; set; } = string.Empty;
    }
}
