namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/advanced_api/create_order 接口的响应。</para>
    /// </summary>
    public class CgibinAdvancedApiCreateOrderResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = default!;
    }
}
