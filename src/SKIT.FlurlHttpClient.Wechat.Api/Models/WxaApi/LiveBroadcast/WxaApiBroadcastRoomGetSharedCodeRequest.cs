namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/broadcast/room/getsharedcode 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoomGetSharedCodeRequest : WechatApiRequest, IInferable<WxaApiBroadcastRoomGetSharedCodeRequest, WxaApiBroadcastRoomGetSharedCodeResponse>
    {
        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long RoomId { get; set; }

        /// <summary>
        /// 获取或设置自定义参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? CustomParameter { get; set; }
    }
}
