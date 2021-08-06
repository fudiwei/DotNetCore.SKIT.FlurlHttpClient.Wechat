using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getqcloudtoken 接口的响应。</para>
    /// </summary>
    public class TcbGetQCloudTokenResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置 SecretId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("secretid")]
        [System.Text.Json.Serialization.JsonPropertyName("secretid")]
        public string SecretId { get; set; } = default!;

        /// <summary>
        /// 获取或设置 SecretKey。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("secretkey")]
        [System.Text.Json.Serialization.JsonPropertyName("secretkey")]
        public string SecretKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token")]
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 获取或设置过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expired_time")]
        [System.Text.Json.Serialization.JsonPropertyName("expired_time")]
        public long ExpireTimestamp { get; set; }
    }
}
