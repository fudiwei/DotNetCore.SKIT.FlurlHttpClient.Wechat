namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.change_external_contact 或 INFO.change_external_contact 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/92130 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/92005 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/92277 ]]>
    /// </para>
    /// </summary>
    public class ChangeExternalContactEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SuiteId")]
        [System.Text.Json.Serialization.JsonPropertyName("SuiteId")]
        [System.Xml.Serialization.XmlElement("SuiteId", IsNullable = true)]
        public string? SuiteId { get; set; }

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthCorpId")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthCorpId")]
        [System.Xml.Serialization.XmlElement("AuthCorpId", IsNullable = true)]
        public string? AuthorizerCorpId { get; set; }

        /// <summary>
        /// 获取或设置变更类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ChangeType")]
        [System.Text.Json.Serialization.JsonPropertyName("ChangeType")]
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ChangeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("UserID")]
        [System.Text.Json.Serialization.JsonPropertyName("UserID")]
        [System.Xml.Serialization.XmlElement("UserID", IsNullable = true)]
        public string? UserId { get; set; }

        /// <summary>
        /// 获取或设置外部联系人账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ExternalUserID")]
        [System.Text.Json.Serialization.JsonPropertyName("ExternalUserID")]
        [System.Xml.Serialization.XmlElement("ExternalUserID", IsNullable = true)]
        public string? ExternalUserId { get; set; }

        /// <summary>
        /// 获取或设置自定义渠道参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("State")]
        [System.Text.Json.Serialization.JsonPropertyName("State")]
        [System.Xml.Serialization.XmlElement("State", IsNullable = true)]
        public string? State { get; set; }

        /// <summary>
        /// 获取或设置欢迎语 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WelcomeCode")]
        [System.Text.Json.Serialization.JsonPropertyName("WelcomeCode")]
        [System.Xml.Serialization.XmlElement("WelcomeCode", IsNullable = true)]
        public string? WelcomeCode { get; set; }

        /// <summary>
        /// 获取或设置接替失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FailReason")]
        [System.Text.Json.Serialization.JsonPropertyName("FailReason")]
        [System.Xml.Serialization.XmlElement("FailReason", IsNullable = true)]
        public string? TransferFailReason { get; set; }

        /// <summary>
        /// 获取或设置删除客户的操作来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Source")]
        [System.Text.Json.Serialization.JsonPropertyName("Source")]
        [System.Xml.Serialization.XmlElement("Source", IsNullable = true)]
        public string? Source { get; set; }
    }
}
