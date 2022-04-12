namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/complaint/get 接口的请求。</para>
    /// </summary>
    public class ShopComplaintGetRequest : WechatApiRequest, IInferable<ShopComplaintGetRequest, ShopComplaintGetResponse>
    {
        /// <summary>
        /// 获取或设置纠纷单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_order_id")]
        public long ComplaintOrderId { get; set; }
    }
}
