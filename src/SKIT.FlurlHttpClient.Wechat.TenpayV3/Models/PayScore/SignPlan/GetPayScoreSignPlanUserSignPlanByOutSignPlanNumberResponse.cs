using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /payscore/sign-plan/user-sign-plans/merchant-sign-plan-no/{merchant_sign_plan_no} 接口的响应。</para>
    /// </summary>
    public class GetPayScoreSignPlanUserSignPlanByOutSignPlanNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class SignPlanDetail
            {
                /// <summary>
                /// 获取或设置计划明细序号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plan_detail_no")]
                [System.Text.Json.Serialization.JsonPropertyName("plan_detail_no")]
                public int PlanDetailNumber { get; set; }

                /// <summary>
                /// 获取或设置明细名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plan_detail_name")]
                [System.Text.Json.Serialization.JsonPropertyName("plan_detail_name")]
                public string PlanDetailName { get; set; } = default!;

                /// <summary>
                /// 获取或设置明细状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plan_detail_state")]
                [System.Text.Json.Serialization.JsonPropertyName("plan_detail_state")]
                public string PlanDetailState { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plan_discount_description")]
                [System.Text.Json.Serialization.JsonPropertyName("plan_discount_description")]
                public string? DiscountDescription { get; set; }

                /// <summary>
                /// 获取或设置原支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("original_price")]
                [System.Text.Json.Serialization.JsonPropertyName("original_price")]
                public int OriginalPrice { get; set; }

                /// <summary>
                /// 获取或设置实际支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actual_price")]
                [System.Text.Json.Serialization.JsonPropertyName("actual_price")]
                public int ActualPrice { get; set; }

                /// <summary>
                /// 获取或设置实际支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actual_pay_price")]
                [System.Text.Json.Serialization.JsonPropertyName("actual_pay_price")]
                public int? ActualPayPrice { get; set; }

                /// <summary>
                /// 获取或设置商户计划明细使用订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_plan_detail_no")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_plan_detail_no")]
                public string OutPlanDetailNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信支付服务订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string? OrderId { get; set; }

                /// <summary>
                /// 获取或设置使用时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("use_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("use_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset? UseTime { get; set; }

                /// <summary>
                /// 获取或设置完成时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complete_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("complete_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset? CompleteTime { get; set; }

                /// <summary>
                /// 获取或设置取消时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cancel_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("cancel_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset? CancelTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

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
