using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /getbindlink/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class GetBindLinkRequest : WechatOpenAIPlatformRequest, WechatOpenAIPlatformRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置直播 ID。
        /// </summary>
        [XmlElement("redirectlink")]
        public string RedirectLink { get; set; } = string.Empty;
    }
}
