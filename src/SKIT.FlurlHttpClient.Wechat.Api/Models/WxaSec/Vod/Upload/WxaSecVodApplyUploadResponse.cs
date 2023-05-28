namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/applyupload 接口的响应。</para>
    /// </summary>
    public class WxaSecVodApplyUploadResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置分片上传 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_id")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        public string UploadId { get; set; } = default!;
    }
}
