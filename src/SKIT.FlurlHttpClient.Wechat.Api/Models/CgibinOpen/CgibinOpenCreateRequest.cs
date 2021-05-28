using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/open/create 接口的请求。</para>
    /// </summary>
    public class CgibinOpenCreateRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置授权方 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AuthorizerAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置授权方的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;
    }
}
