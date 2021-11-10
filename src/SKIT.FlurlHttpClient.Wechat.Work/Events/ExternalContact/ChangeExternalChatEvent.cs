using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.change_external_chat 或 INFO.change_external_chat 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92130 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92277 </para>
    /// </summary>
    public class ChangeExternalChatEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SuiteId", IsNullable = true)]
        public string? SuiteId { get; set; }

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AuthCorpId", IsNullable = true)]
        public string? AuthorizerCorpId { get; set; }

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ActionType { get; set; } = default!;

        /// <summary>
        /// 获取或设置客户群 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ChatId", IsNullable = true)]
        public string? GroupChatId { get; set; }

        /// <summary>
        /// 获取或设置客户群变更详情。
        /// </summary>
        [System.Xml.Serialization.XmlElement("UpdateDetail", IsNullable = true)]
        public string? UpdateDetail { get; set; }

        /// <summary>
        /// 获取或设置客户群入群场景值。
        /// </summary>
        [System.Xml.Serialization.XmlElement("JoinScene", IsNullable = true)]
        public int? JoinScene { get; set; }

        /// <summary>
        /// 获取或设置客户群退群场景值。
        /// </summary>
        [System.Xml.Serialization.XmlElement("QuitScene", IsNullable = true)]
        public int? QuitScene { get; set; }

        /// <summary>
        /// 获取或设置成员变更数量。
        /// </summary>
        [System.Xml.Serialization.XmlElement("MemChangeCnt", IsNullable = true)]
        public int? MemberChangedCount { get; set; }
    }
}
