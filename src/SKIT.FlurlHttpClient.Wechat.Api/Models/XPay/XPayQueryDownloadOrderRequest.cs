namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_download_order 接口的请求。</para>
    /// </summary>
    public class XPayQueryDownloadOrderRequest : XPayRequestBase, IInferable<XPayQueryDownloadOrderRequest, XPayQueryDownloadOrderResponse>
    {
        /// <summary>
        /// 获取或设置下载任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string TaskId { get; set; } = string.Empty;

        protected internal override string GetRequestPath()
        {
            return "/xpay/query_download_order";
        }
    }
}
