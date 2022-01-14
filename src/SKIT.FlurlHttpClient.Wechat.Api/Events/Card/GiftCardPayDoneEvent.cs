namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.giftcard_pay_done 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/gift_card.html#_10-1%E3%80%81%E7%94%A8%E6%88%B7%E8%B4%AD%E4%B9%B0%E7%A4%BC%E5%93%81%E5%8D%A1%E4%BB%98%E6%AC%BE%E6%88%90%E5%8A%9FCallBack </para>
    /// </summary>
    public class GiftCardPayDoneEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置货架 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PageId")]
        [System.Text.Json.Serialization.JsonPropertyName("PageId")]
        [System.Xml.Serialization.XmlElement("PageId")]
        public string PageId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OrderId")]
        [System.Text.Json.Serialization.JsonPropertyName("OrderId")]
        [System.Xml.Serialization.XmlElement("OrderId")]
        public string OrderId { get; set; } = default!;
    }
}
