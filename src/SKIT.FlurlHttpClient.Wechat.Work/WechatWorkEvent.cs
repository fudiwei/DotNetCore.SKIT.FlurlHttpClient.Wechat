using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    /// <summary>
    /// 表示微信 API 回调通知事件的基类。
    /// </summary>
    [Serializable]
    public class WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置接收的企业 ID。
        /// </summary>
        [XmlElement("ToUserName")]
        public string ToUserName { get; set; } = default!;

        /// <summary>
        /// 获取或设置接收的应用 ID。
        /// </summary>
        [XmlElement("AgentID")]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 获取或设置经过加密的消息数据。
        /// </summary>
        [XmlElement("Encrypt")]
        public string EncryptedData { get; set; } = default!;
    }
}
