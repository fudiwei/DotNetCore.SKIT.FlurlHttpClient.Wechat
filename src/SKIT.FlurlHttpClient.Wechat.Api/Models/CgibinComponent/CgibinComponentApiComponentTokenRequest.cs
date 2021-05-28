using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/api_component_token 接口的请求。</para>
    /// </summary>
    public class CgibinComponentApiComponentTokenRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置第三方平台 AppSecret。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("component_appid")]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置第三方平台 AppSecret。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppSecret"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_appsecret")]
        [System.Text.Json.Serialization.JsonPropertyName("component_appsecret")]
        public string? ComponentSecret { get; set; }

        /// <summary>
        /// 获取或设置微信验证票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_verify_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("component_verify_ticket")]
        public string ComponentVerifyTicket { get; set; } = string.Empty;
    }
}
