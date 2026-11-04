namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/contactrule/update 接口的请求。</para>
    /// </summary>
    public class CgibinContactRuleUpdateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Rule
            {
                public static class Types
                {
                    public class Range : CgibinContactRuleCreateRequest.Types.Rule.Types.Range
                    {
                    }
                }

                /// <summary>
                /// 获取或设置规则 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rule_id")]
                [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
                public long RuleId { get; set; }

                /// <summary>
                /// 获取或设置目标规则范围信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("range")]
                [System.Text.Json.Serialization.JsonPropertyName("range")]
                public Types.Range? Range { get; set; }

                /// <summary>
                /// 获取或设置白名单范围信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("whitelist")]
                [System.Text.Json.Serialization.JsonPropertyName("whitelist")]
                public Types.Range? WhiteList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rules")]
        [System.Text.Json.Serialization.JsonPropertyName("rules")]
        public List<Types.Rule>? RuleList { get; set; }
    }
}
