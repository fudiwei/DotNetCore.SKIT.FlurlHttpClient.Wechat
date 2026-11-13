namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/aibot/topic/get_search_result 接口的响应。</para>
    /// </summary>
    public class CgibinAIBotTopicGetSerachResultResponse : WechatWorkAIBotResponse
    {
        public static class Types
        {
            public class Result
            {
                public static class Types
                {
                    public class Reply
                    {
                        /// <summary>
                        /// 获取或设置评论 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reply_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("reply_id")]
                        public string? ReplyId { get; set; }

                        /// <summary>
                        /// 获取或设置评论摘要。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brief_content")]
                        [System.Text.Json.Serialization.JsonPropertyName("brief_content")]
                        public string? BriefContent { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置帖子 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("post_id")]
                [System.Text.Json.Serialization.JsonPropertyName("post_id")]
                public string? PostId { get; set; }

                /// <summary>
                /// 获取或设置内容摘要。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brief_content")]
                [System.Text.Json.Serialization.JsonPropertyName("brief_content")]
                public string? BriefContent { get; set; }

                /// <summary>
                /// 获取或设置评论列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reply_list")]
                [System.Text.Json.Serialization.JsonPropertyName("reply_list")]
                public List<Types.Reply>? ReplyList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置搜索结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_list")]
        [System.Text.Json.Serialization.JsonPropertyName("result_list")]
        public Types.Result[]? ResultList { get; set; }

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
