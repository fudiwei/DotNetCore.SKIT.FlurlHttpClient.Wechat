namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/pay/profitsharingorder 接口的请求。</para>
    /// </summary>
    public class ShopPayProfitSharingOrderRequest : WechatApiRequest, IInferable<ShopPayProfitSharingOrderRequest, ShopPayProfitSharingOrderResponse>
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_no")]
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置微信支付交易单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置商户分账单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profit_sharing_no")]
        [System.Text.Json.Serialization.JsonPropertyName("profit_sharing_no")]
        public string OutProfitSharingNumber { get; set; } = string.Empty;
    }
}
