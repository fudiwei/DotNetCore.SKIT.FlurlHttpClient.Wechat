using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/publish/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class OpenApiPublishRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置管理员 ID。
        /// </summary>
        [XmlElement("managerid")]
        public string ManagerId { get; set; } = string.Empty;
    }
}
