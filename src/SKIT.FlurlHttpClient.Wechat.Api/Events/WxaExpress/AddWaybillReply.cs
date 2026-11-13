namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.add_waybill" 回调通知应答的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/event_push/express/provider/Request_an_order_event.html ]]>
    /// </para>
    /// </summary>
    public class AddWaybillReply : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置微信订单 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Token")]
        [System.Text.Json.Serialization.JsonPropertyName("Token")]
        [System.Xml.Serialization.XmlElement("Token")]
        public string? Token { get; set; }

        /// <summary>
        /// 获取或设置快递公司客户编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("BizID")]
        [System.Text.Json.Serialization.JsonPropertyName("BizID")]
        [System.Xml.Serialization.XmlElement("BizID")]
        public string? BusinessId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OrderID")]
        [System.Text.Json.Serialization.JsonPropertyName("OrderID")]
        [System.Xml.Serialization.XmlElement("OrderID")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WayBillID")]
        [System.Text.Json.Serialization.JsonPropertyName("WayBillID")]
        [System.Xml.Serialization.XmlElement("WayBillID")]
        public string? WaybillId { get; set; }

        /// <summary>
        /// 获取或设置运单面单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WaybillData")]
        [System.Text.Json.Serialization.JsonPropertyName("WaybillData")]
        [System.Xml.Serialization.XmlElement("WaybillData")]
        public string? WaybillData { get; set; }

        /// <summary>
        /// 获取或设置处理结果错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ResultCode")]
        [System.Text.Json.Serialization.JsonPropertyName("ResultCode")]
        [System.Xml.Serialization.XmlElement("ResultCode")]
        public int ResultCode { get; set; }

        /// <summary>
        /// 获取或设置处理结果错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ResultMsg")]
        [System.Text.Json.Serialization.JsonPropertyName("ResultMsg")]
        [System.Xml.Serialization.XmlElement("ResultMsg", IsNullable = true)]
        public string? ResultMessage { get; set; }

        public AddWaybillReply()
        {
            MessageType = "event";
            Event = "add_waybill";
        }
    }
}
