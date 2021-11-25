using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供响应敏感数据解密的扩展方法。
    /// </summary>
    public static class WechatTenpayClientResponseDecryptionExtensions
    {
        /// <summary>
        /// <para>解密响应中返回的敏感数据。该方法会改变传入的响应信息。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static TResponse DecryptResponseSensitiveProperty<TResponse>(this WechatTenpayClient client, TResponse response)
            where TResponse : WechatTenpayResponse
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (string.IsNullOrEmpty(client.Credentials.MerchantCertPrivateKey))
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed, because there is no merchant private key.");

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

                // 遍历并解密被标记为敏感数据的字段
                Utilities.ReflectionUtility.ReplacePropertyStringValue(ref response, (obj, prop, value) =>
                {
                    var attr = prop.GetCustomAttribute<WechatTenpaySensitivePropertyAttribute>();
                    if (attr == null)
                        return value;

                    if (Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB.Equals(attr.Algorithm))
                    {
                        return Utilities.RSAUtility.DecryptWithECB(
                            privateKey: client.Credentials.MerchantCertPrivateKey,
                            cipherText: value
                        );
                    }
                    else
                    {
                        throw new Exceptions.WechatTenpayResponseDecryptionException("Unsupported decryption algorithm.");
                    }
                });
            }
            catch (Exception ex) when (!(ex is Exceptions.WechatTenpayResponseDecryptionException))
            {
                throw new Exceptions.WechatTenpayResponseDecryptionException("Decrypt response failed. Please see the `InnerException` for more details.", ex);
            }

            return response;
        }
    }
}
