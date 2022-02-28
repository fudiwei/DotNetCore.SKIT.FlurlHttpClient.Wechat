namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/order/getbyid 接口的请求。</para>
    /// </summary>
    public class MerchantOrderGetByIdRequest : WechatApiRequest, IMapResponse<MerchantOrderGetByIdRequest, MerchantOrderGetByIdResponse>
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;
    }
}
