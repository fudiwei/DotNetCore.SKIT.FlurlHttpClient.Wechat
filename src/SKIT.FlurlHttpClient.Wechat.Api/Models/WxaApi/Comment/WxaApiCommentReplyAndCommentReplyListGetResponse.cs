namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/comment/replyandcommentreplylist/get 接口的响应。</para>
    /// </summary>
    public class WxaApiCommentReplyAndCommentReplyListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Reply
                    {
                        public static class Types
                        {
                            public class ContentInfo
                            {
                                /// <summary>
                                /// 获取或设置内容。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("content")]
                                [System.Text.Json.Serialization.JsonPropertyName("content")]
                                public string Content { get; set; } = default!;
                            }

                            public class UserInfo
                            {
                                /// <summary>
                                /// 获取或设置昵称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("nickname")]
                                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                                public string Nickname { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置头像 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("imgUrl")]
                                [System.Text.Json.Serialization.JsonPropertyName("imgUrl")]
                                public string HeadImageUrl { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置评论 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("replyId")]
                        [System.Text.Json.Serialization.JsonPropertyName("replyId")]
                        public string ReplyId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评价 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commentId")]
                        [System.Text.Json.Serialization.JsonPropertyName("commentId")]
                        public string CommentId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论内容信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("replyContent")]
                        [System.Text.Json.Serialization.JsonPropertyName("replyContent")]
                        public Types.ContentInfo ContentInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论用户信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("replyObject")]
                        [System.Text.Json.Serialization.JsonPropertyName("replyObject")]
                        public Types.UserInfo UserInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("createTime")]
                        [System.Text.Json.Serialization.JsonPropertyName("createTime")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("updateTime")]
                        [System.Text.Json.Serialization.JsonPropertyName("updateTime")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long UpdateTimestamp { get; set; }
                    }

                    public class CommentReply
                    {
                        public static class Types
                        {
                            public class ContentInfo : Reply.Types.ContentInfo
                            {
                            }

                            public class UserInfo : Reply.Types.UserInfo
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置回复 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commentReplyId")]
                        [System.Text.Json.Serialization.JsonPropertyName("commentReplyId")]
                        public string CommentReplyId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评价 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commentId")]
                        [System.Text.Json.Serialization.JsonPropertyName("commentId")]
                        public string CommentId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论内容信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commentReplyContent")]
                        [System.Text.Json.Serialization.JsonPropertyName("commentReplyContent")]
                        public Types.ContentInfo ContentInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论用户信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commentReplyObject")]
                        [System.Text.Json.Serialization.JsonPropertyName("commentReplyObject")]
                        public Types.UserInfo UserInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("createTime")]
                        [System.Text.Json.Serialization.JsonPropertyName("createTime")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("updateTime")]
                        [System.Text.Json.Serialization.JsonPropertyName("updateTime")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long UpdateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置评论信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reply")]
                [System.Text.Json.Serialization.JsonPropertyName("reply")]
                public Types.Reply Reply { get; set; } = default!;

                /// <summary>
                /// 获取或设置评论回复列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commentReplyList")]
                [System.Text.Json.Serialization.JsonPropertyName("commentReplyList")]
                public Types.CommentReply[] CommentReplyList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Data Data { get; set; } = default!;
    }
}
