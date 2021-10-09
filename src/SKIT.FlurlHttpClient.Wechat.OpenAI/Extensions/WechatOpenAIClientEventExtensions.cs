using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 为 <see cref="WechatOpenAIClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static class WechatOpenAIClientEventExtensions
    {
        private class EncryptedWechatOpenAIEvent
        {
            [Newtonsoft.Json.JsonProperty("Encrypt")]
            [System.Text.Json.Serialization.JsonPropertyName("Encrypt")]
            public string EncryptedData { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("TimeStamp")]
            [System.Text.Json.Serialization.JsonPropertyName("TimeStamp")]
            [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
            public string Timestamp { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("Nonce")]
            [System.Text.Json.Serialization.JsonPropertyName("Nonce")]
            public string Nonce { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("MsgSignature")]
            [System.Text.Json.Serialization.JsonPropertyName("MsgSignature")]
            public string Signature { get; set; } = default!;
        }

        private static TEvent InnerDeserializeEventFromXml<TEvent>(this WechatOpenAIClient client, string callbackXml)
            where TEvent : WechatOpenAIEvent
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackXml)) throw new ArgumentNullException(callbackXml);

            try
            {
                if (!Utilities.WxBizMsgCryptor.TryParseXml(callbackXml, out string? encryptedXml))
                    throw new Exceptions.WechatOpenAIEventSerializationException("Encrypt event failed, because of empty encrypted data.");

                callbackXml = Utilities.WxBizMsgCryptor.AESDecrypt(cipherText: encryptedXml!, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);

                using var reader = new StringReader(callbackXml);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(TEvent), new XmlRootAttribute("xml"));
                return (TEvent)xmlSerializer.Deserialize(reader)!;
            }
            catch (WechatOpenAIException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatOpenAIEventSerializationException("Deserialize event failed. Please see the `InnerException` for more details.", ex);
            }
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatOpenAIEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromXml<TEvent>(this WechatOpenAIClient client, string callbackXml)
            where TEvent : WechatOpenAIEvent, WechatOpenAIEvent.Serialization.IXmlSerializable, new()
        {
            return InnerDeserializeEventFromXml<TEvent>(client, callbackXml);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatOpenAIEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static WechatOpenAIEvent DeserializeEventFromXml(this WechatOpenAIClient client, string callbackXml)
        {
            return InnerDeserializeEventFromXml<WechatOpenAIEvent>(client, callbackXml);
        }

        /// <summary>
        /// 将 <see cref="WechatOpenAIEvent"/> 对象序列化成 XML。
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackModel"></param>
        /// <returns></returns>
        public static string SerializeEventToXml<TEvent>(this WechatOpenAIClient client, TEvent callbackModel)
            where TEvent : WechatOpenAIEvent, WechatOpenAIEvent.Serialization.IXmlSerializable, new()
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
            catch (Exception ex)
            {
                throw new Exceptions.WechatOpenAIEventSerializationException("Serialize event failed. Please see the `InnerException` for more details.", ex);
            }


            if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                throw new Exceptions.WechatOpenAIEventSerializationException("Encrypt event failed, because there is no encoding AES key.");
            if (string.IsNullOrEmpty(client.Credentials.PushToken))
                throw new Exceptions.WechatOpenAIEventSerializationException("Encrypt event failed, because there is no token.");

            try
            {
                string cipher = Utilities.WxBizMsgCryptor.AESEncrypt(
                    plainText: xml,
                    encodingAESKey: client.Credentials.PushEncodingAESKey!,
                    appId: client.Credentials.AppId!
                );

                xml = Utilities.WxBizMsgCryptor.WrapXml(sToken: client.Credentials.PushToken!, sMsgEncrypt: cipher);
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatOpenAIEventSerializationException("Encrypt event failed. Please see the `InnerException` for more details.", ex);
            }

            return xml;
        }
    }
}
