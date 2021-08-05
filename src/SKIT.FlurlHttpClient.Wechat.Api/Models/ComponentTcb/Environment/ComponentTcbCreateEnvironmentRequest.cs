using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/createenv 接口的请求。</para>
    /// </summary>
    public class ComponentTcbCreateEnvironmentRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境别名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alias")]
        [System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string Alias { get; set; } = string.Empty;
    }
}
