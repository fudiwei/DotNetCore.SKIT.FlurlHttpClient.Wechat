namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_suite_token 接口的请求。</para>
    /// </summary>
    public class CgibinServiceGetSuiteTokenRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置第三方应用 SuiteId。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.SuiteId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suite_id")]
        [System.Text.Json.Serialization.JsonPropertyName("suite_id")]
        public string? SuiteId { get; set; }

        /// <summary>
        /// 获取或设置第三方应用 SuiteSecret。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.SuiteSecret"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suite_secret")]
        [System.Text.Json.Serialization.JsonPropertyName("suite_secret")]
        public string? SuiteSecret { get; set; }

        /// <summary>
        /// 获取或设置企业微信后台推送的 Ticket。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suite_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("suite_ticket")]
        public string SuiteTicket { get; set; } = string.Empty;
    }
}
