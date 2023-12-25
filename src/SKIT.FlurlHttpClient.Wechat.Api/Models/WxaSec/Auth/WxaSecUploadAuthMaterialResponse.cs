namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/uploadauthmaterial 接口的响应。</para>
    /// </summary>
    public class WxaSecUploadAuthMaterialResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 获取或设置 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mediaid")]
        [System.Text.Json.Serialization.JsonPropertyName("mediaid")]
        public string MediaId { get; set; } = default!;
    }
}
