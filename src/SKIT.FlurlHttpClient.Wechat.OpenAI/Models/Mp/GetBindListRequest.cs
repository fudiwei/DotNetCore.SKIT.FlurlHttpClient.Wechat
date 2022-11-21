using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /getbindlist/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class GetBindListRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedXmlable
    {
    }
}
