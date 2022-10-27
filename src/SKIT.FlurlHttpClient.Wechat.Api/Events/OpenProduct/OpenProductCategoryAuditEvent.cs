namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.open_product_category_audit 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent2/callback/category_audit.html </para>
    /// </summary>
    public class OpenProductCategoryAuditEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class EventData
            {
                /// <summary>
                /// 获取或设置审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置审核单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_id")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
                [System.Xml.Serialization.XmlElement("audit_id")]
                public string AuditId { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_type")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_type")]
                [System.Xml.Serialization.XmlElement("audit_type")]
                public int AuditType { get; set; }

                /// <summary>
                /// 获取或设置拒绝原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reject_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                [System.Xml.Serialization.XmlElement("reject_reason")]
                public string? RejectReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("QualificationAuditResult")]
        [System.Text.Json.Serialization.JsonPropertyName("QualificationAuditResult")]
        [System.Xml.Serialization.XmlElement("QualificationAuditResult")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
