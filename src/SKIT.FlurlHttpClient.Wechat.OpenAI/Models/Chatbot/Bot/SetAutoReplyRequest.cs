using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /setautoreply/{TOKEN} 接口的请求。</para>
    /// </summary>
    public class SetAutoReplyRequest : WechatChatbotRequest, WechatChatbotRequest.Serialization.IEncryptedXmlable
    {
        public static class Types
        {
            public class QuestionList
            {
                [Newtonsoft.Json.JsonProperty("question")]
                [System.Text.Json.Serialization.JsonPropertyName("question")]
                public IList<string> Items { get; set; } = new List<string>();
            }
        }

        /// <summary>
        /// 获取或设置管理员 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("managerid")]
        [System.Text.Json.Serialization.JsonPropertyName("managerid")]
        public string ManagetId { get; set; } = string.Empty;

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
        /// 获取或设置自动回答的内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置相似问题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.QuestionList QuestionList { get; set; } = new Types.QuestionList();
    }
}
