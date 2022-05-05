namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/rule/list_ids 接口的响应。</para>
    /// </summary>
    public class CgibinCorpGroupRuleListIdsResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置上下游关系规则的 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_ids")]
        public int[] RuleIdList { get; set; } = default!;
    }
}
