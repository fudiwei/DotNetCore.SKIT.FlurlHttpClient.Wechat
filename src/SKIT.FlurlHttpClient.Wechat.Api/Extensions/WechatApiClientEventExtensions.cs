using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    /// <summary>
    /// 为 <see cref="WechatApiClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static class WechatApiClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="WechatApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this WechatApiClient client, string callbackJson)
            where TEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackJson)) throw new ArgumentNullException(callbackJson);

            try
            {
                return client.JsonSerializer.Deserialize<TEvent>(callbackJson);
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatApiEventSerializationException("Deserialize event failed. Please see the `InnerException` for more details.", ex);
            }
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromXml<TEvent>(this WechatApiClient client, string callbackXml)
            where TEvent : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackXml)) throw new ArgumentNullException(callbackXml);

            try
            {
                using var reader = new StringReader(callbackXml);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(TEvent), new XmlRootAttribute("xml"));
                return (TEvent)xmlSerializer.Deserialize(reader);
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatApiEventSerializationException("Deserialize event failed. Please see the `InnerException` for more details.", ex);
            }
        }

        /// <summary>
        /// 将 <see cref="WechatApiEvent"/> 对象序列化成 JSON。
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackModel"></param>
        /// <param name="safety">是否是安全模式。</param>
        /// <returns></returns>
        public static string SerializeEventToJson<TEvent>(this WechatApiClient client, TEvent callbackModel, bool safety = false)
            where TEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable, new()
        {
            string json;

            try
            {
                json = client.JsonSerializer.Serialize(callbackModel);
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatApiEventSerializationException("Serialize event failed. Please see the `InnerException` for more details.", ex);
            }

            if (safety)
            {
                if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                    throw new Exceptions.WechatApiEventSerializationException ("Encrypt event failed, because of there is no encoding AES key.");
                if (string.IsNullOrEmpty(client.Credentials.PushToken))
                    throw new Exceptions.WechatApiEventSerializationException("Encrypt event failed, because of there is no token.");

                try
                {
                    string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
                    string nonce = DateTimeOffset.Now.Ticks.ToString("x");
                    string cipher = Utilities.WxBizMsgCryptor.AESEncrypt(
                        plainText: json,
                        encodingAESKey: client.Credentials.PushEncodingAESKey!,
                        appId: client.Credentials.AppId
                    );
                    string sign = Utilities.WxBizMsgCryptor.GenerateSignature(
                        sToken: client.Credentials.PushToken!,
                        sTimestamp: timestamp,
                        sNonce: nonce,
                        sMsgEncrypt: cipher
                    );

                    json = client.JsonSerializer.Serialize(new Dictionary<string, string>()
                    {
                        { "Encrypt", cipher },
                        { "TimeStamp", timestamp },
                        { "Nonce", nonce },
                        { "MsgSignature", sign }
                    });
                }
                catch (Exception ex)
                {
                    throw new Exceptions.WechatApiEventSerializationException("Encrypt event failed. Please see the `InnerException` for more details.", ex);
                }
            }

            return json;
        }

        /// <summary>
        /// 将 <see cref="WechatApiEvent"/> 对象序列化成 XML。
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackModel"></param>
        /// <param name="safety">是否是安全模式。</param>
        /// <returns></returns>
        public static string SerializeEventToXml<TEvent>(this WechatApiClient client, TEvent callbackModel, bool safety = false)
            where TEvent : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable, new()
        {
            string xml;

            try
            {
                using var stream = new MemoryStream();
                using var writer = new System.Xml.XmlTextWriter(stream, Encoding.UTF8);
                writer.Formatting = System.Xml.Formatting.None;

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(TEvent), new XmlRootAttribute("xml"));
                XmlSerializerNamespaces xmlNamespace = new XmlSerializerNamespaces();
                xmlNamespace.Add(string.Empty, string.Empty);
                xmlSerializer.Serialize(writer, callbackModel, xmlNamespace);
                writer.Flush();
                xml = Encoding.UTF8.GetString(stream.ToArray());
                xml = Regex.Replace(xml, "\\s+<\\w+ (xsi|d2p1):nil=\"true\"[^>]*/>", string.Empty, RegexOptions.IgnoreCase);
                xml = Regex.Replace(xml, "<\\?xml[^>]*\\?>", string.Empty, RegexOptions.IgnoreCase);
            }
            catch (System.Xml.XmlException ex)
            {
                throw new Exceptions.WechatApiEventSerializationException("Serialize event failed. Please see the `InnerException` for more details.", ex);
            }

            if (safety)
            {
                if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                    throw new Exceptions.WechatApiEventSerializationException("Encrypt event failed, because of there is no encoding AES key.");
                if (string.IsNullOrEmpty(client.Credentials.PushToken))
                    throw new Exceptions.WechatApiEventSerializationException("Encrypt event failed, because of there is no token.");

                try
                {
                    string cipher = Utilities.WxBizMsgCryptor.AESEncrypt(
                        plainText: xml,
                        encodingAESKey: client.Credentials.PushEncodingAESKey!,
                        appId: client.Credentials.AppId
                    );

                    xml = Utilities.WxBizMsgCryptor.WrapXml(sToken: client.Credentials.PushToken!, sMsgEncrypt: cipher);
                }
                catch (Exception ex)
                {
                    throw new Exceptions.WechatApiEventSerializationException("Encrypt event failed. Please see the `InnerException` for more details.", ex);
                }
            }

            return xml;
        }
    }
}
