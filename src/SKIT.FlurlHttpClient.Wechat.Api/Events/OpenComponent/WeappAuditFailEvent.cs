namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.weapp_audit_fail 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/code-management/submitAudit.html ]]>
    /// </para>
    /// </summary>
    public class WeappAuditFailEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置审核失败时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FailTime")]
        [System.Text.Json.Serialization.JsonPropertyName("FailTime")]
        [System.Xml.Serialization.XmlElement("FailTime")]
        public long FailTimestamp { get; set; }

        /// <summary>
        /// 获取或设置审核失败的原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Reason")]
        [System.Text.Json.Serialization.JsonPropertyName("Reason")]
        [System.Xml.Serialization.XmlElement("Reason", IsNullable = true)]
        public string? FailReason { get; set; }

        /// <summary>
        /// 获取或设置截图 MediaId 列表，使用竖线分隔。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ScreenShot")]
        [System.Text.Json.Serialization.JsonPropertyName("ScreenShot")]
        [System.Xml.Serialization.XmlElement("ScreenShot", IsNullable = true)]
        public string? ScreenshotMediaIds { get; set; }
    }
}
