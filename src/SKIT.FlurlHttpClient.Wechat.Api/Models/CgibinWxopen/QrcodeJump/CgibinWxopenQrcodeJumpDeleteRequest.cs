namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxopen/qrcodejumpdelete 接口的请求。</para>
    /// </summary>
    public class CgibinWxopenQrcodeJumpDeleteRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置匹配前缀。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prefix")]
        [System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string Prefix { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? MiniProgramAppId { get; set; }
    }
}
