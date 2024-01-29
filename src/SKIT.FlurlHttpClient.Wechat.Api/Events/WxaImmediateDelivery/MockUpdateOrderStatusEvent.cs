namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.mock_update_order_status 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-provider/immediateDelivery.onMockUpdateOrder.html </para>
    /// </summary>
    public class MockUpdateOrderStatusEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shopid")]
        [System.Text.Json.Serialization.JsonPropertyName("shopid")]
        [System.Xml.Serialization.XmlElement("shopid")]
        public string ShopId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_order_id")]
        [System.Xml.Serialization.XmlElement("shop_order_id")]
        public string ShopOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商家门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_no")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_no")]
        [System.Xml.Serialization.XmlElement("shop_no")]
        public string ShopNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置配送单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        [System.Xml.Serialization.XmlElement("waybill_id")]
        public string WaybillId { get; set; } = default!;

        /// <summary>
        /// 获取或设置校验串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_sign")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_sign")]
        [System.Xml.Serialization.XmlElement("delivery_sign")]
        public string DeliverySignature { get; set; } = default!;

        /// <summary>
        /// 获取或设置配送状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
        [System.Xml.Serialization.XmlElement("order_status")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// 获取或设置状态变更时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_time")]
        [System.Text.Json.Serialization.JsonPropertyName("action_time")]
        [System.Xml.Serialization.XmlElement("action_time")]
        public long ActionTimestamp { get; set; }

        /// <summary>
        /// 获取或设置附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("action_msg")]
        [System.Xml.Serialization.XmlElement("action_msg")]
        public string? ActionMessage { get; set; }
    }
}
