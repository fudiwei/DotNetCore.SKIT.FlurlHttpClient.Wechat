using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.change_auth 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90642 </para>
    /// </summary>
    public class ChangeAuthEvent : WechatWorkEvent, WechatWorkEvent.Types.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SuiteId")]
        public string SuiteId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AuthCorpId")]
        public string AuthorizerCorpId { get; set; } = default!;
    }
}
