namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /secapi/pay/refundv2 接口的响应。</para>
    /// </summary>
    public class CreatePayRefundV2Response : WechatTenpaySignableResponse
    {
        public static class Types
        {
            public class PromotionDetail : GetPayRefundV2Response.Types.PromotionDetail
            {
                public static new class Types
                {
                    public class Promotion : GetPayRefundV2Response.Types.PromotionDetail.Types.Promotion
                    {
                        public static new class Types
                        {
                            public class GoodsDetail : GetPayRefundV2Response.Types.PromotionDetail.Types.Promotion.Types.GoodsDetail
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置单品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_detail")]
                        public new Types.GoodsDetail[]? GoodsList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置优惠信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_detail")]
                public new Types.Promotion[]? PromotionList { get; set; }
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
