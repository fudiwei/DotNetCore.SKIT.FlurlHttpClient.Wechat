namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.cancel_single_waybill 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/delivery/single-delivery.html </para>
    /// </summary>
    public class CancelSingleWaybillEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
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
        /// 获取或设置取消原因 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CancelID")]
        [System.Text.Json.Serialization.JsonPropertyName("CancelID")]
        [System.Xml.Serialization.XmlElement("CancelID")]
        public string CancelReasonId { get; set; } = default!;

        /// <summary>
        /// 获取或设置取消原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CancelReason")]
        [System.Text.Json.Serialization.JsonPropertyName("CancelReason")]
        [System.Xml.Serialization.XmlElement("CancelReason", IsNullable = true)]
        public string? CancelReason { get; set; }
    }
}
