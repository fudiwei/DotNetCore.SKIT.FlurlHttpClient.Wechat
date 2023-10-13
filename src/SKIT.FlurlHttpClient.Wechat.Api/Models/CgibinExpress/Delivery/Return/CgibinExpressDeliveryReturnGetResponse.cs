namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/return/get 接口的响应。</para>
    /// </summary>
    public class CgibinExpressDeliveryReturnGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置退货状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = default!;

        /// <summary>
        /// 获取或设置运单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string DeliveryId { get; set; } = default!;

        /// <summary>
        /// 获取或设置快递公司名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_name")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_name")]
        public string DeliveryName { get; set; } = default!;
    }
}
