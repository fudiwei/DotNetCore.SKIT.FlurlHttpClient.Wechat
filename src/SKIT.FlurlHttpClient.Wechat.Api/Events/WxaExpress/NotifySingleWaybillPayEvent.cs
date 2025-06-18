namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.notify_single_waybill_pay 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/delivery/single-delivery.html ]]>
    /// </para>
    /// </summary>
    public class NotifySingleWaybillPayEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置微信订单 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Token")]
        [System.Text.Json.Serialization.JsonPropertyName("Token")]
        [System.Xml.Serialization.XmlElement("Token")]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WXAppId")]
        [System.Text.Json.Serialization.JsonPropertyName("WXAppId")]
        [System.Xml.Serialization.XmlElement("WXAppId")]
        public string MiniProgramAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OrderID")]
        [System.Text.Json.Serialization.JsonPropertyName("OrderID")]
        [System.Xml.Serialization.XmlElement("OrderID", IsNullable = true)]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WayBillID")]
        [System.Text.Json.Serialization.JsonPropertyName("WayBillID")]
        [System.Xml.Serialization.XmlElement("WayBillID", IsNullable = true)]
        public string? WaybillId { get; set; }

        /// <summary>
        /// 获取或设置支付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Fee")]
        [System.Text.Json.Serialization.JsonPropertyName("Fee")]
        [System.Xml.Serialization.XmlElement("Fee")]
        public int Fee { get; set; }

        /// <summary>
        /// 获取或设置原价（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OriginalFee")]
        [System.Text.Json.Serialization.JsonPropertyName("OriginalFee")]
        [System.Xml.Serialization.XmlElement("OriginalFee", IsNullable = true)]
        public int? OriginalFee { get; set; }

        /// <summary>
        /// 获取或设置支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PayOrderId")]
        [System.Text.Json.Serialization.JsonPropertyName("PayOrderId")]
        [System.Xml.Serialization.XmlElement("PayOrderId", IsNullable = true)]
        public string? PayOrderId { get; set; }

        /// <summary>
        /// 获取或设置支付时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PayFinishTime")]
        [System.Text.Json.Serialization.JsonPropertyName("PayFinishTime")]
        [System.Xml.Serialization.XmlElement("PayFinishTime", IsNullable = true)]
        public long? PayTimestamp { get; set; }
    }
}
