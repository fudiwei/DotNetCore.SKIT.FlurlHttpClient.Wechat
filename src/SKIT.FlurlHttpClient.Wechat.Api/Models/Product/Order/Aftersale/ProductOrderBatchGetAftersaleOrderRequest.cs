using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/order/batchgetaftersaleorder 接口的请求。</para>
    /// </summary>
    public class ProductOrderBatchGetAftersaleOrderRequest : WechatApiRequest, IInferable<ProductOrderBatchGetAftersaleOrderRequest, ProductOrderBatchGetAftersaleOrderResponse>
    {
        /// <summary>
        /// 获取或设置售后单号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_order_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_id_list")]
        public IList<long> AftersaleOrderIdList { get; set; } = new List<long>();
    }
}
