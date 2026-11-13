namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/upload_media_chunk 接口的请求。</para>
    /// </summary>
    public class CgibinAIBotUploadMediaChunkRequest : WechatWorkAIBotRequest
    {
        /// <summary>
        /// 获取或设置上传操作 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_id")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        public string? UploadId { get; set; }

        /// <summary>
        /// 获取或设置分片序号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chunk_index")]
        [System.Text.Json.Serialization.JsonPropertyName("chunk_index")]
        public int ChunkIndex { get; set; }

        /// <summary>
        /// 获取或设置分片数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base64_data")]
        [System.Text.Json.Serialization.JsonPropertyName("base64_data")]
        public byte[]? ChunkData { get; set; }
    }
}
