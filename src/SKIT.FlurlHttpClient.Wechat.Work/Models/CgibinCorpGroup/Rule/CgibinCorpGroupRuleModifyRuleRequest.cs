namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/rule/modify_rule 接口的请求。</para>
    /// </summary>
    public class CgibinCorpGroupRuleModifyRuleRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Rule
            {
                public static class Types
                {
                    public class OwnerCorpRange : CgibinCorpGroupRuleAddRuleRequest.Types.Rule.Types.OwnerCorpRange
                    {
                    }

                    public class MemberCorpRange : CgibinCorpGroupRuleAddRuleRequest.Types.Rule.Types.MemberCorpRange
                    {
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
        /// 获取或设置上下游关系规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        public int RuleId { get; set; }

        /// <summary>
        /// 获取或设置上下游关系规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_info")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_info")]
        public Types.Rule Rule { get; set; } = new Types.Rule();
    }
}
