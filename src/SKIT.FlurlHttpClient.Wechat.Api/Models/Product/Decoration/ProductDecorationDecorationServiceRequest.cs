namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/decoration/decoration_service 接口的请求。</para>
    /// </summary>
    public class ProductDecorationDecorationServiceRequest : WechatApiRequest, IInferable<ProductDecorationDecorationServiceRequest, ProductDecorationDecorationServiceResponse>
    {
        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public int ServiceId { get; set; }

        /// <summary>
        /// 获取或设置装修服务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("switch_status")]
        [System.Text.Json.Serialization.JsonPropertyName("switch_status")]
        public int DecorationStatus { get; set; }
    }
}
