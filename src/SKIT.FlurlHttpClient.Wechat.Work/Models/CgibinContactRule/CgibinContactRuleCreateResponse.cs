namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/contactrule/create 接口的响应。</para>
    /// </summary>
    public class CgibinContactRuleCreateResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置规则 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_ids")]
        public long[] RuleIdList { get; set; } = default!;
    }
}
