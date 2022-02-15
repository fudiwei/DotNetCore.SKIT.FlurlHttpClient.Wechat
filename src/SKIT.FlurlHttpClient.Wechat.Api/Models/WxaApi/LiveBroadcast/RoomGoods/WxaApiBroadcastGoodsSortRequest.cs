using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/goods/sort 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastGoodsSortRequest : WechatApiRequest, IMapResponse<WxaApiBroadcastGoodsSortRequest, WxaApiBroadcastGoodsSortResponse>
    {
        public static class Types
        {
            public class Goods
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goodsId")]
                [System.Text.Json.Serialization.JsonPropertyName("goodsId")]
                public int GoodsId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomId")]
        [System.Text.Json.Serialization.JsonPropertyName("roomId")]
        public long RoomId { get; set; }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods")]
        [System.Text.Json.Serialization.JsonPropertyName("goods")]
        public IList<Types.Goods> GoodsList { get; set; } = new List<Types.Goods>();
    }
}
