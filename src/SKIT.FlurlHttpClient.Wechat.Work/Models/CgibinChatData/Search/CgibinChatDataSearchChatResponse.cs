namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/search_chat 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataSearchChatResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class GroupChat
            {
                /// <summary>
                /// 获取或设置群 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chatid")]
                [System.Text.Json.Serialization.JsonPropertyName("chatid")]
                public string GroupChatId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置群列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_list")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_list")]
        public Types.GroupChat[] GroupChatList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanReadOnlyConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanReadOnlyConverter))]
        public bool HasMore { get; set; }
    }
}
