namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/setpaymode 接口的请求。</para>
    /// </summary>
    public class CgibinExpressIntracitySetPayModeRequest : WechatApiRequest, IInferable<CgibinExpressIntracitySetPayModeRequest, CgibinExpressIntracitySetPayModeResponse>
    {
        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置扣费主体。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_mode")]
        public string? PayMode { get; set; }
    }
}
