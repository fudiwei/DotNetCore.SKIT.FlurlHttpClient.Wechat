namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.trade_manage_order_settlement" 回调通知事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/order-shipping/order-shipping.html </para>
    /// </summary>
    public class TradeManageOrderSettlementEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
        [System.Xml.Serialization.XmlElement("merchant_id")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_merchant_id")]
        [System.Xml.Serialization.XmlElement("sub_merchant_id", IsNullable = true)]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_trade_no")]
        [System.Xml.Serialization.XmlElement("merchant_trade_no")]
        public string? MerchantTradeNo { get; set; }

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        [System.Xml.Serialization.XmlElement("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置支付成功时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_time")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
        [System.Xml.Serialization.XmlElement("pay_time")]
        public long PayTimestamp { get; set; }

        /// <summary>
        /// 获取或设置发货时间时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipped_time")]
        [System.Text.Json.Serialization.JsonPropertyName("shipped_time")]
        [System.Xml.Serialization.XmlElement("shipped_time")]
        public long ShippedTimestamp { get; set; }

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
    }
}
