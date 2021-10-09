using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.change_external_contact 或 INFO.change_external_contact 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92130 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92005 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92277 </para>
    /// </summary>
    public class ChangeExternalContactEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
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
        /// 获取或设置用户成员账号。
        /// </summary>
        [System.Xml.Serialization.XmlElement("UserID", IsNullable = true)]
        public string? UserId { get; set; }

        /// <summary>
        /// 获取或设置外部联系人账号。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ExternalUserID", IsNullable = true)]
        public string? ExternalUserId { get; set; }

        /// <summary>
        /// 获取或设置自定义渠道参数。
        /// </summary>
        [System.Xml.Serialization.XmlElement("State", IsNullable = true)]
        public string? State { get; set; }

        /// <summary>
        /// 获取或设置欢迎语 Code。
        /// </summary>
        [System.Xml.Serialization.XmlElement("WelcomeCode", IsNullable = true)]
        public string? WelcomeCode { get; set; }

        /// <summary>
        /// 获取或设置接替失败原因。
        /// </summary>
        [System.Xml.Serialization.XmlElement("FailReason", IsNullable = true)]
        public string? TransferFailReason { get; set; }

        /// <summary>
        /// 获取或设置删除客户的操作来源。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Source", IsNullable = true)]
        public string? Source { get; set; }
    }
}
