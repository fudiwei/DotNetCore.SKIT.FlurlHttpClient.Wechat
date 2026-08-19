namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/deliverynegotiation/submit 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderDeliveryNegotiationSubmitRequest : WechatApiRequest, IInferable<ChannelsECOrderDeliveryNegotiationSubmitRequest, ChannelsECOrderDeliveryNegotiationSubmitResponse>
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置预计发货时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("predict_delivery_time")]
        [System.Text.Json.Serialization.JsonPropertyName("predict_delivery_time")]
        public long PredictDeliveryTimestamp { get; set; }

        /// <summary>
        /// 获取或设置协商原因类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public int ReasonType { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }
    }
}
