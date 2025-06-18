namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/rule/add_rule 接口的响应。</para>
    /// </summary>
    public class CgibinCorpGroupRuleAddRuleResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置上下游关系规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        public int RuleId { get; set; }
    }
}
