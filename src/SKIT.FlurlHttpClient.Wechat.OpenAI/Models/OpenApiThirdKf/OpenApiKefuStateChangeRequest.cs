using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/kefustate/change/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class OpenApiKefuStateChangeRequest : WechatOpenAIRequestEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [XmlElement("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置客服接入状态。
        /// </summary>
        [XmlElement("kefustate")]
        public string State { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置有效期（单位：秒）。
        /// <para>默认值：1800</para>
        /// </summary>
        [XmlElement("expires")]
        public int ExpiresIn { get; set; } = 1800;
    }
}
