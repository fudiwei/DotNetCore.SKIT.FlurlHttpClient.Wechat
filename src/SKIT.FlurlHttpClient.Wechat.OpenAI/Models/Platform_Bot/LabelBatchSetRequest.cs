using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /label/batchset/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class LabelBatchSetRequest : WechatOpenAIPlatformRequest, WechatOpenAIPlatformRequest.Serialization.IEncryptedXmlable
    {
        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [XmlElement("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置标签名称。
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置二级标签名称。
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置标签分类规则。
        /// </summary>
        [XmlElement("desc")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置要设置标签的 OpenId 列表。
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("openid", Type = typeof(string))]
        public List<string> OpenIdList { get; set; } = new List<string>();
    }
}
