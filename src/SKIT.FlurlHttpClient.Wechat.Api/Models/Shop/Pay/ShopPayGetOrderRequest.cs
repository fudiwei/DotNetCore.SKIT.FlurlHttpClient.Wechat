namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/pay/getorder 接口的请求。</para>
    /// </summary>
    public class ShopPayGetOrderRequest : WechatApiRequest, IInferable<ShopPayGetOrderRequest, ShopPayGetOrderResponse>
    {
        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_no")]
        public string OutTradeNumber { get; set; } = string.Empty;
    }
}
