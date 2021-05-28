using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.naming_verify_fail 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Account_Management/Wechat_Accreditation_Event_Push.html#3 </para>
    /// </summary>
    public class NamingVerifyFailEvent : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置失败时间戳。
        /// </summary>
        [System.Xml.Serialization.XmlElement("FailTime")]
        public long FailTimestamp { get; set; }

        /// <summary>
        /// 获取或设置失败原因。
        /// </summary>
        [System.Xml.Serialization.XmlElement("FailReason")]
        public string FailReason { get; set; } = default!;
    }
}
