using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
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
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static WechatTenpayEvent DeserializeEvent(this WechatTenpayClient client, string callbackJson)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackJson)) throw new ArgumentNullException(callbackJson);

            return client.JsonSerializer.Deserialize<WechatTenpayEvent>(callbackJson);
        }

        /// <summary>
        /// 返回序列化并解密事件数据中被加密的通知数据。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public static T DecryptEventResource<T>(this WechatTenpayClient client, WechatTenpayEvent callback)
            where T : WechatTenpayEvent.Types.IDecryptedResource, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callback == null) throw new ArgumentNullException(nameof(callback));

            return DecryptEventResource<T>(client, callback.Resource);
        }

        /// <summary>
        /// 返回序列化并解密事件数据中被加密的通知数据。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="resource"></param>
        /// <returns></returns>
        public static T DecryptEventResource<T>(this WechatTenpayClient client, WechatTenpayEvent.Types.Resource resource)
            where T : WechatTenpayEvent.Types.IDecryptedResource, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (resource == null) throw new ArgumentNullException(nameof(resource));

            string plainJson;

            if (Constants.EncryptionAlgorithms.AEAD_AES_256_GCM.Equals(resource.Algorithm))
            {
                try
                {
                    plainJson = Utilities.AESUtility.DecryptWithGCM(
                        key: client.Credentials.MerchantV3Secret,
                        iv: resource.Nonce,
                        aad: resource.AssociatedData,
                        cipherText: resource.CipherText
                    );
                }
                catch (Exception ex)
                {
                    throw new Exceptions.WechatTenpayEventDecryptionException("Decrypt event resource failed. Please see the `InnerException` for more details.", ex);
                }
            }
            else
            {
                throw new Exceptions.WechatTenpayEventDecryptionException("Unsupported encrypt algorithm of the resource.");
            }

            return client.JsonSerializer.Deserialize<T>(plainJson);
        }
    }
}
