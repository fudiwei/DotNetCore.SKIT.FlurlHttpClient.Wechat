using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/sendmsg/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class OpenApiSendMessageRequest : WechatOpenAIRequestEncryptedXmlable
    {        
        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [XmlElement("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置消息内容。
        /// </summary>
        [XmlElement("msg")]
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置渠道。
        /// </summary>
        [XmlElement("channel")]
        public int Channel { get; set; }

        /// <summary>
        /// 获取或设置事件。
        /// </summary>
        [XmlElement("event", IsNullable = true)]
        public string? Event { get; set; }

        /// <summary>
        /// 获取或设置客服人员的昵称。
        /// </summary>
        [XmlElement("kefuname", IsNullable = true)]
        public string? KfName { get; set; }

        /// <summary>
        /// 获取或设置客服人员的头像 URL。
        /// </summary>
        [XmlElement("kefuavatar", IsNullable = true)]
        public string? KfAvatarUrl { get; set; }
    }
}
