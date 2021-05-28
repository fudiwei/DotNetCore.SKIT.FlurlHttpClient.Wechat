using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/mass/send 接口的响应。</para>
    /// </summary>
    public class CgibinMessageMassSendResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置群发消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long MessageId { get; set; }

        /// <summary>
        /// 获取或设置群发消息数据 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_data_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_data_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long? MessageDataId { get; set; }
    }
}
