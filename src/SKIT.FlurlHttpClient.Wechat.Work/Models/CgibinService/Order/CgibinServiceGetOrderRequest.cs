namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_order 接口的请求。</para>
    /// </summary>
    public class CgibinServiceGetOrderRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orderid")]
        [System.Text.Json.Serialization.JsonPropertyName("orderid")]
        public string OrderId { get; set; } = string.Empty;
    }
}
