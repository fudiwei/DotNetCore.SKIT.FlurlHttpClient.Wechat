namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/refundqueryv2 接口的响应。</para>
    /// </summary>
    public class GetPayRefundV2Response : WechatTenpaySignableResponse
    {
        public static class Types
        {
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
                                /// 获取或设置商品单价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("price")]
                                [System.Text.Json.Serialization.JsonPropertyName("price")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int Price { get; set; }

                                /// <summary>
                                /// 获取或设置商品退款数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_quantity")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int RefundQuantity { get; set; }

                                /// <summary>
                                /// 获取或设置商品优惠退款金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int RefundAmount { get; set; }
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
                        /// 获取或设置优惠券退款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                        public int RefundAmount { get; set; }

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
        /// 获取或设置商户退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_refund_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_refund_no")]
        public string OutRefundNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
        public string RefundId { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款渠道。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_channel")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_channel")]
        public string? RefundChannel { get; set; }

        /// <summary>
        /// 获取或设置退款状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_status")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_status")]
        public string RefundStatus { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款资金来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_account")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_account")]
        public string? RefundAccount { get; set; }

        /// <summary>
        /// 获取或设置退款入账账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_recv_accout")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_recv_accout")]
        public string? RefundReceiveAccount { get; set; }

        /// <summary>
        /// 获取或设置退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int RefundFee { get; set; }

        /// <summary>
        /// 获取或设置现金退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cash_refund_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("cash_refund_fee")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? CashRefundFee { get; set; }

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
