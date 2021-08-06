using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/createenvandresource 接口的响应。</para>
    /// </summary>
    public class TcbCreateEnvironmentAndResourceResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置环境状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;
    }
}
