using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/api_get_authorizer_option 接口的请求。</para>
    /// </summary>
    public class CgibinComponentApiGetAuthorizerOptionRequest : WechatApiRequest, IMapResponse<CgibinComponentApiGetAuthorizerOptionRequest, CgibinComponentApiGetAuthorizerOptionResponse>
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

        /// <summary>
        /// 获取或设置授权方 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorizer_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("authorizer_appid")]
        public string AuthorizerAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置选项名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option_name")]
        [System.Text.Json.Serialization.JsonPropertyName("option_name")]
        public string OptionName { get; set; } = string.Empty;
    }
}
