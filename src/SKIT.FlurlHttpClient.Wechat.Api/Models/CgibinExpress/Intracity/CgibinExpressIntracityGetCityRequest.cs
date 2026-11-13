namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/getcity 接口的请求。</para>
    /// </summary>
    public class CgibinExpressIntracityGetCityRequest : WechatApiRequest, IInferable<CgibinExpressIntracityGetCityRequest, CgibinExpressIntracityGetCityResponse>
    {
        /// <summary>
        /// 获取或设置运力 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_trans_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_trans_id")]
        public string? ServiceTransportId { get; set; }
    }
}
