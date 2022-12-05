namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/app/get_email_alias 接口的响应。</para>
    /// </summary>
    public class CgibinExmailAppGetEmailAliasResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置应用邮箱帐号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email")]
        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string Email { get; set; } = default!;

        /// <summary>
        /// 获取或设置别名邮箱地址列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alias_list")]
        [System.Text.Json.Serialization.JsonPropertyName("alias_list")]
        public string[] AliasList { get; set; } = default!;
    }
}
