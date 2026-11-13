namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/upload_media_init 接口的响应。</para>
    /// </summary>
    public class CgibinAIBotUploadMediaInitResponse : WechatWorkAIBotResponse
    {
        /// <summary>
        /// 获取或设置上传操作 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_id")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        public string? UploadId { get; set; }
    }
}
