using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/wxopen/activityid/create 接口的响应。</para>
    /// </summary>
    public class CgibinMessageWxopenActivityIdCreateResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置动态消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public string ActivityId { get; set; } = default!;

        /// <summary>
        /// 获取或设置过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expiration_time")]
        [System.Text.Json.Serialization.JsonPropertyName("expiration_time")]
        public long ExpirationTimestamp { get; set; }
    }
}
