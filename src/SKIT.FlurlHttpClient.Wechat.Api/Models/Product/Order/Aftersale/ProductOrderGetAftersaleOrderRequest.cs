namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/order/getaftersaleorder 接口的请求。</para>
    /// </summary>
    public class ProductOrderGetAftersaleOrderRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置售后单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_id")]
        public long AftersaleOrderId { get; set; }
    }
}
