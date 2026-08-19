using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/deliverynegotiation/result/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderDeliveryNegotiationResultGetRequest : WechatApiRequest, IInferable<ChannelsECOrderDeliveryNegotiationResultGetRequest, ChannelsECOrderDeliveryNegotiationResultGetResponse>
    {
        /// <summary>
        /// 获取或设置订单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id_list")]
        public IList<string> OrderIdList { get; set; } = new List<string>();
    }
}
