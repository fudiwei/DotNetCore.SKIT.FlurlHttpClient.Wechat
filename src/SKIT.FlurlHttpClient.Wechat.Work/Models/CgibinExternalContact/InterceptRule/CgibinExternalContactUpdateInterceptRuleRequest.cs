using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/update_intercept_rule 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactUpdateInterceptRuleRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class ApplicableRange : CgibinExternalContactAddInterceptRuleRequest.Types.ApplicableRange
            {
            }

            public class ExtraRule
            {
                /// <summary>
                /// 获取或设置拦截语义列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("semantics_list")]
                [System.Text.Json.Serialization.JsonPropertyName("semantics_list")]
                public IList<int>? SemanticsList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        public string RuleId { get; set; } = string.Empty;

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
        public int? InterceptType { get; set; }

        /// <summary>
        /// 获取或设置要新增的生效范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_applicable_range")]
        [System.Text.Json.Serialization.JsonPropertyName("add_applicable_range")]
        public Types.ApplicableRange? AddApplicableRange { get; set; }

        /// <summary>
        /// 获取或设置要删除的生效范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remove_applicable_range")]
        [System.Text.Json.Serialization.JsonPropertyName("remove_applicable_range")]
        public Types.ApplicableRange? RemoveApplicableRange { get; set; }
    }
}
