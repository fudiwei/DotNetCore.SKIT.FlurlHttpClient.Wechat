using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/mass/get 接口的响应。</para>
    /// </summary>
    public class CgibinMessageMassGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置群发消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置群发状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_status")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_status")]
        public string MessageStatus { get; set; } = default!;
    }
}
