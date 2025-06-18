namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/download_bill 接口的响应。</para>
    /// </summary>
    public class XPayDownloadBillResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置下载地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;
    }
}
