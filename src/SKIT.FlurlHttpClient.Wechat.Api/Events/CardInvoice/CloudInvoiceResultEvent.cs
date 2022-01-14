namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.cloud_invoice_invoiceresult_event 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Vendor_API_List.html#19 </para>
    /// </summary>
    public class CloudInvoiceResultEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置开票状态码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        [System.Xml.Serialization.XmlElement("status")]
        public int StatusCode { get; set; }

        /// <summary>
        /// 获取或设置发票请求流水号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fpqqlsh")]
        [System.Text.Json.Serialization.JsonPropertyName("fpqqlsh")]
        [System.Xml.Serialization.XmlElement("fpqqlsh")]
        public string InvoiceSerialNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置纳税人识别码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nsrsbh")]
        [System.Text.Json.Serialization.JsonPropertyName("nsrsbh")]
        [System.Xml.Serialization.XmlElement("nsrsbh")]
        public string SellerTaxNumber { get; set; } = default!;
    }
}
