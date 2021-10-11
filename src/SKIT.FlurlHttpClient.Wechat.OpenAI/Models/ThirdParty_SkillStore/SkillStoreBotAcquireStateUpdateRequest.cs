using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/skill_store/bot_acquire_state/update 接口的请求。</para>
    /// </summary>
    public class SkillStoreBotAcquireStateUpdateRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置技能 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        public string SkillId { get; set; } = string.Empty;
    }
}
