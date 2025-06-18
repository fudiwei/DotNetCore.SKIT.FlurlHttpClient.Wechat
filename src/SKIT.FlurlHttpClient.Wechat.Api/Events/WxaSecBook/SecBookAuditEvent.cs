namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.secbook_audit_event 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/novel-api.html#%E5%AE%A1%E6%A0%B8%E7%8A%B6%E6%80%81%E4%BA%8B%E4%BB%B6 </para>
    /// </summary>
    public class SecBookAuditEvent : WechatApiEvent
    {
        public static class Types
        {
            public class EventData
            {
                public static class Types
                {
                    public class AuditDetail
                    {
                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        [System.Xml.Serialization.XmlElement("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置提审时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        [System.Xml.Serialization.XmlElement("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置审核时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_time")]
                        [System.Xml.Serialization.XmlElement("audit_time")]
                        public long AuditTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置作品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("book_id")]
                [System.Text.Json.Serialization.JsonPropertyName("book_id")]
                [System.Xml.Serialization.XmlElement("book_id")]
                public string BookId { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_detail")]
                [System.Xml.Serialization.XmlElement("audit_detail")]
                public Types.AuditDetail AuditDetail { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置事件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_event")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_event")]
        [System.Xml.Serialization.XmlElement("audit_event")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
