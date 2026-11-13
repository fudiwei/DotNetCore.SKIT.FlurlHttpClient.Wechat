namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/topic/get_post_list 接口的响应。</para>
    /// </summary>
    public class CgibinAIBotTopicGetPostListResponse : WechatWorkAIBotResponse
    {
        public static class Types
        {
            public class Post
            {
                public static class Types
                {
                    public class Member : CgibinAIBotTopicSearchRequest.Types.Member
                    {
                    }

                    public class InlineFile
                    {
                        /// <summary>
                        /// 获取或设置占位符。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("placeholder")]
                        [System.Text.Json.Serialization.JsonPropertyName("placeholder")]
                        public string? Placeholder { get; set; }

                        /// <summary>
                        /// 获取或设置文件名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("file_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("file_name")]
                        public string? FileName { get; set; }

                        /// <summary>
                        /// 获取或设置临时 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("download_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("download_url")]
                        public string? DownloadUrl { get; set; }

                        /// <summary>
                        /// 获取或设置 Cookie 键。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cookie_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("cookie_name")]
                        public string? CookieName { get; set; }

                        /// <summary>
                        /// 获取或设置 Cookie 值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cookie_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("cookie_value")]
                        public string? CookieValue { get; set; }
                    }

                    public abstract class __zz__InlineMetion
                    {
                        /// <summary>
                        /// 获取或设置占位符。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("placeholder")]
                        [System.Text.Json.Serialization.JsonPropertyName("placeholder")]
                        public string? Placeholder { get; set; }
                    }

                    public class InlineMetion : __zz__InlineMetion
                    {
                        /// <summary>
                        /// 获取或设置被提及人信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("member")]
                        [System.Text.Json.Serialization.JsonPropertyName("member")]
                        public Member? Member { get; set; }
                    }

                    public class InlineChatRecord
                    {
                        /// <summary>
                        /// 获取或设置占位符。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("placeholder")]
                        [System.Text.Json.Serialization.JsonPropertyName("placeholder")]
                        public string? Placeholder { get; set; }

                        /// <summary>
                        /// 获取或设置聊天记录 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("chat_record_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("chat_record_id")]
                        public string? ChatRecordId { get; set; }
                    }

                    public class Image
                    {
                        /// <summary>
                        /// 获取或设置临时 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("download_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("download_url")]
                        public string? DownloadUrl { get; set; }

                        /// <summary>
                        /// 获取或设置 Cookie 键。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cookie_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("cookie_name")]
                        public string? CookieName { get; set; }

                        /// <summary>
                        /// 获取或设置 Cookie 值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cookie_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("cookie_value")]
                        public string? CookieValue { get; set; }
                    }

                    public abstract class __zz__Emoji
                    {
                        /// <summary>
                        /// 获取或设置表情类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("emoji_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("emoji_type")]
                        public int EmojiType { get; set; }
                    }

                    public class Emoji : __zz__Emoji
                    {
                        /// <summary>
                        /// 获取或设置成员列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_list")]
                        public List<Member>? UserList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置帖子 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("post_id")]
                [System.Text.Json.Serialization.JsonPropertyName("post_id")]
                public string? PostId { get; set; }

                /// <summary>
                /// 获取或设置发帖人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creator_info")]
                [System.Text.Json.Serialization.JsonPropertyName("creator_info")]
                public Types.Member? Creator { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置最后修改时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("modify_time")]
                [System.Text.Json.Serialization.JsonPropertyName("modify_time")]
                public long ModifyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置是否已撤回。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_recalled")]
                [System.Text.Json.Serialization.JsonPropertyName("is_recalled")]
                public bool IsRecalled { get; set; }

                /// <summary>
                /// 获取或设置是否已修改。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_modified")]
                [System.Text.Json.Serialization.JsonPropertyName("is_modified")]
                public bool IsModified { get; set; }

                /// <summary>
                /// 获取或设置内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// 获取或设置内嵌文件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inline_file_list")]
                [System.Text.Json.Serialization.JsonPropertyName("inline_file_list")]
                public List<Types.InlineFile>? InlineFileList { get; set; }

                /// <summary>
                /// 获取或设置内嵌提及列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inline_mention_list")]
                [System.Text.Json.Serialization.JsonPropertyName("inline_mention_list")]
                public List<Types.InlineMetion>? InlineMetionList { get; set; }

                /// <summary>
                /// 获取或设置内嵌聊天记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inline_chat_record_list")]
                [System.Text.Json.Serialization.JsonPropertyName("inline_chat_record_list")]
                public List<Types.InlineChatRecord>? InlineChatRecordList { get; set; }

                /// <summary>
                /// 获取或设置图片列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_list")]
                [System.Text.Json.Serialization.JsonPropertyName("image_list")]
                public List<Types.Image>? ImageList { get; set; }

                /// <summary>
                /// 获取或设置表情列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("emoji_list")]
                [System.Text.Json.Serialization.JsonPropertyName("emoji_list")]
                public List<Types.Emoji>? EmojiList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置帖子列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_list")]
        [System.Text.Json.Serialization.JsonPropertyName("post_list")]
        public Types.Post[]? PostList { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置下一页分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
