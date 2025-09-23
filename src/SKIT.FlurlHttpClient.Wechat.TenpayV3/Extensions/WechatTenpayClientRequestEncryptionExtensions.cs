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

            bool required = request.GetType().IsDefined(typeof(WechatTenpaySensitiveAttribute));
            if (!required)
                return request;

            try
            {
                switch (client.PlatformAuthScheme)
                {
                    case PlatformAuthScheme.Certificate:
                        {
                            WechatTenpayClientRequestSerialNumberExtensions._EnsureRequestWechatpaySerialNumberIsSet(client, request);
                            return EncryptRequestSensitivePropertyUseCertificateManager<TRequest>(client.PlatformCertificateManager, client.Credentials.SignScheme, request);
                        }

                    case PlatformAuthScheme.PublicKey:
                        {
                            WechatTenpayClientRequestSerialNumberExtensions._EnsureRequestWechatpaySerialNumberIsSet(client, request);
                            return EncryptRequestSensitivePropertyUsePublicKeyManager<TRequest>(client.PlatformPublicKeyManager, client.Credentials.SignScheme, request);
                        }

                    default:
                        throw new NotSupportedException($"Unsupported platform auth scheme: \"{client.PlatformAuthScheme}\".");
                }
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

        /// <summary>
        /// <para>异步加密请求中传入的敏感数据。该方法会改变传入的请求模型对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<TRequest> EncryptRequestSensitivePropertyAsync<TRequest>(this WechatTenpayClient client, TRequest request, CancellationToken cancellationToken = default)
            where TRequest : WechatTenpayRequest
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            bool required = request.GetType().IsDefined(typeof(WechatTenpaySensitiveAttribute));
            if (!required)
                return request;

            try
            {
                switch (client.PlatformAuthScheme)
                {
                    case PlatformAuthScheme.Certificate:
                        {
                            if (client.PlatformCertificateManager is not ICertificateManagerAsync)
                            {
                                // 降级为同步调用
                                return EncryptRequestSensitivePropertyUseCertificateManager(client.PlatformCertificateManager, client.Credentials.SignScheme, request);
                            }

                            await WechatTenpayClientRequestSerialNumberExtensions._EnsureRequestWechatpaySerialNumberIsSetAsync(client, request, cancellationToken).ConfigureAwait(false);
                            return await EncryptRequestSensitivePropertyUseCertificateManagerAsync<TRequest>((ICertificateManagerAsync)client.PlatformCertificateManager, client.Credentials.SignScheme, request, cancellationToken).ConfigureAwait(false);
                        }

                    case PlatformAuthScheme.PublicKey:
                        {
                            if (client.PlatformPublicKeyManager is not IPublicKeyManagerAsync)
                            {
                                // 降级为同步调用
                                return EncryptRequestSensitivePropertyUsePublicKeyManager(client.PlatformPublicKeyManager, client.Credentials.SignScheme, request);
                            }

                            await WechatTenpayClientRequestSerialNumberExtensions._EnsureRequestWechatpaySerialNumberIsSetAsync(client, request, cancellationToken).ConfigureAwait(false);
                            return await EncryptRequestSensitivePropertyUsePublicKeyManagerAsync<TRequest>((IPublicKeyManagerAsync)client.PlatformPublicKeyManager, client.Credentials.SignScheme, request, cancellationToken).ConfigureAwait(false);
                        }

                    default:
                        throw new NotSupportedException($"Unsupported platform auth scheme: \"{client.PlatformAuthScheme}\".");
                }
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

        private static TRequest EncryptRequestSensitivePropertyUseCertificateManager<TRequest>(ICertificateManager manager, string signScheme, TRequest request)
            where TRequest : WechatTenpayRequest
        {
            if (manager is null)
                throw new NullReferenceException("The platform certificate manager is not configured.");

            CertificateEntry? entry = manager.GetEntry(request.WechatpaySerialNumber!);
            if (!entry.HasValue)
                throw new WechatTenpayException($"Failed to encrypt request, because the platform certificate manager does not contain a certificate matched the serial number \"{request.WechatpaySerialNumber}\". Please make sure you have downloaded platform (NOT merchant) certificates first.");

            return PopulateRequestEncryptedFieldsByCertificate(signScheme, entry.Value.Certificate, ref request);
        }

        private static async Task<TRequest> EncryptRequestSensitivePropertyUseCertificateManagerAsync<TRequest>(ICertificateManagerAsync manager, string signScheme, TRequest request, CancellationToken cancellationToken = default)
            where TRequest : WechatTenpayRequest
        {
            if (manager is null)
                throw new NullReferenceException("The platform certificate manager is not configured.");

            CertificateEntry? entry = await manager.GetEntryAsync(request.WechatpaySerialNumber!, cancellationToken).ConfigureAwait(false);
            if (!entry.HasValue)
                throw new WechatTenpayException($"Failed to encrypt request, because the platform certificate manager does not contain a certificate matched the serial number \"{request.WechatpaySerialNumber}\". Please make sure you have downloaded platform (NOT merchant) certificates first.");

            return PopulateRequestEncryptedFieldsByCertificate(signScheme, entry.Value.Certificate, ref request);
        }

        private static TRequest EncryptRequestSensitivePropertyUsePublicKeyManager<TRequest>(IPublicKeyManager manager, string signScheme, TRequest request)
            where TRequest : WechatTenpayRequest
        {
            if (manager is null)
                throw new NullReferenceException("The platform public key manager is not configured.");

            PublicKeyEntry? entry = manager.GetEntry(request.WechatpaySerialNumber!);
            if (!entry.HasValue)
                throw new WechatTenpayException($"Failed to encrypt request, because the platform public key manager does not contain a key matched the serial number \"{request.WechatpaySerialNumber}\".");

            return PopulateRequestEncryptedFieldsByPublicKey(signScheme, entry.Value.PublicKey, ref request);
        }

        private static async Task<TRequest> EncryptRequestSensitivePropertyUsePublicKeyManagerAsync<TRequest>(IPublicKeyManagerAsync manager, string signScheme, TRequest request, CancellationToken cancellationToken = default)
            where TRequest : WechatTenpayRequest
        {
            if (manager is null)
                throw new NullReferenceException("The platform public key manager is not configured.");

            PublicKeyEntry? entry = await manager.GetEntryAsync(request.WechatpaySerialNumber!, cancellationToken).ConfigureAwait(false);
            if (!entry.HasValue)
                throw new WechatTenpayException($"Failed to encrypt request, because the platform public key manager does not contain a key matched the serial number \"{request.WechatpaySerialNumber}\".");

            return PopulateRequestEncryptedFieldsByPublicKey(signScheme, entry.Value.PublicKey, ref request);
        }

        private static TRequest PopulateRequestEncryptedFieldsByCertificate<TRequest>(string scheme, string certificate, ref TRequest request)
            where TRequest : WechatTenpayRequest
        {
            switch (scheme)
            {
                case SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256:
                    {
                        string publicKey = RSAUtility.ExportPublicKeyFromCertificate(certificate);
                        return PopulateRequestEncryptedFieldsByPublicKey(scheme, publicKey, ref request);
                    }

                case SignSchemes.WECHATPAY2_SM2_WITH_SM3:
                    {
                        string publicKey = SM2Utility.ExportPublicKeyFromCertificate(certificate);
                        return PopulateRequestEncryptedFieldsByPublicKey(scheme, publicKey, ref request);
                    }

                default:
                    throw new NotSupportedException($"Unsupported signing scheme: \"{scheme}\".");
            }
        }

        private static TRequest PopulateRequestEncryptedFieldsByPublicKey<TRequest>(string scheme, string publicKey, ref TRequest request)
            where TRequest : WechatTenpayRequest
        {
            ReflectionHelper.ReplaceObjectStringProperties(ref request, (_, currentProp, oldValue) =>
            {
                if (currentProp is null || !currentProp.IsDefined(typeof(WechatTenpaySensitivePropertyAttribute)))
                    return (false, oldValue);

                WechatTenpaySensitivePropertyAttribute? attribute = currentProp
                    .GetCustomAttributes<WechatTenpaySensitivePropertyAttribute>()
                    .FirstOrDefault(attr => attr.Scheme == scheme);
                if (attribute is null)
                    return (false, oldValue);

                string newValue;
                switch (attribute.Algorithm)
                {
                    case EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1:
                        newValue = RSAUtility.EncryptWithECB(
                            publicKeyPem: publicKey,
                            plainData: oldValue,
                            paddingMode: RSAUtility.PADDING_MODE_OAEPWITHSHA1ANDMGF1
                        )!;
                        break;

                    case EncryptionAlgorithms.RSA_2048_ECB_PKCS1:
                        newValue = RSAUtility.EncryptWithECB(
                            publicKeyPem: publicKey,
                            plainData: oldValue,
                            paddingMode: RSAUtility.PADDING_MODE_PKCS1
                        )!;
                        break;

                    case EncryptionAlgorithms.SM2_C1C3C2_ASN1:
                        newValue = SM2Utility.Encrypt(
                            publicKeyPem: publicKey,
                            plainData: oldValue,
                            asn1Encoding: true
                        )!;
                        break;

                    default:
                        throw new NotSupportedException($"Unsupported encryption algorithm: \"{attribute.Algorithm}\".");
                }

                return (true, newValue);
            });
            return request;
        }
    }
}
