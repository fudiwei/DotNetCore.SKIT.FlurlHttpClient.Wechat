namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/topic/send_reply 接口的请求。</para>
    /// </summary>
    public class CgibinAIBotTopicSendReplyRequest : WechatWorkAIBotRequest
    {
        public static class Types
        {
            public class Member : CgibinAIBotTopicSearchRequest.Types.Member
            {
            }

            public class InlineFile : CgibinAIBotTopicSendPostRequest.Types.InlineFile
            {
            }

            public class InlineMetion : CgibinAIBotTopicSendPostRequest.Types.__zz__InlineMetion
            {
                /// <summary>
                /// 获取或设置被提及人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("member")]
                [System.Text.Json.Serialization.JsonPropertyName("member")]
                public Member? Member { get; set; }
            }

            public class Image : CgibinAIBotTopicSendPostRequest.Types.Image
            {
            }

            public class Feedback : CgibinAIBotTopicSendPostRequest.Types.Feedback
            {
                /// <summary>
                /// 获取或设置反馈 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string? Id { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置频道 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topic_id")]
        [System.Text.Json.Serialization.JsonPropertyName("topic_id")]
        public string? TopicId { get; set; }

        /// <summary>
        /// 获取或设置帖子 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_id")]
        [System.Text.Json.Serialization.JsonPropertyName("post_id")]
        public string? PostId { get; set; }

        /// <summary>
        /// 获取或设置上级评论 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parent_reply_id")]
        [System.Text.Json.Serialization.JsonPropertyName("parent_reply_id")]
        public string? ParentReplyId { get; set; }

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
        /// 获取或设置图片列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_list")]
        [System.Text.Json.Serialization.JsonPropertyName("image_list")]
        public List<Types.Image>? ImageList { get; set; }

        /// <summary>
        /// 获取或设置反馈配置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feedback")]
        [System.Text.Json.Serialization.JsonPropertyName("feedback")]
        public Types.Feedback? Feedback { get; set; }
    }
}
