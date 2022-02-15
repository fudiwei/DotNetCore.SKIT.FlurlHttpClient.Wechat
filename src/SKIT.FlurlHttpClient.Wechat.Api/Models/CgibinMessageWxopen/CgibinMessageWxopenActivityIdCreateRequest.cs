using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/wxopen/activityid/create 接口的请求。</para>
    /// </summary>
    public class CgibinMessageWxopenActivityIdCreateRequest : WechatApiRequest, IMapResponse<CgibinMessageWxopenActivityIdCreateRequest, CgibinMessageWxopenActivityIdCreateResponse>
    {
        /// <summary>
        /// 获取或设置分享者用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置分享者用户统一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string? UnionId { get; set; }
    }
}
