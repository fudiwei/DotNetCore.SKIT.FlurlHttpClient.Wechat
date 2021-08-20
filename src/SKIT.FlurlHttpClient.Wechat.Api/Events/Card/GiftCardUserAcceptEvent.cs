using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.giftcard_user_accept 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/gift_card.html#_10-3%E3%80%81%E7%94%A8%E6%88%B7%E9%A2%86%E5%8F%96%E7%A4%BC%E5%93%81%E5%8D%A1%E6%88%90%E5%8A%9FCallBack </para>
    /// </summary>
    public class GiftCardUserAcceptEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable, WechatApiEvent.Types.IXmlSerializable
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
        /// 获取或设置是否是群转增。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IsChatRoom")]
        [System.Text.Json.Serialization.JsonPropertyName("IsChatRoom")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        [System.Xml.Serialization.XmlElement("IsChatRoom")]
        public bool IsFromChatroom { get; set; }
    }
}
