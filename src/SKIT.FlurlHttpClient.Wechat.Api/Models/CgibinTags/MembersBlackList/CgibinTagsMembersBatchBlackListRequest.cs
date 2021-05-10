using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/tags/members/batchblacklist 接口的请求。</para>
    /// </summary>
    public class CgibinTagsMembersBatchBlackListRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置要拉黑的用户 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("openid_list")]
        public IList<string> OpenIdList { get; set; } = new List<string>();
    }
}
