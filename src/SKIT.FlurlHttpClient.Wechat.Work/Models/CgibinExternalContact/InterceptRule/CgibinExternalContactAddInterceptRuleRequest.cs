using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/add_intercept_rule 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactAddInterceptRuleRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class ApplicableRange
            {
                /// <summary>
                /// 获取或设置用户 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_list")]
                [System.Text.Json.Serialization.JsonPropertyName("user_list")]
                public IList<string>? UserIdList { get; set; }

                /// <summary>
                /// 获取或设置部门 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department_list")]
                [System.Text.Json.Serialization.JsonPropertyName("department_list")]
                public IList<int>? DepartmentIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置规则名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_name")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_name")]
        public string RuleName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置敏感词列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("word_list")]
        [System.Text.Json.Serialization.JsonPropertyName("word_list")]
        public IList<string> WordList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置拦截语义列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("semantics_list")]
        [System.Text.Json.Serialization.JsonPropertyName("semantics_list")]
        public IList<int>? SemanticsList { get; set; }

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
