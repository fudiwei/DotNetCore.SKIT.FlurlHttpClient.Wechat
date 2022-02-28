using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/getgoodswarehouse 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastGetGoodsWarehouseRequest : WechatApiRequest, IInferable<WxaApiBroadcastGetGoodsWarehouseRequest, WxaApiBroadcastGetGoodsWarehouseResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_ids")]
        public IList<int> GoodsIdList { get; set; } = new List<int>();
    }
}
