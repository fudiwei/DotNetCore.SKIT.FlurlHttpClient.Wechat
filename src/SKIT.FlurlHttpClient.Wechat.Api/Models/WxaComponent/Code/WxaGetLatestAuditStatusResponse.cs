namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/get_latest_auditstatus 接口的响应。</para>
    /// </summary>
    public class WxaGetLatestAuditStatusResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auditid")]
        [System.Text.Json.Serialization.JsonPropertyName("auditid")]
        public long AuditId { get; set; }

        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置审核失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? FailReason { get; set; }

        /// <summary>
        /// 获取或设置截图 MediaId 列表，使用竖线分隔。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("screenshot")]
        [System.Text.Json.Serialization.JsonPropertyName("screenshot")]
        public string? ScreenshotMediaIds { get; set; }

        /// <summary>
        /// 获取或设置审核版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_version")]
        [System.Text.Json.Serialization.JsonPropertyName("user_version")]
        public string? UserVersion { get; set; }

        /// <summary>
        /// 获取或设置审核版本描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("user_desc")]
        public string? UserDescription { get; set; }

        /// <summary>
        /// 获取或设置提交审核时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("submit_audit_time")]
        [System.Text.Json.Serialization.JsonPropertyName("submit_audit_time")]
        public long SubmitAuditTimestamp { get; set; }
    }
}
