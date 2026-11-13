namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/order/update_order_detail_path 接口的请求。</para>
    /// </summary>
    public class WxaSecOrderUpdateOrderDetailPathRequest : WechatApiRequest, IInferable<WxaSecOrderUpdateOrderDetailPathRequest, WxaSecOrderUpdateOrderDetailPathResponse>
    {
        /// <summary>
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? PagePath { get; set; }
    }
}
