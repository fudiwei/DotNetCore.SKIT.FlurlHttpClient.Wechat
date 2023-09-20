namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/cancelorder 接口的响应。</para>
    /// </summary>
    public class CgibinExpressIntracityCancelOrderResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置微信门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_store_id")]
        public string StoreId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店订单编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("store_order_id")]
        public string StoreOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// 获取或设置违约金（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deductfee")]
        [System.Text.Json.Serialization.JsonPropertyName("deductfee")]
        public int? DeductFee { get; set; }
    }
}
