﻿using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /kefustate/change/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class KefuStateChangeRequest : WechatOpenAIPlatformRequest, WechatOpenAIPlatformRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatOpenAIPlatformClient"/> 时的 <see cref="WechatOpenAIPlatformClientOptions.AppId"/> 参数。
        /// </summary>
        [XmlElement("appid")]
        public string? AppId { get; set; }

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
