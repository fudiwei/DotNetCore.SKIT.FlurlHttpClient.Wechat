namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.user_authorize_invoice" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/card/gift_card.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/weixin_invoice/E_Invoice/Vendor_API_List.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/weixin_invoice/Nontax_Bill/API_list.html ]]>
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
        public string? Source { get; set; }
    }
}
