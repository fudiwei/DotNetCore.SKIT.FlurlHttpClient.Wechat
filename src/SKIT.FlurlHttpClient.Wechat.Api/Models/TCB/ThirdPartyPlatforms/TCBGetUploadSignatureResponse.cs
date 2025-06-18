namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getuploadsignature 接口的响应。</para>
    /// </summary>
    public class TCBGetUploadSignatureResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置带签名标头。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("headers")]
        [System.Text.Json.Serialization.JsonPropertyName("headers")]
        public string Headers { get; set; } = default!;
    }
}
