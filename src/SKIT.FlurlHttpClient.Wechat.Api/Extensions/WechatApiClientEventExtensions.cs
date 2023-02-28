using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    /// <summary>
    /// 为 <see cref="WechatApiClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static class WechatApiClientEventExtensions
    {
        private class InnerEncryptedEvent
        {
            [Newtonsoft.Json.JsonProperty("Encrypt")]
            [System.Text.Json.Serialization.JsonPropertyName("Encrypt")]
            public string EncryptedData { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("TimeStamp")]
            [System.Text.Json.Serialization.JsonPropertyName("TimeStamp")]
            [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
            public string TimestampString { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("Nonce")]
            [System.Text.Json.Serialization.JsonPropertyName("Nonce")]
            public string Nonce { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("MsgSignature")]
            [System.Text.Json.Serialization.JsonPropertyName("MsgSignature")]
            public string Signature { get; set; } = default!;
        }

        private static TEvent InnerDeserializeEventFromJson<TEvent>(WechatApiClient client, string callbackJson)
            where TEvent : WechatApiEvent
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackJson == null) throw new ArgumentNullException(callbackJson);

            try
            {
                if (callbackJson.Contains("\"Encrypt\""))
                {
                    if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                        throw new Exceptions.WechatApiEventSerializationException("Decrypt event failed, because there is no encoding AES key.");

                    InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(callbackJson);
                    callbackJson = Utilities.WxMsgCryptor.AESDecrypt(cipherText: encryptedEvent.EncryptedData, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
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

        private static TEvent InnerDeserializeEventFromXml<TEvent>(WechatApiClient client, string callbackXml)
            where TEvent : WechatApiEvent
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackXml == null) throw new ArgumentNullException(callbackXml);

            try
            {
                if (callbackXml.Contains("<Encrypt>") && callbackXml.Contains("</Encrypt>"))
                {
                    if (!Utilities.WxMsgCryptor.TryParseXml(callbackXml, out string encryptedXml))
                        throw new Exceptions.WechatApiEventSerializationException("Decrypt event failed, because of empty encrypted data.");

                    callbackXml = Utilities.WxMsgCryptor.AESDecrypt(cipherText: encryptedXml, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                }

                return Utilities.XmlUtility.Deserialize<TEvent>(callbackXml);
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
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this WechatApiClient client, string callbackJson)
            where TEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, callbackJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="WechatApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static WechatApiEvent DeserializeEventFromJson(this WechatApiClient client, string callbackJson)
        {
            return InnerDeserializeEventFromJson<WechatApiEvent>(client, callbackJson);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatApiEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromXml<TEvent>(this WechatApiClient client, string callbackXml)
            where TEvent : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable, new()
        {
            return InnerDeserializeEventFromXml<TEvent>(client, callbackXml);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static WechatApiEvent DeserializeEventFromXml(this WechatApiClient client, string callbackXml)
        {
            return InnerDeserializeEventFromXml<WechatApiEvent>(client, callbackXml);
        }

        /// <summary>
        /// 将 <see cref="WechatApiEvent"/> 对象序列化成 JSON。
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackModel"></param>
        /// <param name="safety">是否是安全模式（即是否需要加密）。</param>
        /// <returns></returns>
        public static string SerializeEventToJson<TEvent>(this WechatApiClient client, TEvent callbackModel, bool safety = true)
            where TEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, new()
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
                    throw new Exceptions.WechatApiEventSerializationException("Encrypt event failed, because there is no encoding AES key.");
                if (string.IsNullOrEmpty(client.Credentials.PushToken))
                    throw new Exceptions.WechatApiEventSerializationException("Encrypt event failed, because there is no token.");

                try
                {
                    string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
                    string nonce = DateTimeOffset.Now.Ticks.ToString("x");
                    string cipher = Utilities.WxMsgCryptor.AESEncrypt(
                        plainText: json,
                        encodingAESKey: client.Credentials.PushEncodingAESKey!,
                        appId: client.Credentials.AppId
                    );
                    string sign = Utilities.WxMsgCryptor.GenerateSignature(
                        sToken: client.Credentials.PushToken!,
                        sTimestamp: timestamp,
                        sNonce: nonce,
                        sMsgEncrypt: cipher
                    );

                    json = client.JsonSerializer.Serialize(new InnerEncryptedEvent()
                    {
                        EncryptedData = cipher,
                        TimestampString = timestamp,
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
        public static string SerializeEventToXml<TEvent>(this WechatApiClient client, TEvent callbackModel, bool safety = true)
            where TEvent : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable, new()
        {
            string xml;

            try
            {
                xml = Utilities.XmlUtility.Serialize(callbackModel);
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
                    string cipher = Utilities.WxMsgCryptor.AESEncrypt(
                        plainText: xml,
                        encodingAESKey: client.Credentials.PushEncodingAESKey!,
                        appId: client.Credentials.AppId
                    );

                    xml = Utilities.WxMsgCryptor.WrapXml(sToken: client.Credentials.PushToken!, sMsgEncrypt: cipher);
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
        /// <param name="callbackTimestamp">微信回调通知中的 "timestamp" 查询参数。</param>
        /// <param name="callbackNonce">微信回调通知中的 "nonce" 查询参数。</param>
        /// <param name="callbackSignature">微信回调通知中的 "signature" 查询参数。</param>
        /// <returns></returns>
        public static bool VerifyEventSignatureForEcho(this WechatApiClient client, string callbackTimestamp, string callbackNonce, string callbackSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackTimestamp == null) throw new ArgumentNullException(nameof(callbackTimestamp));
            if (callbackNonce == null) throw new ArgumentNullException(nameof(callbackNonce));
            if (callbackSignature == null) throw new ArgumentNullException(nameof(callbackSignature));

            ISet<string> set = new SortedSet<string>(StringComparer.Ordinal) { client.Credentials.PushToken!, callbackTimestamp, callbackNonce };
            string sign = Utilities.SHA1Utility.Hash(string.Concat(set));
            return string.Equals(sign, callbackSignature, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// <para>验证回调通知事件签名（仅安全模式）。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Message_encryption_and_decryption_instructions.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">微信回调通知中的 "timestamp" 查询参数。</param>
        /// <param name="callbackNonce">微信回调通知中的 "nonce" 查询参数。</param>
        /// <param name="callbackJson">微信回调通知中请求正文（JSON 格式）。</param>
        /// <param name="callbackSignature">微信回调通知中的 "msg_signature" 查询参数。</param>
        /// <returns></returns>
        public static bool VerifyEventSignatureFromJson(this WechatApiClient client, string callbackTimestamp, string callbackNonce, string callbackJson, string callbackSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackJson == null) throw new ArgumentNullException(nameof(callbackJson));

            try
            {
                var encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(callbackJson);
                return Utilities.WxMsgCryptor.VerifySignature(
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
        /// <para>验证回调通知事件签名（仅安全模式）。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Message_encryption_and_decryption_instructions.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">微信回调通知中的 "timestamp" 查询参数。</param>
        /// <param name="callbackNonce">微信回调通知中的 "nonce" 查询参数。</param>
        /// <param name="callbackXml">微信回调通知中请求正文（XML 格式）。</param>
        /// <param name="callbackSignature">微信回调通知中的 "msg_signature" 查询参数。</param>
        /// <returns></returns>
        public static bool VerifyEventSignatureFromXml(this WechatApiClient client, string callbackTimestamp, string callbackNonce, string callbackXml, string callbackSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackXml == null) throw new ArgumentNullException(nameof(callbackXml));

            try
            {
                XDocument xDoc = XDocument.Parse(callbackXml);
                string? msgEncrypt = xDoc.Root?.Element("Encrypt")?.Value;

                return Utilities.WxMsgCryptor.VerifySignature(
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
