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
                // 遍历并加密被标记为敏感数据的字段
                Utilities.ReflectionUtility.ReplacePropertyStringValue(ref request, (obj, prop, value) =>
                {
                    var attr = prop.GetCustomAttribute<WechatTenpaySensitivePropertyAttribute>();
                    if (attr == null)
                        return value;

                    if (Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB.Equals(attr.Algorithm))
                    {
                        if (client.CertificateManager == null)
                            throw new Exceptions.WechatTenpayRequestEncryptionException("Encrypt request failed, because there is no platform certificate in the manager.");

                        string certificate;

                        if (!string.IsNullOrEmpty(request.WechatpayCertSerialNumber))
                        {
                            // 如果已在请求中指定特定的平台证书序列号，直接从管理器中取值
                            var cert = client.CertificateManager.GetEntry(request.WechatpayCertSerialNumber!);
                            if (!cert.HasValue)
                            {
                                throw new Exceptions.WechatTenpayEventVerificationException("Encrypt request failed, because there is no platform certificate matched the serial number.");
                            }

                            certificate = cert.Value.Certificate;
                        }
                        else
                        {
                            // 如果未在请求中指定特定的平台证书序列号，从管理器中取过期时间最远的
                            var certs = client.CertificateManager.AllEntries().OrderByDescending(e => e.ExpireTime);
                            if (!certs.Any())
                            {
                                throw new Exceptions.WechatTenpayEventVerificationException("Encrypt request failed, because there is no platform certificate in the manager.");
                            }

                            certificate = certs.First().Certificate;
                        }

                        return Utilities.RSAUtility.EncryptWithECBByCertificate(
                            certificate: certificate,
                            plainText: value
                        );
                    }
                    else
                    {
                        throw new Exceptions.WechatTenpayRequestEncryptionException("Unsupported encryption algorithm.");
                    }
                });
            }
            catch (Exception ex) when (!(ex is Exceptions.WechatTenpayRequestEncryptionException))
            {
                throw new Exceptions.WechatTenpayRequestEncryptionException("Encrypt request failed. Please see the `InnerException` for more details.", ex);
            }

            return request;
        }
    }
}
