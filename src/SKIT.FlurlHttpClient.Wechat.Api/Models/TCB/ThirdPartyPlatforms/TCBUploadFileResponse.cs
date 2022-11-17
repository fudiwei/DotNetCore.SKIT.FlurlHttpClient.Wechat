namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/uploadfile 接口的响应。</para>
    /// </summary>
    public class TCBUploadFileResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置上传 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 获取或设置上传凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token")]
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization")]
        public string Authorization { get; set; } = default!;

        /// <summary>
        /// 获取或设置文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_id")]
        [System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// 获取或设置 COS 文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cos_file_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cos_file_id")]
        public string COSFileId { get; set; } = default!;
    }
}
