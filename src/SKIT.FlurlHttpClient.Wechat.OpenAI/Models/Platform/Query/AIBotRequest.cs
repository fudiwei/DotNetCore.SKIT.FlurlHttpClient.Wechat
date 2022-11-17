using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.Platform
{
    /// <summary>
    /// <para>表示 [POST] /aibot/{TOKEN} 接口的请求。</para>
    /// </summary>
    [XmlRoot("xml")]
    public class AIBotRequest : WechatOpenAIPlatformRequest
    {
        /// <summary>
        /// 获取或设置请求签名。
        /// </summary>
        [XmlElement("signature")]
        [JsonPropertyName("signature")]
        public string Signature { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置询问语句。
        /// </summary>
        [XmlElement("query")]
        [JsonPropertyName("query")]
        public string QueryString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境。
        /// </summary>
        [XmlElement("env", IsNullable = true)]
        [JsonPropertyName("env")]
        public string? Environment { get; set; }
    }
}
