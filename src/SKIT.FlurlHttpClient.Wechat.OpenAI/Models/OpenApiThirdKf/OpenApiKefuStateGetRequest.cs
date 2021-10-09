using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/kefustate/get/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class OpenApiKefuStateGetRequest : WechatOpenAIRequestEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [XmlElement("openid")]
        public string OpenId { get; set; } = string.Empty;
    }
}
