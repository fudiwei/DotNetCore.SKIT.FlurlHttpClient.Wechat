using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/list 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class GroupChat
            {
                /// <summary>
                /// 获取或设置客户群 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("chat_id")]
                public string GroupChatId { get; set; } = default!;

                /// <summary>
                /// 获取或设置跟进状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置客户群列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_chat_list")]
        [System.Text.Json.Serialization.JsonPropertyName("group_chat_list")]
        public Types.GroupChat[] GroupChatList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
