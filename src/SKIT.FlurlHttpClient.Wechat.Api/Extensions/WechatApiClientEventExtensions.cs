using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    using SKIT.FlurlHttpClient.Internal;
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// 为 <see cref="WechatApiClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static partial class WechatApiClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="WechatApiEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this WechatApiClient client, string webhookJson)
            where TEvent : WechatApiEvent, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="WechatApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static WechatApiEvent DeserializeEventFromJson(this WechatApiClient client, string webhookJson)
        {
            return InnerDeserializeEventFromJson<WechatApiEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatApiEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromXml<TEvent>(this WechatApiClient client, string webhookXml)
            where TEvent : WechatApiEvent, new()
        {
            return InnerDeserializeEventFromXml<TEvent>(client, webhookXml);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static WechatApiEvent DeserializeEventFromXml(this WechatApiClient client, string webhookXml)
        {
            return InnerDeserializeEventFromXml<WechatApiEvent>(client, webhookXml);
        }

        /// <summary>
        /// 将 <see cref="WechatApiEvent"/> 对象序列化成 JSON。
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookEvent"></param>
        /// <param name="safety">是否是安全模式（即是否需要加密）。</param>
        /// <returns></returns>
        public static string SerializeEventToJson<TEvent>(this WechatApiClient client, TEvent webhookEvent, bool safety = true)
            where TEvent : WechatApiEvent, new()
        {
            string json;

            try
            {
                json = client.JsonSerializer.Serialize(webhookEvent);
            }
            catch (Exception ex)
            {
                throw new WechatApiException("Failed to serialize event data. Please see the inner exception for more details.", ex);
            }

            if (safety)
            {
                if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                    throw new WechatApiException("Failed to encrypt event data, because the push no encoding AES key is not set.");
                if (string.IsNullOrEmpty(client.Credentials.PushToken))
                    throw new WechatApiException("Failed to encrypt event data, because the push token is not set.");

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
                    throw new WechatApiException("Failed to encrypt event data. Please see the inner exception for more details.", ex);
                }
            }

            return json;
        }

        /// <summary>
        /// 将 <see cref="WechatApiEvent"/> 对象序列化成 XML。
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookEvent"></param>
        /// <param name="safety">是否是安全模式（即是否需要加密）。</param>
        /// <returns></returns>
        public static string SerializeEventToXml<TEvent>(this WechatApiClient client, TEvent webhookEvent, bool safety = true)
            where TEvent : WechatApiEvent, new()
        {
            string xml;

            try
            {
                xml = _XmlSimpleSerializer.Serialize(webhookEvent, typeof(TEvent));
            }
            catch (Exception ex)
            {
                throw new WechatApiException("Failed to serialize event data. Please see the inner exception for more details.", ex);
            }

            if (safety)
            {
                if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                    throw new WechatApiException("Failed to encrypt event data, because the push encoding AES key is not set.");
                if (string.IsNullOrEmpty(client.Credentials.PushToken))
                    throw new WechatApiException("Failed to encrypt event data, because the push token is not set.");

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
                    throw new WechatApiException("Failed to encrypt event data. Please see the inner exception for more details.", ex);
                }
            }

            return xml;
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Basic_Information/Access_Overview.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/basics/message_push.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">微信回调通知中的 "timestamp" 查询参数。</param>
        /// <param name="webhookNonce">微信回调通知中的 "nonce" 查询参数。</param>
        /// <param name="webhookSignature">微信回调通知中的 "signature" 查询参数。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureForEcho(this WechatApiClient client, string webhookTimestamp, string webhookNonce, string webhookSignature)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            ErroredResult result;

            try
            {
                List<string> tmp = new List<string>(capacity: 3) { client.Credentials.PushToken!, webhookTimestamp, webhookNonce };
                tmp.Sort(StringComparer.Ordinal);

                string sign = Utilities.SHA1Utility.Hash(string.Concat(tmp)).Value!;
                bool valid = string.Equals(sign, webhookSignature, StringComparison.OrdinalIgnoreCase);

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
        /// <para>验证回调通知事件签名（仅安全模式）。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Message_encryption_and_decryption_instructions.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/basics/message_push.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">微信回调通知中的 "timestamp" 查询参数。</param>
        /// <param name="webhookNonce">微信回调通知中的 "nonce" 查询参数。</param>
        /// <param name="webhookJson">微信回调通知中请求正文（JSON 格式）。</param>
        /// <param name="webhookSignature">微信回调通知中的 "msg_signature" 查询参数。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureFromJson(this WechatApiClient client, string webhookTimestamp, string webhookNonce, string webhookJson, string webhookSignature)
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
        /// <para>验证回调通知事件签名（仅安全模式）。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Message_encryption_and_decryption_instructions.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/API/basics/message_push.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">微信回调通知中的 "timestamp" 查询参数。</param>
        /// <param name="webhookNonce">微信回调通知中的 "nonce" 查询参数。</param>
        /// <param name="webhookXml">微信回调通知中请求正文（XML 格式）。</param>
        /// <param name="webhookSignature">微信回调通知中的 "msg_signature" 查询参数。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureFromXml(this WechatApiClient client, string webhookTimestamp, string webhookNonce, string webhookXml, string webhookSignature)
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

    partial class WechatApiClientEventExtensions
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

        private static TEvent InnerDeserializeEventFromJson<TEvent>(WechatApiClient client, string webhookJson)
            where TEvent : WechatApiEvent
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookJson is null) throw new ArgumentNullException(webhookJson);

            try
            {
                if (webhookJson.Contains("\"Encrypt\""))
                {
                    if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                        throw new WechatApiException("Failed to decrypt event data, because the push no encoding AES key is not set.");

                    InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(webhookJson);
                    webhookJson = Utilities.WxMsgCryptor.AESDecrypt(cipherText: encryptedEvent.EncryptedData, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                }

                return client.JsonSerializer.Deserialize<TEvent>(webhookJson);
            }
            catch (WechatApiException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new WechatApiException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }

        private static TEvent InnerDeserializeEventFromXml<TEvent>(WechatApiClient client, string webhookXml)
            where TEvent : WechatApiEvent
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookXml is null) throw new ArgumentNullException(webhookXml);

            try
            {
                if (webhookXml.Contains("<Encrypt>") && webhookXml.Contains("</Encrypt>"))
                {
                    if (!Utilities.WxMsgCryptor.TryParseXml(webhookXml, out string encryptedXml))
                        throw new WechatApiException("Failed to decrypt event data, because the encrypted data is empty.");

                    webhookXml = Utilities.WxMsgCryptor.AESDecrypt(cipherText: encryptedXml, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                }

                return (TEvent)_XmlSimpleSerializer.Deserialize(webhookXml, typeof(TEvent));
            }
            catch (WechatApiException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new WechatApiException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }
    }
}
