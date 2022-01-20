namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/getorderlist 接口的响应。</para>
    /// </summary>
    public class NontaxGetOrderListResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置订单号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id_list")]
        public string[] OrderIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置已经支付的订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paid_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("paid_order_id")]
        public string? PaidOrderId { get; set; }
    }
}
