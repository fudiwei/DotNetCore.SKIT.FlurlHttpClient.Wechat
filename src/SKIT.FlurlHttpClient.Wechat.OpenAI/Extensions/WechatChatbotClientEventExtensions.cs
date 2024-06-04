using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 为 <see cref="WechatChatbotClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static partial class WechatChatbotClientEventExtensions
    {
        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatChatbotEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromXml<TEvent>(this WechatChatbotClient client, string webhookXml)
            where TEvent : WechatChatbotEvent, new()
        {
            return InnerDeserializeEventFromXml<TEvent>(client, webhookXml);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatChatbotEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static WechatChatbotEvent DeserializeEventFromXml(this WechatChatbotClient client, string webhookXml)
        {
            return InnerDeserializeEventFromXml<WechatChatbotEvent>(client, webhookXml);
        }

        /// <summary>
        /// 将 <see cref="WechatChatbotEvent"/> 对象序列化成 XML。
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookEvent"></param>
        /// <returns></returns>
        public static string SerializeEventToXml<TEvent>(this WechatChatbotClient client, TEvent webhookEvent)
            where TEvent : WechatChatbotEvent, new()
        {
            string xml;

            try
            {
                xml = Utilities.XmlHelper.Serialize(webhookEvent);
            }
            catch (Exception ex)
            {
                throw new WechatChatbotException("Failed to serialize event data. Please see the inner exception for more details.", ex);
            }

            if (string.IsNullOrEmpty(client.Credentials.EncodingAESKey))
                throw new WechatChatbotException("Failed to encrypt event data, because the push encoding AES key is not set.");
            if (string.IsNullOrEmpty(client.Credentials.Token))
                throw new WechatChatbotException("Failed to encrypt event data, because the push token is not set.");

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
                throw new WechatChatbotException("Failed to encrypt event data. Please see the inner exception for more details.", ex);
            }

            return xml;
        }
    }

    partial class WechatChatbotClientEventExtensions
    {
        private static TEvent InnerDeserializeEventFromXml<TEvent>(this WechatChatbotClient client, string webhookXml)
            where TEvent : WechatChatbotEvent
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookXml is null) throw new ArgumentNullException(webhookXml);

            try
            {
                if (!Utilities.WxMsgCryptor.TryParseXml(webhookXml, out string? encryptedXml))
                    throw new WechatChatbotException("Failed to decrypt event data, because of the encrypted data is empty.");

                webhookXml = Utilities.WxMsgCryptor.AESDecrypt(cipherText: encryptedXml!, encodingAESKey: client.Credentials.EncodingAESKey!, out _);
                return Utilities.XmlHelper.Deserialize<TEvent>(webhookXml);
            }
            catch (WechatChatbotException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new WechatChatbotException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }
    }
}
