namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/comment/list 接口的响应。</para>
    /// </summary>
    public class CgibinCommentListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Comment
            {
                public static class Types
                {
                    public class Reply
                    {
                        /// <summary>
                        /// 获取或设置回复内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置回复时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置评论 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_comment_id")]
                [System.Text.Json.Serialization.JsonPropertyName("user_comment_id")]
                public long CommentId { get; set; }

                /// <summary>
                /// 获取或设置用户唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置评论内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否精选评论。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comment_type")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("comment_type")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsElected { get; set; }

                /// <summary>
                /// 获取或设置作者回复列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reply")]
                [System.Text.Json.Serialization.JsonPropertyName("reply")]
                public Types.Reply[]? ReplyList { get; set; } = default!;

                /// <summary>
                /// 获取或设置评论时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置评论列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment")]
        [System.Text.Json.Serialization.JsonPropertyName("comment")]
        public Types.Comment[] CommentList { get; set; } = default!;

        /// <summary>
        /// 获取或设置评论总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }
    }
}
