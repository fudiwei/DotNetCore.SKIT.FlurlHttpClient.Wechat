namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.update_invoice_status 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Invoicing_Platform_API_List.html#7 ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Nontax_Bill/API_list.html#3.6 ]]>
    /// </para>
    /// </summary>
    public class UpdateInvoiceStatusEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置发票或非税票据卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CardId")]
        [System.Text.Json.Serialization.JsonPropertyName("CardId")]
        [System.Xml.Serialization.XmlElement("CardId")]
        public string CardId { get; set; } = default!;

        /// <summary>
        /// 获取或设置发票或非税票据卡券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Code")]
        [System.Text.Json.Serialization.JsonPropertyName("Code")]
        [System.Xml.Serialization.XmlElement("Code")]
        public string CardCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置发票或非税票据报销状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Status")]
        [System.Text.Json.Serialization.JsonPropertyName("Status")]
        [System.Xml.Serialization.XmlElement("Status", IsNullable = true)]
        public string? ReimburseStatus { get; set; }
    }
}
