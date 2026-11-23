namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/servicemarket/getwxaqrcode 接口的请求。</para>
    /// </summary>
    public class WxaServiceMarketGetWxaQrcodeRequest : WechatApiRequest, IInferable<WxaServiceMarketGetWxaQrcodeRequest, WxaServiceMarketGetWxaQrcodeResponse>
    {
        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string? ServiceId { get; set; }

        /// <summary>
        /// 获取或设置服务商自定义的参数字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_params")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_params")]
        public string? CustomParametersString { get; set; }
    }
}
