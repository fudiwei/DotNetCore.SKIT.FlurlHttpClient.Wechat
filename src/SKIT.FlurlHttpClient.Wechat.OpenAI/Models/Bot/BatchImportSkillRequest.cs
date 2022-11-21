using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /batchimportskill/{TOKEN} 接口的请求。</para>
    /// </summary>
    public class BatchImportSkillRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedXmlable
    {
        public static class Types
        {
            public class Skill
            {
                /// <summary>
                /// 获取或设置技能名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skillname")]
                [System.Text.Json.Serialization.JsonPropertyName("skillname")]
                public string SkillName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置标准问题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置相似问题列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("question")]
                [System.Text.Json.Serialization.JsonPropertyName("question")]
                public IList<string> QuestionList { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置机器人回答列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("answer")]
                [System.Text.Json.Serialization.JsonPropertyName("answer")]
                public IList<string> AnswerList { get; set; } = new List<string>();
            }
        }

        /// <summary>
        /// 获取或设置管理员 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("managerid")]
        [System.Text.Json.Serialization.JsonPropertyName("managerid")]
        public string ManagetId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置技能列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skill")]
        [System.Text.Json.Serialization.JsonPropertyName("skill")]
        public IList<Types.Skill> SkillList { get; set; } = new List<Types.Skill>();
    }
}
