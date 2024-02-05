namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.channels_ec_aftersale_update 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/aftersale/ec_callback/channels_ec_aftersale_update.html ]]>
    /// </para>
    /// </summary>
    public class ChannelsECAftersaleUpdateEvent : WechatApiEvent
    {
        public static class Types
        {
            public class AftersaleOrder
            {
                /// <summary>
                /// 获取或设置售后单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("after_sale_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("after_sale_order_id")]
                public long AftersaleOrderId { get; set; }

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
        [Newtonsoft.Json.JsonProperty("finder_shop_aftersale_status_update")]
        [System.Text.Json.Serialization.JsonPropertyName("finder_shop_aftersale_status_update")]
        [System.Xml.Serialization.XmlElement("finder_shop_aftersale_status_update")]
        public Types.AftersaleOrder AftersaleOrder { get; set; } = default!;
    }
}
