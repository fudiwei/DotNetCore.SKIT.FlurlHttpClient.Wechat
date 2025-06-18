using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/knowledge/mod_intent 接口的请求。</para>
    /// </summary>
    public class CgibinKfKnowledgeModifyIntentRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Text : CgibinKfKnowledgeAddIntentRequest.Types.Text
            {
            }

            public class Attachment : CgibinKfKnowledgeAddIntentRequest.Types.Attachment
            {
                public new static class Types
                {
                    public class Image : CgibinKfKnowledgeAddIntentRequest.Types.Attachment.Types.Image
                    {
                    }

                    public class Link : CgibinKfKnowledgeAddIntentRequest.Types.Attachment.Types.Link
                    {
                    }

                    public class Video : CgibinKfKnowledgeAddIntentRequest.Types.Attachment.Types.Video
                    {
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
                public new Types.Image? Image { get; set; }

                /// <summary>
                /// 获取或设置图文消息附件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("link")]
                [System.Text.Json.Serialization.JsonPropertyName("link")]
                public new Types.Link? Link { get; set; }

                /// <summary>
                /// 获取或设置视频附件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video")]
                [System.Text.Json.Serialization.JsonPropertyName("video")]
                public new Types.Video? Video { get; set; }

                /// <summary>
                /// 获取或设置小程序附件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("miniprogram")]
                [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
                public new Types.MiniProgram? MiniProgram { get; set; }
            }

            public class Question : CgibinKfKnowledgeAddIntentRequest.Types.Question
            {
                /// <summary>
                /// 获取或设置主问题文本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public new Text? Text { get; set; }
            }

            public class SimilarQuestionList : CgibinKfKnowledgeAddIntentRequest.Types.SimilarQuestionList
            {
                /// <summary>
                /// 获取或设置相似问题列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public new IList<SimilarQuestionItem> Items { get; set; } = new List<SimilarQuestionItem>();
            }

            public class SimilarQuestionItem : CgibinKfKnowledgeAddIntentRequest.Types.SimilarQuestionItem
            {
                /// <summary>
                /// 获取或设置相似问题文本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public new Text? Text { get; set; }
            }

            public class Answer : CgibinKfKnowledgeAddIntentRequest.Types.Answer
            {
                /// <summary>
                /// 获取或设置回答文本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public new Text? Text { get; set; }

                /// <summary>
                /// 获取或设置附件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attachments")]
                [System.Text.Json.Serialization.JsonPropertyName("attachments")]
                public new IList<Attachment>? AttachmentList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置问答 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("intent_id")]
        public string IntentId { get; set; } = string.Empty;

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
        public IList<Types.Answer>? AnswerList { get; set; }
    }
}
