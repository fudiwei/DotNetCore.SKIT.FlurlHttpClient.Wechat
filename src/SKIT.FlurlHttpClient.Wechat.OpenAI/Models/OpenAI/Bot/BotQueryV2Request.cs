using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/bot/query 接口的请求。</para>
    /// </summary>
    public class BotQueryV2Request : WechatOpenAIRequest
    {
        /// <summary>
        /// 获取或设置查询语句。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query")]
        [System.Text.Json.Serialization.JsonPropertyName("query")]
        public string QueryString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置查询环境。
        /// <para>默认值："online"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string Environment { get; set; } = "online";

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

        /// <summary>
        /// 获取或设置用户标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string? UserId { get; set; }

        /// <summary>
        /// 获取或设置用户昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("user_name")]
        public string? UserName { get; set; }

        /// <summary>
        /// 获取或设置用户头像 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avatar")]
        [System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? AvatarUrl { get; set; }
    }
}
