namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/cancelorder 接口的请求。</para>
    /// </summary>
    public class CgibinExpressIntracityCancelOrderRequest : WechatApiRequest, IInferable<CgibinExpressIntracityCancelOrderRequest, CgibinExpressIntracityCancelOrderResponse>
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

        /// <summary>
        /// 获取或设置取消原因	 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_reason_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_reason_id")]
        public int CancelReasonId { get; set; }

        /// <summary>
        /// 获取或设置取消原因描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_reason")]
        public string? CancelReason { get; set; }
    }
}
