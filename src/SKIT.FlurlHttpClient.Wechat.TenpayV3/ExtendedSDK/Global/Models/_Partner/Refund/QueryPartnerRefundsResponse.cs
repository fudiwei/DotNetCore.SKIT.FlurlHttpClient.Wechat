namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [GET] /refunds 接口的响应。</para>
    /// </summary>
    public class QueryPartnerRefundsResponse : WechatTenpayGlobalResponse
    {
        public static class Types
        {
            public class Amount : QueryRefundsResponse.Types.Amount
            {
            }

            public abstract class __zz__Refund : QueryRefundsResponse.Types.__zz__Refund
            {
            }

            public class Refund : __zz__Refund
            {
                public static class Types
                {
                    public abstract class __zz__Amount : QueryRefundsResponse.Types.Refund.Types.__zz__Amount
                    {
                    }

                    public class Amount : __zz__Amount
                    {
                        public static class Types
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
                        public Types.ExchangeRate? ExchangeRate { get; set; }

                        /// <summary>
                        /// 获取或设置退款出资账户及金额列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("from")]
                        [System.Text.Json.Serialization.JsonPropertyName("from")]
                        public List<Types.From>? FromList { get; set; }
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
                public Types.Amount? Amount { get; set; }

                /// <summary>
                /// 获取或设置优惠退款信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_detail")]
                public Types.Promotion? Promotion { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public Types.Amount? Amount { get; set; }

        /// <summary>
        /// 获取或设置退款单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public List<Types.Refund>? RefundList { get; set; }

        /// <summary>
        /// 获取或设置订单总退款次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalRefundCount { get; set; }

        /// <summary>
        /// 获取或设置本次返回退款单数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("current_total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("current_total_num")]
        public int CurrentRefundCount { get; set; }
    }
}
