using System;
using System.Linq;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供请求模型敏感数据加密的扩展方法。
    /// </summary>
    public static class WechatTenpayClientRequestEncryptionExtensions
    {
        /// <summary>
        /// <para>加密请求中传入的敏感数据。该方法会改变传入的请求模型对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static TRequest EncryptRequestSensitiveProperty<TRequest>(this WechatTenpayClient client, TRequest request)
            where TRequest : WechatTenpayRequest
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (request == null) throw new ArgumentNullException(nameof(request));

            try
            {
                bool requireEncrypt = request.GetType().GetCustomAttributes<WechatTenpaySensitiveAttribute>(inherit: true).Any();
                if (requireEncrypt)
                {
                    // 遍历并加密被标记为敏感数据的字段
                    Utilities.ReflectionUtility.ReplacePropertyStringValue(ref request, (target, currentProp, oldValue) =>
                    {
                        var attr = currentProp.GetCustomAttribute<WechatTenpaySensitivePropertyAttribute>();
                        if (attr == null)
                            return (false, oldValue);

                        if (Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1.Equals(attr.Algorithm) ||
                            Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS1.Equals(attr.Algorithm))
                        {
                            if (client.PlatformCertificateManager == null)
                                throw new Exceptions.WechatTenpayRequestEncryptionException("Encrypt request failed, because there is no platform certificate in the manager.");

                            string certificate;

                            if (!string.IsNullOrEmpty(request.WechatpayCertificateSerialNumber))
                            {
                                // 如果已在请求中指定特定的平台证书序列号，直接从管理器中取值
                                var cert = client.PlatformCertificateManager.GetEntry(request.WechatpayCertificateSerialNumber!);
                                if (!cert.HasValue)
                                {
                                    throw new Exceptions.WechatTenpayEventVerificationException("Encrypt request failed, because there is no platform certificate matched the serial number.");
                                }

                                certificate = cert.Value.Certificate;
                            }
                            else
                            {
                                // 如果未在请求中指定特定的平台证书序列号，从管理器中取过期时间最远的
                                var certs = client.PlatformCertificateManager.AllEntries().OrderByDescending(e => e.ExpireTime);
                                if (!certs.Any())
                                {
                                    throw new Exceptions.WechatTenpayEventVerificationException("Encrypt request failed, because there is no platform certificate in the manager.");
                                }

                                var cert = certs.First();
                                certificate = cert.Certificate;
                                request.WechatpayCertificateSerialNumber = cert.SerialNumber;
                            }

                            string newValue = oldValue;
                            if (Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1.Equals(attr.Algorithm))
                            {
                                newValue = Utilities.RSAUtility.EncryptWithECBByCertificate(
                                    certificate: certificate,
                                    plainText: oldValue
                                );
                            }
                            else if (Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS1.Equals(attr.Algorithm))
                            {
                                newValue = Utilities.RSAUtility.EncryptWithECBByCertificate(
                                    certificate: certificate,
                                    plainText: oldValue,
                                    paddingMode: "PKCS1PADDING"
                                );
                            }

                            return (true, newValue);
                        }
                        else
                        {
                            throw new Exceptions.WechatTenpayRequestEncryptionException("Unsupported encryption algorithm.");
                        }
                    });
                }
            }
            catch (Exception ex) when (!(ex is Exceptions.WechatTenpayRequestEncryptionException))
            {
                throw new Exceptions.WechatTenpayRequestEncryptionException("Encrypt request failed. Please see the `InnerException` for more details.", ex);
            }

            return request;
        }
    }
}
