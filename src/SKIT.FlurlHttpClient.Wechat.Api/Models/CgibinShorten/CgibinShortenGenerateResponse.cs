using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/shorten/gen 接口的响应。</para>
    /// </summary>
    public class CgibinShortenGenerateResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置短 Key。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("short_key")]
        [System.Text.Json.Serialization.JsonPropertyName("short_key")]
        public string ShortKey { get; set; } = default!;
    }
}
