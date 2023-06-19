using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 为 <see cref="WechatOpenAIClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static class WechatOpenAIClientEventExtensions
    {
        private static TEvent InnerDeserializeEventFromXml<TEvent>(this WechatOpenAIClient client, string callbackXml)
            where TEvent : WechatOpenAIEvent
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackXml == null) throw new ArgumentNullException(callbackXml);

            try
            {
                if (!Utilities.WxMsgCryptor.TryParseXml(callbackXml, out string? encryptedXml))
                    throw new Exceptions.WechatOpenAIEventSerializationException("Failed to encrypt event data, because of empty encrypted data.");

                callbackXml = Utilities.WxMsgCryptor.AESDecrypt(cipherText: encryptedXml!, encodingAESKey: client.Credentials.EncodingAESKey!, out _);
                return Utilities.XmlUtility.Deserialize<TEvent>(callbackXml);
            }
            catch (WechatOpenAIException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatOpenAIEventSerializationException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
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
                xml = Utilities.XmlUtility.Serialize(callbackModel);
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatOpenAIEventSerializationException("Failed to serialize event data. Please see the inner exception for more details.", ex);
            }

            if (string.IsNullOrEmpty(client.Credentials.EncodingAESKey))
                throw new Exceptions.WechatOpenAIEventSerializationException("Failed to encrypt event data, because there is no encoding AES key.");
            if (string.IsNullOrEmpty(client.Credentials.Token))
                throw new Exceptions.WechatOpenAIEventSerializationException("Failed to encrypt event data, because there is no token.");

            try
            {
                string cipher = Utilities.WxMsgCryptor.AESEncrypt(
                    plainText: xml,
                    encodingAESKey: client.Credentials.EncodingAESKey!,
                    appId: client.Credentials.AppId!
                );

                xml = Utilities.WxMsgCryptor.WrapXml(sToken: client.Credentials.Token!, sMsgEncrypt: cipher);
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatOpenAIEventSerializationException("Failed to encrypt event data. Please see the inner exception for more details.", ex);
            }

            return xml;
        }
    }
}
