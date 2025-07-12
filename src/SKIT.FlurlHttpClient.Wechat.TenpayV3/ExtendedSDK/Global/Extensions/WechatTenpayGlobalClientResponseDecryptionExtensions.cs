using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    using SKIT.FlurlHttpClient.Primitives;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Constants;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities;

    public static class WechatTenpayGlobalClientResponseDecryptionExtensions
    {
        /// <summary>
        /// <para>解密响应中返回的敏感数据。该方法会改变传入的响应模型对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static QueryCertificatesResponse DecryptResponseSensitiveProperty(this WechatTenpayGlobalClient client, QueryCertificatesResponse response)
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
        public static TResponse DecryptResponseSensitiveProperty<TResponse>(this WechatTenpayGlobalClient client, TResponse response)
            where TResponse : WechatTenpayGlobalResponse
        {
            // [GET] /certificates 接口的响应模型需特殊处理
            if (response is QueryCertificatesResponse queryCertificatesResponse)
            {
                return (DecryptResponseSensitiveProperty(client, queryCertificatesResponse) as TResponse)!;
            }

            return WechatTenpayClientResponseDecryptionExtensions.DecryptResponseSensitiveProperty(client.ProxyClient, response);
        }
    }
}
