namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/getpaymode 接口的响应。</para>
    /// </summary>
    public class CgibinExpressIntracityGetPayModeResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置扣费小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置扣费服务商小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_component_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_component_appid")]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置扣费主体。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_mode")]
        public string? PayMode { get; set; }
    }
}
