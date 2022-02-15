using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/goods/onsale 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastGoodsOnSaleRequest : WechatApiRequest, IMapResponse<WxaApiBroadcastGoodsOnSaleRequest, WxaApiBroadcastGoodsOnSaleResponse>
    {
        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomId")]
        [System.Text.Json.Serialization.JsonPropertyName("roomId")]
        public long RoomId { get; set; }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goodsId")]
        [System.Text.Json.Serialization.JsonPropertyName("goodsId")]
        public int GoodsId { get; set; }

        /// <summary>
        /// 获取或设置是否上架。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("onSale")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("onSale")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsOnSale { get; set; }
    }
}
