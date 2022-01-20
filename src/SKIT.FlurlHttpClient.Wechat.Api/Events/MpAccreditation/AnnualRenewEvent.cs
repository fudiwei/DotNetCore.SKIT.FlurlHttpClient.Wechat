﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.annual_renew 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Account_Management/Wechat_Accreditation_Event_Push.html#4 </para>
    /// </summary>
    public class AnnualRenewEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ExpiredTime")]
        [System.Text.Json.Serialization.JsonPropertyName("ExpiredTime")]
        [System.Xml.Serialization.XmlElement("ExpiredTime")]
        public long ExpireTimestamp { get; set; }
    }
}
