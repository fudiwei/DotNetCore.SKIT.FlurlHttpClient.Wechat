using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /kefustate/get/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class KefuStateGetResponse : WechatOpenAIPlatformResponse
    {
        /// <summary>
        /// 获取或设置客户接入状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kefustate")]
        [System.Text.Json.Serialization.JsonPropertyName("kefustate")]
        public string State { get; set; } = default!;
    }
}
