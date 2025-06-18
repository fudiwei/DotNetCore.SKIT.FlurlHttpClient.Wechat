namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/pullupload 接口的响应。</para>
    /// </summary>
    public class WxaSecVodPullUploadResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置拉取上传任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long TaskId { get; set; }
    }
}
