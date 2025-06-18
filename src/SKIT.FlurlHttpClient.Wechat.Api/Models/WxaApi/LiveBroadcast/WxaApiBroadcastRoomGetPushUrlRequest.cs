﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/broadcast/room/getpushurl 接口的请求。</para>
    /// </summary>
    public class WxaApiBroadcastRoomGetPushUrlRequest : WechatApiRequest, IInferable<WxaApiBroadcastRoomGetPushUrlRequest, WxaApiBroadcastRoomGetPushUrlResponse>
    {
        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long RoomId { get; set; }
    }
}
