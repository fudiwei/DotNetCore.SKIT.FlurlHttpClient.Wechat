using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/addguidebuyerrelation 接口的请求。</para>
    /// </summary>
    public class CgibinGuideAddGuideBuyerRelationRequest : WechatApiRequest, IMapResponse<CgibinGuideAddGuideBuyerRelationRequest, CgibinGuideAddGuideBuyerRelationResponse>
    {
        public static class Types
        {
            public class Buyer
            {
                /// <summary>
                /// 获取或设置客户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置客户微信昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buyer_nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("buyer_nickname")]
                public string? Nickname { get; set; }
            }
        }

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
        /// 获取或设置客户 OpenId。与字段 <see cref="BuyerList"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? BuyerOpenId { get; set; }

        /// <summary>
        /// 获取或设置客户微信昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_nickname")]
        public string? BuyerNickname { get; set; }

        /// <summary>
        /// 获取或设置客户列表。与字段 <see cref="BuyerOpenId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_list")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_list")]
        public IList<Types.Buyer>? BuyerList { get; set; }
    }
}
