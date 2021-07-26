using System;
using System.IO;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    /// <summary>
    /// 为 <see cref="WechatWorkClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static class WechatWorkClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="WechatWorkEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this WechatWorkClient client, string callbackJson)
            where TEvent : WechatWorkEvent, WechatWorkEvent.Types.IJsonSerializable, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackJson)) throw new ArgumentNullException(callbackJson);

            return client.JsonSerializer.Deserialize<TEvent>(callbackJson);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatWorkEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromXml<TEvent>(this WechatWorkClient client, string callbackXml)
            where TEvent : WechatWorkEvent, WechatWorkEvent.Types.IXmlSerializable, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackXml)) throw new ArgumentNullException(callbackXml);

            using StringReader reader = new StringReader(callbackXml);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(TEvent), new XmlRootAttribute("xml"));
            return (TEvent)xmlSerializer.Deserialize(reader);
        }
    }
}
