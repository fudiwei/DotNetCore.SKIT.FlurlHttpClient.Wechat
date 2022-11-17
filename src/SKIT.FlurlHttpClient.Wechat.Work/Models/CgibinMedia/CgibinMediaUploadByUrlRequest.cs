namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/media/upload_by_url 接口的请求。</para>
    /// </summary>
    public class CgibinMediaUploadByUrlRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public int Scene { get; set; }

        /// <summary>
        /// 获取或设置媒体文件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string FileUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filename")]
        [System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string FileName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件 MD5 哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("md5")]
        [System.Text.Json.Serialization.JsonPropertyName("md5")]
        public string? FileMD5 { get; set; }
    }
}
