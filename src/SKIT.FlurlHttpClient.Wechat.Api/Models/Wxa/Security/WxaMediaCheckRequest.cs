using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/media_check_async 接口的请求。</para>
    /// </summary>
    public class WxaMediaCheckRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置多媒体 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_url")]
        [System.Text.Json.Serialization.JsonPropertyName("media_url")]
        public string MediaUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置多媒体类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_type")]
        [System.Text.Json.Serialization.JsonPropertyName("media_type")]
        public int MediaType { get; set; }
    }
}
