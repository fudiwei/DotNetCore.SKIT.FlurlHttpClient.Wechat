using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/tags/members/getblacklist 接口的请求。</para>
    /// </summary>
    public class CgibinTagsMembersGetBlackListRequest : WechatApiRequest, IMapResponse<CgibinTagsMembersGetBlackListRequest, CgibinTagsMembersGetBlackListResponse>
    {
        /// <summary>
        /// 获取或设置第一个拉取的 OpenId。不填默认从头开始拉取。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_openid")]
        public string? NextOpenId { get; set; }
    }
}
