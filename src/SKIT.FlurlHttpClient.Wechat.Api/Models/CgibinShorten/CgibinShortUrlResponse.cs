using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/shorturl 接口的响应。</para>
    /// </summary>
    public class CgibinShortUrlResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置短链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("short_url")]
        [System.Text.Json.Serialization.JsonPropertyName("short_url")]
        public string ShortUrl { get; set; } = default!;
    }
}
