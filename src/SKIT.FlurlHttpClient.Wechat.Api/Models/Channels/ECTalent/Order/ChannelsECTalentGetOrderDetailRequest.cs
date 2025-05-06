namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/talent/get_order_detail 接口的请求。</para>
    /// </summary>
    public class ChannelsECTalentGetOrderDetailRequest : WechatApiRequest, IInferable<ChannelsECTalentGetOrderDetailRequest, ChannelsECTalentGetOrderDetailResponse>
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 SKU ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
        public long SKUId { get; set; }
    }
}
