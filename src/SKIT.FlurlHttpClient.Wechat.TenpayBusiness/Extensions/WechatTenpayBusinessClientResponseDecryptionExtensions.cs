using System;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    using SKIT.FlurlHttpClient.Primitives;

    public static class WechatTenpayBusinessClientResponseDecryptionExtensions
    {
        /// <summary>
        /// <para>解密响应中返回的敏感数据。该方法会改变传入的响应模型对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static TResponse DecryptResponseSensitiveProperty<TResponse>(this WechatTenpayBusinessClient client, TResponse response)
            where TResponse : WechatTenpayBusinessResponse
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (response is null) throw new ArgumentNullException(nameof(response));

            if (!response.IsSuccessful())
                throw new WechatTenpayBusinessException("Failed to decrypt response, because the response is not successful.");

            try
            {
                bool requireDecrypt = response.GetType().IsDefined(typeof(WechatTenpayBusinessSensitiveAttribute));
                if (!requireDecrypt)
                    return response;

                if (response.WechatpayEncryption is null)
                    throw new InvalidOperationException("Failed to decrypt response, because the value of \"TBEP-Encrypt\" is empty.");
                if (response.WechatpayEncryption.PlatformId is not null && response.WechatpayEncryption.SerialNumber != client.Credentials.PlatformCertificateSerialNumber)
                    throw new WechatTenpayBusinessException($"Failed to decrypt response, because the platform certificate with serial number \"{response.WechatpayEncryption.SerialNumber}\" does not existed.");
                if (response.WechatpayEncryption.EnterpriseId is not null && response.WechatpayEncryption.SerialNumber != client.Credentials.EnterpriseCertificateSerialNumber)
                    throw new WechatTenpayBusinessException($"Failed to decrypt response, because the enterprise certificate serial number \"{response.WechatpayEncryption.SerialNumber}\" does not existed.");

                if (Constants.EncryptionAlgorithms.RSA_OAEP_WITH_SM4_128_CBC.Equals(response.WechatpayEncryption.Algorithm))
                {
                    Utilities.ReflectionHelper.ReplaceObjectStringProperties(response, (_, currentProp, oldValue) =>
                    {
                        if (currentProp is null || !currentProp.IsDefined(typeof(WechatTenpayBusinessSensitivePropertyAttribute)))
                            return (false, oldValue);

                        string sm4EncryptedKey = response.WechatpayEncryption.EncryptedKey!;
                        string sm4Key = Utilities.RSAUtility.DecryptWithECB(
                            privateKeyPem: response.WechatpayEncryption.PlatformId is not null ? client.Credentials.PlatformCertificatePrivateKey! :
                                        response.WechatpayEncryption.EnterpriseId is not null ? client.Credentials.EnterpriseCertificatePrivateKey! :
                                        string.Empty,
                            encodingCipher: new EncodedString(sm4EncryptedKey, EncodingKinds.Base64)
                        )!;
                        string sm4IV = response.WechatpayEncryption.IV!;

                        string newValue = Utilities.SM4Utility.DecryptWithCBC(encodingKey: new EncodedString(sm4Key, EncodingKinds.Base64), encodingIV: new EncodedString(sm4IV, EncodingKinds.Base64), encodingCipher: new EncodedString(oldValue, EncodingKinds.Base64)).Value!;
                        return (true, newValue);
                    });
                }
                else
                {
                    throw new WechatTenpayBusinessException($"Failed to decrypt response. Unsupported encryption algorithm: \"{response.WechatpayEncryption.Algorithm}\".");
                }
            }
            catch (WechatTenpayBusinessException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new WechatTenpayBusinessException("Failed to decrypt response. Please see the inner exception for more details.", ex);
            }

            return response;
        }
    }
}
