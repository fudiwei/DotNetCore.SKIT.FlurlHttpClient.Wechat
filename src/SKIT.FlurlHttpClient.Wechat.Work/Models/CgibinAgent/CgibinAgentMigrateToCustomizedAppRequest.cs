namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/agent/migrate_to_customized_app 接口的请求。</para>
    /// </summary>
    public class CgibinAgentMigrateToCustomizedAppRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置代开发应用模版接口调用凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("suite_access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("suite_access_token")]
        public string SuiteAccessToken { get; set; } = string.Empty;
    }
}
