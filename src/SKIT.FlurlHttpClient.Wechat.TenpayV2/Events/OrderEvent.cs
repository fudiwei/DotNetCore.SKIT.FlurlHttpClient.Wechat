using System;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Events
{
    /// <summary>
    /// <para>表示交易结果通知的模型。</para>
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Converters.EventClassNewtonsoftJsonConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(Converters.EventClassSystemTextJsonConverter))]
    public class OrderEvent : WechatTenpayEvent
    {
        public static new class Types
        {
            public class Coupon
            {
                /// <summary>
                /// 获取或设置代金券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_id_$n")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_id_$n")]
                public string CouponId { get; set; } = default!;

                /// <summary>
                /// 获取或设置代金券类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_type_$n")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_type_$n")]
                public string CouponType { get; set; } = default!;

                /// <summary>
                /// 获取或设置代金券金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_fee_$n")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_fee_$n")]
                public int CouponFee { get; set; }
            }
        }

        internal static class Converters
        {
            internal class EventClassNewtonsoftJsonConverter : Newtonsoft.Json.Converters.Internal.FlattenNArrayObjectConverterBase<OrderEvent, Types.Coupon>
            {
                protected override PropertyInfo FlattenProperty => OrderEvent._flattenProperty;
            }

            internal class EventClassSystemTextJsonConverter : System.Text.Json.Serialization.Internal.FlattenNArrayObjectConverterBase<OrderEvent, Types.Coupon>
            {
                protected override PropertyInfo FlattenProperty => OrderEvent._flattenProperty;
            }
        }

        private readonly static PropertyInfo _flattenProperty = typeof(OrderEvent).GetProperty(nameof(CouponList), BindingFlags.Instance | BindingFlags.Public)!;

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
        /// 获取或设置终端设备号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_info")]
        [System.Text.Json.Serialization.JsonPropertyName("device_info")]
        public string? DeviceInfo { get; set; }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户是否订阅该公众号标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_subscribe")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Internal.YesOrNoBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_subscribe")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Internal.YesOrNoBooleanConverter))]
        public bool? IsSubscribed { get; set; }

        /// <summary>
        /// 获取或设置用户在子商户下的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
        public string? SubOpenId { get; set; }

        /// <summary>
        /// 获取或设置交易状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_state")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_state")]
        public string TradeState { get; set; } = default!;

        /// <summary>
        /// 获取或设置交易状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_state_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_state_desc")]
        public string TradeStateDescription { get; set; } = default!;

        /// <summary>
        /// 获取或设置交易类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_type")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_type")]
        public string TradeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置付款银行。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_type")]
        public string BankType { get; set; } = default!;

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
        public int? SettlementFee { get; set; }

        /// <summary>
        /// 获取或设置代金券金额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? CouponFee { get; set; }

        /// <summary>
        /// 获取或设置代金券使用数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_count")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_count")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? CouponCount { get; set; }

        /// <summary>
        /// 获取或设置代金券使用列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty(Converters.EventClassNewtonsoftJsonConverter.FLATTEN_PROPERTY_JSON_NAME)]
        [System.Text.Json.Serialization.JsonPropertyName(Converters.EventClassSystemTextJsonConverter.FLATTEN_PROPERTY_JSON_NAME)]
        public Types.Coupon[]? CouponList { get; set; }

        /// <summary>
        /// 获取或设置现金支付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cash_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("cash_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? CashFee { get; set; }

        /// <summary>
        /// 获取或设置现金支付货币类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cash_fee_type")]
        [System.Text.Json.Serialization.JsonPropertyName("cash_fee_type")]
        public string? CashFeeType { get; set; }

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
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置支付完成时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_end")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.DigitalDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_end")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.DigitalDateTimeOffsetConverter))]
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// 获取或设置汇率（格式：外币兑换人民币的比例乘以 10 的 8 次方）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rate")]
        [System.Text.Json.Serialization.JsonPropertyName("rate")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public decimal? ExchangeRate { get; set; }
    }
}
