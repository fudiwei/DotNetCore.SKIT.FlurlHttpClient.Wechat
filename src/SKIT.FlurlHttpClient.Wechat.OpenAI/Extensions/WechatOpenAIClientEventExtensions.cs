using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 为 <see cref="WechatOpenAIClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static partial class WechatOpenAIClientEventExtensions
    {
        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatOpenAIEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromXml<TEvent>(this WechatOpenAIClient client, string webhookXml)
            where TEvent : WechatOpenAIEvent, new()
        {
            return InnerDeserializeEventFromXml<TEvent>(client, webhookXml);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="WechatOpenAIEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static WechatOpenAIEvent DeserializeEventFromXml(this WechatOpenAIClient client, string webhookXml)
        {
            return InnerDeserializeEventFromXml<WechatOpenAIEvent>(client, webhookXml);
        }

        /// <summary>
        /// 将 <see cref="WechatOpenAIEvent"/> 对象序列化成 XML。
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookEvent"></param>
        /// <returns></returns>
        public static string SerializeEventToXml<TEvent>(this WechatOpenAIClient client, TEvent webhookEvent)
            where TEvent : WechatOpenAIEvent, new()
        {
            string xml;

            try
            {
                xml = Utilities.XmlHelper.Serialize(webhookEvent);
            }
            catch (Exception ex)
            {
                throw new WechatOpenAIException("Failed to serialize event data. Please see the inner exception for more details.", ex);
            }

            if (string.IsNullOrEmpty(client.Credentials.EncodingAESKey))
                throw new WechatOpenAIException("Failed to encrypt event data, because the push encoding AES key is not set.");
            if (string.IsNullOrEmpty(client.Credentials.Token))
                throw new WechatOpenAIException("Failed to encrypt event data, because the push token is not set.");

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
                throw new WechatOpenAIException("Failed to encrypt event data. Please see the inner exception for more details.", ex);
            }

            return xml;
        }
    }

    partial class WechatOpenAIClientEventExtensions
    {
        private static TEvent InnerDeserializeEventFromXml<TEvent>(this WechatOpenAIClient client, string webhookXml)
            where TEvent : WechatOpenAIEvent
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookXml is null) throw new ArgumentNullException(webhookXml);

            try
            {
                if (!Utilities.WxMsgCryptor.TryParseXml(webhookXml, out string? encryptedXml))
                    throw new WechatOpenAIException("Failed to decrypt event data, because of the encrypted data is empty.");

                webhookXml = Utilities.WxMsgCryptor.AESDecrypt(cipherText: encryptedXml!, encodingAESKey: client.Credentials.EncodingAESKey!, out _);
                return Utilities.XmlHelper.Deserialize<TEvent>(webhookXml);
            }
            catch (WechatOpenAIException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new WechatOpenAIException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }
    }
}
