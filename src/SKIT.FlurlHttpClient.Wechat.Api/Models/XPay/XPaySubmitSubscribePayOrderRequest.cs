namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/submit_subscribe_pay_order 接口的请求。</para>
    /// </summary>
    public class XPaySubmitSubscribePayOrderRequest : XPayRequestBase, IInferable<XPaySubmitSubscribePayOrderRequest, XPaySubmitSubscribePayOrderResponse>
    {
        /// <summary>
        /// 获取或设置米大师应用 ID。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.MidasOfferIdV2"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offer_id")]
        [System.Text.Json.Serialization.JsonPropertyName("offer_id")]
        public string OfferId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置道具 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public string ProductId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置道具价格（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deduct_price")]
        [System.Text.Json.Serialization.JsonPropertyName("deduct_price")]
        public int DeductPrice { get; set; }

        /// <summary>
        /// 获取或设置购买数量。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buy_quantity")]
        [System.Text.Json.Serialization.JsonPropertyName("buy_quantity")]
        public int BuyQuantity { get; set; } = 1;

        /// <summary>
        /// 获取或设置币种。
        /// <para>默认值："CNY"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currency_type")]
        [System.Text.Json.Serialization.JsonPropertyName("currency_type")]
        public string CurrencyType { get; set; } = "CNY";

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置透传信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string Attachment { get; set; } = string.Empty;

        protected internal override string GetRequestPath()
        {
            return "/xpay/submit_subscribe_pay_order";
        }
    }
}
