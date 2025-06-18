namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.chat_archive_audit_approved_single 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/99532 ]]>
    /// </para>
    /// </summary>
    public class ChatArchiveAuditApprovedSingleEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SuiteId")]
        [System.Text.Json.Serialization.JsonPropertyName("SuiteId")]
        [System.Xml.Serialization.XmlElement("SuiteId")]
        public string SuiteId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthCorpId")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthCorpId")]
        [System.Xml.Serialization.XmlElement("AuthCorpId")]
        public string AuthorizerCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置企业服务人员的 OpenUserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OpenUserID")]
        [System.Text.Json.Serialization.JsonPropertyName("OpenUserID")]
        [System.Xml.Serialization.XmlElement("OpenUserID", IsNullable = true)]
        public string? OpenUserId { get; set; }

        /// <summary>
        /// 获取或设置外部联系人的 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ExternalUserID")]
        [System.Text.Json.Serialization.JsonPropertyName("ExternalUserID")]
        [System.Xml.Serialization.XmlElement("ExternalUserID", IsNullable = true)]
        public string? ExternalUserId { get; set; }

        /// <summary>
        /// 获取或设置客户群 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ChatId")]
        [System.Text.Json.Serialization.JsonPropertyName("ChatId")]
        [System.Xml.Serialization.XmlElement("ChatId", IsNullable = true)]
        public string? GroupChatId { get; set; }
    }
}
