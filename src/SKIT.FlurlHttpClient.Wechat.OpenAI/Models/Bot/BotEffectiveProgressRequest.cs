using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/bot/effective_progress 接口的请求。</para>
    /// </summary>
    public class BotEffectiveProgressRequest : WechatOpenAIRequest
    {
        /// <summary>
        /// 获取或设置环境。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string? Environment { get; set; }
    }
}
