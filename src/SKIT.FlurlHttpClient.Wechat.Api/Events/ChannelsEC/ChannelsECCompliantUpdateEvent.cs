namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.channels_ec_complaint_update 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/complaint/callback/channels_ec_complaint_update.html </para>
    /// </summary>
    public class ChannelsECCompliantUpdateEvent : WechatApiEvent
    {
        public static class Types
        {
            public class CompliantOrder
            {
                /// <summary>
                /// 获取或设置纠纷单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complaint_id")]
                [System.Text.Json.Serialization.JsonPropertyName("complaint_id")]
                [System.Xml.Serialization.XmlElement("complaint_id")]
                public string CompliantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置售后单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("after_sale_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("after_sale_order_id")]
                public long AftersaleOrderId { get; set; }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("order_id")]
                public long OrderId { get; set; }

                /// <summary>
                /// 获取或设置纠纷单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complaint_status")]
                [System.Text.Json.Serialization.JsonPropertyName("complaint_status")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("complaint_status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置纠纷单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_shop_complaint")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_shop_complaint")]
        [System.Xml.Serialization.XmlElement("finder_shop_complaint")]
        public Types.CompliantOrder CompliantOrder { get; set; } = default!;
    }
}
