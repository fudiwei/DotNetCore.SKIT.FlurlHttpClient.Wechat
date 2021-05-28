using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getgroupinfo 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGroupInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Guide
            {
                /// <summary>
                /// 获取或设置顾问微信号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("guide_account")]
                [System.Text.Json.Serialization.JsonPropertyName("guide_account")]
                public string? GuideAccount { get; set; }

                /// <summary>
                /// 获取或设置顾问 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("guide_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("guide_openid")]
                public string? GuideOpenId { get; set; }

                /// <summary>
                /// 获取或设置顾问昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("guide_nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("guide_nickname")]
                public string GuideNickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置顾问头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("guide_headimgurl")]
                [System.Text.Json.Serialization.JsonPropertyName("guide_headimgurl")]
                public string GuideHeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置组内顾问人员总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int Total { get; set; }

        /// <summary>
        /// 获取或设置顾问列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_list")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_list")]
        public Types.Guide[] GuideList { get; set; } = default!;
    }
}
