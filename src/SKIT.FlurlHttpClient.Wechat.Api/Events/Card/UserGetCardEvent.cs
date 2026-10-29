namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "EVENT.user_get_card" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/card/Distributing_Coupons_Vouchers_and_Cards.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/card/Coupons_Vouchers_and_Cards_Event_Push_Messages.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/card/Membership_Cards/Create_a_membership_card.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/card/gift_card.html ]]>
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
        public string? CardId { get; set; }

        /// <summary>
        /// 获取或设置卡券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("UserCardCode")]
        [System.Text.Json.Serialization.JsonPropertyName("UserCardCode")]
        [System.Xml.Serialization.XmlElement("UserCardCode")]
        public string? CardCode { get; set; }

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
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
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
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
        [System.Xml.Serialization.XmlElement("IsRestoreMemberCard", IsNullable = true)]
        public bool? IsRestoreMemberCard { get; set; }

        /// <summary>
        /// 获取或设置是否是来自好友推荐。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IsRecommendByFriend")]
        [System.Text.Json.Serialization.JsonPropertyName("IsRecommendByFriend")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
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
