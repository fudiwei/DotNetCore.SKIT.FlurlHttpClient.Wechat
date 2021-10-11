using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/skill_store/get_list 接口的响应。</para>
    /// </summary>
    public class SkillStoreGetListResponse : WechatOpenAIThirdPartyResponse<SkillStoreGetListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Skill
                    {
                        public static class Types
                        {
                            public class Bot
                            {
                                /// <summary>
                                /// 获取或设置机器人总数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("count")]
                                [System.Text.Json.Serialization.JsonPropertyName("count")]
                                public int TotalCount { get; set; }

                                /// <summary>
                                /// 获取或设置开启的机器人数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("on_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("on_num")]
                                public int OnCount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置技能 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skill_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("skill_id")]
                        public string SkillId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置技能名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skill_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("skill_name")]
                        public string SkillName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置机器人名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bot_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("bot_name")]
                        public string BotName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否已获取。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("acquired")]
                        [System.Text.Json.Serialization.JsonPropertyName("acquired")]
                        public bool IsAcquired { get; set; }

                        /// <summary>
                        /// 获取或设置获取时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("acquired_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("acquired_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        public DateTimeOffset? AcquireTime { get; set; }

                        /// <summary>
                        /// 获取或设置机器人信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bot_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("bot_info")]
                        public Types.Bot Bot { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category")]
                        [System.Text.Json.Serialization.JsonPropertyName("category")]
                        public string Category { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置热度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hot")]
                        [System.Text.Json.Serialization.JsonPropertyName("hot")]
                        public int Hot { get; set; }

                        /// <summary>
                        /// 获取或设置话术举例列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("statement_case_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("statement_case_list")]
                        public string[] StatementCaseList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("state")]
                        [System.Text.Json.Serialization.JsonPropertyName("state")]
                        public int State { get; set; }

                        /// <summary>
                        /// 获取或设置技能开关。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("switch")]
                        [System.Text.Json.Serialization.JsonPropertyName("switch")]
                        public bool Switch { get; set; }

                        /// <summary>
                        /// 获取或设置修改时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset UpdateTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置技能列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Skill[] SkillList { get; set; } = default!;

                /// <summary>
                /// 获取或设置技能总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int TotalCount { get; set; }
            }
        }
    }
}
