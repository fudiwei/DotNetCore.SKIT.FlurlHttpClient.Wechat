using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/setautoreply/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class OpenApiBatchSetAutoReplyRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置管理员 ID。
        /// </summary>
        [XmlElement("managerid")]
        public string ManagerId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置技能名称。
        /// </summary>
        [XmlElement("skillname")]
        public string SkillName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置标准问题。
        /// </summary>
        [XmlElement("title", IsNullable = true)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置自动回答的内容。
        /// </summary>
        [XmlElement("content", IsNullable = true)]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置要设置的相似问题列表。
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("question", Type = typeof(string))]
        public List<string> QuestionId { get; set; } = new List<string>();
    }
}
