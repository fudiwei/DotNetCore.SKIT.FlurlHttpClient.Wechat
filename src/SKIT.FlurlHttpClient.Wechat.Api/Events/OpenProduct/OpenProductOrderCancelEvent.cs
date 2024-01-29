namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.open_product_order_cancel 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent2/callback/order_cancel.html </para>
    /// </summary>
    public class OpenProductOrderCancelEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Order
            {
                /// <summary>
                /// 获取或设置商家自定义订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_order_id")]
                [System.Xml.Serialization.XmlElement("out_order_id")]
                public string OutOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Xml.Serialization.XmlElement("order_id")]
                public long OrderId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
        [System.Xml.Serialization.XmlElement("order_info")]
        public Types.Order Order { get; set; } = default!;
    }
}
