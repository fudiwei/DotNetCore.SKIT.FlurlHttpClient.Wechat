using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/paygiftcard/add 接口的请求。</para>
    /// </summary>
    public class CardPayGiftCardAddRequest : WechatApiRequest, IInferable<CardPayGiftCardAddRequest, CardPayGiftCardAddResponse>
    {
        public static class Types
        {
            public class Rule
            {
                public static class Types
                {
                    public class Base
                    {
                        /// <summary>
                        /// 获取或设置微信商户号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mchid_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("mchid_list")]
                        public IList<string> MerchantIdList { get; set; } = new List<string>();

                        /// <summary>
                        /// 获取或设置规则开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                        public long BeginTimetamp { get; set; }

                        /// <summary>
                        /// 获取或设置规则结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long EndTimetamp { get; set; }
                    }

                    public class MemberRule
                    {
                        /// <summary>
                        /// 获取或设置要赠送的会员卡卡券模板编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
                        public string CardId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置单次消费送会员卡的金额下限（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("least_cost")]
                        [System.Text.Json.Serialization.JsonPropertyName("least_cost")]
                        public int LeastCost { get; set; }

                        /// <summary>
                        /// 获取或设置单次消费送会员卡的金额上限（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("max_cost")]
                        [System.Text.Json.Serialization.JsonPropertyName("max_cost")]
                        public int MaxCost { get; set; }

                        /// <summary>
                        /// 获取或设置商户自定义领卡网页 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("jump_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("jump_url")]
                        public string? Url { get; set; }

                        /// <summary>
                        /// 获取或设置商户自定义领卡小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_brand_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_brand_id")]
                        public string? MiniProgramAppId { get; set; }

                        /// <summary>
                        /// 获取或设置商户自定义领卡小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_brand_pass")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_brand_pass")]
                        public string? MiniProgramPath { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置营销规则类型。
                /// <para>默认值："RULE_TYPE_PAY_MEMBER_CARD"</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = "RULE_TYPE_PAY_MEMBER_CARD";

                /// <summary>
                /// 获取或设置营销规则基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = new Types.Base();

                /// <summary>
                /// 获取或设置支付即会员规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("member_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("member_rule")]
                public Types.MemberRule? MemberRule { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置营销规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_info")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_info")]
        public Types.Rule Rule { get; set; } = new Types.Rule();
    }
}
