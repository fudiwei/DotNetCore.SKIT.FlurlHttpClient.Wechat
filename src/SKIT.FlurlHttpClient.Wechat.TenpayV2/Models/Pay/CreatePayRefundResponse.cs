using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /secapi/pay/refund 接口的响应。</para>
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(CreatePayRefundResponse.Converters.ResponseClassNewtonsoftJsonConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(CreatePayRefundResponse.Converters.ResponseClassSystemTextJsonConverter))]
    public class CreatePayRefundResponse : WechatTenpaySignableResponse
    {
        public static class Types
        {
            public class RefundCoupon
            {
                /// <summary>
                /// 获取或设置代金券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_refund_id_$n")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_refund_id_$n")]
                public string? CouponId { get; set; }

                /// <summary>
                /// 获取或设置代金券类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_type_$n")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_type_$n")]
                public string? CouponType { get; set; }

                /// <summary>
                /// 获取或设置代金券金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_refund_fee_$n")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_refund_fee_$n")]
                public int CouponFee { get; set; }
            }
        }

        internal static class Converters
        {
            internal class ResponseClassNewtonsoftJsonConverter : TenpayV2.Converters.NewtonsoftJson.FlattenNListObjectConverterBase<CreatePayRefundResponse, Types.RefundCoupon>
            {
                protected override PropertyInfo FlattenProperty => CreatePayRefundResponse._flattenProperty;
            }

            internal class ResponseClassSystemTextJsonConverter : TenpayV2.Converters.SystemTextJson.FlattenNListObjectConverterBase<CreatePayRefundResponse, Types.RefundCoupon>
            {
                protected override PropertyInfo FlattenProperty => CreatePayRefundResponse._flattenProperty;
            }
        }

        private readonly static PropertyInfo _flattenProperty = typeof(CreatePayRefundResponse).GetProperty(nameof(CouponRefundList), BindingFlags.Instance | BindingFlags.Public)!;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public override string? AppId { get; set; }

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
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置商户退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_refund_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_refund_no")]
        public string? OutRefundNumber { get; set; }

        /// <summary>
        /// 获取或设置微信退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
        public string? RefundId { get; set; }

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
        /// 获取或设置退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int RefundFee { get; set; }

        /// <summary>
        /// 获取或设置应结订单金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_total_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("settlement_total_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? SettlementTotalFee { get; set; }

        /// <summary>
        /// 获取或设置应结退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_refund_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("settlement_refund_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? SettlementRefundFee { get; set; }

        /// <summary>
        /// 获取或设置代金券退款金额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_refund_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_refund_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? CouponRefundFee { get; set; }

        /// <summary>
        /// 获取或设置代金券退款数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_refund_count")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_refund_count")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? CouponRefundCount { get; set; }

        /// <summary>
        /// 获取或设置代金券退款列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty(Converters.ResponseClassNewtonsoftJsonConverter.FLATTEN_PROPERTY_JSON_NAME)]
        [System.Text.Json.Serialization.JsonPropertyName(Converters.ResponseClassSystemTextJsonConverter.FLATTEN_PROPERTY_JSON_NAME)]
        public List<Types.RefundCoupon>? CouponRefundList { get; set; }

        /// <summary>
        /// 获取或设置现金支付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cash_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("cash_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? CashFee { get; set; }

        /// <summary>
        /// 获取或设置现金退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cash_refund_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("cash_refund_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? CashRefundFee { get; set; }
    }
}
