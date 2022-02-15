namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/decoration/wxaproduct_decoration_query_pressure_test_status 接口的响应。</para>
    /// </summary>
    public class ProductDecorationWxaProductDecorationQueryPressureTestStatusResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置压测状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int PressureStatus { get; set; }
    }
}
