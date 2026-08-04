using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/contactrule/create 接口的请求。</para>
    /// </summary>
    public class CgibinContactRuleCreateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Rule
            {
                public static class Types
                {
                    public class Range
                    {
                        /// <summary>
                        /// 获取或设置成员 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public IList<string>? UserIdList { get; set; }

                        /// <summary>
                        /// 获取或设置部门 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("partyid")]
                        [System.Text.Json.Serialization.JsonPropertyName("partyid")]
                        public IList<long>? DepartmentIdList { get; set; }

                        /// <summary>
                        /// 获取或设置标签 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tagid")]
                        [System.Text.Json.Serialization.JsonPropertyName("tagid")]
                        public IList<long>? TagIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置规则类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rule_type")]
                [System.Text.Json.Serialization.JsonPropertyName("rule_type")]
                public int RuleType { get; set; }

                /// <summary>
                /// 获取或设置目标规则范围信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("range")]
                [System.Text.Json.Serialization.JsonPropertyName("range")]
                public Types.Range Range { get; set; } = new Types.Range();

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
        public IList<Types.Rule> RuleList { get; set; } = new List<Types.Rule>();
    }
}
