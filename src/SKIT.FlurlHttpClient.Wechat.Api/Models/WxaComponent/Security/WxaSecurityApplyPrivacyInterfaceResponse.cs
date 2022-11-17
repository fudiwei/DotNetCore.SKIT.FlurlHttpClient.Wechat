namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/security/apply_privacy_interface 接口的响应。</para>
    /// </summary>
    public class WxaSecurityApplyPrivacyInterfaceResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_id")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
        public long? AuditId { get; set; }
    }
}
