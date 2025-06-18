namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/applyupload 接口的请求。</para>
    /// </summary>
    public class WxaSecVodApplyUploadRequest : WechatApiRequest, IInferable<WxaSecVodApplyUploadRequest, WxaSecVodApplyUploadResponse>
    {
        /// <summary>
        /// 获取或设置视频名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_name")]
        [System.Text.Json.Serialization.JsonPropertyName("media_name")]
        public string MediaName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频格式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_type")]
        [System.Text.Json.Serialization.JsonPropertyName("media_type")]
        public string MediaType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频封面图片格式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover_type")]
        [System.Text.Json.Serialization.JsonPropertyName("cover_type")]
        public string? CoverType { get; set; }

        /// <summary>
        /// 获取或设置来源上下文。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_context")]
        [System.Text.Json.Serialization.JsonPropertyName("source_context")]
        public string? SourceContext { get; set; }
    }
}
