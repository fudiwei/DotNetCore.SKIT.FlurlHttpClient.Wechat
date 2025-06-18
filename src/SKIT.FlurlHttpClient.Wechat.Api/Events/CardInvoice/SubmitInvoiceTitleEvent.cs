namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.submit_invoice_title 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Quick_issuing/Interface_Instructions.html ]]>
    /// </para>
    /// </summary>
    public class SubmitInvoiceTitleEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置发票抬头类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title_type")]
        [System.Text.Json.Serialization.JsonPropertyName("title_type")]
        [System.Xml.Serialization.XmlElement("title_type")]
        public string TitleType { get; set; } = default!;

        /// <summary>
        /// 获取或设置发票抬头。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        [System.Xml.Serialization.XmlElement("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置税号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tax_no")]
        [System.Text.Json.Serialization.JsonPropertyName("tax_no")]
        [System.Xml.Serialization.XmlElement("tax_no", IsNullable = true)]
        public string? TaxNumber { get; set; }

        /// <summary>
        /// 获取或设置联系电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone")]
        [System.Text.Json.Serialization.JsonPropertyName("phone")]
        [System.Xml.Serialization.XmlElement("phone", IsNullable = true)]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置联系地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addr")]
        [System.Text.Json.Serialization.JsonPropertyName("addr")]
        [System.Xml.Serialization.XmlElement("addr", IsNullable = true)]
        public string? Address { get; set; }

        /// <summary>
        /// 获取或设置开户行。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_type")]
        [System.Xml.Serialization.XmlElement("bank_type", IsNullable = true)]
        public string? Bank { get; set; }

        /// <summary>
        /// 获取或设置银行账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_no")]
        [System.Xml.Serialization.XmlElement("bank_no", IsNullable = true)]
        public string? BankNumber { get; set; }

        /// <summary>
        /// 获取或设置附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        [System.Xml.Serialization.XmlElement("attach", IsNullable = true)]
        public string? Attachment { get; set; }
    }
}
