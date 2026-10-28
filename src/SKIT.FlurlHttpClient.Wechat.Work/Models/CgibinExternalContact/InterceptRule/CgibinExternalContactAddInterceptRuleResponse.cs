namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/add_intercept_rule 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactAddInterceptRuleResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringConverter))]
        public string? RuleId { get; set; }
    }
}
