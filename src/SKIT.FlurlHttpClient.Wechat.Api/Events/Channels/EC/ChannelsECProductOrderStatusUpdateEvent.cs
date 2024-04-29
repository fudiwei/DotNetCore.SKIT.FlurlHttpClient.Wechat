namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.product_order_status_update 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/order/callback/product_order_status_update.html </para>
    /// </summary>
    public class ChannelsECProductOrderStatusUpdateEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Order
            {
                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("order_id")]
                public long OrderId { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ProductOrderStatusUpdate")]
        [System.Text.Json.Serialization.JsonPropertyName("ProductOrderStatusUpdate")]
        [System.Xml.Serialization.XmlElement("ProductOrderStatusUpdate")]
        public Types.Order Order { get; set; } = default!;
    }
}
