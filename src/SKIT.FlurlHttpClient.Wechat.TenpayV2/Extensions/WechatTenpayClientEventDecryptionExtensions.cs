using System;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供回调通知事件敏感数据解密的扩展方法。
    /// </summary>
    public static class WechatTenpayClientEventDecryptionExtensions
    {
        /// <summary>
        /// <para>反序列化得到 <see cref="WechatTenpayEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static WechatTenpayEvent DeserializeEvent(this WechatTenpayClient client, string callbackXml)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackXml == null) throw new ArgumentNullException(callbackXml);

            string callbackJson = Utilities.XmlUtility.ConvertToJson(callbackXml);
            return client.JsonSerializer.Deserialize<WechatTenpayEvent>(callbackJson);
        }

        /// <summary>
        /// <para>反序列化得到微信支付回调通知事件模型对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEvent<TEvent>(this WechatTenpayClient client, string callbackXml)
            where TEvent : WechatTenpayEvent, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackXml == null) throw new ArgumentNullException(callbackXml);

            string callbackJson = Utilities.XmlUtility.ConvertToJson(callbackXml);
            return client.JsonSerializer.Deserialize<TEvent>(callbackJson);
        }

        /// <summary>
        /// 返回序列化并解密事件数据中被加密的信息。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public static T DecryptEventRequestInfo<T>(this WechatTenpayClient client, WechatTenpayEvent callback)
            where T : WechatTenpayEvent.Types.IDecryptedRequestInfo, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callback == null) throw new ArgumentNullException(nameof(callback));

            string plainJson;

            try
            {
                string key = Utilities.MD5Utility.Hash(client.Credentials.MerchantSecret).ToLower();
                string plainXml = Utilities.AESUtility.DecryptWithECB(
                    encodingKey: Convert.ToBase64String(Encoding.UTF8.GetBytes(key)),
                    encodingCipherText: callback.EncryptedRequestInfo!
                );
                plainJson = Utilities.XmlUtility.ConvertToJson(plainXml);
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatTenpayEventDecryptionException("Failed to decrypt event resource data. Please see the inner exception for more details.", ex);
            }

            return client.JsonSerializer.Deserialize<T>(plainJson);
        }
    }
}
