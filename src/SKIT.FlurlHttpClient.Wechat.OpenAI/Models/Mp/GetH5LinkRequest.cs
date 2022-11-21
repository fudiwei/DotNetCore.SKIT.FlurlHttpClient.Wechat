using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /geth5link/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class GetH5LinkRequest : WechatOpenAIRequest, WechatOpenAIRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置页面标题。
        /// </summary>
        [XmlElement("title", IsNullable = true)]
        public string? Title { get; set; }
    }
}
