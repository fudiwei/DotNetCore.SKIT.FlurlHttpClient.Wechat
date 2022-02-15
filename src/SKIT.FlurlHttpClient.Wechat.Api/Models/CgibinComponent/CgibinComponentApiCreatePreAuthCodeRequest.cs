using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/api_create_preauthcode 接口的请求。</para>
    /// </summary>
    public class CgibinComponentApiCreatePreAuthCodeRequest : WechatApiRequest, IMapResponse<CgibinComponentApiCreatePreAuthCodeRequest, CgibinComponentApiCreatePreAuthCodeResponse>
    {
        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置第三方平台 AppSecret。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("component_appid")]
        public string? ComponentAppId { get; set; }
    }
}
