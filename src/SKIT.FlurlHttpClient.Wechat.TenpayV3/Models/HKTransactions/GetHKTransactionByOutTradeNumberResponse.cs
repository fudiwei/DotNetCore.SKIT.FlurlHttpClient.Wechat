using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /transactions/out-trade-no/{out_trade_no} 接口的响应。</para>
    /// </summary>
    public class GetHKTransactionByOutTradeNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Payer : GetPayTransactionByOutTradeNumberResponse.Types.Payer
            {
            }

            public class Amount : GetPayTransactionByOutTradeNumberResponse.Types.Amount
            {
                public static class Types
                {
                    public class ExchangeRate
                    {
                        /// <summary>
                        /// 获取或设置结算方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置汇率（格式：外币兑换人民币的比例乘以 10 的 8 次方）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("rate")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long Value { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置汇率信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exchange_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("exchange_rate")]
                public Types.ExchangeRate? ExchangeRate { get; set; }
            }

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
                        public int Quantity { get; set; }

                        /// <summary>
                        /// 获取或设置商品单价（单位：指定货币的最小单位）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        public int UnitPrice { get; set; }

                        /// <summary>
                        /// 获取或设置商品优惠金额（单位：指定货币的最小单位）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
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
                /// 获取或设置券 ID。
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
                /// 获取或设置优惠券面额（单位：指定货币的最小单位）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置优惠券退款金额（单位：指定货币的最小单位）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                public int? RefundAmount { get; set; }

                /// <summary>
                /// 获取或设置活动 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_id")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                public string? ActivityId { get; set; }

                /// <summary>
                /// 获取或设置微信出资（单位：指定货币的最小单位）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wechatpay_contribute_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("wechatpay_contribute_amount")]
                public int? WechatpayContribute { get; set; }

                /// <summary>
                /// 获取或设置商户出资（单位：指定货币的最小单位）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_contribute_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_contribute_amount")]
                public int? MerchantContribute { get; set; }

                /// <summary>
                /// 获取或设置其他出资（单位：指定货币的最小单位）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("other_contribute_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("other_contribute_amount")]
                public int? OtherContribute { get; set; }

                /// <summary>
                /// 获取或设置优惠币种。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string? Currency { get; set; }

                /// <summary>
                /// 获取或设置单品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_detail")]
                public Types.GoodsDetail[]? GoodsList { get; set; }
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
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置交易类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_type")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_type")]
        public string TradeType { get; set; } = default!;

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
        /// 获取或设置付款银行类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_type")]
        public string? BankType { get; set; }

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置支付完成时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("success_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? SuccessTime { get; set; }

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public Types.Payer? Payer { get; set; }

        /// <summary>
        /// 获取或设置金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public Types.Amount Amount { get; set; } = default!;

        /// <summary>
        /// 获取或设置优惠信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_detail")]
        public Types.Promotion[]? PromotionList { get; set; }
    }
}
