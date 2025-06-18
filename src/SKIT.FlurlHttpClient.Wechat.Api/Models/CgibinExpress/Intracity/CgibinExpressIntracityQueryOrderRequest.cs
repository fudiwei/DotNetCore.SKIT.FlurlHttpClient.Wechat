namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/queryorder 接口的请求。</para>
    /// </summary>
    public class CgibinExpressIntracityQueryOrderRequest : WechatApiRequest, IInferable<CgibinExpressIntracityQueryOrderRequest, CgibinExpressIntracityQueryOrderResponse>
    {
        /// <summary>
        /// 获取或设置微信门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_store_id")]
        public string? StoreId { get; set; }

        /// <summary>
        /// 获取或设置门店订单编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("store_order_id")]
        public string? StoreOrderId { get; set; }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_order_id")]
        public string? OrderId { get; set; }
    }
}
