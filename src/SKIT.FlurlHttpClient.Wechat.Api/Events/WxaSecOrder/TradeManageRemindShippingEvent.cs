namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.trade_manage_remind_shipping 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/order-shipping/order-shipping.html#%E4%B9%9D%E3%80%81%E7%9B%B8%E5%85%B3%E6%B6%88%E6%81%AF%E6%8E%A8%E9%80%81 </para>
    /// </summary>
    public class TradeManageRemindShippingEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
        [System.Xml.Serialization.XmlElement("merchant_id")]
        public string MerchantId { get; set; } = default!;

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
        public string MerchantTradeNo { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        [System.Xml.Serialization.XmlElement("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置支付成功时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_time")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
        [System.Xml.Serialization.XmlElement("pay_time")]
        public long PayTimestamp { get; set; }

        /// <summary>
        /// 获取或设置消息文本内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        [System.Xml.Serialization.XmlElement("msg", IsNullable = true)]
        public string? Message { get; set; }
    }
}
