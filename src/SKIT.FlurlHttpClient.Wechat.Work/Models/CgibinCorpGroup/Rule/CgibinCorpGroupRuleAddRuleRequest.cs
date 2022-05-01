using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/rule/add_rule 接口的请求。</para>
    /// </summary>
    public class CgibinCorpGroupRuleAddRuleRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Rule
            {
                public static class Types
                {
                    public class OwnerCorpRange
                    {
                        /// <summary>
                        /// 获取或设置 UserId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userids")]
                        [System.Text.Json.Serialization.JsonPropertyName("userids")]
                        public IList<string>? UserIdList { get; set; }

                        /// <summary>
                        /// 获取或设置部门 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("departmentids")]
                        [System.Text.Json.Serialization.JsonPropertyName("departmentids")]
                        public IList<long>? DepartmentIdList { get; set; }
                    }

                    public class MemberCorpRange
                    {
                        /// <summary>
                        /// 获取或设置分组 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("groupids")]
                        [System.Text.Json.Serialization.JsonPropertyName("groupids")]
                        public IList<int>? GroupIdList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置企业 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("corpids")]
                        [System.Text.Json.Serialization.JsonPropertyName("corpids")]
                        public IList<string>? CorpIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置上游企业的对接人规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("owner_corp_range")]
                [System.Text.Json.Serialization.JsonPropertyName("owner_corp_range")]
                public Types.OwnerCorpRange OwnerCorpRange { get; set; } = default!;

                /// <summary>
                /// 获取或设置下游企业规则范围信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("member_corp_range")]
                [System.Text.Json.Serialization.JsonPropertyName("member_corp_range")]
                public Types.MemberCorpRange MemberCorpRange { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置上下游 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chain_id")]
        [System.Text.Json.Serialization.JsonPropertyName("chain_id")]
        public string ChainId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上下游关系规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_info")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_info")]
        public Types.Rule Rule { get; set; } = new Types.Rule();
    }
}
