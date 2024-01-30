using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/refundquery 接口的响应。</para>
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponseClassNewtonsoftJsonConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponseClassSystemTextJsonConverter))]
    public class GetPayRefundResponse : WechatTenpaySignableResponse
    {
        public static class Types
        {
            public class Refund
            {
                /// <summary>
                /// 获取或设置商户退款单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_refund_no_$n")]
                [System.Text.Json.Serialization.JsonPropertyName("out_refund_no_$n")]
                public string OutRefundNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信退款单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_id_$n")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_id_$n")]
                public string RefundId { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款渠道。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_channel_$n")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_channel_$n")]
                public string? RefundChannel { get; set; }

                /// <summary>
                /// 获取或设置退款状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_status_$n")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_status_$n")]
                public string RefundStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款资金来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_account_$n")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_account_$n")]
                public string? RefundAccount { get; set; }

                /// <summary>
                /// 获取或设置退款入账账户。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_recv_accout_$n")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_recv_accout_$n")]
                public string? RefundReceiveAccount { get; set; }

                /// <summary>
                /// 获取或设置退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_fee_$n")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_fee_$n")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int RefundFee { get; set; }

                /// <summary>
                /// 获取或设置应结退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settlement_refund_fee_$n")]
                [System.Text.Json.Serialization.JsonPropertyName("settlement_refund_fee_$n")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? SettlementRefundFee { get; set; }

                /// <summary>
                /// 获取或设置代金券退款金额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_refund_fee_$n")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_refund_fee_$n")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? CouponRefundFee { get; set; }

                /// <summary>
                /// 获取或设置退款成功时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_success_time_$n")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.DigitalDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("refund_success_time_$n")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.DigitalDateTimeOffsetConverter))]
                public DateTimeOffset? SuccessTime { get; set; }
            }
        }

        internal static class Converters
        {
            internal class ResponseClassNewtonsoftJsonConverter : Newtonsoft.Json.Converters.FlattenNArrayObjectConverterBase<GetPayRefundResponse>
            {
            }

            internal class ResponseClassSystemTextJsonConverter : System.Text.Json.Converters.FlattenNArrayObjectConverterBase<GetPayRefundResponse>
            {
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
#pragma warning disable CS8618
#pragma warning disable CS8765
        public override string MerchantId { get; set; }
#pragma warning restore CS8765
#pragma warning restore CS8618

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
#pragma warning disable CS8618
#pragma warning disable CS8765
        public override string AppId { get; set; }
#pragma warning restore CS8765
#pragma warning restore CS8618

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("total_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int TotalFee { get; set; }

        /// <summary>
        /// 获取或设置货币类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee_type")]
        [System.Text.Json.Serialization.JsonPropertyName("fee_type")]
        public string? FeeType { get; set; }

        /// <summary>
        /// 获取或设置应结订单金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_total_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("settlement_total_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? SettlementTotalFee { get; set; }

        /// <summary>
        /// 获取或设置现金支付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cash_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("cash_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? CashFee { get; set; }

        /// <summary>
        /// 获取或设置记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty(Newtonsoft.Json.Converters.FlattenNArrayObjectConverterBase.PROPERTY_NAME_NARRAY)]
        [System.Text.Json.Serialization.JsonPropertyName(System.Text.Json.Converters.FlattenNArrayObjectConverterBase.PROPERTY_NAME_NARRAY)]
        public Types.Refund[] RefundList { get; set; } = default!;

        /// <summary>
        /// 获取或设置记录总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_refund_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_refund_count")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int TotalRefundCount { get; set; }
    }
}
