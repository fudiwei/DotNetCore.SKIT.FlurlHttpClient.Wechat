namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_intercept_rule 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGetInterceptRuleRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        public string RuleId { get; set; } = string.Empty;
    }
}
