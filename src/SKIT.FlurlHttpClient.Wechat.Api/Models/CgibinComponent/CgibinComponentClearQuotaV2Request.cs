namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/clear_quota/v2 接口的请求。</para>
    /// </summary>
    public class CgibinComponentClearQuotaV2Request : WechatApiRequest, IInferable<CgibinComponentClearQuotaV2Request, CgibinComponentClearQuotaV2Response>
    {
        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置第三方平台 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("component_appid")]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置第三方平台 AppSecret。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppSecret"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appsecret")]
        [System.Text.Json.Serialization.JsonPropertyName("appsecret")]
        public string? ComponentAppSecret { get; set; }
    }
}
