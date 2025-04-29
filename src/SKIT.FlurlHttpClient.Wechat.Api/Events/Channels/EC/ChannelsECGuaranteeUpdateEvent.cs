namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.channels_ec_guarantee_update 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/aftersale/ec_callback/channels_ec_guarantee_update.html ]]>
    /// </para>
    /// </summary>
    public class ChannelsECGuaranteeUpdateEvent : WechatApiEvent
    {
        public static class Types
        {
            public class GuaranteeOrder
            {
                /// <summary>
                /// 获取或设置保障单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("guarantee_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("guarantee_order_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("guarantee_order_id")]
                public long GuaranteeOrderId { get; set; }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("order_id")]
                public long OrderId { get; set; }

                /// <summary>
                /// 获取或设置售后单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Xml.Serialization.XmlElement("status")]
                public string Status { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置售后单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("finder_shop_guarantee_status_update")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_shop_guarantee_status_update")]
        [System.Xml.Serialization.XmlElement("finder_shop_guarantee_status_update")]
        public Types.GuaranteeOrder GuaranteeOrder { get; set; } = default!;
    }
}
