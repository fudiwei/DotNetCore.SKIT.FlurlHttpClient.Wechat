using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/goods/update 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastGoodsUpdateRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Goods : WxaApiBroadcastGoodsAddRequest.Types.Goods
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
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goodsInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("goodsInfo")]
        public Types.Goods Goods { get; set; } = new Types.Goods();
    }
}
