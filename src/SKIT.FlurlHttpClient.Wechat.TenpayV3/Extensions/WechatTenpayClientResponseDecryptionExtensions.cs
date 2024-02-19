using System;
using System.Linq;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Primitives;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Constants;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Models;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities;

    public static class WechatTenpayClientResponseDecryptionExtensions
    {
        /// <summary>
        /// <para>解密响应中返回的敏感数据。该方法会改变传入的响应模型对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static QueryCertificatesResponse DecryptResponseSensitiveProperty(this WechatTenpayClient client, QueryCertificatesResponse response)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (response is null) throw new ArgumentNullException(nameof(response));

            if (response.CertificateList is null)
                return response;

            foreach (var certificate in response.CertificateList)
            {
                if (certificate.EncryptCertificate is null)
                    continue;

                switch (certificate.EncryptCertificate.Algorithm)
                {
                    case EncryptionAlgorithms.AEAD_AES_256_GCM:
                        {
                            if (string.IsNullOrEmpty(client.Credentials.MerchantV3Secret))
                                throw new WechatTenpayException("Failed to decrypt response, because the merchant APIv3 secret is not set.");

                            certificate.EncryptCertificate.CipherText = AESUtility.DecryptWithGCM(
                                encodingKey: new EncodedString(client.Credentials.MerchantV3Secret, EncodingKinds.Literal),
                                encodingNonce: new EncodedString(certificate.EncryptCertificate.Nonce, EncodingKinds.Literal),
                                encodingAssociatedData: new EncodedString(certificate.EncryptCertificate.AssociatedData, EncodingKinds.Literal),
                                encodingCipher: new EncodedString(certificate.EncryptCertificate.CipherText, EncodingKinds.Base64)
                            )!;
                        }
                        break;

                    case EncryptionAlgorithms.AEAD_SM4_128_GCM:
                        {
                            if (string.IsNullOrEmpty(client.Credentials.MerchantV3Secret))
                                throw new WechatTenpayException("Failed to decrypt response, because the merchant APIv3 secret is not set.");

                            // REF: https://pay.weixin.qq.com/docs/merchant/development/shangmi/guide.html
                            // 由于 SM4 密钥长度的限制，密钥由 APIv3 密钥通过国密 SM3 Hash 计算生成。SM4 密钥取其摘要（256bit）的前 128bit。
                            byte[] secretBytes = SM3Utility.Hash(EncodedString.FromLiteralString(client.Credentials.MerchantV3Secret));
                            byte[] keyBytes = new byte[16];
                            Array.Copy(secretBytes, keyBytes, keyBytes.Length);

                            byte[] plainBytes = SM4Utility.DecryptWithGCM(
                                keyBytes: keyBytes,
                                nonceBytes: EncodedString.FromLiteralString(certificate.EncryptCertificate.Nonce),
                                associatedDataBytes: EncodedString.FromLiteralString(certificate.EncryptCertificate.AssociatedData),
                                cipherBytes: EncodedString.FromBase64String(certificate.EncryptCertificate.CipherText)
                            );
                            certificate.EncryptCertificate.CipherText = EncodedString.ToLiteralString(plainBytes).Value!;
                        }
                        break;

                    default:
                        {
                            throw new WechatTenpayException($"Failed to decrypt response. Unsupported encryption algorithm: \"{certificate.EncryptCertificate.Algorithm}\".");
                        }
                }
            }

            return response;
        }

        /// <summary>
        /// <para>解密响应中返回的敏感数据。该方法会改变传入的响应模型对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static TResponse DecryptResponseSensitiveProperty<TResponse>(this WechatTenpayClient client, TResponse response)
            where TResponse : WechatTenpayResponse
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (response is null) throw new ArgumentNullException(nameof(response));

            if (!response.IsSuccessful())
                throw new WechatTenpayException("Failed to decrypt response, because the response is not successful.");

            try
            {
                // [GET] /certificates 接口的响应模型需特殊处理
                if (response is QueryCertificatesResponse queryCertificatesResponse)
                {
                    return (DecryptResponseSensitiveProperty(client, queryCertificatesResponse) as TResponse)!;
                }

                // 遍历并解密被标记为敏感数据的字段
                bool requireDecrypt = Attribute.IsDefined(response.GetType(), typeof(WechatTenpaySensitiveAttribute));
                if (!requireDecrypt)
                    return response;

                string signScheme = client.Credentials.SignScheme;

                ReflectionHelper.ReplaceObjectStringProperties(response, (_, currentProp, oldValue) =>
                {
                    if (currentProp is null || !currentProp.IsDefined(typeof(WechatTenpaySensitivePropertyAttribute)))
                        return (false, oldValue);

                    WechatTenpaySensitivePropertyAttribute? attribute = currentProp
                        .GetCustomAttributes<WechatTenpaySensitivePropertyAttribute>()
                        .FirstOrDefault(attr => attr.Scheme == signScheme);
                    if (attribute is null)
                        return (false, oldValue);

                    string newValue;
                    switch (attribute.Algorithm)
                    {
                        case EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1:
                            {
                                newValue = RSAUtility.DecryptWithECB(
                                    privateKeyPem: client.Credentials.MerchantCertificatePrivateKey,
                                    encodingCipher: new EncodedString(oldValue, EncodingKinds.Base64),
                                    paddingMode: RSAUtility.PADDING_MODE_OAEPWITHSHA1ANDMGF1
                                )!;
                            }
                            break;

                        case EncryptionAlgorithms.RSA_2048_ECB_PKCS1:
                            {
                                newValue = RSAUtility.DecryptWithECB(
                                    privateKeyPem: client.Credentials.MerchantCertificatePrivateKey,
                                    encodingCipher: new EncodedString(oldValue, EncodingKinds.Base64),
                                    paddingMode: RSAUtility.PADDING_MODE_PKCS1
                                )!;
                            }
                            break;

                        case EncryptionAlgorithms.SM2_C1C3C2_ASN1:
                            {
                                newValue = SM2Utility.Decrypt(
                                    privateKeyPem: client.Credentials.MerchantCertificatePrivateKey,
                                    encodingCipher: new EncodedString(oldValue, EncodingKinds.Base64),
                                    asn1Encoding: true
                                )!;
                            }
                            break;

                        default:
                            {
                                throw new WechatTenpayException($"Failed to decrypt response. Unsupported encryption algorithm: \"{attribute.Algorithm}\".");
                            }
                    }

                    return (true, newValue);
                });

                return response;
            }
            catch (WechatTenpayException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new WechatTenpayException("Failed to decrypt response. Please see the inner exception for more details.", ex);
            }
        }
    }
}
