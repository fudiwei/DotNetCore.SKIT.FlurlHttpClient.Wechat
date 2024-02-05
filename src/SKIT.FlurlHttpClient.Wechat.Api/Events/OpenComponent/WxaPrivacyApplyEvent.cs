namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.wxa_privacy_apply 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/privacy-api-management/applyPrivacyInterface.html ]]>
    /// </para>
    /// </summary>
    public class WxaPrivacyApplyEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置 API 英文名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("api_name")]
                [System.Text.Json.Serialization.JsonPropertyName("api_name")]
                [System.Xml.Serialization.XmlElement("api_name")]
                public string ApiName { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_id")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
                [System.Xml.Serialization.XmlElement("audit_id")]
                public long AuditId { get; set; }

                /// <summary>
                /// 获取或设置申请状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置申请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_time")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_time")]
                [System.Xml.Serialization.XmlElement("apply_time")]
                public long ApplyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置审核时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_time")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_time")]
                [System.Xml.Serialization.XmlElement("audit_time")]
                public long AuditTimestamp { get; set; }

                /// <summary>
                /// 获取或设置审核被驳回原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                [System.Xml.Serialization.XmlElement("reason", IsNullable = true)]
                public string? RejectReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置审核结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_info")]
        [System.Text.Json.Serialization.JsonPropertyName("result_info")]
        [System.Xml.Serialization.XmlElement("result_info")]
        public Types.Result Result { get; set; } = default!;
    }
}
