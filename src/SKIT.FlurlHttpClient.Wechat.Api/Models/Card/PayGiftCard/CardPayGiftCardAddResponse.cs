using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/paygiftcard/add 接口的响应。</para>
    /// </summary>
    public class CardPayGiftCardAddResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Merchant
            {
                /// <summary>
                /// 获取或设置微信商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                public string MerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string? ErrorMessage { get; set; }

                /// <summary>
                /// 获取或设置被占用的规则 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("occupy_rule_id")]
                [System.Text.Json.Serialization.JsonPropertyName("occupy_rule_id")]
                public int? OccupyRuleId { get; set; }

                /// <summary>
                /// 获取或设置被占用的微信 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("occupy_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("occupy_appid")]
                public string? OccupyAppId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_id")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        public int RuleId { get; set; }

        /// <summary>
        /// 获取或设置设置失败的微信商户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_mchid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_mchid_list")]
        public Types.Merchant[] FailMerchantList { get; set; } = default!;

        /// <summary>
        /// 获取或设置设置成功的微信商户号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("succ_mchid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("succ_mchid_list")]
        public string[] SuccessMerchantIdList { get; set; } = default!;
    }
}
