using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/shorten/fetch 接口的响应。</para>
    /// </summary>
    public class CgibinShortenFetchResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置二维码类型有效时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_seconds")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_seconds")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// 获取或设置长信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("long_data")]
        [System.Text.Json.Serialization.JsonPropertyName("long_data")]
        public string LongData { get; set; } = default!;

        /// <summary>
        /// 获取或设置创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public long CreateTimestamp { get; set; }
    }
}
