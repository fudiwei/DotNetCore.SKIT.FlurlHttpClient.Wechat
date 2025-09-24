using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /new-tax-control-fapiao/fapiaomerchant/listspinvitemchinfo 接口的响应。</para>
    /// </summary>
    public class QueryNewTaxControlFapiaoMerchantServicePartnerInvitedMerchantsResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class MerchantInviteResult
            {
                /// <summary>
                /// 获取或设置受邀商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
                public string? SubMerchantId { get; set; }

                /// <summary>
                /// 获取或设置商户邀请状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mch_invite_status")]
                [System.Text.Json.Serialization.JsonPropertyName("mch_invite_status")]
                public string MerchantInviteStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ep_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ep_name")]
                public string MerchantName { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户税号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tax_id")]
                [System.Text.Json.Serialization.JsonPropertyName("tax_id")]
                public string TaxId { get; set; } = default!;

                /// <summary>
                /// 获取或设置邀请码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invite_code")]
                [System.Text.Json.Serialization.JsonPropertyName("invite_code")]
                public string InviteCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置操作时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operate_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("operate_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset OperateTime { get; set; }

                /// <summary>
                /// 获取或设置邀请失败错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invite_failed_code")]
                [System.Text.Json.Serialization.JsonPropertyName("invite_failed_code")]
                public string? InviteFailCode { get; set; }

                /// <summary>
                /// 获取或设置邀请失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invite_failed_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("invite_failed_reason")]
                public string? InviteFailReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置邀请的商户结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_invite_result_list")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_invite_result_list")]
        public Types.MerchantInviteResult[] MerchantInviteResultList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }
    }
}
