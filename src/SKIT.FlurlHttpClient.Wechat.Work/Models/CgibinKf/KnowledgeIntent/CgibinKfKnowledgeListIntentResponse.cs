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
                    public class Text : CgibinKfKnowledgeAddIntentRequest.Types.Text
                    {
                    }

                    public class Attachment : CgibinKfKnowledgeAddIntentRequest.Types.__zz__Attachment
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
                                public string? Name { get; set; }
                            }

                            public class Link : CgibinKfKnowledgeAddIntentRequest.Types.Attachment.Types.Link
                            {
                            }

                            public class Video
                            {
                                /// <summary>
                                /// 获取或设置视频文件名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string? Name { get; set; }
                            }

                            public class MiniProgram : CgibinKfKnowledgeAddIntentRequest.Types.Attachment.Types.MiniProgram
                            {
                            }
                        }

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
                        public Text? Text { get; set; }
                    }

                    public class SimilarQuestionList
                    {
                        /// <summary>
                        /// 获取或设置相似问题列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("items")]
                        [System.Text.Json.Serialization.JsonPropertyName("items")]
                        public List<SimilarQuestionItem>? Items { get; set; }
                    }

                    public class SimilarQuestionItem
                    {
                        /// <summary>
                        /// 获取或设置相似问题文本信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public Text? Text { get; set; }
                    }

                    public class Answer
                    {
                        /// <summary>
                        /// 获取或设置回答文本信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public Text? Text { get; set; }

                        /// <summary>
                        /// 获取或设置附件列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attachments")]
                        [System.Text.Json.Serialization.JsonPropertyName("attachments")]
                        public List<Attachment>? AttachmentList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置分组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_id")]
                [System.Text.Json.Serialization.JsonPropertyName("group_id")]
                public string? GroupId { get; set; }

                /// <summary>
                /// 获取或设置问答 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("intent_id")]
                [System.Text.Json.Serialization.JsonPropertyName("intent_id")]
                public string? IntentId { get; set; }

                /// <summary>
                /// 获取或设置主问题信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("question")]
                [System.Text.Json.Serialization.JsonPropertyName("question")]
                public Types.Question? Question { get; set; }

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
                public List<Types.Answer>? AnswerList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置问答列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intent_list")]
        [System.Text.Json.Serialization.JsonPropertyName("intent_list")]
        public List<Types.Intent>? IntentList { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
