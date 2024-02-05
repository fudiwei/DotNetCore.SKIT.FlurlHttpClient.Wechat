using System;
using System.Xml.Linq;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// 为 <see cref="WechatWorkClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static partial class WechatWorkClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="WechatWorkEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this WechatWorkClient client, string webhookJson)
            where TEvent : WechatWorkEvent, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="WechatWorkEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static WechatWorkEvent DeserializeEventFromJson(this WechatWorkClient client, string webhookJson)
        {
            return InnerDeserializeEventFromJson<WechatWorkEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatWorkEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromXml<TEvent>(this WechatWorkClient client, string webhookXml)
            where TEvent : WechatWorkEvent, new()
        {
            return InnerDeserializeEventFromXml<TEvent>(client, webhookXml);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatWorkEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static WechatWorkEvent DeserializeEventFromXml(this WechatWorkClient client, string webhookXml)
        {
            return InnerDeserializeEventFromXml<WechatWorkEvent>(client, webhookXml);
        }

        /// <summary>
        /// 将 <see cref="WechatWorkEvent"/> 对象序列化成 JSON。
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookEvent"></param>
        /// <returns></returns>
        public static string SerializeEventToJson<TEvent>(this WechatWorkClient client, TEvent webhookEvent)
            where TEvent : WechatWorkEvent, new()
        {
            string json;

            try
            {
                json = client.JsonSerializer.Serialize(webhookEvent);
            }
            catch (Exception ex)
            {
                throw new WechatWorkException("Failed to serialize event data. Please see the inner exception for more details.", ex);
            }

            if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                throw new WechatWorkException("Failed to encrypt event data, because the push encoding AES key is empty.");
            if (string.IsNullOrEmpty(client.Credentials.PushToken))
                throw new WechatWorkException("Failed to encrypt event data, because the push token is empty.");

            try
            {
                string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
                string nonce = DateTimeOffset.Now.Ticks.ToString("x");
                string cipher = Utilities.WxMsgCryptor.AESEncrypt(
                    plainText: json,
                    encodingAESKey: client.Credentials.PushEncodingAESKey!,
                    corpId: string.IsNullOrEmpty(client.Credentials.SuiteId) ? client.Credentials.CorpId : client.Credentials.SuiteId!
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
                throw new WechatWorkException("Failed to encrypt event data. Please see the inner exception for more details.", ex);
            }

            return json;
        }

        /// <summary>
        /// 将 <see cref="WechatWorkEvent"/> 对象序列化成 XML。
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookEvent"></param>
        /// <returns></returns>
        public static string SerializeEventToXml<TEvent>(this WechatWorkClient client, TEvent webhookEvent)
            where TEvent : WechatWorkEvent, new()
        {
            string xml;

            try
            {
                xml = Utilities.XmlHelper.Serialize(webhookEvent);
            }
            catch (Exception ex)
            {
                throw new WechatWorkException("Failed to serialize event data. Please see the inner exception for more details.", ex);
            }

            if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                throw new WechatWorkException("Failed to encrypt event data, because the push encoding AES key is empty.");
            if (string.IsNullOrEmpty(client.Credentials.PushToken))
                throw new WechatWorkException("Failed to encrypt event data, because the push token is empty.");

            try
            {
                string cipher = Utilities.WxMsgCryptor.AESEncrypt(
                    plainText: xml,
                    encodingAESKey: client.Credentials.PushEncodingAESKey!,
                    corpId: string.IsNullOrEmpty(client.Credentials.SuiteId) ? client.Credentials.CorpId : client.Credentials.SuiteId!
                );

                xml = Utilities.WxMsgCryptor.WrapXml(sToken: client.Credentials.PushToken!, sMsgEncrypt: cipher);
            }
            catch (Exception ex)
            {
                throw new WechatWorkException("Failed to encrypt event data. Please see the inner exception for more details.", ex);
            }

            return xml;
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90930 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91116 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91148 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">微信回调通知中的 "timestamp" 查询参数。</param>
        /// <param name="webhookNonce">微信回调通知中的 "nonce" 查询参数。</param>
        /// <param name="webhookEcho">微信回调通知中的 "echostr" 查询参数。</param>
        /// <param name="webhookSignature">微信回调通知中的 "msg_signature" 查询参数。</param>
        /// <param name="replyEcho"></param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureForEcho(this WechatWorkClient client, string webhookTimestamp, string webhookNonce, string webhookEcho, string webhookSignature, out string? replyEcho)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            ErroredResult result;

            try
            {
                bool valid = Utilities.WxMsgCryptor.VerifySignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: webhookTimestamp,
                    sNonce: webhookNonce,
                    sMsgEncrypt: webhookEcho,
                    sMsgSign: webhookSignature
                );

                if (valid)
                {
                    replyEcho = Utilities.WxMsgCryptor.AESDecrypt(cipherText: webhookEcho, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                    result = ErroredResult.Ok();
                }
                else
                {
                    replyEcho = null;
                    result = ErroredResult.Fail(new Exception($"Signature does not match. Maybe \"{webhookSignature}\" is an illegal signature."));
                }
            }
            catch (Exception ex)
            {
                replyEcho = null;
                result = ErroredResult.Fail(ex);
            }

            return result;
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90930 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91116 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91148 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">微信回调通知中的 "timestamp" 查询参数。</param>
        /// <param name="webhookNonce">微信回调通知中的 "nonce" 查询参数。</param>
        /// <param name="webhookJson">微信回调通知中请求正文（JSON 格式）。</param>
        /// <param name="webhookSignature">微信回调通知中的 "msg_signature" 查询参数。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureFromJson(this WechatWorkClient client, string webhookTimestamp, string webhookNonce, string webhookJson, string webhookSignature)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            ErroredResult result;

            try
            {
                InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(webhookJson);
                bool valid = Utilities.WxMsgCryptor.VerifySignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: webhookTimestamp,
                    sNonce: webhookNonce,
                    sMsgEncrypt: encryptedEvent.EncryptedData,
                    sMsgSign: webhookSignature
                );

                if (valid)
                    result = ErroredResult.Ok();
                else
                    result = ErroredResult.Fail(new Exception($"Signature does not match. Maybe \"{webhookSignature}\" is an illegal signature."));
            }
            catch (Exception ex)
            {
                result = ErroredResult.Fail(ex);
            }

            return result;
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90930 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91116 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/91148 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">微信回调通知中的 "timestamp" 查询参数。</param>
        /// <param name="webhookNonce">微信回调通知中的 "nonce" 查询参数。</param>
        /// <param name="webhookXml">微信回调通知中请求正文（XML 格式）。</param>
        /// <param name="webhookSignature">微信回调通知中的 "msg_signature" 查询参数。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureFromXml(this WechatWorkClient client, string webhookTimestamp, string webhookNonce, string webhookXml, string webhookSignature)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            ErroredResult result;

            try
            {
                XDocument xDoc = XDocument.Parse(webhookXml);
                string? msgEncrypt = xDoc.Root?.Element("Encrypt")?.Value;

                bool valid = Utilities.WxMsgCryptor.VerifySignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: webhookTimestamp,
                    sNonce: webhookNonce,
                    sMsgEncrypt: msgEncrypt!,
                    sMsgSign: webhookSignature
                );

                if (valid)
                    result = ErroredResult.Ok();
                else
                    result = ErroredResult.Fail(new Exception($"Signature does not match. Maybe \"{webhookSignature}\" is an illegal signature."));
            }
            catch (Exception ex)
            {
                result = ErroredResult.Fail(ex);
            }

            return result;
        }
    }

    partial class WechatWorkClientEventExtensions
    {
        private class InnerEncryptedEvent
        {
            [Newtonsoft.Json.JsonProperty("Encrypt")]
            [System.Text.Json.Serialization.JsonPropertyName("Encrypt")]
            public string EncryptedData { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("TimeStamp")]
            [System.Text.Json.Serialization.JsonPropertyName("TimeStamp")]
            [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
            public string TimestampString { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("Nonce")]
            [System.Text.Json.Serialization.JsonPropertyName("Nonce")]
            public string Nonce { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("MsgSignature")]
            [System.Text.Json.Serialization.JsonPropertyName("MsgSignature")]
            public string Signature { get; set; } = default!;
        }

        private static TEvent InnerDeserializeEventFromJson<TEvent>(this WechatWorkClient client, string webhookJson)
            where TEvent : WechatWorkEvent
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            try
            {
                if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                    throw new WechatWorkException("Failed to decrypt event data, because the push encoding AES key is empty.");

                InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(webhookJson);
                webhookJson = Utilities.WxMsgCryptor.AESDecrypt(cipherText: encryptedEvent.EncryptedData, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);

                return client.JsonSerializer.Deserialize<TEvent>(webhookJson);
            }
            catch (WechatWorkException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new WechatWorkException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }

        private static TEvent InnerDeserializeEventFromXml<TEvent>(this WechatWorkClient client, string webhookXml)
            where TEvent : WechatWorkEvent
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            try
            {
                if (!Utilities.WxMsgCryptor.TryParseXml(webhookXml, out string? encryptedXml))
                    throw new WechatWorkException("Failed to decrypt event data, because the encrypted data is empty.");

                webhookXml = Utilities.WxMsgCryptor.AESDecrypt(cipherText: encryptedXml!, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                return Utilities.XmlHelper.Deserialize<TEvent>(webhookXml);
            }
            catch (WechatWorkException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new WechatWorkException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }
    }
}
