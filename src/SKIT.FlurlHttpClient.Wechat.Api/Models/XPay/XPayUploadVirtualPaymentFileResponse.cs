namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/upload_vp_file 接口的响应。</para>
    /// </summary>
    public class XPayUploadVirtualPaymentFileResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_id")]
        [System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string FileId { get; set; } = default!;
    }
}
