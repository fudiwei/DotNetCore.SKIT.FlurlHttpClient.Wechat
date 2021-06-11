using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.betaapp_verify_event 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/verify_beta_Mini_Programs/getmpadminauth.html </para>
    /// </summary>
    public class BetaAppVerifyEvent : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable
    {
        public new static class Types
        {
            public class EventData : BetaAppAuthorizationApplyEvent.Types.EventData
            {
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ApplyAuthorizationInfoNoitfy")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
