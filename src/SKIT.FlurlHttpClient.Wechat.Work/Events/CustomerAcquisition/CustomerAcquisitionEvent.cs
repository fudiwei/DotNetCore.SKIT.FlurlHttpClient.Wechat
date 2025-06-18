namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.customer_acquisition 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97299 ]]>
    /// </para>
    /// </summary>
    public class CustomerAcquisitionEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置变更类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ChangeType")]
        [System.Text.Json.Serialization.JsonPropertyName("ChangeType")]
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ChangeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置获客链接 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("LinkId")]
        [System.Text.Json.Serialization.JsonPropertyName("LinkId")]
        [System.Xml.Serialization.XmlElement("LinkId", IsNullable = true)]
        public string? LinkId { get; set; }

        /// <summary>
        /// 获取或设置企业服务人员的成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("UserID")]
        [System.Text.Json.Serialization.JsonPropertyName("UserID")]
        [System.Xml.Serialization.XmlElement("UserID", IsNullable = true)]
        public string? UserId { get; set; }

        /// <summary>
        /// 获取或设置外部联系人 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ExternalUserID")]
        [System.Text.Json.Serialization.JsonPropertyName("ExternalUserID")]
        [System.Xml.Serialization.XmlElement("ExternalUserID", IsNullable = true)]
        public string? ExternalUserId { get; set; }

        /// <summary>
        /// 获取或设置过期时间戳戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ExpireTime")]
        [System.Text.Json.Serialization.JsonPropertyName("ExpireTime")]
        [System.Xml.Serialization.XmlElement("ExpireTime", IsNullable = true)]
        public long? ExpireTimestamp { get; set; }

        /// <summary>
        /// 获取或设置过期获客额度数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ExpireQuotaNum")]
        [System.Text.Json.Serialization.JsonPropertyName("ExpireQuotaNum")]
        [System.Xml.Serialization.XmlElement("ExpireQuotaNum", IsNullable = true)]
        public int? ExpireQuota { get; set; }
    }
}
