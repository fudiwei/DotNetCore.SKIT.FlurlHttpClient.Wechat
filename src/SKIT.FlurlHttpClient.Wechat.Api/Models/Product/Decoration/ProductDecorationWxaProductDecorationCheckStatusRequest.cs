namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/decoration/wxaproduct_decoration_check_status 接口的请求。</para>
    /// </summary>
    public class ProductDecorationWxaProductDecorationCheckStatusRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public int ServiceId { get; set; }
    }
}
