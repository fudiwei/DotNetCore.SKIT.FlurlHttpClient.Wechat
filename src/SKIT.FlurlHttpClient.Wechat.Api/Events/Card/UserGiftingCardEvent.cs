using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.user_gifting_card 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Coupons_Vouchers_and_Cards_Event_Push_Messages.html#3 </para>
    /// </summary>
    public class UserGiftingCardEvent : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [System.Xml.Serialization.XmlElement("CardId")]
        public string CardId { get; set; } = default!;

        /// <summary>
        /// 获取或设置卡券 Code。
        /// </summary>
        [System.Xml.Serialization.XmlElement("UserCardCode")]
        public string CardCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置接收卡券用户的 OpenId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("FriendUserName")]
        public string FriendOpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否转增退回。
        /// </summary>
        [System.Xml.Serialization.XmlElement("IsReturnBack")]
        public bool IsReturnBack { get; set; }

        /// <summary>
        /// 获取或设置是否是群转增。
        /// </summary>
        [System.Xml.Serialization.XmlElement("IsChatRoom")]
        public bool IsFromChatroom { get; set; }
    }
}
