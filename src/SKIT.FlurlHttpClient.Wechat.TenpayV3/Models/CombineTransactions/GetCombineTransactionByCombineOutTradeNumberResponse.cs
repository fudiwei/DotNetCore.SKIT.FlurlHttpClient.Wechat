using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /combine-transactions/out-trade-no/{combine_out_trade_no} 接口的响应。</para>
    /// </summary>
    public class GetCombineTransactionByCombineOutTradeNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class SubOrder
            {
                public static class Types
                {
                    public class Amount
                    {
                        /// <summary>
                        /// 获取或设置标价金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                        public int Total { get; set; }

                        /// <summary>
                        /// 获取或设置标价币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                        public string Currency { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户支付金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payer_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("payer_amount")]
                        public int PayerAmount { get; set; }

                        /// <summary>
                        /// 获取或设置用户支付币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payer_currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("payer_currency")]
                        public string PayerCurrency { get; set; } = default!;
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
                /// 获取或设置子单子商户 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
                public string? SubAppId { get; set; }

                /// <summary>
                /// 获取或设置用户在子商户下的唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
                public string? SubOpenId { get; set; }

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
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("success_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                public DateTimeOffset? SuccessTime { get; set; }

                /// <summary>
                /// 获取或设置金额信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public Types.Amount Amount { get; set; } = default!;
            }

            public class Payer
            {
                /// <summary>
                /// 获取或设置用户唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string? OpenId { get; set; }
            }

            public class Scene
            {
                /// <summary>
                /// 获取或设置商户端设备号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_id")]
                [System.Text.Json.Serialization.JsonPropertyName("device_id")]
                public string? DeviceId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置合单发起方的微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_appid")]
        public string CombineAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置合单发起方的微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_mchid")]
        public string CombineMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置合单商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_out_trade_no")]
        public string CombineOutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置子单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_orders")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_orders")]
        public Types.SubOrder[]? SubOrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_payer_info")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_payer_info")]
        public Types.Payer? CombinePayer { get; set; }

        /// <summary>
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        public Types.Scene? Scene { get; set; }
    }
}
