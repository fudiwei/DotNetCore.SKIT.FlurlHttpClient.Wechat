namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/knowledge/list_intent 接口的响应。</para>
    /// </summary>
    public class CgibinKfKnowledgeListIntentResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Intent
            {
                public static class Types
                {
                    public class Text
                    {
                        /// <summary>
                        /// 获取或设置文本内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;
                    }

                    public class Attachment
                    {
                        public static class Types
                        {
                            public class Image
                            {
                                /// <summary>
                                /// 获取或设置图片文件名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;
                            }

                            public class Link
                            {
                                /// <summary>
                                /// 获取或设置图文消息标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置图文消息描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("desc")]
                                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                                public string? Description { get; set; }

                                /// <summary>
                                /// 获取或设置图文消息 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("url")]
                                [System.Text.Json.Serialization.JsonPropertyName("url")]
                                public string Url { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置图文消息封面 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pic_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("pic_url")]
                                public string? PictureUrl { get; set; }
                            }

                            public class Video
                            {
                                /// <summary>
                                /// 获取或设置视频文件名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;
                            }

                            public class MiniProgram
                            {
                                /// <summary>
                                /// 获取或设置小程序 AppId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                                public string AppId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置小程序页面路径。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pagepath")]
                                [System.Text.Json.Serialization.JsonPropertyName("pagepath")]
                                public string PagePath { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置小程序标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string? Title { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置附件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msgtype")]
                        [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置图片附件信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image")]
                        [System.Text.Json.Serialization.JsonPropertyName("image")]
                        public Types.Image? Image { get; set; }

                        /// <summary>
                        /// 获取或设置图文消息附件信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("link")]
                        [System.Text.Json.Serialization.JsonPropertyName("link")]
                        public Types.Link? Link { get; set; }

                        /// <summary>
                        /// 获取或设置视频附件信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video")]
                        [System.Text.Json.Serialization.JsonPropertyName("video")]
                        public Types.Video? Video { get; set; }

                        /// <summary>
                        /// 获取或设置小程序附件信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("miniprogram")]
                        [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
                        public Types.MiniProgram? MiniProgram { get; set; }
                    }

                    public class Question
                    {
                        /// <summary>
                        /// 获取或设置主问题文本信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public Text Text { get; set; } = default!;
                    }

                    public class SimilarQuestionList
                    {
                        /// <summary>
                        /// 获取或设置相似问题列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("items")]
                        [System.Text.Json.Serialization.JsonPropertyName("items")]
                        public SimilarQuestionItem[] Items { get; set; } = default!;
                    }

                    public class SimilarQuestionItem
                    {
                        /// <summary>
                        /// 获取或设置相似问题文本信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public Text Text { get; set; } = default!;
                    }

                    public class Answer
                    {
                        /// <summary>
                        /// 获取或设置回答文本信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public Text Text { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置附件列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attachments")]
                        [System.Text.Json.Serialization.JsonPropertyName("attachments")]
                        public Attachment[] AttachmentList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置分组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_id")]
                [System.Text.Json.Serialization.JsonPropertyName("group_id")]
                public string GroupId { get; set; } = default!;

                /// <summary>
                /// 获取或设置问答 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("intent_id")]
                [System.Text.Json.Serialization.JsonPropertyName("intent_id")]
                public string IntentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置主问题信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("question")]
                [System.Text.Json.Serialization.JsonPropertyName("question")]
                public Types.Question Question { get; set; } = default!;

                /// <summary>
                /// 获取或设置相似问题列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("similar_questions")]
                [System.Text.Json.Serialization.JsonPropertyName("similar_questions")]
                public Types.SimilarQuestionList? SimilarQuestionList { get; set; }

                /// <summary>
                /// 获取或设置回答列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("answers")]
                [System.Text.Json.Serialization.JsonPropertyName("answers")]
                public Types.Answer[] AnswerList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置问答列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intent_list")]
        [System.Text.Json.Serialization.JsonPropertyName("intent_list")]
        public Types.Intent[] IntentList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
