namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/keyword/get_hit_msg_list 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataKeywordGetHitMessageListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Message
            {
                public static class Types
                {
                    public class HitRule
                    {
                        /// <summary>
                        /// 获取或设置关键词规则 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rule_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
                        public string RuleId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否命中关键词。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("has_hit_keyword")]
                        [System.Text.Json.Serialization.JsonPropertyName("has_hit_keyword")]
                        public bool HasHitKeyword { get; set; }

                        /// <summary>
                        /// 获取或设置关键行为列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("semantics_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("semantics_list")]
                        public int[]? SemanticsList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgid")]
                [System.Text.Json.Serialization.JsonPropertyName("msgid")]
                public string MessageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置命中的规则列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hit_rule_list")]
                [System.Text.Json.Serialization.JsonPropertyName("hit_rule_list")]
                public Types.HitRule[] HitRuleList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置消息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_list")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_list")]
        public Types.Message[] MessageList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanReadOnlyConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanReadOnlyConverter))]
        public bool HasMore { get; set; }
    }
}
