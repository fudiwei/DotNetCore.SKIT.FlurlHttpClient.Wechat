namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/externalcontact/get_intercept_rule_list 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetInterceptRuleListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Rule
            {
                /// <summary>
                /// 获取或设置规则 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rule_id")]
                [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                public string RuleId { get; set; } = default!;

                /// <summary>
                /// 获取或设置规则名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rule_name")]
                [System.Text.Json.Serialization.JsonPropertyName("rule_name")]
                public string RuleName { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_list")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_list")]
        public Types.Rule[] RuleList { get; set; } = default!;
    }
}