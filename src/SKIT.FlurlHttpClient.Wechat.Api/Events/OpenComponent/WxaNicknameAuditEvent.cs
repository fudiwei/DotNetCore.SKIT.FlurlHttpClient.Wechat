namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.wxa_nickname_audit 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/basic-info-management/setNickName.html </para>
    /// </summary>
    public class WxaNicknameAuditEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
        [System.Xml.Serialization.XmlElement("nickname")]
        public string Nickname { get; set; } = default!;

        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ret")]
        [System.Text.Json.Serialization.JsonPropertyName("ret")]
        [System.Xml.Serialization.XmlElement("ret")]
        public int AuditStatus { get; set; }

        /// <summary>
        /// 获取或设置审核拒绝原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        [System.Xml.Serialization.XmlElement("reason", IsNullable = true)]
        public string? AuditRejectReason { get; set; }
    }
}
