using System;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
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
            switch (resource.Algorithm)
            {
                case Constants.EncryptionAlgorithms.AEAD_AES_256_GCM:
                    {
                        try
                        {
                            plainJson = Utilities.AESUtility.DecryptWithGCM(
                                key: client.Credentials.MerchantV3Secret,
                                nonce: resource.Nonce,
                                aad: resource.AssociatedData,
                                cipherText: resource.CipherText
                            );
                        }
                        catch (Exception ex)
                        {
                            throw new Exceptions.WechatTenpayEventDecryptionException("Failed to decrypt event resource data. Please see the inner exception for more details.", ex);
                        }
                    }
                    break;

                case Constants.EncryptionAlgorithms.AEAD_SM4_128_GCM:
                    {
                        try
                        {
                            // REF: https://pay.weixin.qq.com/docs/merchant/development/shangmi/guide.html
                            // 由于 SM4 密钥长度的限制，密钥由 APIv3 密钥通过国密 SM3 Hash 计算生成。SM4 密钥取其摘要（256bit）的前 128bit。
                            byte[] secretBytes = Utilities.SM3Utility.Hash(Encoding.UTF8.GetBytes(client.Credentials.MerchantV3Secret));
                            byte[] keyBytes = new byte[16];
                            Array.Copy(secretBytes, keyBytes, keyBytes.Length);

                            byte[] plainBytes = Utilities.SM4Utility.DecryptWithGCM(
                                keyBytes: keyBytes,
                                nonceBytes: Encoding.UTF8.GetBytes(resource.Nonce),
                                aadBytes: resource.AssociatedData is null ? null : Encoding.UTF8.GetBytes(resource.AssociatedData),
                                cipherBytes: Convert.FromBase64String(resource.CipherText)
                            );
                            plainJson = Encoding.UTF8.GetString(plainBytes);
                        }
                        catch (Exception ex)
                        {
                            throw new Exceptions.WechatTenpayEventDecryptionException("Failed to decrypt event resource data. Please see the inner exception for more details.", ex);
                        }
                    }
                    break;

                default:
                    {
                        throw new Exceptions.WechatTenpayEventDecryptionException($"Unsupported encryption algorithm: \"{resource.Algorithm}\".");
                    }
            }

            return client.JsonSerializer.Deserialize<T>(plainJson);
        }
    }
}
