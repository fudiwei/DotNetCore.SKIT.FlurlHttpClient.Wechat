namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/shorten/fetch 接口的请求。</para>
    /// </summary>
    public class CgibinShortenFetchRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置短 Key。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("short_key")]
        [System.Text.Json.Serialization.JsonPropertyName("short_key")]
        public string ShortKey { get; set; } = string.Empty;
    }
}
