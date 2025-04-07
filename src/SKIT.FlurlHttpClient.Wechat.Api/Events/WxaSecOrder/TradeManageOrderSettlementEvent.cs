namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.trade_manage_order_settlement 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/order-shipping/order-shipping.html#%E4%B9%9D%E3%80%81%E7%9B%B8%E5%85%B3%E6%B6%88%E6%81%AF%E6%8E%A8%E9%80%81 </para>
    /// </summary>
    public class TradeManageOrderSettlementEvent : TradeManageRemindShippingEvent
    {
        /// <summary>
        /// 获取或设置发货时间时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipped_time")]
        [System.Text.Json.Serialization.JsonPropertyName("shipped_time")]
        [System.Xml.Serialization.XmlElement("shipped_time")]
        public long ShippedTimestamp { get; set; } = default!;

        /// <summary>
        /// 获取或设置预计结算时时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("estimated_settlement_time")]
        [System.Text.Json.Serialization.JsonPropertyName("estimated_settlement_time")]
        [System.Xml.Serialization.XmlElement("estimated_settlement_time", IsNullable = true)]
        public long? EstimatedSettlementTimestamp { get; set; }

        /// <summary>
        /// 获取或设置确认收货方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confirm_receive_method")]
        [System.Text.Json.Serialization.JsonPropertyName("confirm_receive_method")]
        [System.Xml.Serialization.XmlElement("confirm_receive_method", IsNullable = true)]
        public int? ConfirmReceiveMethod { get; set; }

        /// <summary>
        /// 获取或设置确认收货时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confirm_receive_time")]
        [System.Text.Json.Serialization.JsonPropertyName("confirm_receive_time")]
        [System.Xml.Serialization.XmlElement("confirm_receive_time", IsNullable = true)]
        public long? ConfirmReceiveTimestamp { get; set; }

        /// <summary>
        /// 获取或设置订单结算时间时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_time")]
        [System.Text.Json.Serialization.JsonPropertyName("settlement_time")]
        [System.Xml.Serialization.XmlElement("settlement_time", IsNullable = true)]
        public long? SettlementTimestamp { get; set; }

        /// <summary>
        /// 获取或设置消息文本内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        [System.Xml.Serialization.XmlElement("msg", IsNullable = true)]
        public string? Message { get; set; }
    }
}
