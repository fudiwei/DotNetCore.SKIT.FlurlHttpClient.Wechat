namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/getauthurl 接口的响应。</para>
    /// </summary>
    public class CardInvoiceGetAuthUrlResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置授权链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_url")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_url")]
        public string AuthUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }
    }
}
