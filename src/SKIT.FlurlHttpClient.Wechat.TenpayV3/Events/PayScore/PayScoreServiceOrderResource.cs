using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 PAYSCORE.USER_CONFIRM（针对直连商户）通知的数据。</para>
    /// <para>表示 PAYSCORE.USER_PAID（针对直连商户）通知的数据。</para>
    /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/weixin-pay-score/success-notification.html </para>
    /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/weixin-pay-score/confirm-notification.html </para>
    /// </summary>
    public class PayScoreServiceOrderResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        public static class Types
        {
            public class Payment
            {
                /// <summary>
                /// 获取或设置付费项目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置付费说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置付费金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int? Amount { get; set; }

                /// <summary>
                /// 获取或设置付费数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int? Count { get; set; }
            }

            public class Discount
            {
                /// <summary>
                /// 获取或设置优惠名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置优惠金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int? Amount { get; set; }
            }

            public class TimeRange
            {
                /// <summary>
                /// 获取或设置服务开始时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.PureDigitalTextDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.PureDigitalTextDateTimeOffsetConverter))]
                public DateTimeOffset StartTime { get; set; }

                /// <summary>
                /// 获取或设置服务开始时间备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time_remark")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time_remark")]
                public string? StartTimeRemark { get; set; }

                /// <summary>
                /// 获取或设置服务结束时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
                public DateTimeOffset? EndTime { get; set; }

                /// <summary>
                /// 获取或设置服务结束时间备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time_remark")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time_remark")]
                public string? EndTimeRemark { get; set; }
            }

            public class Location : Models.GetPayScoreServiceOrderByOutOrderNumberResponse.Types.Location
            {
            }

            public class RiskFund : Models.GetPayScoreServiceOrderByOutOrderNumberResponse.Types.RiskFund
            {
            }

            public class Collection : Models.GetPayScoreServiceOrderByOutOrderNumberResponse.Types.Collection
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
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户服务订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string OutOrderNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付服务订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_introduction")]
        [System.Text.Json.Serialization.JsonPropertyName("service_introduction")]
        public string ServiceIntroduction { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务订单状态说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state_description")]
        [System.Text.Json.Serialization.JsonPropertyName("state_description")]
        public string? StateDescription { get; set; }

        /// <summary>
        /// 获取或设置商户收款总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        public int? TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置付费项目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_payments")]
        [System.Text.Json.Serialization.JsonPropertyName("post_payments")]
        public Types.Payment[]? PostPaymentList { get; set; }

        /// <summary>
        /// 获取或设置商户优惠列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_discounts")]
        [System.Text.Json.Serialization.JsonPropertyName("post_discounts")]
        public Types.Discount[]? PostDiscountList { get; set; }

        /// <summary>
        /// 获取或设置服务时间段信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_range")]
        [System.Text.Json.Serialization.JsonPropertyName("time_range")]
        public Types.TimeRange? TimeRange { get; set; }

        /// <summary>
        /// 获取或设置服务位置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location")]
        [System.Text.Json.Serialization.JsonPropertyName("location")]
        public Types.Location? Location { get; set; }

        /// <summary>
        /// 获取或设置订单风险金信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_fund")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_fund")]
        public Types.RiskFund? RiskFund { get; set; }

        /// <summary>
        /// 获取或设置是否需要收款。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_collection")]
        [System.Text.Json.Serialization.JsonPropertyName("need_collection")]
        public bool? RequireCollection { get; set; }

        /// <summary>
        /// 获取或设置收款信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collection")]
        [System.Text.Json.Serialization.JsonPropertyName("collection")]
        public Types.Collection? Collection { get; set; }
    }
}
