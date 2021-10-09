using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/generatereport/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class OpenApiGenerateReportRequest : WechatOpenAIRequestEncryptedXmlable
    {        
        /// <summary>
        /// 获取或设置直播 ID。
        /// </summary>
        [XmlElement("liveid")]
        public string LiveId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置房间 ID。
        /// </summary>
        [XmlElement("bucket")]
        public string Bucket { get; set; } = string.Empty;
    }
}
