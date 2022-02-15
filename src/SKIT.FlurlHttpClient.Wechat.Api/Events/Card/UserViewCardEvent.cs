namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.user_view_card 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Coupons_Vouchers_and_Cards_Event_Push_Messages.html#7 </para>
    /// </summary>
    public class UserViewCardEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
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
        /// 获取或设置商户自定义数值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OuterId")]
        [System.Text.Json.Serialization.JsonPropertyName("OuterId")]
        [System.Xml.Serialization.XmlElement("OuterId", IsNullable = true)]
        public string? OuterId { get; set; }

        /// <summary>
        /// 获取或设置商户自定义字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OuterStr")]
        [System.Text.Json.Serialization.JsonPropertyName("OuterStr")]
        [System.Xml.Serialization.XmlElement("OuterStr", IsNullable = true)]
        public string? OuterString { get; set; }
    }
}
