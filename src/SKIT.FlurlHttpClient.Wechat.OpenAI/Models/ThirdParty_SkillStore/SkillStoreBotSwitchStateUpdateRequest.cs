using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/skill_store/bot_switch_state/update 接口的请求。</para>
    /// </summary>
    public class SkillStoreBotSwitchStateUpdateRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置技能 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        public string SkillId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置要开启技能开关的机器人 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("on_bot_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("on_bot_id_list")]
        public IList<string> OnBotIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置要关闭技能开关的机器人 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("off_bot_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("off_bot_id_list")]
        public IList<string> OffBotIdList { get; set; } = new List<string>();
    }
}
