﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/goods/deleteInRoom 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastGoodsDeleteInRoomRequest : WechatApiRequest, IInferable<WxaApiBroadcastGoodsDeleteInRoomRequest, WxaApiBroadcastGoodsDeleteInRoomResponse>
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
        public long GoodsId { get; set; }
    }
}
