using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/setwebviewdomain 接口的请求。</para>
    /// </summary>
    public class WxaSetWebviewDomainRequest : WechatApiRequest, IMapResponse<WxaSetWebviewDomainRequest, WxaSetWebviewDomainResponse>
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// <para>默认值：get</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "get";

        /// <summary>
        /// 获取或设置业务域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webviewdomain")]
        [System.Text.Json.Serialization.JsonPropertyName("webviewdomain")]
        public IList<string>? WebviewDomainList { get; set; }
    }
}
