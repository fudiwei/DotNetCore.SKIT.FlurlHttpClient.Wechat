namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.giftcard_user_accept" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/card/gift_card.html ]]>
    /// </para>
    /// </summary>
    public class GiftCardUserAcceptEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置货架 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PageId")]
        [System.Text.Json.Serialization.JsonPropertyName("PageId")]
        [System.Xml.Serialization.XmlElement("PageId")]
        public string? PageId { get; set; }

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OrderId")]
        [System.Text.Json.Serialization.JsonPropertyName("OrderId")]
        [System.Xml.Serialization.XmlElement("OrderId")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置是否是群转增。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IsChatRoom")]
        [System.Text.Json.Serialization.JsonPropertyName("IsChatRoom")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
        [System.Xml.Serialization.XmlElement("IsChatRoom")]
        public bool IsFromChatroom { get; set; }
    }
}
