namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.open_product_order_pay 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent2/callback/order_success.html </para>
    /// </summary>
    public class OpenProductOrderPayEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class EventData
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

                /// <summary>
                /// 获取或设置微信支付交易单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_id")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                [System.Xml.Serialization.XmlElement("transaction_id")]
                public string TransactionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付时间字符串（格式：yyyy-MM-dd HH:mm:ss）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                [System.Xml.Serialization.XmlElement("pay_time")]
                public string PayTimeString { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
        [System.Xml.Serialization.XmlElement("order_info")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
