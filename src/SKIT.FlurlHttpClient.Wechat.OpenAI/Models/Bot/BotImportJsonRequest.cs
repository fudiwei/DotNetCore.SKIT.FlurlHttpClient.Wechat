using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/bot/import/json 接口的请求。</para>
    /// </summary>
    public class BotImportJsonRequest : WechatOpenAIRequest
    {
        public static class Types
        {
            public class Intent
            {
                /// <summary>
                /// 获取或设置技能名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skill")]
                [System.Text.Json.Serialization.JsonPropertyName("skill")]
                public string SkillName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置原来意图名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("old_intent")]
                [System.Text.Json.Serialization.JsonPropertyName("old_intent")]
                public string? OldIntentName { get; set; }

                /// <summary>
                /// 获取或设置意图名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("intent")]
                [System.Text.Json.Serialization.JsonPropertyName("intent")]
                public string IntentName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置相似度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("threshold")]
                [System.Text.Json.Serialization.JsonPropertyName("threshold")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                public double Threshold { get; set; }

                /// <summary>
                /// 获取或设置是否禁用。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("disable")]
                [System.Text.Json.Serialization.JsonPropertyName("disable")]
                public bool IsDisabled { get; set; }

                /// <summary>
                /// 获取或设置问题列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("questions")]
                [System.Text.Json.Serialization.JsonPropertyName("questions")]
                public IList<string> QuestionList { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置回答列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("answers")]
                [System.Text.Json.Serialization.JsonPropertyName("answers")]
                public IList<string> AnswerList { get; set; } = new List<string>();
            }
        }

        /// <summary>
        /// 获取或设置意图列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public IList<Types.Intent> IntentList { get; set; } = new List<Types.Intent>();

        /// <summary>
        /// 获取或设置导入模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mode")]
        [System.Text.Json.Serialization.JsonPropertyName("mode")]
        public int Mode { get; set; }
    }
}
