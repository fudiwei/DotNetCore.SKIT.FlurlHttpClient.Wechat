using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 PAYSCORE.USER_SIGN_PLAN（针对服务商）通知的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012159037 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012159652 ]]>
    /// </para>
    /// </summary>
    public class PayScorePartnerUserSignPlanResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        public static class Types
        {
            public class SignPlanDetail : Models.GetPayScorePartnerSignPlanUserSignPlanByOutSignPlanNumberResponse.Types.SignPlanDetail
            {
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置支付分计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public string PlanId { get; set; } = default!;

        /// <summary>
        /// 获取或设置计划名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_name")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_name")]
        public string PlanName { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户签约计划单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_sign_plan_no")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_sign_plan_no")]
        public string OutSignPlanNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置签约计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_plan_id")]
        public string SignPlanId { get; set; } = default!;

        /// <summary>
        /// 获取或设置计划状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_state")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_state")]
        public string SignState { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户在子商户下的唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
        public string? SubOpenId { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_callback_url")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_callback_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置目前用户进行到的计划明细序号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("going_detail_no")]
        [System.Text.Json.Serialization.JsonPropertyName("going_detail_no")]
        public int GoingDetailNumber { get; set; }

        /// <summary>
        /// 获取或设置计划过期时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_over_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("plan_over_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset PlanOverTime { get; set; }

        /// <summary>
        /// 获取或设置扣费次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deduction_quantity")]
        [System.Text.Json.Serialization.JsonPropertyName("deduction_quantity")]
        public int DeductionQuantity { get; set; }

        /// <summary>
        /// 获取或设置原总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_origin_price")]
        [System.Text.Json.Serialization.JsonPropertyName("total_origin_price")]
        public int TotalOriginalPrice { get; set; }

        /// <summary>
        /// 获取或设置实际总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_actual_price")]
        [System.Text.Json.Serialization.JsonPropertyName("total_actual_price")]
        public int TotalActualPrice { get; set; }

        /// <summary>
        /// 获取或设置签约时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("sign_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? SignTime { get; set; }

        /// <summary>
        /// 获取或设置取消类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_sign_type")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_sign_type")]
        public string? CancelType { get; set; }

        /// <summary>
        /// 获取或设置取消原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_reason")]
        public string? CancelReason { get; set; }

        /// <summary>
        /// 获取或设置取消时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_sign_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_sign_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? CancelTime { get; set; }

        /// <summary>
        /// 获取或设置签约计划明细列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signed_detail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("signed_detail_list")]
        public Types.SignPlanDetail[]? SignPlanDetailList { get; set; }
    }
}
