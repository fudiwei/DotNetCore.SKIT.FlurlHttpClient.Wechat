namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.giftcard_send_to_friend 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/gift_card.html#_10-2%E3%80%81%E7%94%A8%E6%88%B7%E8%B4%AD%E4%B9%B0%E5%90%8E%E8%B5%A0%E9%80%81CallBack </para>
    /// </summary>
    public class GiftCardSendToFriendEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
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

        /// <summary>
        /// 获取或设置是否转增退回。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IsReturnBack")]
        [System.Text.Json.Serialization.JsonPropertyName("IsReturnBack")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        [System.Xml.Serialization.XmlElement("IsReturnBack")]
        public bool IsReturnBack { get; set; }

        /// <summary>
        /// 获取或设置是否是群转增。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IsChatRoom")]
        [System.Text.Json.Serialization.JsonPropertyName("IsChatRoom")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        [System.Xml.Serialization.XmlElement("IsChatRoom")]
        public bool IsFromChatroom { get; set; }
    }
}
