using System;
using System.Xml.Linq;

namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.AIBot
{
    using SKIT.FlurlHttpClient.Internal;
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// 为 <see cref="WechatWorkAIBotClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static partial class WechatWorkAIBotClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="WechatWorkAIBotEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this WechatWorkAIBotClient client, string webhookJson)
            where TEvent : WechatWorkAIBotEvent, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="WechatWorkAIBotEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static WechatWorkAIBotEvent DeserializeEventFromJson(this WechatWorkAIBotClient client, string webhookJson)
        {
            return InnerDeserializeEventFromJson<WechatWorkAIBotEvent>(client, webhookJson);
        }

        /// <summary>
        /// 将 <see cref="WechatWorkAIBotEvent"/> 对象序列化成 JSON。
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookEvent"></param>
        /// <returns></returns>
        public static string SerializeEventToJson<TEvent>(this WechatWorkAIBotClient client, TEvent webhookEvent)
            where TEvent : WechatWorkAIBotEvent, new()
        {
            string json;

            try
            {
                json = client.JsonSerializer.Serialize(webhookEvent);
            }
            catch (Exception ex)
            {
                throw new WechatWorkAIBotException("Failed to serialize event data. Please see the inner exception for more details.", ex);
            }

            if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                throw new WechatWorkAIBotException("Failed to encrypt event data, because the push encoding AES key is empty.");
            if (string.IsNullOrEmpty(client.Credentials.PushToken))
                throw new WechatWorkAIBotException("Failed to encrypt event data, because the push token is empty.");

            try
            {
                string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
                string nonce = DateTimeOffset.Now.Ticks.ToString("x");
                string cipher = Utilities.WxMsgCryptor.AESEncrypt(
                    plainText: json,
                    encodingAESKey: client.Credentials.PushEncodingAESKey!,
                    receiveId: string.Empty
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
                throw new WechatWorkAIBotException("Failed to encrypt event data. Please see the inner exception for more details.", ex);
            }

            return json;
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/101033 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">企业微信回调通知中的 "timestamp" 查询参数。</param>
        /// <param name="webhookNonce">企业微信回调通知中的 "nonce" 查询参数。</param>
        /// <param name="webhookEcho">企业微信回调通知中的 "echostr" 查询参数。</param>
        /// <param name="webhookSignature">企业微信回调通知中的 "msg_signature" 查询参数。</param>
        /// <param name="replyEcho"></param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureForEcho(this WechatWorkAIBotClient client, string webhookTimestamp, string webhookNonce, string webhookEcho, string webhookSignature, out string? replyEcho)
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
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/101033 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">企业微信回调通知中的 "timestamp" 查询参数。</param>
        /// <param name="webhookNonce">企业微信回调通知中的 "nonce" 查询参数。</param>
        /// <param name="webhookJson">企业微信回调通知中请求正文（JSON 格式）。</param>
        /// <param name="webhookSignature">企业微信回调通知中的 "msg_signature" 查询参数。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureFromJson(this WechatWorkAIBotClient client, string webhookTimestamp, string webhookNonce, string webhookJson, string webhookSignature)
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
    }

    partial class WechatWorkAIBotClientEventExtensions
    {
        private class InnerEncryptedEvent
        {
            [Newtonsoft.Json.JsonProperty("encrypt")]
            [System.Text.Json.Serialization.JsonPropertyName("encrypt")]
            public string EncryptedData { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("timestamp")]
            [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringConverter))]
            public string TimestampString { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("nonce")]
            [System.Text.Json.Serialization.JsonPropertyName("nonce")]
            public string Nonce { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("msgsignature")]
            [System.Text.Json.Serialization.JsonPropertyName("msgsignature")]
            public string Signature { get; set; } = default!;
        }

        private static TEvent InnerDeserializeEventFromJson<TEvent>(this WechatWorkAIBotClient client, string webhookJson)
            where TEvent : WechatWorkAIBotEvent
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            try
            {
                if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                    throw new WechatWorkAIBotException("Failed to decrypt event data, because the push encoding AES key is empty.");

                InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(webhookJson);
                webhookJson = Utilities.WxMsgCryptor.AESDecrypt(cipherText: encryptedEvent.EncryptedData, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);

                return client.JsonSerializer.Deserialize<TEvent>(webhookJson);
            }
            catch (WechatWorkAIBotException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new WechatWorkAIBotException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }
    }
}
