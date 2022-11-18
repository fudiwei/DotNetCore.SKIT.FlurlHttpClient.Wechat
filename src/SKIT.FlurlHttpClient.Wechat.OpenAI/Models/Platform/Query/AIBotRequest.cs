using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /aibot/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class AIBotRequest : WechatOpenAIPlatformRequest
    {
        /// <summary>
        /// 获取或设置请求签名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signature")]
        [System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string Signature { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置询问语句。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query")]
        [System.Text.Json.Serialization.JsonPropertyName("query")]
        public string QueryString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string? Environment { get; set; }

        /// <summary>
        /// 获取或设置第一优先级的限定技能命中范围列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_priority_skills")]
        [System.Text.Json.Serialization.JsonPropertyName("first_priority_skills")]
        public IList<string>? FirstPrioritySkillList { get; set; }

        /// <summary>
        /// 获取或设置第二优先级的限定技能命中范围列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("second_priority_skills")]
        [System.Text.Json.Serialization.JsonPropertyName("second_priority_skills")]
        public IList<string>? SecondPrioritySkillList { get; set; }
    }
}
