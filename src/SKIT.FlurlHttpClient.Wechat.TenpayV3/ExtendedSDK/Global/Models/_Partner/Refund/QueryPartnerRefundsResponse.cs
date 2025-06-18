namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [GET] /refunds 接口的响应。</para>
    /// </summary>
    public class QueryPartnerRefundsResponse : QueryRefundsResponse
    {
        public static new class Types
        {
            public class Amount : QueryRefundsResponse.Types.Amount
            {
            }

            public class Refund : QueryRefundsResponse.Types.Refund
            {
                public static new class Types
                {
                    public class Amount : QueryRefundsResponse.Types.Refund.Types.Amount
                    {
                        public static new class Types
                        {
                            public class ExchangeRate : QueryRefundsResponse.Types.Refund.Types.Amount.Types.ExchangeRate
                            {
                            }

                            public class From : QueryRefundsResponse.Types.Refund.Types.Amount.Types.From
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置汇率信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exchange_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("exchange_rate")]
                        public new Types.ExchangeRate? ExchangeRate { get; set; }

                        /// <summary>
                        /// 获取或设置退款出资账户及金额列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("from")]
                        [System.Text.Json.Serialization.JsonPropertyName("from")]
                        public new Types.From[]? FromList { get; set; }
                    }

                    public class Promotion : QueryRefundsResponse.Types.Refund.Types.Promotion
                    {
                    }
                }

                /// <summary>
                /// 获取或设置退款金额信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public new Types.Amount Amount { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠退款信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_detail")]
                public new Types.Promotion Promotion { get; set; } = default!;
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public override string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public new Types.Amount Amount { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public new Types.Refund[] RefundList { get; set; } = default!;
    }
}
