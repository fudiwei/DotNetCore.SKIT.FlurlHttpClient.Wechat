using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /refund/domestic/refunds 接口的请求。</para>
    /// </summary>
    public class CreateRefundDomesticRefundRequest : WechatTenpayRequest
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
                        public string Account { get; set; } = string.Empty;
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
                /// <para>默认值：CNY</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string Currency { get; set; } = "CNY";

                /// <summary>
                /// 获取或设置退款出资账户及金额列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("from")]
                [System.Text.Json.Serialization.JsonPropertyName("from")]
                public IList<Types.From>? FromList { get; set; }
            }

            public class GoodsDetail
            {
                /// <summary>
                /// 获取或设置商户侧商品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_goods_id")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_goods_id")]
                public string MerchantGoodsId { get; set; } = string.Empty;

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
        /// 获取或设置子单子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。与字段 <see cref="OutTradeNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。与字段 <see cref="TransactionId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置商户退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_refund_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_refund_no")]
        public string OutRefundNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置退款原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置退款资金来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("funds_account")]
        [System.Text.Json.Serialization.JsonPropertyName("funds_account")]
        public string? FundsAccount { get; set; }

        /// <summary>
        /// 获取或设置退款金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public Types.Amount Amount { get; set; } = new Types.Amount();

        /// <summary>
        /// 获取或设置退款商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_detail")]
        public List<Types.GoodsDetail>? GoodsList { get; set; }
    }
}
