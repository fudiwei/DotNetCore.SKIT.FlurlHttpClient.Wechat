using System;
using System.Linq;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供响应模型敏感数据解密的扩展方法。
    /// </summary>
    public static class WechatTenpayClientResponseDecryptionExtensions
    {
        /// <summary>
        /// <para>解密响应中返回的敏感数据。该方法会改变传入的响应模型对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static TResponse DecryptResponseSensitiveProperty<TResponse>(this WechatTenpayClient client, TResponse response)
            where TResponse : WechatTenpayResponse
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (!response.IsSuccessful())
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because the response is not successful.");

            try
            {
                // [GET] /certificates 接口的响应模型需特殊处理
                if (response is Models.QueryCertificatesResponse queryCertificatesResponse)
                {
                    if (queryCertificatesResponse.CertificateList == null)
                        return response;

                    foreach (var certificateModel in queryCertificatesResponse.CertificateList)
                    {
                        if (Constants.EncryptionAlgorithms.AEAD_AES_256_GCM.Equals(certificateModel.EncryptCertificate?.Algorithm))
                        {
                            if (string.IsNullOrEmpty(client.Credentials.MerchantCertificatePrivateKey))
                                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because there is no merchant private key.");

                            certificateModel.EncryptCertificate.CipherText = Utilities.AESUtility.DecryptWithGCM(
                                key: client.Credentials.MerchantV3Secret,
                                iv: certificateModel.EncryptCertificate.Nonce,
                                aad: certificateModel.EncryptCertificate.AssociatedData,
                                cipherText: certificateModel.EncryptCertificate.CipherText
                            );
                        }
                        else
                        {
                            throw new Exceptions.WechatTenpayResponseDecryptionException("Unsupported decryption algorithm.");
                        }
                    }

                    return response;
                }

                bool requireDecrypt = Attribute.IsDefined(response.GetType(), typeof(WechatTenpaySensitiveAttribute));
                if (requireDecrypt)
                {
                    // 遍历并解密被标记为敏感数据的字段
                    Utilities.ReflectionUtility.ReplacePropertyStringValue(ref response, (target, currentProp, oldValue) =>
                    {
                        var attr = currentProp.GetCustomAttribute<WechatTenpaySensitivePropertyAttribute>();
                        if (attr == null)
                            return (false, oldValue);

                        if (Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1.Equals(attr.Algorithm) ||
                            Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS1.Equals(attr.Algorithm))
                        {
                            string newValue = oldValue;
                            if (Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1.Equals(attr.Algorithm))
                            {
                                newValue = Utilities.RSAUtility.DecryptWithECB(
                                    privateKey: client.Credentials.MerchantCertificatePrivateKey,
                                    cipherText: oldValue
                                );
                            }
                            else if (Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS1.Equals(attr.Algorithm))
                            {
                                newValue = Utilities.RSAUtility.DecryptWithECB(
                                    privateKey: client.Credentials.MerchantCertificatePrivateKey,
                                    cipherText: oldValue,
                                    paddingMode: "PKCS1PADDING"
                                );
                            }

                            return (true, newValue);
                        }
                        else
                        {
                            throw new Exceptions.WechatTenpayResponseDecryptionException("Unsupported decryption algorithm.");
                        }
                    });
                }
            }
            catch (Exception ex) when (!(ex is Exceptions.WechatTenpayResponseDecryptionException))
            {
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed. Please see the `InnerException` for more details.", ex);
            }

            return response;
        }
    }
}
