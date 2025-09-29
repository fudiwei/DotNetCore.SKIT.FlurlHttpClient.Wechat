using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/dropship/cancel 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderDropshipCancelRequest : WechatApiRequest, IInferable<ChannelsECOrderDropshipCancelRequest, ChannelsECOrderDropshipCancelResponse>
    {
        public static class Types
        {
            public class DropshipProduct : ChannelsECOrderDropshipAssignRequest.Types.DropshipProduct
            {
            }
        }

        /// <summary>
        /// 获取或设置代发单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ds_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ds_order_id")]
        public string DropshipOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置代发商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dropship_product_list")]
        [System.Text.Json.Serialization.JsonPropertyName("dropship_product_list")]
        public IList<Types.DropshipProduct> DropshipProductList { get; set; } = new List<Types.DropshipProduct>();
    }
}
