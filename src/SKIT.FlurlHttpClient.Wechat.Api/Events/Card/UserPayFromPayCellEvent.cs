using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.user_pay_from_pay_cell 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Create_a_Coupon_Voucher_or_Card.html#13 </para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Coupons_Vouchers_and_Cards_Event_Push_Messages.html#6 </para>
    /// </summary>
    public class UserPayFromPayCellEvent : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable
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
        /// 获取或设置微信支付交易订单号。
        /// </summary>
        [System.Xml.Serialization.XmlElement("TransId", IsNullable = true)]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("LocationId", IsNullable = true)]
        public long? POIId { get; set; }

        /// <summary>
        /// 获取或设置门店名称。
        /// </summary>
        [System.Xml.Serialization.XmlElement("LocationName", IsNullable = true)]
        public string? POIName { get; set; }

        /// <summary>
        /// 获取或设置实付金额（单位：分）。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Fee")]
        public int Fee { get; set; }

        /// <summary>
        /// 获取或设置应付金额（单位：分）。
        /// </summary>
        [System.Xml.Serialization.XmlElement("OriginalFee")]
        public int OriginalFee { get; set; }
    }
}
