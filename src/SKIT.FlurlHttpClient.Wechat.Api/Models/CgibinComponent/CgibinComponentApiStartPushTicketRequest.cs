using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/component/api_start_push_ticket 接口的请求。</para>
    /// </summary>
    public class CgibinComponentApiStartPushTicketRequest : WechatApiRequest, IMapResponse<CgibinComponentApiStartPushTicketRequest, CgibinComponentApiStartPushTicketResponse>
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
        [Newtonsoft.Json.JsonProperty("component_secret")]
        [System.Text.Json.Serialization.JsonPropertyName("component_secret")]
        public string? ComponentSecret { get; set; }
    }
}
