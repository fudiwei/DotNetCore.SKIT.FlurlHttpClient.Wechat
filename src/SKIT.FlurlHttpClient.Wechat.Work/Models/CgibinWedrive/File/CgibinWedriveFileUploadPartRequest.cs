namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_upload_part 接口的请求。</para>
    /// </summary>
    public class CgibinWedriveFileUploadPartRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置上传凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_key")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_key")]
        public string UploadKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件分块号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("index")]
        [System.Text.Json.Serialization.JsonPropertyName("index")]
        public int Index { get; set; }

        /// <summary>
        /// 获取或设置经过 Base64 编码的文件分块内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_base64_content")]
        [System.Text.Json.Serialization.JsonPropertyName("file_base64_content")]
        public string EncodingBlockContent { get; set; } = string.Empty;
    }
}
