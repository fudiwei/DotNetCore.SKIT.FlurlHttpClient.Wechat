using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.weapp_audit_success 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/code/audit_event.html </para>
    /// </summary>
    public class WeappAuditSuccessEvent : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置审核成功时间戳。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SuccTime")]
        public long SuccessTimestamp { get; set; }
    }
}
