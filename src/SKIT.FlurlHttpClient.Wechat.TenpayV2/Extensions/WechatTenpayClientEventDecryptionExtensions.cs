using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供回调通知事件敏感数据解密的扩展方法。
    /// </summary>
    public static class WechatTenpayClientEventDecryptionExtensions
    {
        /// <summary>
        /// <para>反序列化得到 <see cref="WechatTenpayEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static WechatTenpayEvent DeserializeEvent(this WechatTenpayClient client, string webhookXml)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookXml is null) throw new ArgumentNullException(webhookXml);

            string webhookJson = Utilities.XmlHelper.ConvertToJson(webhookXml);
            return client.JsonSerializer.Deserialize<WechatTenpayEvent>(webhookJson);
        }

        /// <summary>
        /// <para>反序列化得到微信支付回调通知事件模型对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEvent<TEvent>(this WechatTenpayClient client, string webhookXml)
            where TEvent : WechatTenpayEvent, new()
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookXml is null) throw new ArgumentNullException(webhookXml);

            string webhookJson = Utilities.XmlHelper.ConvertToJson(webhookXml);
            return client.JsonSerializer.Deserialize<TEvent>(webhookJson);
        }

        /// <summary>
        /// 返回序列化并解密事件数据中被加密的信息。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookEvent"></param>
        /// <returns></returns>
        public static T DecryptEventRequestInfo<T>(this WechatTenpayClient client, WechatTenpayEvent webhookEvent)
            where T : WechatTenpayEvent.Types.IDecryptedRequestInfo, new()
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookEvent is null) throw new ArgumentNullException(nameof(webhookEvent));

            string plainJson;

            try
            {
                string key = Utilities.MD5Utility.Hash(client.Credentials.MerchantSecret).Value!.ToLower();
                string plainXml = Utilities.AESUtility.DecryptWithECB(
                    encodingKey: new EncodedString(key, EncodingKinds.Literal),
                    encodingCipher: new EncodedString(webhookEvent.EncryptedRequestInfo!, EncodingKinds.Base64)
                )!;
                plainJson = Utilities.XmlHelper.ConvertToJson(plainXml);
            }
            catch (Exception ex)
            {
                throw new WechatTenpayException("Failed to decrypt event resource data. Please see the inner exception for more details.", ex);
            }

            return client.JsonSerializer.Deserialize<T>(plainJson);
        }
    }
}
