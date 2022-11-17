namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /file-uploads 接口的响应。</para>
    /// </summary>
    public class UploadFileResponse : WechatTenpayBusinessResponse
    {
        /// <summary>
        /// 获取或设置媒体文件标识 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_id")]
        [System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string FileId { get; set; } = default!;
    }
}
