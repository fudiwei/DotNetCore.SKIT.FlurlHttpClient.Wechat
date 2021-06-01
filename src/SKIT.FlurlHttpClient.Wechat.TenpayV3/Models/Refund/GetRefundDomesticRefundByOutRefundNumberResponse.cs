using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /refund/domestic/refunds/{out_refund_no} 接口的响应。</para>
    /// </summary>
    public class GetRefundDomesticRefundByOutRefundNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Amount
            {
                public static class Types
                {
                    public class From
                    {
                        /// <summary>
                        /// 获取或设置出资金额	（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int Amount { get; set; }

                        /// <summary>
                        /// 获取或设置出资账户。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account")]
                        [System.Text.Json.Serialization.JsonPropertyName("account")]
                        public string Account { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置原订单金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int Total { get; set; }

                /// <summary>
                /// 获取或设置退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund")]
                [System.Text.Json.Serialization.JsonPropertyName("refund")]
                public int Refund { get; set; }

                /// <summary>
                /// 获取或设置退款币种。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string Currency { get; set; } = "CNY";

                /// <summary>
                /// 获取或设置用户支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_total")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_total")]
                public int PayerTotal { get; set; }

                /// <summary>
                /// 获取或设置用户退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_refund")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_refund")]
                public int PayerRefund { get; set; }

                /// <summary>
                /// 获取或设置应结订单金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settlement_total")]
                [System.Text.Json.Serialization.JsonPropertyName("settlement_total")]
                public int SettlementTotal { get; set; }

                /// <summary>
                /// 获取或设置应结退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settlement_refund")]
                [System.Text.Json.Serialization.JsonPropertyName("settlement_refund")]
                public int SettlementRefund { get; set; }

                /// <summary>
                /// 获取或设置优惠退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_refund")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_refund")]
                public int DiscountRefund { get; set; }

                /// <summary>
                /// 获取或设置退款出资账户及金额列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("from")]
                [System.Text.Json.Serialization.JsonPropertyName("from")]
                public Types.From[]? FromList { get; set; }
            }

            public class Promotion
            {
                public static class Types
                {
                    public class GoodsDetail
                    {
                        /// <summary>
                        /// 获取或设置商户侧商品编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_goods_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_goods_id")]
                        public string MerchantGoodsId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置微信侧商品编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wechatpay_goods_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("wechatpay_goods_id")]
                        public string? WechatpayGoodsId { get; set; }

                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
                        public string? GoodsName { get; set; }

                        /// <summary>
                        /// 获取或设置商品单价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unit_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("unit_price")]
                        public int UnitPrice { get; set; }

                        /// <summary>
                        /// 获取或设置商品退款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                        public int RefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置商品退货数量（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_quantity")]
                        public int RefundQuantity { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_id")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_id")]
                public string PromotionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠范围。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scope")]
                [System.Text.Json.Serialization.JsonPropertyName("scope")]
                public string Scope { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠券面额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置优惠退款金额（单位：分）。
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
        /// 获取或设置微信支付退款号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
        public string RefundId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_refund_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_refund_no")]
        public string OutRefundNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款渠道。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel")]
        [System.Text.Json.Serialization.JsonPropertyName("channel")]
        public string Channel { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款入账账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_received_account")]
        [System.Text.Json.Serialization.JsonPropertyName("user_received_account")]
        public string UserReceivedAccount { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款成功时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("success_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? SuccessTime { get; set; }

        /// <summary>
        /// 获取或设置退款创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置退款状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款资金来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("funds_account")]
        [System.Text.Json.Serialization.JsonPropertyName("funds_account")]
        public string FundsAccount { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public Types.Amount Amount { get; set; } = default!;

        /// <summary>
        /// 获取或设置优惠退款信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_detail")]
        public Types.Promotion[]? PromotionList { get; set; }
    }
}
