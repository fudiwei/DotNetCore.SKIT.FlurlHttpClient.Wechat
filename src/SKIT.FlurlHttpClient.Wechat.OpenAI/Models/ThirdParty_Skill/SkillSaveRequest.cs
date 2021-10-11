using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/skill/save 接口的请求。</para>
    /// </summary>
    public class SkillSaveRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置技能 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? SkillId { get; set; }

        /// <summary>
        /// 获取或设置技能名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        
        /// <summary>
        /// 获取或设置技能类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? SkillType { get; set; }

        /// <summary>
        /// 获取或设置场景存活的最大轮数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_round")]
        [System.Text.Json.Serialization.JsonPropertyName("max_round")]
        public int? MaxRound { get; set; }

        /// <summary>
        /// 获取或设置唤醒开关。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wake_open")]
        [System.Text.Json.Serialization.JsonPropertyName("wake_open")]
        public bool? WakeSwitch { get; set; }

        /// <summary>
        /// 获取或设置唤醒热词。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("awaken_word")]
        [System.Text.Json.Serialization.JsonPropertyName("awaken_word")]
        public string? AwakeWord { get; set; }

        /// <summary>
        /// 获取或设置唤醒的回复语句列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("awaken_answer")]
        [System.Text.Json.Serialization.JsonPropertyName("awaken_answer")]
        public IList<string>? AwakeAnswerList { get; set; }

        /// <summary>
        /// 获取或设置退出热词。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exist_word")]
        [System.Text.Json.Serialization.JsonPropertyName("exist_word")]
        public string? ExistWord { get; set; }

        /// <summary>
        /// 获取或设置退出的回复语句列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exist_answer")]
        [System.Text.Json.Serialization.JsonPropertyName("exist_answer")]
        public IList<string>? ExitAnswerList { get; set; }

        /// <summary>
        /// 获取或设置取消意图操作。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_intent_operation")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_intent_operation")]
        public bool? CancelIntentOperation { get; set; }

        /// <summary>
        /// 获取或设置取消操作的回复列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_answer")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_answer")]
        public IList<string>? CancelAnswerList { get; set; }

        /// <summary>
        /// 获取或设置没有可取消意图时的回复列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("no_cancel_answer")]
        [System.Text.Json.Serialization.JsonPropertyName("no_cancel_answer")]
        public IList<string>? NoCancelAnswerList { get; set; }
    }
}
