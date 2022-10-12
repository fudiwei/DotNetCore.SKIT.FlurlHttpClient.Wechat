namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/devicedata/add_accesscontrol_rule 接口的响应。</para>
    /// </summary>
    public class CgibinDeviceDataAddAccessControlRuleResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置门禁规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        public string RuleId { get; set; } = default!;

        /// <summary>
        /// 获取或设置非法的 OpenUserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_list")]
        public string[]? InvalidOpenUserIdList { get; set; }
    }
}
