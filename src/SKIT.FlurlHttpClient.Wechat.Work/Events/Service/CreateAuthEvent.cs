using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.create_auth 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90642 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90795 </para>
    /// </summary>
    public class CreateAuthEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SuiteId")]
        public string SuiteId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权码。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AuthCode")]
        public string AuthCode { get; set; } = default!;
    }
}
