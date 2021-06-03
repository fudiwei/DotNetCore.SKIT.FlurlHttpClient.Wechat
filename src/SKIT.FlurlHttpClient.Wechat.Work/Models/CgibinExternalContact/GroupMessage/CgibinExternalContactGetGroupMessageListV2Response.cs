using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_groupmsg_list_v2 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetGroupMessageListV2Response : WechatWorkResponse
    {
        public static class Types
        {
            public class GroupMessage
            {
                public static class Types
                {
                    public class TextMessage : CgibinExternalContactAddMessageTemplateRequest.Types.TextMessage
                    { 
                    }

                    public class Attachment : CgibinExternalContactAddMessageTemplateRequest.Types.Attachment
                    {
                    }
                }

                /// <summary>
                /// 获取或设置群发消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgid")]
                [System.Text.Json.Serialization.JsonPropertyName("msgid")]
                public string MessageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建者成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creator")]
                [System.Text.Json.Serialization.JsonPropertyName("creator")]
                public string CreatorUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_type")]
                [System.Text.Json.Serialization.JsonPropertyName("create_type")]
                public int CreateType { get; set; }

                /// <summary>
                /// 获取或设置文本消息信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public Types.TextMessage? Text { get; set; }

                /// <summary>
                /// 获取或设置附件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attachments")]
                [System.Text.Json.Serialization.JsonPropertyName("attachments")]
                public Types.Attachment[]? AttachmentList { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置群发消息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_msg_list")]
        [System.Text.Json.Serialization.JsonPropertyName("group_msg_list")]
        public Types.GroupMessage[]? GroupMessageList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
