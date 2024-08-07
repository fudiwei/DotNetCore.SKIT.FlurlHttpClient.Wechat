namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/clear_quota/v2 接口的请求。</para>
    /// </summary>
    public class CgibinClearQuotaV2Request : WechatApiRequest, IInferable<CgibinClearQuotaV2Request, CgibinClearQuotaV2Response>
    {
        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppSecret。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppSecret"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appsecret")]
        [System.Text.Json.Serialization.JsonPropertyName("appsecret")]
        public string? AppSecret { get; set; }
    }
}
