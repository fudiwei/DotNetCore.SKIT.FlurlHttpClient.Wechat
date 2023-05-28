namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/pullupload 接口的请求。</para>
    /// </summary>
    public class WxaSecVodPullUploadRequest : WechatApiRequest, IInferable<WxaSecVodPullUploadRequest, WxaSecVodPullUploadResponse>
    {
        /// <summary>
        /// 获取或设置视频名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_name")]
        [System.Text.Json.Serialization.JsonPropertyName("media_name")]
        public string MediaName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_url")]
        [System.Text.Json.Serialization.JsonPropertyName("media_url")]
        public string MediaUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频封面 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover_url")]
        [System.Text.Json.Serialization.JsonPropertyName("cover_url")]
        public string? CoverUrl { get; set; }

        /// <summary>
        /// 获取或设置来源上下文。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_context")]
        [System.Text.Json.Serialization.JsonPropertyName("source_context")]
        public string? SourceContext { get; set; }
    }
}
