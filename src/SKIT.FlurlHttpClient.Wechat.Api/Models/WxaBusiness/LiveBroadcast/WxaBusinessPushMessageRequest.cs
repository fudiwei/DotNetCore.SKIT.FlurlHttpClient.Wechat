using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/push_message 接口的请求。</para>
    /// </summary>
    public class WxaBusinessPushMessageRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_id")]
        [System.Text.Json.Serialization.JsonPropertyName("room_id")]
        public long RoomId { get; set; }

        /// <summary>
        /// 获取或设置订阅用户 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("user_openid")]
        public IList<string> UserOpenIdList { get; set; } = new List<string>();
    }
}
