namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.user_del_card 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Coupons_Vouchers_and_Cards_Event_Push_Messages.html#4 ]]>
    /// </para>
    /// </summary>
    public class UserDeleteCardEvent : WechatApiEvent
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
    }
}
