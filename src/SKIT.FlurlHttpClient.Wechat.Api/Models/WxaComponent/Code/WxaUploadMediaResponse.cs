namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/uploadmedia 接口的响应。</para>
    /// </summary>
    public class WxaUploadMediaResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置媒体文件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 获取或设置媒体文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mediaid")]
        [System.Text.Json.Serialization.JsonPropertyName("mediaid")]
        public string MediaId { get; set; } = default!;
    }
}
