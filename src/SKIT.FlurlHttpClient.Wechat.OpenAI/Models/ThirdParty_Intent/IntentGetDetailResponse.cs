using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/intent/get_detail 接口的响应。</para>
    /// </summary>
    public class IntentGetDetailResponse : WechatOpenAIThirdPartyResponse<IntentGetDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
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
                        public string Content { get; set; } = default!;

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
                /// 获取或设置意图 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long IntentId { get; set; }

                /// <summary>
                /// 获取或设置技能 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skill_id")]
                [System.Text.Json.Serialization.JsonPropertyName("skill_id")]
                public long SkillId { get; set; }

                /// <summary>
                /// 获取或设置意图名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

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
                /// 获取或设置意图开关。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("switch")]
                [System.Text.Json.Serialization.JsonPropertyName("switch")]
                public bool Switch { get; set; }

                /// <summary>
                /// 获取或设置命中次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("frequency")]
                [System.Text.Json.Serialization.JsonPropertyName("frequency")]
                public int Frequency { get; set; }

                /// <summary>
                /// 获取或设置意图问题列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("questions")]
                [System.Text.Json.Serialization.JsonPropertyName("questions")]
                public Types.Question[] QuestionList { get; set; } = default!;

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("updated_time")]
                [System.Text.Json.Serialization.JsonPropertyName("updated_time")]
                public long UpdateTimestamp { get; set; }
            }
        }
    }
}
