using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/skill/get_detail 接口的响应。</para>
    /// </summary>
    public class SkillGetDetailResponse : WechatOpenAIResponse<SkillGetDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Skill : SkillGetListResponse.Types.Data.Types.Skill
                    {
                        /// <summary>
                        /// 获取或设置技能开关。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("switch")]
                        [System.Text.Json.Serialization.JsonPropertyName("switch")]
                        public bool Switch { get; set; }
                    }

                    public class IntentItem
                    {
                        /// <summary>
                        /// 获取或设置意图 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public long IntentId { get; set; }

                        /// <summary>
                        /// 获取或设置意图名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置技能 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skill_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("skill_id")]
                        public long SkillId { get; set; }

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
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("created_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("created_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置修改时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("updated_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("updated_time")]
                        public long UpdateTimestamp { get; set; }
                    }

                    public class IntentList
                    {
                        /// <summary>
                        /// 获取或设置意图列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("list")]
                        [System.Text.Json.Serialization.JsonPropertyName("list")]
                        public IntentItem[] Items { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置意图数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        public int Count { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置技能信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skill")]
                [System.Text.Json.Serialization.JsonPropertyName("skill")]
                public Types.Skill Skill { get; set; } = default!;

                /// <summary>
                /// 获取或设置意图列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("intents")]
                [System.Text.Json.Serialization.JsonPropertyName("intents")]
                public Types.IntentList IntentList { get; set; } = default!;
            }
        }
    }
}
