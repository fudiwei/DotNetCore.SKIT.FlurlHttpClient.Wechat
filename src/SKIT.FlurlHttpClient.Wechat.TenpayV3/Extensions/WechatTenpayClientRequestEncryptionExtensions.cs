using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供请求模型敏感数据加密的扩展方法。
    /// </summary>
    public static class WechatTenpayClientRequestEncryptionExtensions
    {
        private static TRequest InnerEncryptRequestSensitivePropertyByRSA<TRequest>(WechatTenpayClient client, TRequest request)
            where TRequest : WechatTenpayRequest
        {
            Utilities.ReflectionUtility.ReplacePropertyStringValue(ref request, (target, currentProp, oldValue) =>
            {
                WechatTenpaySensitivePropertyAttribute? attribute = currentProp
                    .GetCustomAttributes<WechatTenpaySensitivePropertyAttribute>()
                    .FirstOrDefault(attr => Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256.Equals(attr.Scheme));
                if (attribute == null)
                    return (false, oldValue);

                if (client.PlatformCertificateManager == null)
                    throw new Exceptions.WechatTenpayRequestEncryptionException("Failed to encrypt request, because the platform certificate manager is not initialized.");

                string certificate;
                if (string.IsNullOrEmpty(request.WechatpayCertificateSerialNumber))
                {
                    // 如果未在请求中指定特定的平台证书序列号，从管理器中取过期时间最远的
                    IEnumerable<CertificateEntry> entries = client.PlatformCertificateManager.AllEntries()
                        .Where(e => CertificateEntry.ALGORITHM_TYPE_RSA.Equals(e.AlgorithmType))
                        .OrderByDescending(e => e.ExpireTime);
                    if (!entries.Any())
                    {
                        throw new Exceptions.WechatTenpayEventVerificationException("Failed to encrypt request, because there is no platform certificate in the manager. Please make sure you have downloaded platform certificates first.");
                    }

                    CertificateEntry entry = entries.First();
                    certificate = entry.Certificate;
                    request.WechatpayCertificateSerialNumber = entry.SerialNumber;
                }
                else
                {
                    // 如果已在请求中指定特定的平台证书序列号，直接从管理器中取值
                    CertificateEntry? entry = client.PlatformCertificateManager.GetEntry(request.WechatpayCertificateSerialNumber!);
                    if (!entry.HasValue)
                    {
                        throw new Exceptions.WechatTenpayEventVerificationException($"Failed to encrypt request, because there is no platform certificate matched the serial number: \"{request.WechatpayCertificateSerialNumber}\". Please make sure you have downloaded platform certificates first.");
                    }

                    certificate = entry.Value.Certificate;
                }

                string newValue;
                switch (attribute.Algorithm)
                {
                    case Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1:
                        {
                            newValue = Utilities.RSAUtility.EncryptWithECBByCertificate(
                                certificate: certificate,
                                plainText: oldValue
                            );
                        }
                        break;

                    case Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS1:
                        {
                            newValue = Utilities.RSAUtility.EncryptWithECBByCertificate(
                                certificate: certificate,
                                plainText: oldValue,
                                paddingMode: "PKCS1PADDING"
                            );
                        }
                        break;

                    default:
                        {
                            throw new Exceptions.WechatTenpayRequestEncryptionException($"Unsupported encryption algorithm: \"{attribute.Algorithm}\".");
                        }
                }

                return (true, newValue);
            });
            return request;
        }

        private static TRequest InnerEncryptRequestSensitivePropertyBySM<TRequest>(WechatTenpayClient client, TRequest request)
            where TRequest : WechatTenpayRequest
        {
            Utilities.ReflectionUtility.ReplacePropertyStringValue(ref request, (target, currentProp, oldValue) =>
            {
                WechatTenpaySensitivePropertyAttribute? attribute = currentProp
                    .GetCustomAttributes<WechatTenpaySensitivePropertyAttribute>()
                    .FirstOrDefault(attr => Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3.Equals(attr.Scheme));
                if (attribute == null)
                    return (false, oldValue);

                if (client.PlatformCertificateManager == null)
                    throw new Exceptions.WechatTenpayRequestEncryptionException("Failed to encrypt request, because the platform certificate manager is not initialized.");

                string certificate;
                if (string.IsNullOrEmpty(request.WechatpayCertificateSerialNumber))
                {
                    // 如果未在请求中指定特定的平台证书序列号，从管理器中取过期时间最远的
                    IEnumerable<CertificateEntry> entries = client.PlatformCertificateManager.AllEntries()
                        .Where(e => CertificateEntry.ALGORITHM_TYPE_SM2.Equals(e.AlgorithmType))
                        .OrderByDescending(e => e.ExpireTime);
                    if (!entries.Any())
                    {
                        throw new Exceptions.WechatTenpayEventVerificationException("Failed to encrypt request, because there is no platform certificate in the manager. Please make sure you have downloaded platform certificates first.");
                    }

                    CertificateEntry entry = entries.First();
                    certificate = entry.Certificate;
                    request.WechatpayCertificateSerialNumber = entry.SerialNumber;
                }
                else
                {
                    // 如果已在请求中指定特定的平台证书序列号，直接从管理器中取值
                    CertificateEntry? entry = client.PlatformCertificateManager.GetEntry(request.WechatpayCertificateSerialNumber!);
                    if (!entry.HasValue)
                    {
                        throw new Exceptions.WechatTenpayEventVerificationException($"Failed to encrypt request, because there is no platform certificate matched the serial number: \"{request.WechatpayCertificateSerialNumber}\". Please make sure you have downloaded platform certificates first.");
                    }

                    certificate = entry.Value.Certificate;
                }

                string newValue;
                switch (attribute.Algorithm)
                {
                    case Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1:
                        {
                            newValue = Utilities.SM2Utility.EncryptByCertificate(
                                certificate: certificate,
                                plainText: oldValue,
                                asn1Encoding: true
                            );
                        }
                        break;

                    default:
                        {
                            throw new Exceptions.WechatTenpayRequestEncryptionException($"Unsupported encryption algorithm: \"{attribute.Algorithm}\".");
                        }
                }

                return (true, newValue);
            });
            return request;
        }

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
                bool requireEncrypt = Attribute.IsDefined(request.GetType(), typeof(WechatTenpaySensitiveAttribute));
                if (requireEncrypt)
                {
                    switch (client.Credentials.SignScheme)
                    {
                        case Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256:
                            return InnerEncryptRequestSensitivePropertyByRSA(client, request);

                        case Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3:
                            return InnerEncryptRequestSensitivePropertyBySM(client, request);
                    }
                }

                return request;
            }
            catch (WechatTenpayException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatTenpayRequestEncryptionException("Failed to encrypt request. Please see the inner exception for more details.", ex);
            }
        }
    }
}
