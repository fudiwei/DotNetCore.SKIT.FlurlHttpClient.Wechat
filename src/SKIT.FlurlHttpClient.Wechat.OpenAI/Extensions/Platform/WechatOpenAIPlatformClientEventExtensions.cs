using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 为 <see cref="WechatOpenAIPlatformClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static class WechatOpenAIPlatformClientEventExtensions
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

        private static TEvent InnerDeserializeEventFromXml<TEvent>(this WechatOpenAIPlatformClient client, string callbackXml)
            where TEvent : WechatOpenAIPlatformEvent
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackXml)) throw new ArgumentNullException(callbackXml);

            try
            {
                if (!Utilities.WxBizMsgCryptor.TryParseXml(callbackXml, out string? encryptedXml))
                    throw new Exceptions.WechatOpenAIEventSerializationException("Encrypt event failed, because of empty encrypted data.");

                callbackXml = Utilities.WxBizMsgCryptor.AESDecrypt(cipherText: encryptedXml!, encodingAESKey: client.Credentials.EncodingAESKey!, out _);
                return Utilities.XmlUtility.Deserialize<TEvent>(callbackXml);
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
        /// <para>从 XML 反序列化得到 <see cref="WechatOpenAIPlatformEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromXml<TEvent>(this WechatOpenAIPlatformClient client, string callbackXml)
            where TEvent : WechatOpenAIPlatformEvent, WechatOpenAIPlatformEvent.Serialization.IXmlSerializable, new()
        {
            return InnerDeserializeEventFromXml<TEvent>(client, callbackXml);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatOpenAIPlatformEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static WechatOpenAIPlatformEvent DeserializeEventFromXml(this WechatOpenAIPlatformClient client, string callbackXml)
        {
            return InnerDeserializeEventFromXml<WechatOpenAIPlatformEvent>(client, callbackXml);
        }

        /// <summary>
        /// 将 <see cref="WechatOpenAIPlatformEvent"/> 对象序列化成 XML。
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackModel"></param>
        /// <returns></returns>
        public static string SerializeEventToXml<TEvent>(this WechatOpenAIPlatformClient client, TEvent callbackModel)
            where TEvent : WechatOpenAIPlatformEvent, WechatOpenAIPlatformEvent.Serialization.IXmlSerializable, new()
        {
            string xml;

            try
            {
                xml = Utilities.XmlUtility.Serialize(callbackModel);
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatOpenAIEventSerializationException("Serialize event failed. Please see the `InnerException` for more details.", ex);
            }


            if (string.IsNullOrEmpty(client.Credentials.EncodingAESKey))
                throw new Exceptions.WechatOpenAIEventSerializationException("Encrypt event failed, because there is no encoding AES key.");
            if (string.IsNullOrEmpty(client.Credentials.Token))
                throw new Exceptions.WechatOpenAIEventSerializationException("Encrypt event failed, because there is no token.");

            try
            {
                string cipher = Utilities.WxBizMsgCryptor.AESEncrypt(
                    plainText: xml,
                    encodingAESKey: client.Credentials.EncodingAESKey!,
                    appId: client.Credentials.AppId!
                );

                xml = Utilities.WxBizMsgCryptor.WrapXml(sToken: client.Credentials.Token!, sMsgEncrypt: cipher);
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatOpenAIEventSerializationException("Encrypt event failed. Please see the `InnerException` for more details.", ex);
            }

            return xml;
        }
    }
}
