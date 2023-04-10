using System;
using System.Linq;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
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
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (!response.IsSuccessful())
                throw new Exceptions.WechatTenpayBusinessResponseDecryptionException("Failed to decrypt response, because the response is not successful.");

            try
            {
                bool requireDecrypt = response.GetType().GetCustomAttributes<WechatTenpayBusinessSensitiveAttribute>(inherit: true).Any();
                if (requireDecrypt)
                {
                    if (response.Encryption is null)
                        throw new InvalidOperationException("Could not read value of 'TBEP-Encrypt'.");
                    if (response.Encryption.PlatformId != null && response.Encryption.SerialNumber != client.Credentials.PlatformCertificateSerialNumber)
                        throw new Exceptions.WechatTenpayBusinessResponseDecryptionException("Failed to decrypt response, because the platform certificate serial number does not match.");
                    if (response.Encryption.EnterpriseId != null && response.Encryption.SerialNumber != client.Credentials.EnterpriseCertificateSerialNumber)
                        throw new Exceptions.WechatTenpayBusinessResponseDecryptionException("Failed to decrypt response, because the enterprise certificate serial number does not match.");

                    if (Constants.EncryptionAlgorithms.RSA_OAEP_WITH_SM4_128_CBC.Equals(response.Encryption.Algorithm))
                    {
                        Utilities.ReflectionUtility.ReplacePropertyStringValue(ref response, (target, currentProp, oldValue) =>
                        {
                            var attr = currentProp.GetCustomAttribute<WechatTenpayBusinessSensitivePropertyAttribute>();
                            if (attr == null)
                                return (false, oldValue);

                            string sm4EncryptedKey = response.Encryption.EncryptedKey!;
                            string sm4Key = Utilities.RSAUtility.DecryptWithECB(
                                privateKey: response.Encryption.PlatformId != null ? client.Credentials.PlatformCertificatePrivateKey! :
                                            response.Encryption.EnterpriseId != null ? client.Credentials.EnterpriseCertificatePrivateKey! :
                                            string.Empty,
                                cipherText: sm4EncryptedKey
                            );
                            string sm4IV = response.Encryption.IV!;

                            string newValue = Utilities.SM4Utility.DecryptWithCBC(key: sm4Key, iv: sm4IV, cipherText: oldValue);
                            return (true, newValue);
                        });
                    }
                    else
                    {
                        throw new NotSupportedException("Unsupported decryption algorithm.");
                    }
                }
            }
            catch (Exception ex) when (!(ex is Exceptions.WechatTenpayBusinessResponseDecryptionException))
            {
                throw new Exceptions.WechatTenpayBusinessResponseDecryptionException("Failed to decrypt response. Please see the inner exception for more details.", ex);
            }

            return response;
        }
    }
}
