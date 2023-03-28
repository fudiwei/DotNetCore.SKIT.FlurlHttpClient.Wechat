namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.waybill_evaluate_agent 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/delivery/single-delivery.html </para>
    /// </summary>
    public class WaybillEvaluateAgentEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
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
        /// 获取或设置小哥类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CourierType")]
        [System.Text.Json.Serialization.JsonPropertyName("CourierType")]
        [System.Xml.Serialization.XmlElement("CourierType")]
        public int CourierType { get; set; }

        /// <summary>
        /// 获取或设置评分。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Score")]
        [System.Text.Json.Serialization.JsonPropertyName("Score")]
        [System.Xml.Serialization.XmlElement("Score")]
        public int Score { get; set; }
    }
}
