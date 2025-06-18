namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/upload_media 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataUploadMediaResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置媒体文件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 获取或设置媒体文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string MediaId { get; set; } = default!;

        /// <summary>
        /// 获取或设置媒体文件上传时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("created_at")]
        [System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long CreateTimestamp { get; set; }
    }
}
