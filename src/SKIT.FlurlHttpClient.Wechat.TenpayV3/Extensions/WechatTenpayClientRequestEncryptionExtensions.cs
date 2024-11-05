using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Constants;
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

            switch (client.PlatformAuthScheme)
            {
                case PlatformAuthScheme.Certificate:
                    return EncryptRequestSensitivePropertyByCertificate<TRequest>(client, request);

                case PlatformAuthScheme.PublicKey:
                    return EncryptRequestSensitivePropertyByPublicKey<TRequest>(client, request);

                default:
                    throw new WechatTenpayException($"Unsupported platform auth scheme: \"{client.PlatformAuthScheme}\".");
            }
        }

        /// <summary>
        /// <para>异步加密请求中传入的敏感数据。该方法会改变传入的请求模型对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task<TRequest> EncryptRequestSensitivePropertyAsync<TRequest>(this WechatTenpayClient client, TRequest request, CancellationToken cancellationToken = default)
            where TRequest : WechatTenpayRequest
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            switch (client.PlatformAuthScheme)
            {
                case PlatformAuthScheme.Certificate:
                    return EncryptRequestSensitivePropertyByCertificateAsync<TRequest>(client, request);

                case PlatformAuthScheme.PublicKey:
                    return EncryptRequestSensitivePropertyByPublicKeyAsync<TRequest>(client, request);

                default:
                    throw new WechatTenpayException($"Unsupported platform auth scheme: \"{client.PlatformAuthScheme}\".");
            }
        }

        private static TRequest EncryptRequestSensitivePropertyByCertificate<TRequest>(this WechatTenpayClient client, TRequest request)
            where TRequest : WechatTenpayRequest
        {
            try
            {
                bool requireEncrypt = request.GetType().IsDefined(typeof(WechatTenpaySensitiveAttribute));
                if (!requireEncrypt)
                    return request;

                string signScheme = client.Credentials.SignScheme;
                string algorithmType = // 签名方式与加密算法保持一致：RSA_SHA256 签名需 RSA 加密，SM3 签名需 SM2 加密
                    SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256.Equals(signScheme) ? CertificateEntry.ALGORITHM_TYPE_RSA :
                    SignSchemes.WECHATPAY2_SM2_WITH_SM3.Equals(signScheme) ? CertificateEntry.ALGORITHM_TYPE_SM2 :
                    throw new WechatTenpayException($"Failed to encrypt request. Unsupported signing scheme: \"{signScheme}\".");

                string certificate;
                if (string.IsNullOrEmpty(request.WechatpaySerialNumber))
                {
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
                    request.WechatpaySerialNumber = entry.SerialNumber;
                }
                else
                {
                    // 如果已在请求中指定特定的平台证书序列号，直接从管理器中取值
                    CertificateEntry? entry = client.PlatformCertificateManager.GetEntry(request.WechatpaySerialNumber!);
                    if (!entry.HasValue)
                    {
                        throw new WechatTenpayException($"Failed to encrypt request, because the platform certificate manager does not contain a certificate matched the serial number \"{request.WechatpaySerialNumber}\". Please make sure you have downloaded platform (NOT merchant) certificates first.");
                    }

                    certificate = entry.Value.Certificate;
                }

                ReflectionHelper.ReplaceObjectStringProperties(request, (_, currentProp, oldValue) =>
                {
                    if (currentProp is null || !currentProp.IsDefined(typeof(WechatTenpaySensitivePropertyAttribute)))
                        return (false, oldValue);

                    WechatTenpaySensitivePropertyAttribute? attribute = currentProp
                        .GetCustomAttributes<WechatTenpaySensitivePropertyAttribute>()
                        .FirstOrDefault(attr => attr.Scheme == signScheme);
                    if (attribute is null)
                        return (false, oldValue);

                    string newValue = GenerateEncryptedValueByCertificate(attribute.Algorithm, certificate, oldValue);
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

        private static async Task<TRequest> EncryptRequestSensitivePropertyByCertificateAsync<TRequest>(this WechatTenpayClient client, TRequest request, CancellationToken cancellationToken = default)
            where TRequest : WechatTenpayRequest
        {
            if (client.PlatformCertificateManager is not ICertificateManagerAsync)
            {
                // 降级为同步调用
                return EncryptRequestSensitivePropertyByCertificate(client, request);
            }

            try
            {
                bool requireEncrypt = request.GetType().IsDefined(typeof(WechatTenpaySensitiveAttribute));
                if (!requireEncrypt)
                    return request;

                string signScheme = client.Credentials.SignScheme;
                string algorithmType = // 签名方式与加密算法保持一致：RSA_SHA256 签名需 RSA 加密，SM3 签名需 SM2 加密
                    SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256.Equals(signScheme) ? CertificateEntry.ALGORITHM_TYPE_RSA :
                    SignSchemes.WECHATPAY2_SM2_WITH_SM3.Equals(signScheme) ? CertificateEntry.ALGORITHM_TYPE_SM2 :
                    throw new WechatTenpayException($"Failed to encrypt request. Unsupported signing scheme: \"{signScheme}\".");

                string certificate;
                if (string.IsNullOrEmpty(request.WechatpaySerialNumber))
                {
                    if (client.PlatformCertificateManager is null)
                        throw new WechatTenpayException("Failed to encrypt request, because the platform certificate manager is not initialized.");

                    // 如果未在请求中指定特定的平台证书序列号，从管理器中取过期时间最远的
                    IEnumerable<CertificateEntry> entries = await ((ICertificateManagerAsync)client.PlatformCertificateManager).AllEntriesAsync(cancellationToken).ConfigureAwait(false);
                    entries = entries.Where(e => e.AlgorithmType == algorithmType).OrderByDescending(e => e.ExpireTime);
                    if (!entries.Any())
                    {
                        throw new WechatTenpayException("Failed to encrypt request, because the platform certificate manager is empty. Please make sure you have downloaded platform (NOT merchant) certificates first.");
                    }

                    CertificateEntry entry = entries.First();
                    certificate = entry.Certificate;
                    request.WechatpaySerialNumber = entry.SerialNumber;
                }
                else
                {
                    // 如果已在请求中指定特定的平台证书序列号，直接从管理器中取值
                    CertificateEntry? entry = await ((ICertificateManagerAsync)client.PlatformCertificateManager).GetEntryAsync(request.WechatpaySerialNumber!, cancellationToken).ConfigureAwait(false);
                    if (!entry.HasValue)
                    {
                        throw new WechatTenpayException($"Failed to encrypt request, because the platform certificate manager does not contain a certificate matched the serial number \"{request.WechatpaySerialNumber}\". Please make sure you have downloaded platform (NOT merchant) certificates first.");
                    }

                    certificate = entry.Value.Certificate;
                }

                ReflectionHelper.ReplaceObjectStringProperties(request, (_, currentProp, oldValue) =>
                {
                    if (currentProp is null || !currentProp.IsDefined(typeof(WechatTenpaySensitivePropertyAttribute)))
                        return (false, oldValue);

                    WechatTenpaySensitivePropertyAttribute? attribute = currentProp
                        .GetCustomAttributes<WechatTenpaySensitivePropertyAttribute>()
                        .FirstOrDefault(attr => attr.Scheme == signScheme);
                    if (attribute is null)
                        return (false, oldValue);

                    string newValue = GenerateEncryptedValueByCertificate(attribute.Algorithm, certificate, oldValue);
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

        private static TRequest EncryptRequestSensitivePropertyByPublicKey<TRequest>(this WechatTenpayClient client, TRequest request)
            where TRequest : WechatTenpayRequest
        {
            try
            {
                bool requireEncrypt = request.GetType().IsDefined(typeof(WechatTenpaySensitiveAttribute));
                if (!requireEncrypt)
                    return request;

                string signScheme = client.Credentials.SignScheme;
                string algorithmType = // 签名方式与加密算法保持一致：RSA_SHA256 签名需 RSA 加密，SM3 签名需 SM2 加密
                    SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256.Equals(signScheme) ? PublicKeyEntry.ALGORITHM_TYPE_RSA :
                    SignSchemes.WECHATPAY2_SM2_WITH_SM3.Equals(signScheme) ? PublicKeyEntry.ALGORITHM_TYPE_SM2 :
                    throw new WechatTenpayException($"Failed to encrypt request. Unsupported signing scheme: \"{signScheme}\".");

                string publicKey;
                if (string.IsNullOrEmpty(request.WechatpaySerialNumber))
                {
                    // 如果未在请求中指定特定的平台公钥序列号，从管理器中取第一个
                    IEnumerable<PublicKeyEntry> entries = client.PlatformPublicKeyManager.AllEntries()
                        .Where(e => e.AlgorithmType == algorithmType);
                    if (!entries.Any())
                    {
                        throw new WechatTenpayException("Failed to encrypt request, because the platform public key manager is empty.");
                    }

                    PublicKeyEntry entry = entries.First();
                    publicKey = entry.PublicKey;
                    request.WechatpaySerialNumber = entry.SerialNumber;
                }
                else
                {
                    // 如果已在请求中指定特定的平台公钥序列号，直接从管理器中取值
                    PublicKeyEntry? entry = client.PlatformPublicKeyManager.GetEntry(request.WechatpaySerialNumber!);
                    if (!entry.HasValue)
                    {
                        throw new WechatTenpayException($"Failed to encrypt request, because the platform public key manager does not contain a key matched the serial number \"{request.WechatpaySerialNumber}\".");
                    }

                    publicKey = entry.Value.PublicKey;
                }

                ReflectionHelper.ReplaceObjectStringProperties(request, (_, currentProp, oldValue) =>
                {
                    if (currentProp is null || !currentProp.IsDefined(typeof(WechatTenpaySensitivePropertyAttribute)))
                        return (false, oldValue);

                    WechatTenpaySensitivePropertyAttribute? attribute = currentProp
                        .GetCustomAttributes<WechatTenpaySensitivePropertyAttribute>()
                        .FirstOrDefault(attr => attr.Scheme == signScheme);
                    if (attribute is null)
                        return (false, oldValue);

                    string newValue = GenerateEncryptedValueByPublicKey(attribute.Algorithm, publicKey, oldValue);
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

        private static async Task<TRequest> EncryptRequestSensitivePropertyByPublicKeyAsync<TRequest>(this WechatTenpayClient client, TRequest request, CancellationToken cancellationToken = default)
            where TRequest : WechatTenpayRequest
        {
            if (client.PlatformPublicKeyManager is not IPublicKeyManagerAsync)
            {
                // 降级为同步调用
                return EncryptRequestSensitivePropertyByPublicKey(client, request);
            }

            try
            {
                bool requireEncrypt = request.GetType().IsDefined(typeof(WechatTenpaySensitiveAttribute));
                if (!requireEncrypt)
                    return request;

                string signScheme = client.Credentials.SignScheme;
                string algorithmType = // 签名方式与加密算法保持一致：RSA_SHA256 签名需 RSA 加密，SM3 签名需 SM2 加密
                    SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256.Equals(signScheme) ? PublicKeyEntry.ALGORITHM_TYPE_RSA :
                    SignSchemes.WECHATPAY2_SM2_WITH_SM3.Equals(signScheme) ? PublicKeyEntry.ALGORITHM_TYPE_SM2 :
                    throw new WechatTenpayException($"Failed to encrypt request. Unsupported signing scheme: \"{signScheme}\".");

                string publicKey;
                if (string.IsNullOrEmpty(request.WechatpaySerialNumber))
                {
                    if (client.PlatformPublicKeyManager is null)
                        throw new WechatTenpayException("Failed to encrypt request, because the platform public key manager is not initialized.");

                    // 如果未在请求中指定特定的平台公钥序列号，从管理器中第一个
                    IEnumerable<PublicKeyEntry> entries = await ((IPublicKeyManagerAsync)client.PlatformPublicKeyManager).AllEntriesAsync(cancellationToken).ConfigureAwait(false);
                    entries = entries.Where(e => e.AlgorithmType == algorithmType);
                    if (!entries.Any())
                    {
                        throw new WechatTenpayException("Failed to encrypt request, because the platform public key manager is empty.");
                    }

                    PublicKeyEntry entry = entries.First();
                    publicKey = entry.PublicKey;
                    request.WechatpaySerialNumber = entry.SerialNumber;
                }
                else
                {
                    // 如果已在请求中指定特定的平台公钥序列号，直接从管理器中取值
                    PublicKeyEntry? entry = await ((IPublicKeyManagerAsync)client.PlatformPublicKeyManager).GetEntryAsync(request.WechatpaySerialNumber!, cancellationToken).ConfigureAwait(false);
                    if (!entry.HasValue)
                    {
                        throw new WechatTenpayException($"Failed to encrypt request, because the platform public key manager does not contain a key matched the serial number \"{request.WechatpaySerialNumber}\".");
                    }

                    publicKey = entry.Value.PublicKey;
                }

                ReflectionHelper.ReplaceObjectStringProperties(request, (_, currentProp, oldValue) =>
                {
                    if (currentProp is null || !currentProp.IsDefined(typeof(WechatTenpaySensitivePropertyAttribute)))
                        return (false, oldValue);

                    WechatTenpaySensitivePropertyAttribute? attribute = currentProp
                        .GetCustomAttributes<WechatTenpaySensitivePropertyAttribute>()
                        .FirstOrDefault(attr => attr.Scheme == signScheme);
                    if (attribute is null)
                        return (false, oldValue);

                    string newValue = GenerateEncryptedValueByPublicKey(attribute.Algorithm, publicKey, oldValue);
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

        private static string GenerateEncryptedValueByCertificate(string algorithm, string certificate, string value)
        {
            switch (algorithm)
            {
                case EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1:
                case EncryptionAlgorithms.RSA_2048_ECB_PKCS1:
                    {
                        string publicKey = RSAUtility.ExportPublicKeyFromCertificate(certificate);
                        return GenerateEncryptedValueByPublicKey(algorithm, publicKey, value);
                    }

                case EncryptionAlgorithms.SM2_C1C3C2_ASN1:
                    {
                        string publicKey = SM2Utility.ExportPublicKeyFromCertificate(certificate);
                        return GenerateEncryptedValueByPublicKey(algorithm, publicKey, value);
                    }

                default:
                    throw new WechatTenpayException($"Failed to encrypt request. Unsupported encryption algorithm: \"{algorithm}\".");
            }
        }

        private static string GenerateEncryptedValueByPublicKey(string algorithm, string publicKey, string value)
        {
            switch (algorithm)
            {
                case EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1:
                    return RSAUtility.EncryptWithECB(
                        publicKeyPem: publicKey,
                        plainData: value,
                        paddingMode: RSAUtility.PADDING_MODE_OAEPWITHSHA1ANDMGF1
                    )!;

                case EncryptionAlgorithms.RSA_2048_ECB_PKCS1:
                    return RSAUtility.EncryptWithECB(
                        publicKeyPem: publicKey,
                        plainData: value,
                        paddingMode: RSAUtility.PADDING_MODE_PKCS1
                    )!;

                case EncryptionAlgorithms.SM2_C1C3C2_ASN1:
                    return SM2Utility.Encrypt(
                        publicKeyPem: publicKey,
                        plainData: value,
                        asn1Encoding: true
                    )!;

                default:
                    throw new WechatTenpayException($"Failed to encrypt request. Unsupported encryption algorithm: \"{algorithm}\".");
            }
        }
    }
}
