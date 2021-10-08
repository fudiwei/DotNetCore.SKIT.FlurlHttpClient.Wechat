using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/intent/config/get 接口的请求。</para>
    /// </summary>
    public class IntentConfigGetRequest : WechatOpenAIRequest
    {
        /// <summary>
        /// 获取或设置意图 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("intent_id")]
        public long IntentId { get; set; }

        /// <summary>
        /// 获取或设置技能 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        public long SkillId { get; set; }
    }
}
