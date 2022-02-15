using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/addguidebuyerdisplaytag 接口的请求。</para>
    /// </summary>
    public class CgibinGuideAddGuideBuyerDisplayTagRequest : WechatApiRequest, IMapResponse<CgibinGuideAddGuideBuyerDisplayTagRequest, CgibinGuideAddGuideBuyerDisplayTagResponse>
    {
        /// <summary>
        /// 获取或设置顾问微信号。与字段 <see cref="GuideOpenId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_account")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_account")]
        public string? GuideAccount { get; set; }

        /// <summary>
        /// 获取或设置顾问 OpenId。与字段 <see cref="GuideAccount"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_openid")]
        public string? GuideOpenId { get; set; }

        /// <summary>
        /// 获取或设置客户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string BuyerOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置自定义客户标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("display_tag_list")]
        [System.Text.Json.Serialization.JsonPropertyName("display_tag_list")]
        public IList<string> DisplayTagList { get; set; } = new List<string>();
    }
}
