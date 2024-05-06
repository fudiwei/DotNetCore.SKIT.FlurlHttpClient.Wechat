using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [GET] /refunds/out-refund-no/{out_refund_no} 接口的响应。</para>
    /// </summary>
    public class GetRefundByOutRefundNumberResponse : WechatTenpayGlobalResponse
    {
        public static class Types
        {
            public class Amount
            {
                public static class Types
                {
                    public class ExchangeRate : GetTransactionByOutTradeNumberResponse.Types.Amount.Types.ExchangeRate
                    {
                    }
                }

                /// <summary>
                /// 获取或设置原订单金额（单位：指定货币的最小单位）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int? Total { get; set; }

                /// <summary>
                /// 获取或设置退款金额（单位：指定货币的最小单位）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund")]
                [System.Text.Json.Serialization.JsonPropertyName("refund")]
                public int Refund { get; set; }

                /// <summary>
                /// 获取或设置退款币种。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string? Currency { get; set; }

                /// <summary>
                /// 获取或设置用户支付金额（单位：指定货币的最小单位）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_total")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_total")]
                public int PayerTotal { get; set; }

                /// <summary>
                /// 获取或设置用户退款金额（单位：指定货币的最小单位）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_refund")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_refund")]
                public int PayerRefund { get; set; }

                /// <summary>
                /// 获取或设置用户支付币种。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_currency")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_currency")]
                public string PayerCurrency { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇率信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exchange_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("exchange_rate")]
                public Types.ExchangeRate? ExchangeRate { get; set; }
            }

            public class Promotion
            {
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
                /// 获取或设置优惠币种。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string? Currency { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信支付退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
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
        /// 获取或设置退款资金来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fund_source")]
        [System.Text.Json.Serialization.JsonPropertyName("fund_source")]
        public string FundSource { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款入账账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recv_account")]
        [System.Text.Json.Serialization.JsonPropertyName("recv_account")]
        public string ReceiveAccount { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款成功时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("success_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? SuccessTime { get; set; }

        /// <summary>
        /// 获取或设置退款创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

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
