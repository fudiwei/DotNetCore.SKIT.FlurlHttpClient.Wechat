namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/broadcast/room/getsubanchor 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoomGetSubAnchorRequest : WechatApiRequest, IInferable<WxaApiBroadcastRoomGetSubAnchorRequest, WxaApiBroadcastRoomGetSubAnchorResponse>
    {
        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long RoomId { get; set; }
    }
}
