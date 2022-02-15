﻿using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /unbindmp/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class UnbindMpRequest : WechatOpenAIPlatformRequest, WechatOpenAIPlatformRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [XmlElement("authorizer_appid")]
        public string AuthorizerAppId { get; set; } = string.Empty;
    }
}
