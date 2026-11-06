namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/paygiftcard/getbyid 接口的响应。</para>
    /// </summary>
    public class CardPayGiftCardGetByIdResponse : WechatApiResponse
    {
        public static class Types
        {
            public abstract class __zz__Rule
            {
                /// <summary>
                /// 获取或设置营销规则类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string? Type { get; set; }
            }

            public class Rule : __zz__Rule
            {
                public static class Types
                {
                    public class BaseInfo : CardPayGiftCardAddRequest.Types.Rule.Types.BaseInfo
                    {
                        /// <summary>
                        /// 获取或设置规则状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string? Status { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置修改时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimetamp { get; set; }
                    }

                    public class MemberRule : CardPayGiftCardAddRequest.Types.Rule.Types.MemberRule
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
        /// 获取或设置营销规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_info")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_info")]
        public Types.Rule? Rule { get; set; }
    }
}
