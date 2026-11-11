namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /multiuse/stocks/{stock_id}/send-flow 接口的响应。</para>
    /// </summary>
    public class GetMultiuseStockSendFlowResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置流水文件下载地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? DownloadUrl { get; set; }
    }
}
