namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/uploadpart 接口的响应。</para>
    /// </summary>
    public class WxaSecVodUploadPartResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置根据分片内容生成的标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("etag")]
        [System.Text.Json.Serialization.JsonPropertyName("etag")]
        public string ETag { get; set; } = default!;
    }
}
