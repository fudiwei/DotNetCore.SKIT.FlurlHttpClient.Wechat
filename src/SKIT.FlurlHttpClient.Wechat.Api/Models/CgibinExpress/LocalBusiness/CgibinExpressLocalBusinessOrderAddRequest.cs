namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/local/business/order/add 接口的请求。</para>
    /// </summary>
    public class CgibinExpressLocalBusinessOrderAddRequest : CgibinExpressLocalBusinessOrderPreAddRequest
    {
        /// <summary>
        /// 获取或设置预下单接口返回的参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_token")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_token")]
        public string? DeliveryToken { get; set; }
    }
}
