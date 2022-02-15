using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/getliveinfo?action=get_replay 接口的请求。</para>
    /// </summary>
    public class WxaBusinessGetLiveReplayRequest : WechatApiRequest, IMapResponse<WxaBusinessGetLiveReplayRequest, WxaBusinessGetLiveReplayResponse>
    {
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "get_replay";

        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_id")]
        [System.Text.Json.Serialization.JsonPropertyName("room_id")]
        public long RoomId { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start")]
        [System.Text.Json.Serialization.JsonPropertyName("start")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; } = 10;
    }
}
