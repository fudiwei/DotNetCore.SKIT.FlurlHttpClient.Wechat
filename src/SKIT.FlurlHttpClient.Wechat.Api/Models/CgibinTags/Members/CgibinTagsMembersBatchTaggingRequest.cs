using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/tags/members/batchtagging 接口的请求。</para>
    /// </summary>
    public class CgibinTagsMembersBatchTaggingRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置要打标签的用户 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("openid_list")]
        public IList<string> OpenIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置标签 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tagid")]
        [System.Text.Json.Serialization.JsonPropertyName("tagid")]
        public int TagId { get; set; }
    }
}
