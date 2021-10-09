using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/batchreply/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class OpenApiBatchReplyRequest : WechatOpenAIRequestEncryptedXmlable
    {        
        /// <summary>
        /// 获取或设置直播 ID。
        /// </summary>
        [XmlElement("liveid")]
        public string LiveId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回复内容。
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置希望展示给用户的客服人员的名字。
        /// </summary>
        [XmlElement("waitername", IsNullable = true)]
        public string? WaiterName { get; set; }

        /// <summary>
        /// 获取或设置客希望展示给用户的客服人员的头像 URL。
        /// </summary>
        [XmlElement("waiteravatar", IsNullable = true)]
        public string? WaiterAvatarUrl { get; set; }

        /// <summary>
        /// 获取或设置要设置标签的 OpenId 列表。
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("openid", Type = typeof(string))]
        public List<string> OpenIdList { get; set; } = new List<string>();
    }
}
