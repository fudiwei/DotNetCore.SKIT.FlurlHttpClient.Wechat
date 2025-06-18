namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.weapp_audit_delay 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/code-management/submitAudit.html ]]>
    /// </para>
    /// </summary>
    public class WeappAuditDelayEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置审核延后时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DelayTime")]
        [System.Text.Json.Serialization.JsonPropertyName("DelayTime")]
        [System.Xml.Serialization.XmlElement("DelayTime")]
        public long DelayTimestamp { get; set; }

        /// <summary>
        /// 获取或设置审核拒绝原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Reason")]
        [System.Text.Json.Serialization.JsonPropertyName("Reason")]
        [System.Xml.Serialization.XmlElement("Reason", IsNullable = true)]
        public string? RejectReason { get; set; }
    }
}
