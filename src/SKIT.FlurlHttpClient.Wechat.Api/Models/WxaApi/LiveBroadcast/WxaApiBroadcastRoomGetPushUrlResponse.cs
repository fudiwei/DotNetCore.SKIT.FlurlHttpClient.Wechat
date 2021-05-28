using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/broadcast/room/getpushurl 接口的响应。</para>
    /// </summary>
    public class WxaApiBroadcastRoomGetPushUrlResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置直播间推流地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pushAddr")]
        [System.Text.Json.Serialization.JsonPropertyName("pushAddr")]
        public string PushUrl { get; set; } = default!;
    }
}
