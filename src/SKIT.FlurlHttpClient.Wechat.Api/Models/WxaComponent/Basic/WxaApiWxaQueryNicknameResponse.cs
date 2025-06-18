namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/api_wxa_querynickname 接口的响应。</para>
    /// </summary>
    public class WxaApiWxaQueryNicknameResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置小程序昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string Nickname { get; set; } = default!;

        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_stat")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_stat")]
        public int AuditStatus { get; set; }

        /// <summary>
        /// 获取或设置审核拒绝原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        public string? AuditRejectReason { get; set; }

        /// <summary>
        /// 获取或设置审核完成时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_time")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_time")]
        public long? AuditTimestamp { get; set; }

        /// <summary>
        /// 获取或设置审核提交时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public long CreateTimestamp { get; set; }
    }
}
