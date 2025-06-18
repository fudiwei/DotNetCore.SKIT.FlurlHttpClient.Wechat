namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/component/fastregisterpersonalweapp?action=create 接口的响应。</para>
    /// </summary>
    public class WxaComponentFastRegisterPersonalWeappCreateResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("taskid")]
        public string TaskId { get; set; } = default!;

        /// <summary>
        /// 获取或设置任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置扫码认证链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorize_url")]
        [System.Text.Json.Serialization.JsonPropertyName("authorize_url")]
        public string? AuthorizeUrl { get; set; }
    }
}
