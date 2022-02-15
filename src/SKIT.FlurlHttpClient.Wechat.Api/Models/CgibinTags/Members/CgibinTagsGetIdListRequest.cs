using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/tags/getidlist 接口的请求。</para>
    /// </summary>
    public class CgibinTagsGetIdListRequest : WechatApiRequest, IMapResponse<CgibinTagsGetIdListRequest, CgibinTagsGetIdListResponse>
    {
        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;
    }
}
