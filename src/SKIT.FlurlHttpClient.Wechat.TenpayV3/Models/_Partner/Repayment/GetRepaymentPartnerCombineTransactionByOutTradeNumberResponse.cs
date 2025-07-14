using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /repayment/combine-transactions/partner/out-trade-no/{combine_out_trade_no} 接口的响应。</para>
    /// </summary>
    public class GetRepaymentPartnerCombineTransactionByOutTradeNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class SubOrder
            {
                public static class Types
                {
                    public class Amount : GetCombineTransactionByCombineOutTradeNumberResponse.Types.SubOrder.Types.Amount
                    {
                    }
                }

                /// <summary>
                /// 获取或设置子单微信商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                public string MerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置子单子商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
                public string? SubMerchantId { get; set; }

                /// <summary>
                /// 获取或设置子单商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
                public string OutTradeNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置子单微信订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_id")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                public string TransactionId { get; set; } = default!;

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
                public string Attachment { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付完成时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("success_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset? SuccessTime { get; set; }

                /// <summary>
                /// 获取或设置金额信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public Types.Amount Amount { get; set; } = default!;
            }

            public class Payer : GetCombineTransactionByCombineOutTradeNumberResponse.Types.Payer
            {
            }
        }

        /// <summary>
        /// 获取或设置还款单发起方的微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_mchid")]
        public string CombineMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置还款服务商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_appid")]
        public string CombineAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置还款商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_out_trade_no")]
        public string CombineOutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_transaction_id")]
        public string CombineTransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_orders")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_orders")]
        public Types.SubOrder[]? SubOrderList { get; set; }

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_payer_info")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_payer_info")]
        public Types.Payer? CombinePayer { get; set; }
    }
}
