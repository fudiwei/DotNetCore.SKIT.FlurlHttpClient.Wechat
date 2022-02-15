using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/setguideconfig 接口的请求。</para>
    /// </summary>
    public class CgibinGuideSetGuideConfigRequest : WechatApiRequest, IMapResponse<CgibinGuideSetGuideConfigRequest, CgibinGuideSetGuideConfigResponse>
    {
        public static class Types
        {
            public class FastReply
            {
                /// <summary>
                /// 获取或设置快捷回复内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = string.Empty;
            }

            public class AutoReply
            {
                /// <summary>
                /// 获取或设置自动回复类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgtype")]
                [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
                public int MessageType { get; set; }

                /// <summary>
                /// 获取或设置自动回复内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = string.Empty;
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
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_delete")]
        [System.Text.Json.Serialization.JsonPropertyName("is_delete")]
        public bool IsDelete { get; set; }

        /// <summary>
        /// 获取或设置快捷回复列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_fast_reply_list")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_fast_reply_list")]
        public IList<Types.FastReply>? GuideFastReplyList { get; set; }

        /// <summary>
        /// 获取或设置第一条新客户关注自动回复信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_auto_reply")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_auto_reply")]
        public Types.AutoReply? GuideAutoReply { get; set; }

        /// <summary>
        /// 获取或设置第二条新客户关注自动回复信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_auto_reply_plus")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_auto_reply_plus")]
        public Types.AutoReply? GuideAutoReplyPlus { get; set; }
    }
}
