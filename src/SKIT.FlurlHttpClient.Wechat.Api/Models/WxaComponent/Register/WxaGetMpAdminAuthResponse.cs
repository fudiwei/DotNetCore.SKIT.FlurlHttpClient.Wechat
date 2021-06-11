using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getmpadminauth 接口的响应。</para>
    /// </summary>
    public class WxaGetMpAdminAuthResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置用户授权确认链接 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorize_url")]
        [System.Text.Json.Serialization.JsonPropertyName("authorize_url")]
        public string AuthorizeUrl { get; set; } = default!;
    }
}
