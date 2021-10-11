using System;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 表示微信智能对话平台接入 API 回调通知事件的基类。
    /// </summary>
    [Serializable]
    public class WechatOpenAIPlatformEvent
    {
        public static class Serialization
        {
            [XmlRoot("xml")]
            public interface IXmlSerializable
            {
            }
        }

        /// <summary>
        /// 获取或设置 AppId。
        /// </summary>
        [XmlElement("appid", IsNullable = true)]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [XmlElement("event", IsNullable = true)]
        public string? Event { get; set; }

        /// <summary>
        /// 获取或设置消息创建时间戳。
        /// </summary>
        [XmlElement("createtime", IsNullable = true)]
        public long? CreateTimestamp { get; set; }
    }
}
