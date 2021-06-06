using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.update_member_card 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Coupons_Vouchers_and_Cards_Event_Push_Messages.html#9 </para>
    /// </summary>
    public class UpdateMemberCardEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable, WechatApiEvent.Types.IXmlSerializable
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
        /// 获取或设置变动的积分值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ModifyBonus")]
        [System.Text.Json.Serialization.JsonPropertyName("ModifyBonus")]
        [System.Xml.Serialization.XmlElement("ModifyBonus", IsNullable = true)]
        public int? ModifiedBonus { get; set; }

        /// <summary>
        /// 获取或设置变动的余额值（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ModifyBalance")]
        [System.Text.Json.Serialization.JsonPropertyName("ModifyBalance")]
        [System.Xml.Serialization.XmlElement("ModifyBalance", IsNullable = true)]
        public int? ModifiedBalance { get; set; }
    }
}
