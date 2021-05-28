using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguidebuyerchatrecord 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGuideBuyerChatRecordResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ChatRecord
            {
                /// <summary>
                /// 获取或设置顾问微信号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("guide_account")]
                [System.Text.Json.Serialization.JsonPropertyName("guide_account")]
                public string GuideAccount { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置聊天内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = default!;

                /// <summary>
                /// 获取或设置聊天记录类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content_type")]
                [System.Text.Json.Serialization.JsonPropertyName("content_type")]
                public int ContentType { get; set; }

                /// <summary>
                /// 获取或设置消息指向。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("direction")]
                [System.Text.Json.Serialization.JsonPropertyName("direction")]
                public int Direction { get; set; }

                /// <summary>
                /// 获取或设置聊天记录生成时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置消息记录总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int Total { get; set; }

        /// <summary>
        /// 获取或设置消息记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_list")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_list")]
        public Types.ChatRecord[] ChatRecordList { get; set; } = default!;
    }
}
