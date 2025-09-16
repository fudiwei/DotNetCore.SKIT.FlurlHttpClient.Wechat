namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/paytool/get_order_detail 接口的请求。</para>
    /// </summary>
    public class CgibinPayToolGetOrderDetailRequest : CgibinPayToolOrderRequestBase
    {
        /// <summary>
        /// 获取或设置收款订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;
    }
}
