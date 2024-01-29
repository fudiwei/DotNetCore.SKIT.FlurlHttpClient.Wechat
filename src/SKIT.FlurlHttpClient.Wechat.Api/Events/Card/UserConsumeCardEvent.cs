namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.user_consume_card 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Coupons_Vouchers_and_Cards_Event_Push_Messages.html#5 </para>
    /// </summary>
    public class UserConsumeCardEvent : WechatApiEvent
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
        /// 获取或设置核销来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ConsumeSource")]
        [System.Text.Json.Serialization.JsonPropertyName("ConsumeSource")]
        [System.Xml.Serialization.XmlElement("ConsumeSource")]
        public string ConsumeSource { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("LocationId")]
        [System.Text.Json.Serialization.JsonPropertyName("LocationId")]
        [System.Xml.Serialization.XmlElement("LocationId", IsNullable = true)]
        public long? POIId { get; set; }

        /// <summary>
        /// 获取或设置门店名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("LocationName")]
        [System.Text.Json.Serialization.JsonPropertyName("LocationName")]
        [System.Xml.Serialization.XmlElement("LocationName", IsNullable = true)]
        public string? POIName { get; set; }

        /// <summary>
        /// 获取或设置核销员的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("StaffOpenId")]
        [System.Text.Json.Serialization.JsonPropertyName("StaffOpenId")]
        [System.Xml.Serialization.XmlElement("StaffOpenId", IsNullable = true)]
        public string? StaffOpenId { get; set; }

        /// <summary>
        /// 获取或设置自助核销时用户输入的验证码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("VerifyCode")]
        [System.Text.Json.Serialization.JsonPropertyName("VerifyCode")]
        [System.Xml.Serialization.XmlElement("VerifyCode", IsNullable = true)]
        public string? VerifyCode { get; set; }

        /// <summary>
        /// 获取或设置自助核销时用户输入的备注金额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("RemarkAmount")]
        [System.Text.Json.Serialization.JsonPropertyName("RemarkAmount")]
        [System.Xml.Serialization.XmlElement("RemarkAmount", IsNullable = true)]
        public string? RemarkAmount { get; set; }

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
