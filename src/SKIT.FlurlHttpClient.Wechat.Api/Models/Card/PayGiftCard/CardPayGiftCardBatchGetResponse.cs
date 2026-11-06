namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/paygiftcard/batchget 接口的响应。</para>
    /// </summary>
    public class CardPayGiftCardBatchGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Rule : CardPayGiftCardGetByIdResponse.Types.__zz__Rule
            {
                public static class Types
                {
                    public class BaseInfo : CardPayGiftCardGetByIdResponse.Types.Rule.Types.BaseInfo
                    {
                    }

                    public class MemberRule : CardPayGiftCardGetByIdResponse.Types.Rule.Types.MemberRule
                    {
                    }
                }

                /// <summary>
                /// 获取或设置营销规则基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.BaseInfo? BaseInfo { get; set; }

                /// <summary>
                /// 获取或设置支付即会员规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("member_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("member_rule")]
                public Types.MemberRule? MemberRule { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置营销规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_list")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_list")]
        public List<Types.Rule>? RuleList { get; set; }

        /// <summary>
        /// 获取或设置营销规则总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
