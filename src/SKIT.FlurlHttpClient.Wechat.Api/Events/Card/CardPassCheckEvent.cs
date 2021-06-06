using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.card_pass_check 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Coupons_Vouchers_and_Cards_Event_Push_Messages.html#1 </para>
    /// </summary>
    public class CardPassCheckEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable, WechatApiEvent.Types.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CardId")]
        [System.Text.Json.Serialization.JsonPropertyName("CardId")]
        [System.Xml.Serialization.XmlElement("CardId")]
        public string CardId { get; set; } = default!;
    }
}
