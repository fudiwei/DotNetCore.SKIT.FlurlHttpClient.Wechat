namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/queryauth 接口的响应。</para>
    /// </summary>
    public class WxaSecQueryAuthResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置认证任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_status")]
        [System.Text.Json.Serialization.JsonPropertyName("task_status")]
        public int TaskStatus { get; set; }

        /// <summary>
        /// 获取或设置审核单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_status")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_status")]
        public int ApplyStatus { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置打回重填原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refill_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("refill_reason")]
        public string? RefillReason { get; set; }

        /// <summary>
        /// 获取或设置审核失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        public string? FailReason { get; set; }
    }
}
