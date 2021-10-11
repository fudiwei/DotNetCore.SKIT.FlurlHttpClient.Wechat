using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/aibot/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class OpenApiAIBotRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置请求签名。
        /// </summary>
        [XmlElement("signature")]
        public string Signature { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置询问语句。
        /// </summary>
        [XmlElement("query")]
        public string QueryString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境。
        /// </summary>
        [XmlElement("env", IsNullable = true)]
        public string? Environment { get; set; }
    }
}
