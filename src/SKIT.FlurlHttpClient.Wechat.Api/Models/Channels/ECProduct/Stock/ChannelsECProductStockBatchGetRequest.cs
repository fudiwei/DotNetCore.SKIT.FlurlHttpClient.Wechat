using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/stock/batchget 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductStockBatchGetRequest : WechatApiRequest, IInferable<ChannelsECProductStockBatchGetRequest, ChannelsECProductStockBatchGetResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public IList<long> ProductIdList { get; set; } = new List<long>();
    }
}
