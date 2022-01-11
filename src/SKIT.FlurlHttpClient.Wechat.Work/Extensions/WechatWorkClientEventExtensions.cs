using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    /// <summary>
    /// 为 <see cref="WechatWorkClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static class WechatWorkClientEventExtensions
    {
        private class EncryptedWechatWorkEvent
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

        private static TEvent InnerDeserializeEventFromJson<TEvent>(this WechatWorkClient client, string callbackJson)
            where TEvent : WechatWorkEvent
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackJson)) throw new ArgumentNullException(callbackJson);

            try
            {
                if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                    throw new Exceptions.WechatWorkEventSerializationException("Encrypt event failed, because there is no encoding AES key.");

                var encryptedEvent = client.JsonSerializer.Deserialize<EncryptedWechatWorkEvent>(callbackJson);
                if (string.IsNullOrEmpty(encryptedEvent.EncryptedData))
                    throw new Exceptions.WechatWorkEventSerializationException("Encrypt event failed, because of empty encrypted data.");

                callbackJson = Utilities.WxBizMsgCryptor.AESDecrypt(cipherText: encryptedEvent.EncryptedData, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);

                return client.JsonSerializer.Deserialize<TEvent>(callbackJson);
            }
            catch (WechatWorkException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatWorkEventSerializationException("Deserialize event failed. Please see the `InnerException` for more details.", ex);
            }
        }

        private static TEvent InnerDeserializeEventFromXml<TEvent>(this WechatWorkClient client, string callbackXml)
            where TEvent : WechatWorkEvent
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackXml)) throw new ArgumentNullException(callbackXml);

            try
            {
                if (!Utilities.WxBizMsgCryptor.TryParseXml(callbackXml, out string? encryptedXml))
                    throw new Exceptions.WechatWorkEventSerializationException("Encrypt event failed, because of empty encrypted data.");

                callbackXml = Utilities.WxBizMsgCryptor.AESDecrypt(cipherText: encryptedXml!, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                return Utilities.XmlUtility.Deserialize<TEvent>(callbackXml);
            }
            catch (WechatWorkException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatWorkEventSerializationException("Deserialize event failed. Please see the `InnerException` for more details.", ex);
            }
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="WechatWorkEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this WechatWorkClient client, string callbackJson)
            where TEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IJsonSerializable, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, callbackJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="WechatWorkEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static WechatWorkEvent DeserializeEventFromJson(this WechatWorkClient client, string callbackJson)
        {
            return InnerDeserializeEventFromJson<WechatWorkEvent>(client, callbackJson);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatWorkEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromXml<TEvent>(this WechatWorkClient client, string callbackXml)
            where TEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable, new()
        {
            return InnerDeserializeEventFromXml<TEvent>(client, callbackXml);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatWorkEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static WechatWorkEvent DeserializeEventFromXml(this WechatWorkClient client, string callbackXml)
        {
            return InnerDeserializeEventFromXml<WechatWorkEvent>(client, callbackXml);
        }

        /// <summary>
        /// 将 <see cref="WechatWorkEvent"/> 对象序列化成 JSON。
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackModel"></param>
        /// <returns></returns>
        public static string SerializeEventToJson<TEvent>(this WechatWorkClient client, TEvent callbackModel)
            where TEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IJsonSerializable, new()
        {
            string json;

            try
            {
                json = client.JsonSerializer.Serialize(callbackModel);
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatWorkEventSerializationException("Serialize event failed. Please see the `InnerException` for more details.", ex);
            }

            if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                throw new Exceptions.WechatWorkEventSerializationException("Encrypt event failed, because there is no encoding AES key.");
            if (string.IsNullOrEmpty(client.Credentials.PushToken))
                throw new Exceptions.WechatWorkEventSerializationException("Encrypt event failed, because there is no token.");

            try
            {
                string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
                string nonce = DateTimeOffset.Now.Ticks.ToString("x");
                string cipher = Utilities.WxBizMsgCryptor.AESEncrypt(
                    plainText: json,
                    encodingAESKey: client.Credentials.PushEncodingAESKey!,
                    corpOrSuiteId: string.IsNullOrEmpty(client.Credentials.SuiteId) ? client.Credentials.CorpId : client.Credentials.SuiteId!
                );
                string sign = Utilities.WxBizMsgCryptor.GenerateSignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: timestamp,
                    sNonce: nonce,
                    sMsgEncrypt: cipher
                );

                json = client.JsonSerializer.Serialize(new EncryptedWechatWorkEvent()
                {
                    EncryptedData = cipher,
                    Timestamp = timestamp,
                    Nonce = nonce,
                    Signature = sign
                });
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatWorkEventSerializationException("Encrypt event failed. Please see the `InnerException` for more details.", ex);
            }

            return json;
        }

        /// <summary>
        /// 将 <see cref="WechatWorkEvent"/> 对象序列化成 XML。
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackModel"></param>
        /// <returns></returns>
        public static string SerializeEventToXml<TEvent>(this WechatWorkClient client, TEvent callbackModel)
            where TEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable, new()
        {
            string xml;

            try
            {
                xml = Utilities.XmlUtility.Serialize(callbackModel);
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatWorkEventSerializationException("Serialize event failed. Please see the `InnerException` for more details.", ex);
            }

            if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                throw new Exceptions.WechatWorkEventSerializationException("Encrypt event failed, because there is no encoding AES key.");
            if (string.IsNullOrEmpty(client.Credentials.PushToken))
                throw new Exceptions.WechatWorkEventSerializationException("Encrypt event failed, because there is no token.");

            try
            {
                string cipher = Utilities.WxBizMsgCryptor.AESEncrypt(
                    plainText: xml,
                    encodingAESKey: client.Credentials.PushEncodingAESKey!,
                    corpOrSuiteId: string.IsNullOrEmpty(client.Credentials.SuiteId) ? client.Credentials.CorpId : client.Credentials.SuiteId!
                );

                xml = Utilities.WxBizMsgCryptor.WrapXml(sToken: client.Credentials.PushToken!, sMsgEncrypt: cipher);
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatWorkEventSerializationException("Encrypt event failed. Please see the `InnerException` for more details.", ex);
            }

            return xml;
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90139/90968 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90148/91144 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90156/91169 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">微信回调通知中的 timestamp 字段。</param>
        /// <param name="callbackNonce">微信回调通知中的 nonce 字段。</param>
        /// <param name="callbackEcho">微信回调通知中的 echostr 字段。</param>
        /// <param name="callbackSignature">微信回调通知中的 msg_signature 字段。</param>
        /// <param name="replyEcho"></param>
        /// <returns></returns>
        public static bool VerifyEventSignatureForEcho(this WechatWorkClient client, string callbackTimestamp, string callbackNonce, string callbackEcho, string callbackSignature, out string? replyEcho)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackTimestamp == null) throw new ArgumentNullException(nameof(callbackTimestamp));
            if (callbackNonce == null) throw new ArgumentNullException(nameof(callbackNonce));
            if (callbackEcho == null) throw new ArgumentNullException(nameof(callbackEcho));
            if (callbackSignature == null) throw new ArgumentNullException(nameof(callbackSignature));

            try
            {
                bool ret = Utilities.WxBizMsgCryptor.VerifySignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: callbackTimestamp,
                    sNonce: callbackNonce,
                    sMsgEncrypt: callbackEcho,
                    sMsgSign: callbackSignature
                );

                if (ret)
                {
                    replyEcho = Utilities.WxBizMsgCryptor.AESDecrypt(cipherText: callbackEcho, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                    return true;
                }
            }
            catch { }

            replyEcho = null;
            return false;
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90139/90968 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90148/91144 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90156/91169 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">微信回调通知中的 timestamp 字段。</param>
        /// <param name="callbackNonce">微信回调通知中的 nonce 字段。</param>
        /// <param name="callbackJson">微信回调通知中请求正文（JSON 格式）。</param>
        /// <param name="callbackSignature">微信回调通知中的 msg_signature 字段。</param>
        /// <returns></returns>
        public static bool VerifyEventSignatureFromJson(this WechatWorkClient client, string callbackTimestamp, string callbackNonce, string callbackJson, string callbackSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackJson == null) throw new ArgumentNullException(nameof(callbackJson));

            try
            {
                var encryptedEvent = client.JsonSerializer.Deserialize<EncryptedWechatWorkEvent>(callbackJson);
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
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90139/90968 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90148/91144 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90156/91169 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">微信回调通知中的 timestamp 字段。</param>
        /// <param name="callbackNonce">微信回调通知中的 nonce 字段。</param>
        /// <param name="callbackXml">微信回调通知中请求正文（XML 格式）。</param>
        /// <param name="callbackSignature">微信回调通知中的 msg_signature 字段。</param>
        /// <returns></returns>
        public static bool VerifyEventSignatureFromXml(this WechatWorkClient client, string callbackTimestamp, string callbackNonce, string callbackXml, string callbackSignature)
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
