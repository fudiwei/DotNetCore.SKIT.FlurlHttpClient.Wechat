using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities;

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
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            try
            {
                bool requireEncrypt = request.GetType().IsDefined(typeof(WechatTenpaySensitiveAttribute));
                if (!requireEncrypt)
                    return request;

                string signScheme = client.Credentials.SignScheme;
                string algorithmType = // 签名方式与加密算法保持一致：RSA_SHA256 签名需 RSA 加密，SM3 签名需 SM2 加密
                    Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256.Equals(signScheme) ? CertificateEntry.ALGORITHM_TYPE_RSA :
                    Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3.Equals(signScheme) ? CertificateEntry.ALGORITHM_TYPE_SM2 :
                    throw new WechatTenpayException($"Failed to encrypt request. Unsupported signing scheme: \"{signScheme}\".");

                ReflectionHelper.ReplaceObjectStringProperties(request, (_, currentProp, oldValue) =>
                {
                    if (currentProp is null || !currentProp.IsDefined(typeof(WechatTenpaySensitivePropertyAttribute)))
                        return (false, oldValue);

                    WechatTenpaySensitivePropertyAttribute? attribute = currentProp
                        .GetCustomAttributes<WechatTenpaySensitivePropertyAttribute>()
                        .FirstOrDefault(attr => attr.Scheme == signScheme);
                    if (attribute is null)
                        return (false, oldValue);

                    string certificate;
                    if (string.IsNullOrEmpty(request.WechatpayCertificateSerialNumber))
                    {
                        if (client.PlatformCertificateManager is null)
                            throw new WechatTenpayException("Failed to encrypt request, because the platform certificate manager is not initialized.");

                        // 如果未在请求中指定特定的平台证书序列号，从管理器中取过期时间最远的
                        IEnumerable<CertificateEntry> entries = client.PlatformCertificateManager.AllEntries()
                            .Where(e => e.AlgorithmType == algorithmType)
                            .OrderByDescending(e => e.ExpireTime);
                        if (!entries.Any())
                        {
                            throw new WechatTenpayException("Failed to encrypt request, because the platform certificate manager is empty. Please make sure you have downloaded platform (NOT merchant) certificates first.");
                        }

                        CertificateEntry entry = entries.First();
                        certificate = entry.Certificate;
                        request.WechatpayCertificateSerialNumber = entry.SerialNumber;
                    }
                    else
                    {
                        // 如果已在请求中指定特定的平台证书序列号，直接从管理器中取值
                        CertificateEntry? entry = client.PlatformCertificateManager?.GetEntry(request.WechatpayCertificateSerialNumber!);
                        if (!entry.HasValue)
                        {
                            throw new WechatTenpayException($"Failed to encrypt request, because the platform certificate manager does not contain a certificate matched the serial number \"{request.WechatpayCertificateSerialNumber}\". Please make sure you have downloaded platform (NOT merchant) certificates first.");
                        }

                        certificate = entry.Value.Certificate;
                    }

                    string newValue;
                    switch (attribute.Algorithm)
                    {
                        case Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1:
                            {
                                newValue = RSAUtility.EncryptWithECBByCertificate(
                                    certificatePem: certificate,
                                    plainData: oldValue,
                                    paddingMode: RSAUtility.PADDING_MODE_OAEPWITHSHA1ANDMGF1
                                )!;
                            }
                            break;

                        case Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS1:
                            {
                                newValue = RSAUtility.EncryptWithECBByCertificate(
                                    certificatePem: certificate,
                                    plainData: oldValue,
                                    paddingMode: RSAUtility.PADDING_MODE_PKCS1
                                )!;
                            }
                            break;

                        case Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1:
                            {
                                newValue = SM2Utility.EncryptByCertificate(
                                    certificatePem: certificate,
                                    plainData: oldValue,
                                    asn1Encoding: true
                                )!;
                            }
                            break;

                        default:
                            {
                                throw new WechatTenpayException($"Failed to encrypt request. Unsupported encryption algorithm: \"{attribute.Algorithm}\".");
                            }
                    }

                    return (true, newValue);
                });

                return request;
            }
            catch (WechatTenpayException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new WechatTenpayException("Failed to encrypt request. Please see the inner exception for more details.", ex);
            }
        }
    }
}
