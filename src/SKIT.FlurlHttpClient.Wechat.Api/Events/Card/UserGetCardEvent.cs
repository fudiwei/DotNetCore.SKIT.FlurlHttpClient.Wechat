namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.user_get_card 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Distributing_Coupons_Vouchers_and_Cards.html#11 ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Coupons_Vouchers_and_Cards_Event_Push_Messages.html#2 ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Membership_Cards/Create_a_membership_card.html#13 ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/gift_card.html#_10-4%E3%80%81%E8%B5%A0%E9%80%8124%E5%B0%8F%E6%97%B6%E5%AF%B9%E6%96%B9%E6%9C%AA%E9%A2%86%E5%8F%96%E9%80%80%E5%9B%9E%E5%90%8E%E7%9A%84%E4%BA%8B%E4%BB%B6 ]]>
    /// </para>
    /// </summary>
    public class UserGetCardEvent : WechatApiEvent
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
        /// 获取或设置转赠前的卡券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OldUserCardCode")]
        [System.Text.Json.Serialization.JsonPropertyName("OldUserCardCode")]
        [System.Xml.Serialization.XmlElement("OldUserCardCode", IsNullable = true)]
        public string? OldCardCode { get; set; }

        /// <summary>
        /// 获取或设置领券用户的 UnionId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("UnionId")]
        [System.Text.Json.Serialization.JsonPropertyName("UnionId")]
        [System.Xml.Serialization.XmlElement("UnionId", IsNullable = true)]
        public string? UnionId { get; set; }

        /// <summary>
        /// 获取或设置是否来自好友转增。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IsGiveByFriend")]
        [System.Text.Json.Serialization.JsonPropertyName("IsGiveByFriend")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        [System.Xml.Serialization.XmlElement("IsGiveByFriend")]
        public bool IsTransferedByFriend { get; set; }

        /// <summary>
        /// 获取或设置转赠用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FriendUserName")]
        [System.Text.Json.Serialization.JsonPropertyName("FriendUserName")]
        [System.Xml.Serialization.XmlElement("FriendUserName", IsNullable = true)]
        public string? FriendOpenId { get; set; }

        /// <summary>
        /// 获取或设置是否是找回会员卡。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IsRestoreMemberCard")]
        [System.Text.Json.Serialization.JsonPropertyName("IsRestoreMemberCard")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        [System.Xml.Serialization.XmlElement("IsRestoreMemberCard", IsNullable = true)]
        public bool? IsRestoreMemberCard { get; set; }

        /// <summary>
        /// 获取或设置是否是来自好友推荐。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IsRecommendByFriend")]
        [System.Text.Json.Serialization.JsonPropertyName("IsRecommendByFriend")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        [System.Xml.Serialization.XmlElement("IsRecommendByFriend", IsNullable = true)]
        public bool? IsRecommendByFriend { get; set; }

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
