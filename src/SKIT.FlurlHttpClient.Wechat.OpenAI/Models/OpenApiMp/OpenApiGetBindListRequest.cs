using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/getbindlist/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class OpenApiGetBindListRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedXmlable
    {
    }
}
