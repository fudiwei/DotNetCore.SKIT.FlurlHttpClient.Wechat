﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguideconfig 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGuideConfigResponse : WechatApiResponse
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
                public string Content { get; set; } = default!;

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("updatetime")]
                [System.Text.Json.Serialization.JsonPropertyName("updatetime")]
                public long UpdateTimestamp { get; set; }
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
                public string Content { get; set; } = default!;

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("updatetime")]
                [System.Text.Json.Serialization.JsonPropertyName("updatetime")]
                public long UpdateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置快捷回复列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_fast_reply_list")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_fast_reply_list")]
        public Types.FastReply[] GuideFastReplyList { get; set; } = default!;

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
