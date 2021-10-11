using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/intent/search 接口的响应。</para>
    /// </summary>
    public class IntentSearchResponse : WechatOpenAIThirdPartyResponse<IntentSearchResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Intent
                    {
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
                        public string IntentName { get; set; } = default!;

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
                        public string SkillName { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置意图列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Intent[] IntentList { get; set; } = default!;

                /// <summary>
                /// 获取或设置意图总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int TotalCount { get; set; }
            }
        }
    }
}
