namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/marketcode/applycodedownload 接口的响应。</para>
    /// </summary>
    public class IntpMarketCodeApplyCodeDownloadResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置经 Base64 编码的文件内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buffer")]
        [System.Text.Json.Serialization.JsonPropertyName("buffer")]
        public string EncodingFileData { get; set; } = default!;
    }
}
