using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/geth5link/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class OpenApiGetH5LinkResponse : WechatOpenAIResponse
    {
        /// <summary>
        /// 获取或设置机器人链接 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link")]
        [System.Text.Json.Serialization.JsonPropertyName("link")]
        public string Url { get; set; } = default!;
    }
}
