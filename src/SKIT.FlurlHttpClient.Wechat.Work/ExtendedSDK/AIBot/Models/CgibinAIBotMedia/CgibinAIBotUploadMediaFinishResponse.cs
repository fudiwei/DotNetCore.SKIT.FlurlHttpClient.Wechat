namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/upload_media_finish 接口的响应。</para>
    /// </summary>
    public class CgibinAIBotUploadMediaFinishResponse : WechatWorkAIBotResponse
    {
        /// <summary>
        /// 获取或设置文件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 获取或设置文件 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string? MediaId { get; set; }

        /// <summary>
        /// 获取或设置上传时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("created_at")]
        [System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public long CreateTimestamp { get; set; }
    }
}
