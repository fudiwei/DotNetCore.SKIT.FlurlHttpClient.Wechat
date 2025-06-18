namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/singlefileupload 接口的响应。</para>
    /// </summary>
    public class WxaSecVodSingleFileUploadResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置媒资文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long MediaId { get; set; }
    }
}
