using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/intent/name_exist 接口的请求。</para>
    /// </summary>
    public class IntentNameExistRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置技能 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        public long SkillId { get; set; }

        /// <summary>
        /// 获取或设置意图名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intent_name")]
        [System.Text.Json.Serialization.JsonPropertyName("intent_name")]
        public string IntentName { get; set; } = string.Empty;
    }
}
