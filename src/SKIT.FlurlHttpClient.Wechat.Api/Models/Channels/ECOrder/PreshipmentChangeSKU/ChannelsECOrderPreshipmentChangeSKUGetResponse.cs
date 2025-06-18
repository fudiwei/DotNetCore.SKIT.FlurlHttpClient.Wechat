namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/preshipmentchangesku/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderPreshipmentChangeSKUGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置订单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("order_ids")]
        public string[] OrderIdList { get; set; } = default!;
    }
}
