using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/intent/save 接口的请求。</para>
    /// </summary>
    public class IntentSaveRequest : WechatOpenAIThirdPartyRequest
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
                public long? IntentId { get; set; }

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
                public string Name { get; set; } = string.Empty;

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
            }
        }

        /// <summary>
        /// 获取或设置意图列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intent_list")]
        [System.Text.Json.Serialization.JsonPropertyName("intent_list")]
        public IList<Types.Intent> IntentList { get; set; } = new List<Types.Intent>();
    }
}
