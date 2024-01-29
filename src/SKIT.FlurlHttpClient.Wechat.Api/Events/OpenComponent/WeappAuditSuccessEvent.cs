namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.weapp_audit_success 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/code-management/submitAudit.html </para>
    /// </summary>
    public class WeappAuditSuccessEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置审核成功时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SuccTime")]
        [System.Text.Json.Serialization.JsonPropertyName("SuccTime")]
        [System.Xml.Serialization.XmlElement("SuccTime")]
        public long SuccessTimestamp { get; set; }
    }
}
