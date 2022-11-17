namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/pay/getorder 接口的响应。</para>
    /// </summary>
    public class ShopPayGetOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order
            {
                public static class Types
                {
                    public class Refund
                    {
                        /// <summary>
                        /// 获取或设置商户退款单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_no")]
                        public string OutRefundNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置微信支付退款单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
                        public string? RefundId { get; set; }

                        /// <summary>
                        /// 获取或设置退款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int Amount { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置完成时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("finish_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("finish_time")]
                        public long? FinishTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置退款状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("result")]
                        [System.Text.Json.Serialization.JsonPropertyName("result")]
                        public string Status { get; set; } = default!;
                    }

                    public class ProfitSharing
                    {
                        /// <summary>
                        /// 获取或设置微信商户号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mchid")]
                        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                        public string MerchantId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商户分账单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("profit_sharing_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("profit_sharing_no")]
                        public string OutProfitSharingNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置微信分账单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("profit_sharing_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("profit_sharing_id")]
                        public string ProfitSharingId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分账金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int Amount { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置完成时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("finish_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("finish_time")]
                        public long? FinishTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置分账状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("result")]
                        [System.Text.Json.Serialization.JsonPropertyName("result")]
                        public string Status { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置微信商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                public string MerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_no")]
                public string OutTradeNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置合单商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("combine_trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("combine_trade_no")]
                public string CombineOutTradeNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信支付交易单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_id")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                public string? TransactionId { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置支付时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                public long? PayTimestamp { get; set; }

                /// <summary>
                /// 获取或设置过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public long? ExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置订单金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置订单描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_list")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_list")]
                public Types.Refund[]? RefundList { get; set; }

                /// <summary>
                /// 获取或设置分账列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("profit_sharing_list")]
                [System.Text.Json.Serialization.JsonPropertyName("profit_sharing_list")]
                public Types.ProfitSharing[]? ProfitSharingList { get; set; }

                /// <summary>
                /// 获取或设置账期（单位：天）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("profit_sharing_delay")]
                [System.Text.Json.Serialization.JsonPropertyName("profit_sharing_delay")]
                public int? ProfitSharingDelay { get; set; }

                /// <summary>
                /// 获取或设置是否被冻结分账。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("profit_sharing_frozen")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("profit_sharing_frozen")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsProfitSharingFrozen { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public Types.Order Order { get; set; } = default!;
    }
}
