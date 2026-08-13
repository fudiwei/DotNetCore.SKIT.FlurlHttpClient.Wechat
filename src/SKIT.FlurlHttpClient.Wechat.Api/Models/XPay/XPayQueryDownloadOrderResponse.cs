namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_download_order 接口的响应。</para>
    /// </summary>
    public class XPayQueryDownloadOrderResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置下载任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string TaskId { get; set; } = default!;

        /// <summary>
        /// 获取或设置任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置下载地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_url")]
        [System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// 获取或设置下载链接过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_at")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_at")]
        public long DownloadUrlExpireTimestamp { get; set; }
    }
}
