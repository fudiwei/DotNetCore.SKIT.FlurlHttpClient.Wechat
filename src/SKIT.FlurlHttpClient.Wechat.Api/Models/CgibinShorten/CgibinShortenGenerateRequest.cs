namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/shorten/gen 接口的请求。</para>
    /// </summary>
    public class CgibinShortenGenerateRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_seconds")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_seconds")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// 获取或设置需要转换的长信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("long_data")]
        [System.Text.Json.Serialization.JsonPropertyName("long_data")]
        public string LongData { get; set; } = string.Empty;
    }
}
