using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/broadcast/room/addgoods 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoomAddGoodsRequest : WechatApiRequest, IInferable<WxaApiBroadcastRoomAddGoodsRequest, WxaApiBroadcastRoomAddGoodsResponse>
    {
        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomId")]
        [System.Text.Json.Serialization.JsonPropertyName("roomId")]
        public long RoomId { get; set; }

        /// <summary>
        /// 获取或设置商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ids")]
        [System.Text.Json.Serialization.JsonPropertyName("ids")]
        public IList<long> GoodsIdList { get; set; } = new List<long>();
    }
}
