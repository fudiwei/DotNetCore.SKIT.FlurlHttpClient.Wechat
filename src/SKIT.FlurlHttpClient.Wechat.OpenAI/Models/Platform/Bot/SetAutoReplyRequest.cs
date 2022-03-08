using System.Collections.Generic;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /setautoreply/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class SetAutoReplyRequest : WechatOpenAIPlatformRequest, WechatOpenAIPlatformRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置管理员 ID。
        /// </summary>
        [XmlElement("managerid")]
        public string ManagetId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置技能名称。
        /// </summary>
        [XmlElement("skillname")]
        public string SkillName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置标准问题。
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置自动回答的内容。
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置相似问题列表。
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("question", Type = typeof(string))]
        public List<string> QuestionList { get; set; } = new List<string>();
    }
}
