namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.user_authorize_invoice 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/gift_card.html#_12-2-2-4%E6%8E%A5%E6%94%B6%E5%BC%80%E7%A5%A8%E4%BA%8B%E4%BB%B6 ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Vendor_API_List.html#6 ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Nontax_Bill/API_list.html#2.3 ]]>
    /// </para>
    /// </summary>
    public class UserAuthorizeInvoiceEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置授权成功的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SuccOrderId")]
        [System.Text.Json.Serialization.JsonPropertyName("SuccOrderId")]
        [System.Xml.Serialization.XmlElement("SuccOrderId", IsNullable = true)]
        public string? SuccessOrderId { get; set; }

        /// <summary>
        /// 获取或设置授权失败的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FailOrderId")]
        [System.Text.Json.Serialization.JsonPropertyName("FailOrderId")]
        [System.Xml.Serialization.XmlElement("FailOrderId", IsNullable = true)]
        public string? FailOrderId { get; set; }

        /// <summary>
        /// 获取或设置授权来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Source")]
        [System.Text.Json.Serialization.JsonPropertyName("Source")]
        [System.Xml.Serialization.XmlElement("Source")]
        public string Source { get; set; } = default!;
    }
}
