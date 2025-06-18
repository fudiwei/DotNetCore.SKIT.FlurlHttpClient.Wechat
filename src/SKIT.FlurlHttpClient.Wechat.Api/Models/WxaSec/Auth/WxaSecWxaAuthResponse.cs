namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/wxaauth 接口的响应。</para>
    /// </summary>
    public class WxaSecWxaAuthResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置认证任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("taskid")]
        public string TaskId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_url")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_url")]
        public string? AuthUrl { get; set; }
    }
}
