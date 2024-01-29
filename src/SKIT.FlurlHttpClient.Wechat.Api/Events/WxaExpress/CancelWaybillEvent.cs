namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.cancel_waybill 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/express/express-by-provider/onCancelOrder.html </para>
    /// </summary>
    public class CancelWaybillEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置快递公司客户编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("BizID")]
        [System.Text.Json.Serialization.JsonPropertyName("BizID")]
        [System.Xml.Serialization.XmlElement("BizID")]
        public string BusinessId { get; set; } = default!;

        /// <summary>
        /// 获取或设置快递公司客户密码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("BizPwd")]
        [System.Text.Json.Serialization.JsonPropertyName("BizPwd")]
        [System.Xml.Serialization.XmlElement("BizPwd", IsNullable = true)]
        public string? BusinessPassword { get; set; }

        /// <summary>
        /// 获取或设置商户的小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ShopAppID")]
        [System.Text.Json.Serialization.JsonPropertyName("ShopAppID")]
        [System.Xml.Serialization.XmlElement("ShopAppID", IsNullable = true)]
        public string? ShopAppId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OrderID")]
        [System.Text.Json.Serialization.JsonPropertyName("OrderID")]
        [System.Xml.Serialization.XmlElement("OrderID")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WayBillID")]
        [System.Text.Json.Serialization.JsonPropertyName("WayBillID")]
        [System.Xml.Serialization.XmlElement("WayBillID")]
        public string WaybillId { get; set; } = default!;
    }
}
