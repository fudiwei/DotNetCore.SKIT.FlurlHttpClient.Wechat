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
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (request == null) throw new ArgumentNullException(nameof(request));

            try
            {
                bool requireEncrypt = request.GetType().GetCustomAttributes<WechatTenpayBusinessSensitiveAttribute>(inherit: true).Any();
                if (requireEncrypt)
                {
                    if (request.TBEPEncryption is null)
                        request.TBEPEncryption = new WechatTenpayBusinessRequestTBEPEncryption() { Algorithm = client.Credentials.SensitivePropertyEncryptionAlgorithm };

                    if (Constants.EncryptionAlgorithms.RSA_OAEP_WITH_SM4_128_CBC.Equals(request.TBEPEncryption.Algorithm))
                    {
                        Utilities.ReflectionUtility.ReplacePropertyStringValue(ref request, (target, currentProp, oldValue) =>
                        {
                            var attr = currentProp.GetCustomAttribute<WechatTenpayBusinessSensitivePropertyAttribute>();
                            if (attr == null)
                                return (false, oldValue);

                            string sm4IV = client.Credentials.SensitivePropertyEncryptionSM4IV!;
                            string sm4Key = client.Credentials.SensitivePropertyEncryptionSM4Key!;
                            string sm4EncryptedKey = Utilities.RSAUtility.EncryptWithECB(publicKey: client.Credentials.TBEPCertificatePublicKey, plainText: sm4Key);

                            request.TBEPEncryption.CertificateSerialNumber = client.Credentials.TBEPCertificateSerialNumber;
                            request.TBEPEncryption.EncryptedKey = sm4EncryptedKey;
                            request.TBEPEncryption.IV = sm4IV;

                            string newValue = Utilities.SM4Utility.EncryptWithCBC(key: sm4Key, iv: sm4IV, plainText: oldValue);
                            return (true, newValue);
                        });
                    }
                    else
                    {
                        throw new NotSupportedException("Unsupported encryption algorithm.");
                    }
                }
            }
            catch (Exception ex) when (!(ex is Exceptions.WechatTenpayBusinessRequestEncryptionException))
            {
                throw new Exceptions.WechatTenpayBusinessRequestEncryptionException("Encrypt request failed. Please see the `InnerException` for more details.", ex);
            }

            return request;
        }
    }
}
