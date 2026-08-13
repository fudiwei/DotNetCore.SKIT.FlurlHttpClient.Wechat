namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/start_download_order 接口的响应。</para>
    /// </summary>
    public class XPayStartDownloadOrderResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置下载任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string TaskId { get; set; } = default!;
    }
}
