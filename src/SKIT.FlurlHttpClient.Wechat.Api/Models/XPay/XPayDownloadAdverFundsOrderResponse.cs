namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/download_adverfunds_order 接口的响应。</para>
    /// </summary>
    public class XPayDownloadAdverFundsOrderResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置下载地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;
    }
}
