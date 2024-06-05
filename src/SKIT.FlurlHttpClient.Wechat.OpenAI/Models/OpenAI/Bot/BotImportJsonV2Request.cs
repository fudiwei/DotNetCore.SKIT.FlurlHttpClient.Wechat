using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/bot/import/json 接口的请求。</para>
    /// </summary>
    public class BotImportJsonV2Request : WechatOpenAIRequest
    {
        public static class Types
        {
            public class Skill
            {
                /// <summary>
                /// 获取或设置技能名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skill")]
                [System.Text.Json.Serialization.JsonPropertyName("skill")]
                public string SkillName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置原意图名称。
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
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("threshold")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberConverter))]
                public decimal Threshold { get; set; }

                /// <summary>
                /// 获取或设置是否关闭。
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
        /// 获取或设置导入模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mode")]
        [System.Text.Json.Serialization.JsonPropertyName("mode")]
        public int Mode { get; set; }

        /// <summary>
        /// 获取或设置技能列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public IList<Types.Skill> SkillList { get; set; } = new List<Types.Skill>();
    }
}
