namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/decoration/wxaproduct_decoration_check_status 接口的响应。</para>
    /// </summary>
    public class ProductDecorationWxaProductDecorationCheckStatusResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置装修服务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int DecorationStatus { get; set; }
    }
}
