namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/keyword/get_rule_detail 接口的请求。</para>
    /// </summary>
    public class CgibinChatDataKeywordGetRuleDetailRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置关键词规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        public string RuleId { get; set; } = string.Empty;
    }
}
