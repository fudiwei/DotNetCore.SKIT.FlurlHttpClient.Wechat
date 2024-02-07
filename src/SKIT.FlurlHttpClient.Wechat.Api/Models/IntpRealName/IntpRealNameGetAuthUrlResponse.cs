namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/realname/getauthurl 接口的响应。</para>
    /// </summary>
    public class IntpRealNameGetAuthUrlResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置授权链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_url")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_url")]
        public string AuthUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权链接有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// 获取或设置授权小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }
    }
}
