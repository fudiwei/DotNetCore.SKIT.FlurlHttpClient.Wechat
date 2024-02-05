namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.user_gifting_card 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Coupons_Vouchers_and_Cards_Event_Push_Messages.html#3 ]]>
    /// </para>
    /// </summary>
    public class UserGiftingCardEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CardId")]
        [System.Text.Json.Serialization.JsonPropertyName("CardId")]
        [System.Xml.Serialization.XmlElement("CardId")]
        public string CardId { get; set; } = default!;

        /// <summary>
        /// 获取或设置卡券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("UserCardCode")]
        [System.Text.Json.Serialization.JsonPropertyName("UserCardCode")]
        [System.Xml.Serialization.XmlElement("UserCardCode")]
        public string CardCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置接收卡券用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FriendUserName")]
        [System.Text.Json.Serialization.JsonPropertyName("FriendUserName")]
        [System.Xml.Serialization.XmlElement("FriendUserName")]
        public string FriendOpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否转增退回。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IsReturnBack")]
        [System.Text.Json.Serialization.JsonPropertyName("IsReturnBack")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        [System.Xml.Serialization.XmlElement("IsReturnBack")]
        public bool IsReturnBack { get; set; }

        /// <summary>
        /// 获取或设置是否是群转增。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IsChatRoom")]
        [System.Text.Json.Serialization.JsonPropertyName("IsChatRoom")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        [System.Xml.Serialization.XmlElement("IsChatRoom")]
        public bool IsFromChatroom { get; set; }
    }
}
