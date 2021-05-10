using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static class WechatTenpayClientCallbackDeserializationExtensions
    {
        /// <summary>
        /// <para>反序列化得到 <see cref="WechatTenpayCallback"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static WechatTenpayCallback DeserializeCallback(this WechatTenpayClient client, string callbackJson)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackJson)) throw new ArgumentNullException(callbackJson);

            return client.JsonSerializer.Deserialize<WechatTenpayCallback>(callbackJson);
        }

        /// <summary>
        /// 返回序列化并解密事件数据中被加密的通知数据。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public static T DecryptCallbackResource<T>(this WechatTenpayClient client, WechatTenpayCallback callback)
            where T : WechatTenpayCallback.Types.IDecryptedResource, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callback == null) throw new ArgumentNullException(nameof(callback));

            return DecryptCallbackResource<T>(client, callback.Resource);
        }

        /// <summary>
        /// 返回序列化并解密事件数据中被加密的通知数据。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="resource"></param>
        /// <returns></returns>
        public static T DecryptCallbackResource<T>(this WechatTenpayClient client, WechatTenpayCallback.Types.Resource resource)
            where T : WechatTenpayCallback.Types.IDecryptedResource, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (resource == null) throw new ArgumentNullException(nameof(resource));

            string plainJson;

            if (Constants.EncryptionAlgorithms.AEAD_AES_256_GCM.Equals(resource.Algorithm))
            {
                try
                {
                    plainJson = Utilities.AesUtil.DecryptWithGCM(
                        aesKey: client.MerchantV3Secret,
                        nonce: resource.Nonce,
                        associatedData: resource.AssociatedData,
                        cipherText: resource.CipherText
                    );
                }
                catch (Exception ex)
                {
                    throw new Exceptions.WechatTenpayCallbackDecryptionException("Decrypt callback failed.", ex);
                }
            }
            else
            {
                throw new Exceptions.WechatTenpayCallbackDecryptionException("Unknown encrypt algorithm of the resource.");
            }

            return client.JsonSerializer.Deserialize<T>(plainJson);
        }
    }
}
