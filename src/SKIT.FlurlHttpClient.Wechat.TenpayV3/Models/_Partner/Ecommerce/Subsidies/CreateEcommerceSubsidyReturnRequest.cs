namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/subsidies/return 接口的请求。</para>
    /// </summary>
    public class CreateEcommerceSubsidyReturnRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class From : CreateRefundDomesticRefundRequest.Types.Amount.Types.From
            {
            }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置微信支付退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
        public string? RefundId { get; set; }

        /// <summary>
        /// 获取或设置商户补差回退单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string? OutReturnNumber { get; set; }

        /// <summary>
        /// 获取或设置补差回退描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置补差回退金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置微信补差单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subsidy_id")]
        [System.Text.Json.Serialization.JsonPropertyName("subsidy_id")]
        public string? SubsidyId { get; set; }

        /// <summary>
        /// 获取或设置退款出资账户及金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("from")]
        [System.Text.Json.Serialization.JsonPropertyName("from")]
        public List<Types.From>? From { get; set; }
    }
}
