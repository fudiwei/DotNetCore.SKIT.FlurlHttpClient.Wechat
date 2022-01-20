namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/journal/get_record_detail 接口的响应。</para>
    /// </summary>
    public class CgibinOAJournalGetRecordDetailResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Journal
            {
                public static class Types
                {
                    public class User
                    {
                        /// <summary>
                        /// 获取或设置成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string UserId { get; set; } = default!;
                    }

                    public class ApplyData : CgibinOAGetApprovalDetailResponse.Types.Approval.Types.ApplyData
                    {
                    }

                    public class Comment
                    {
                        public static class Types
                        {
                            public class CommentUser
                            {
                                /// <summary>
                                /// 获取或设置评论人成员账号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("userid")]
                                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                                public string UserId { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置评论 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commentid")]
                        [System.Text.Json.Serialization.JsonPropertyName("commentid")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                        public string CommentId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置回复评论 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tocommentid")]
                        [System.Text.Json.Serialization.JsonPropertyName("tocommentid")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                        public string? ToCommentId { get; set; }

                        /// <summary>
                        /// 获取或设置评论人信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment_userinfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment_userinfo")]
                        public Types.CommentUser CommentUser { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置汇报 UUID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("journal_uuid")]
                [System.Text.Json.Serialization.JsonPropertyName("journal_uuid")]
                public string JournalId { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇报表单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public string TemplateId { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇报表单名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_name")]
                [System.Text.Json.Serialization.JsonPropertyName("template_name")]
                public string TemplateName { get; set; } = default!;

                /// <summary>
                /// 获取或设置提交者信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("submitter")]
                [System.Text.Json.Serialization.JsonPropertyName("submitter")]
                public Types.User Submitter { get; set; } = default!;

                /// <summary>
                /// 获取或设置接收者列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receivers")]
                [System.Text.Json.Serialization.JsonPropertyName("receivers")]
                public Types.User[] ReceiverList { get; set; } = default!;

                /// <summary>
                /// 获取或设置已读接收者列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("readed_receivers")]
                [System.Text.Json.Serialization.JsonPropertyName("readed_receivers")]
                public Types.User[] ReadedReceiverList { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇报数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_data")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_data")]
                public Types.ApplyData ApplyData { get; set; } = default!;

                /// <summary>
                /// 获取或设置评论列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comments")]
                [System.Text.Json.Serialization.JsonPropertyName("comments")]
                public Types.Comment[] CommentList { get; set; } = default!;

                /// <summary>
                /// 获取或设置汇报时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("report_time")]
                [System.Text.Json.Serialization.JsonPropertyName("report_time")]
                public long ReportTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置汇报信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.Journal Journal { get; set; } = default!;
    }
}
