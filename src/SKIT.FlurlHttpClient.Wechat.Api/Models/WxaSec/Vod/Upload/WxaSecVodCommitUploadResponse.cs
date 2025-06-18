namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/commitupload 接口的响应。</para>
    /// </summary>
    public class WxaSecVodCommitUploadResponse : WechatApiResponse
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
