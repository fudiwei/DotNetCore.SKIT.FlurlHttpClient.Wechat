﻿using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /sign/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class SignRequest : WechatOpenAIPlatformRequest, WechatOpenAIPlatformRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置用户 ID。
        /// </summary>
        [XmlElement("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户昵称。
        /// </summary>
        [XmlElement("username")]
        public string Nickname { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户头像 URL。
        /// </summary>
        [XmlElement("avatar", IsNullable = true)]
        public string? AvatarUrl { get; set; }
    }
}
