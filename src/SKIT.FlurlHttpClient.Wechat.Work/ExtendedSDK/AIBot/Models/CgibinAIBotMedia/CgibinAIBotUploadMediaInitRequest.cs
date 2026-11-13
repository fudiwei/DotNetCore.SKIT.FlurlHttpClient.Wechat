namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/upload_media_init 接口的请求。</para>
    /// </summary>
    public class CgibinAIBotUploadMediaInitRequest : WechatWorkAIBotRequest
    {
        /// <summary>
        /// 获取或设置文件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 获取或设置文件名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filename")]
        [System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? FileName { get; set; }

        /// <summary>
        /// 获取或设置文件 MD5 哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("md5")]
        [System.Text.Json.Serialization.JsonPropertyName("md5")]
        public string? FileMd5 { get; set; }

        /// <summary>
        /// 获取或设置文件总大小（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_size")]
        [System.Text.Json.Serialization.JsonPropertyName("total_size")]
        public int TotalSize { get; set; }

        /// <summary>
        /// 获取或设置文件总切片数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_chunks")]
        [System.Text.Json.Serialization.JsonPropertyName("total_chunks")]
        public int TotalChunks { get; set; }
    }
}
