namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.open_product_order_settle 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent2/callback/order_settle.html ]]>
    /// </para>
    /// </summary>
    public class OpenProductOrderSettleEvent : WechatApiEvent
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

                /// <summary>
                /// 获取或设置结算单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_no")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_no")]
                [System.Xml.Serialization.XmlElement("settle_no")]
                public string SettleNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置结算金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                [System.Xml.Serialization.XmlElement("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置结算时间字符串（格式：yyyy-MM-dd HH:mm:ss）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_time")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_time")]
                [System.Xml.Serialization.XmlElement("settle_time")]
                public string SettleTimeString { get; set; } = default!;
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
