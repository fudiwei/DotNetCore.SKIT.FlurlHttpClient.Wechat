using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    /// <summary>
    /// 为 <see cref="WechatApiClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static class WechatApiClientEventExtensions
    {
        private class EncryptedWechatApiEvent
        {
            [Newtonsoft.Json.JsonProperty("Encrypt")]
            [System.Text.Json.Serialization.JsonPropertyName("Encrypt")]
            public string EncryptedData { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("TimeStamp")]
            [System.Text.Json.Serialization.JsonPropertyName("TimeStamp")]
            [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedStringConverter))]
            public string Timestamp { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("Nonce")]
            [System.Text.Json.Serialization.JsonPropertyName("Nonce")]
            public string Nonce { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("MsgSignature")]
            [System.Text.Json.Serialization.JsonPropertyName("MsgSignature")]
            public string Signature { get; set; } = default!;
        }

        private static TEvent InnerDeserializeEventFromJson<TEvent>(this WechatApiClient client, string callbackJson, bool safety)
            where TEvent : WechatApiEvent
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackJson)) throw new ArgumentNullException(callbackJson);

            try
            {
                if (safety)
                {
                    if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                        throw new Exceptions.WechatApiEventSerializationException("Encrypt event failed, because there is no encoding AES key.");

                    var encryptedEvent = client.JsonSerializer.Deserialize<EncryptedWechatApiEvent>(callbackJson);
                    if (string.IsNullOrEmpty(encryptedEvent.EncryptedData))
                        throw new Exceptions.WechatApiEventSerializationException("Encrypt event failed, because of empty encrypted data.");

                    callbackJson = Utilities.WxBizMsgCryptor.AESDecrypt(cipherText: encryptedEvent.EncryptedData, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                }

                return client.JsonSerializer.Deserialize<TEvent>(callbackJson);
            }
            catch (WechatApiException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatApiEventSerializationException("Deserialize event failed. Please see the `InnerException` for more details.", ex);
            }
        }

        private static TEvent InnerDeserializeEventFromXml<TEvent>(this WechatApiClient client, string callbackXml, bool safety)
            where TEvent : WechatApiEvent
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackXml)) throw new ArgumentNullException(callbackXml);

            try
            {
                if (safety)
                {
                    if (!Utilities.WxBizMsgCryptor.TryParseXml(callbackXml, out string? encryptedXml))
                        throw new Exceptions.WechatApiEventSerializationException("Encrypt event failed, because of empty encrypted data.");

                    callbackXml = Utilities.WxBizMsgCryptor.AESDecrypt(cipherText: encryptedXml!, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                }

                using var reader = new StringReader(callbackXml);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(TEvent), new XmlRootAttribute("xml"));
                return (TEvent)xmlSerializer.Deserialize(reader)!;
            }
            catch (WechatApiException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatApiEventSerializationException("Deserialize event failed. Please see the `InnerException` for more details.", ex);
            }
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="WechatApiEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <param name="safety">是否是安全模式（即是否需要解密）。</param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this WechatApiClient client, string callbackJson, bool safety = false)
            where TEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, callbackJson, safety);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="WechatApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <param name="safety">是否是安全模式（即是否需要解密）。</param>
        /// <returns></returns>
        public static WechatApiEvent DeserializeEventFromJson(this WechatApiClient client, string callbackJson, bool safety = false)
        {
            return InnerDeserializeEventFromJson<WechatApiEvent>(client, callbackJson, safety);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatApiEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <param name="safety">是否是安全模式（即是否需要解密）。</param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromXml<TEvent>(this WechatApiClient client, string callbackXml, bool safety = false)
            where TEvent : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable, new()
        {
            return InnerDeserializeEventFromXml<TEvent>(client, callbackXml, safety);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <param name="safety">是否是安全模式（即是否需要解密）。</param>
        /// <returns></returns>
        public static WechatApiEvent DeserializeEventFromXml(this WechatApiClient client, string callbackXml, bool safety = false)
        {
            return InnerDeserializeEventFromXml<WechatApiEvent>(client, callbackXml, safety);
        }

        /// <summary>
        /// 将 <see cref="WechatApiEvent"/> 对象序列化成 JSON。
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackModel"></param>
        /// <param name="safety">是否是安全模式（即是否需要加密）。</param>
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
                    throw new Exceptions.WechatApiEventSerializationException ("Encrypt event failed, because there is no encoding AES key.");
                if (string.IsNullOrEmpty(client.Credentials.PushToken))
                    throw new Exceptions.WechatApiEventSerializationException("Encrypt event failed, because there is no token.");

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

                    json = client.JsonSerializer.Serialize(new EncryptedWechatApiEvent()
                    {
                        EncryptedData = cipher,
                        Timestamp = timestamp,
                        Nonce = nonce,
                        Signature = sign
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
        /// <param name="safety">是否是安全模式（即是否需要加密）。</param>
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
            catch (Exception ex)
            {
                throw new Exceptions.WechatApiEventSerializationException("Serialize event failed. Please see the `InnerException` for more details.", ex);
            }

            if (safety)
            {
                if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                    throw new Exceptions.WechatApiEventSerializationException("Encrypt event failed, because there is no encoding AES key.");
                if (string.IsNullOrEmpty(client.Credentials.PushToken))
                    throw new Exceptions.WechatApiEventSerializationException("Encrypt event failed, because there is no token.");

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

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Basic_Information/Access_Overview.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">微信回调通知中的 timestamp 字段。</param>
        /// <param name="callbackNonce">微信回调通知中的 nonce 字段。</param>
        /// <param name="callbackSignature">微信回调通知中的 signature 字段。</param>
        /// <returns></returns>
        public static bool VerifyEventSignatureForEcho(this WechatApiClient client, string callbackTimestamp, string callbackNonce, string callbackSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackTimestamp == null) throw new ArgumentNullException(nameof(callbackTimestamp));
            if (callbackNonce == null) throw new ArgumentNullException(nameof(callbackNonce));
            if (callbackSignature == null) throw new ArgumentNullException(nameof(callbackSignature));

            ISet<string> set = new SortedSet<string>() { client.Credentials.PushToken!, callbackTimestamp, callbackNonce };
            string sign = Security.SHA1Utility.Hash(string.Concat(set));
            return string.Equals(sign, callbackSignature, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Message_encryption_and_decryption_instructions.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">微信回调通知中的 timestamp 字段。</param>
        /// <param name="callbackNonce">微信回调通知中的 nonce 字段。</param>
        /// <param name="callbackJson">微信回调通知中请求正文（JSON 格式）。</param>
        /// <param name="callbackSignature">微信回调通知中的 msg_signature 字段。</param>
        /// <returns></returns>
        public static bool VerifyEventSignatureFromJson(this WechatApiClient client, string callbackTimestamp, string callbackNonce, string callbackJson, string callbackSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackJson == null) throw new ArgumentNullException(nameof(callbackJson));

            try
            {
                var encryptedEvent = client.JsonSerializer.Deserialize<EncryptedWechatApiEvent>(callbackJson);
                return Utilities.WxBizMsgCryptor.VerifySignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: callbackTimestamp,
                    sNonce: callbackNonce,
                    sMsgEncrypt: encryptedEvent.EncryptedData,
                    sMsgSign: callbackSignature
                );
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Message_encryption_and_decryption_instructions.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">微信回调通知中的 timestamp 字段。</param>
        /// <param name="callbackNonce">微信回调通知中的 nonce 字段。</param>
        /// <param name="callbackXml">微信回调通知中请求正文（XML 格式）。</param>
        /// <param name="callbackSignature">微信回调通知中的 msg_signature 字段。</param>
        /// <returns></returns>
        public static bool VerifyEventSignatureFromXml(this WechatApiClient client, string callbackTimestamp, string callbackNonce, string callbackXml, string callbackSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackXml == null) throw new ArgumentNullException(nameof(callbackXml));

            try
            {
                XDocument xDoc = XDocument.Parse(callbackXml);
                string? msgEncrypt = xDoc.Root?.Element("Encrypt")?.Value;

                return Utilities.WxBizMsgCryptor.VerifySignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: callbackTimestamp,
                    sNonce: callbackNonce,
                    sMsgEncrypt: msgEncrypt!,
                    sMsgSign: callbackSignature
                );
            }
            catch
            {
                return false;
            }
        }
    }
}
