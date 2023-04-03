using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/orderquery 接口的响应。</para>
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponseClassNewtonsoftJsonConverter))]
    [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponseClassSystemTextJsonConverter))]
    public class GetPayOrderResponse : WechatTenpaySignableResponse
    {
        public static class Types
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

            public class Detail
            {
                public static class Types
                {
                    public class DiscountDetail
                    {
                        /// <summary>
                        /// 获取或设置商品编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_id")]
                        public string GoodsId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
                        public string GoodsName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置代金券批次 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_batch_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_batch_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                        public string CouponBatchId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置代金券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                        public string CouponId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置代金券支付金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_fee")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int CouponFee { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置单品优惠列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_detail")]
                public Types.DiscountDetail[]? DiscountList { get; set; }
            }

            public class PromotionDetail
            {
                public static class Types
                {
                    public class Promotion
                    {
                        public static class Types
                        {
                            public class GoodsDetail
                            {
                                /// <summary>
                                /// 获取或设置商品编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("goods_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("goods_id")]
                                public string GoodsId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int Quantity { get; set; }

                                /// <summary>
                                /// 获取或设置商品单价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("price")]
                                [System.Text.Json.Serialization.JsonPropertyName("price")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int Price { get; set; }

                                /// <summary>
                                /// 获取或设置商品优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int DiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置商品备注。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("goods_remark")]
                                [System.Text.Json.Serialization.JsonPropertyName("goods_remark")]
                                public string? GoodsRemark { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置券或者立减优惠 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_id")]
                        public string PromotionId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置优惠名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置优惠范围。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scope")]
                        [System.Text.Json.Serialization.JsonPropertyName("scope")]
                        public string? Scope { get; set; }

                        /// <summary>
                        /// 获取或设置优惠类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string? Type { get; set; }

                        /// <summary>
                        /// 获取或设置优惠券面额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int Amount { get; set; }

                        /// <summary>
                        /// 获取或设置活动 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activity_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                        public string? ActivityId { get; set; }

                        /// <summary>
                        /// 获取或设置微信出资（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wxpay_contribute")]
                        [System.Text.Json.Serialization.JsonPropertyName("wxpay_contribute")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int? WechatpayContribute { get; set; }

                        /// <summary>
                        /// 获取或设置商户出资（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_contribute")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_contribute")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int? MerchantContribute { get; set; }

                        /// <summary>
                        /// 获取或设置其他出资（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("other_contribute")]
                        [System.Text.Json.Serialization.JsonPropertyName("other_contribute")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int? OtherContribute { get; set; }

                        /// <summary>
                        /// 获取或设置单品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_detail")]
                        public Types.GoodsDetail[]? GoodsList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置优惠信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_detail")]
                public Types.Promotion[]? PromotionList { get; set; }
            }
        }

        internal static class Converters
        {
            internal class ResponseClassNewtonsoftJsonConverter : Newtonsoft.Json.Converters.FlattenNArrayObjectConverterBase<GetPayOrderResponse>
            {
            }

            internal class ResponseClassSystemTextJsonConverter : System.Text.Json.Converters.FlattenNArrayObjectConverterBase<GetPayOrderResponse>
            {
            }

            internal class ResponsePropertyDetailNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Detail>
            {
            }

            internal class ResponsePropertyDetailSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Detail>
            {
            }

            internal class ResponsePropertyPromotionDetailNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.PromotionDetail>
            {
            }

            internal class ResponsePropertyPromotionDetailSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.PromotionDetail>
            {
            }
        }

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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.YesOrNoBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_subscribe")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.YesOrNoBooleanConverter))]
        public bool IsSubscribed { get; set; }

        /// <summary>
        /// 获取或设置用户在子商户下的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
        public string? SubOpenId { get; set; }

        /// <summary>
        /// 获取或设置用户是否订阅子商户公众号标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_is_subscribe")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.YesOrNoNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("sub_is_subscribe")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.YesOrNoNullableBooleanConverter))]
        public bool? IsSubSubscribed { get; set; }

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
        [Newtonsoft.Json.JsonProperty(Newtonsoft.Json.Converters.FlattenNArrayObjectConverterBase.PROPERTY_NAME_NARRAY)]
        [System.Text.Json.Serialization.JsonPropertyName(System.Text.Json.Converters.FlattenNArrayObjectConverterBase.PROPERTY_NAME_NARRAY)]
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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_end")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyDetailNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyDetailSystemTextJsonConverter))]
        public Types.Detail? Detail { get; set; }

        /// <summary>
        /// 获取或设置优惠信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_detail")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyPromotionDetailNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_detail")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyPromotionDetailSystemTextJsonConverter))]
        public Types.PromotionDetail? PromotionDetail { get; set; }
    }
}
