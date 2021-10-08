using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/intent/question/save 接口的请求。</para>
    /// </summary>
    public class IntentQuestionSaveRequest : WechatOpenAIRequest
    {
        public static class Types
        {
            public class Question
            {
                /// <summary>
                /// 获取或设置问题 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long QuestionId { get; set; }

                /// <summary>
                /// 获取或设置问题内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("question")]
                [System.Text.Json.Serialization.JsonPropertyName("question")]
                public string Content { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置优先级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rank_level")]
                [System.Text.Json.Serialization.JsonPropertyName("rank_level")]
                public double RankLevel { get; set; }

                /// <summary>
                /// 获取或设置相似度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("threshold")]
                [System.Text.Json.Serialization.JsonPropertyName("threshold")]
                public double Threshold { get; set; }

                /// <summary>
                /// 获取或设置是否为反例。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("counter_example")]
                [System.Text.Json.Serialization.JsonPropertyName("counter_example")]
                public bool IsCounterExample { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置保存模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mode")]
        [System.Text.Json.Serialization.JsonPropertyName("mode")]
        public int Mode { get; set; }

        /// <summary>
        /// 获取或设置意图 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("intent_id")]
        public long IntentId { get; set; }

        /// <summary>
        /// 获取或设置意图名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intent_name")]
        [System.Text.Json.Serialization.JsonPropertyName("intent_name")]
        public string? IntentName { get; set; }

        /// <summary>
        /// 获取或设置技能 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        public long SkillId { get; set; }

        /// <summary>
        /// 获取或设置技能名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skill_name")]
        [System.Text.Json.Serialization.JsonPropertyName("skill_name")]
        public string? SkillName { get; set; }

        /// <summary>
        /// 获取或设置意图问题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public IList<Types.Question> IntentQuestionList { get; set; } = new List<Types.Question>();
    }
}
