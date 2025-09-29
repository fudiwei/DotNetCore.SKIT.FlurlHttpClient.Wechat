namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/dropship/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderDropshipGetRequest : WechatApiRequest, IInferable<ChannelsECOrderDropshipGetRequest, ChannelsECOrderDropshipGetResponse>
    {
        /// <summary>
        /// 获取或设置代发单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ds_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ds_order_id")]
        public string DropshipOrderId { get; set; } = string.Empty;
    }
}
