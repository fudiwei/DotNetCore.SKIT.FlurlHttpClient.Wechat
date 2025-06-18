using System;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    using SKIT.FlurlHttpClient.Primitives;

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
                bool requireEncrypt = request.GetType().IsDefined(typeof(WechatTenpayBusinessSensitiveAttribute));
                if (!requireEncrypt)
                    return request;

                if (request.WechatpayEncryption is null)
                    request.WechatpayEncryption = new WechatTenpayBusinessRequestEncryption() { Algorithm = client.Credentials.SensitivePropertyEncryptionAlgorithm };

                if (Constants.EncryptionAlgorithms.RSA_OAEP_WITH_SM4_128_CBC.Equals(request.WechatpayEncryption.Algorithm))
                {
                    Utilities.ReflectionHelper.ReplaceObjectStringProperties(request, (_, currentProp, oldValue) =>
                    {
                        if (currentProp is null || !currentProp.IsDefined(typeof(WechatTenpayBusinessSensitivePropertyAttribute)))
                            return (false, oldValue);

                        string sm4IV = client.Credentials.SensitivePropertyEncryptionSM4IV!;
                        string sm4Key = client.Credentials.SensitivePropertyEncryptionSM4Key!;
                        string sm4EncryptedKey = Utilities.RSAUtility.EncryptWithECB(publicKeyPem: client.Credentials.TBEPCertificatePublicKey, plainData: sm4Key).Value!;

                        request.WechatpayEncryption.SerialNumber = client.Credentials.TBEPCertificateSerialNumber;
                        request.WechatpayEncryption.EncryptedKey = sm4EncryptedKey;
                        request.WechatpayEncryption.IV = sm4IV;

                        string newValue = Utilities.SM4Utility.EncryptWithCBC(encodingKey: new EncodedString(sm4Key, EncodingKinds.Base64), encodingIV: new EncodedString(sm4IV, EncodingKinds.Base64), plainData: oldValue).Value!;
                        return (true, newValue);
                    });
                }
                else
                {
                    throw new WechatTenpayBusinessException($"Failed to encrypt request. Unsupported encryption algorithm: \"{request.WechatpayEncryption.Algorithm}\".");
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
