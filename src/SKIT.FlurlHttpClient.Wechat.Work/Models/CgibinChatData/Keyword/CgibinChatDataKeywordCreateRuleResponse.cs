namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/keyword/create_rule 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataKeywordCreateRuleResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置关键词规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        public string RuleId { get; set; } = default!;
    }
}
