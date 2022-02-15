namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/business/test_update_order 接口的请求。</para>
    /// </summary>
    public class CgibinExpressBusinessTestUpdateOrderRequest : WechatApiRequest, IMapResponse<CgibinExpressBusinessTestUpdateOrderRequest, CgibinExpressBusinessTestUpdateOrderResponse>
    {
        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string DeliveryId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递公司客户编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_id")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_id")]
        public string BusinessId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置轨迹节点时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_time")]
        [System.Text.Json.Serialization.JsonPropertyName("action_time")]
        public long ActionTimestamp { get; set; }

        /// <summary>
        /// 获取或设置轨迹节点类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_type")]
        [System.Text.Json.Serialization.JsonPropertyName("action_type")]
        public int ActionType { get; set; }

        /// <summary>
        /// 获取或设置轨迹节点详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("action_msg")]
        public string ActionMessage { get; set; } = string.Empty;
    }
}
