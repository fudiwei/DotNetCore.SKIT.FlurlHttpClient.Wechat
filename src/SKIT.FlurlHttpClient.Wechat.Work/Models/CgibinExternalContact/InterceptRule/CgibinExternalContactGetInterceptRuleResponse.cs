namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_intercept_rule 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetInterceptRuleResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Rule : CgibinExternalContactGetInterceptRuleListResponse.Types.Rule
            {
                public static class Types
                {
                    public class ExtraRule
                    {
                        /// <summary>
                        /// 获取或设置拦截语义列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("semantics_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("semantics_list")]
                        public int[]? SemanticsList { get; set; }
                    }

                    public class ApplicableRange
                    {
                        /// <summary>
                        /// 获取或设置用户 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_list")]
                        public string[]? UserIdList { get; set; }

                        /// <summary>
                        /// 获取或设置部门 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("department_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("department_list")]
                        public long[]? DepartmentIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置敏感词列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("word_list")]
                [System.Text.Json.Serialization.JsonPropertyName("word_list")]
                public string[] WordList { get; set; } = default!;

                /// <summary>
                /// 获取或设置额外规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extra_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("extra_rule")]
                public Types.ExtraRule? ExtraRule { get; set; }

                /// <summary>
                /// 获取或设置拦截类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("intercept_type")]
                [System.Text.Json.Serialization.JsonPropertyName("intercept_type")]
                public int InterceptType { get; set; }

                /// <summary>
                /// 获取或设置生效范围。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applicable_range")]
                [System.Text.Json.Serialization.JsonPropertyName("applicable_range")]
                public Types.ApplicableRange? ApplicableRange { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule")]
        [System.Text.Json.Serialization.JsonPropertyName("rule")]
        public Types.Rule Rule { get; set; } = default!;
    }
}
