using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getfuncconfig 接口的响应。</para>
    /// </summary>
    public class TcbGetFunctionConfigResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置 JSON 格式的配置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("config")]
        [System.Text.Json.Serialization.JsonPropertyName("config")]
        public string JsonConfig { get; set; } = default!;
    }
}
