using System;
using System.Linq;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientRequestEncryptionExtensions
    {
        /// <summary>
        /// <para>加密请求中传入的敏感数据。该方法会改变传入的请求模型对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static TRequest EncryptRequestSensitiveProperty<TRequest>(this WechatTenpayBusinessClient client, TRequest request)
            where TRequest : WechatTenpayBusinessRequest
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            try
            {
                bool requireEncrypt = request.GetType().GetCustomAttributes<WechatTenpayBusinessSensitiveAttribute>(inherit: true).Any();
                if (requireEncrypt)
                {
                    if (request.WechatpayEncryption is null)
                        request.WechatpayEncryption = new WechatTenpayBusinessRequestEncryption() { Algorithm = client.Credentials.SensitivePropertyEncryptionAlgorithm };

                    if (Constants.EncryptionAlgorithms.RSA_OAEP_WITH_SM4_128_CBC.Equals(request.WechatpayEncryption.Algorithm))
                    {
                        Utilities.ReflectionUtility.ReplacePropertyStringValue(ref request, (target, currentProp, oldValue) =>
                        {
                            var attr = currentProp.GetCustomAttribute<WechatTenpayBusinessSensitivePropertyAttribute>();
                            if (attr is null)
                                return (false, oldValue);

                            string sm4IV = client.Credentials.SensitivePropertyEncryptionSM4IV!;
                            string sm4Key = client.Credentials.SensitivePropertyEncryptionSM4Key!;
                            string sm4EncryptedKey = Utilities.RSAUtility.EncryptWithECB(publicKey: client.Credentials.TBEPCertificatePublicKey, plainText: sm4Key);

                            request.WechatpayEncryption.SerialNumber = client.Credentials.TBEPCertificateSerialNumber;
                            request.WechatpayEncryption.EncryptedKey = sm4EncryptedKey;
                            request.WechatpayEncryption.IV = sm4IV;

                            string newValue = Utilities.SM4Utility.EncryptWithCBC(key: sm4Key, iv: sm4IV, plainText: oldValue);
                            return (true, newValue);
                        });
                    }
                    else
                    {
                        throw new WechatTenpayBusinessException($"Failed to encrypt request. Unsupported encryption algorithm: \"{request.WechatpayEncryption.Algorithm}\".");
                    }
                }
            }
            catch (WechatTenpayBusinessException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new WechatTenpayBusinessException("Failed to encrypt request. Please see the inner exception for more details.", ex);
            }

            return request;
        }
    }
}
