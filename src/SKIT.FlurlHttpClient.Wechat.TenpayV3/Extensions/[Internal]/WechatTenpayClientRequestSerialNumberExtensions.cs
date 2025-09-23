using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Constants;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

    internal static class WechatTenpayClientRequestSerialNumberExtensions
    {
        public static TRequest _EnsureRequestWechatpaySerialNumberIsSet<TRequest>(this WechatTenpayClient client, TRequest request)
            where TRequest : WechatTenpayRequest
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            try
            {
                switch (client.PlatformAuthScheme)
                {
                    case PlatformAuthScheme.Certificate:
                        return EnsureRequestWechatpaySerialNumberIsSetUseCertificateManager<TRequest>(client.PlatformCertificateManager, client.Credentials.SignScheme, request);

                    case PlatformAuthScheme.PublicKey:
                        return EnsureRequestWechatpaySerialNumberIsSetUsePublicKeyManager<TRequest>(client.PlatformPublicKeyManager, client.Credentials.SignScheme, request);

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
                throw new WechatTenpayException("Failed to set the wechatpay serial number of request. Please see the inner exception for more details.", ex);
            }
        }

        public static async Task<TRequest> _EnsureRequestWechatpaySerialNumberIsSetAsync<TRequest>(this WechatTenpayClient client, TRequest request, CancellationToken cancellationToken = default)
            where TRequest : WechatTenpayRequest
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            try
            {
                switch (client.PlatformAuthScheme)
                {
                    case PlatformAuthScheme.Certificate:
                        {
                            if (client.PlatformCertificateManager is not ICertificateManagerAsync)
                            {
                                // 降级为同步调用
                                return EnsureRequestWechatpaySerialNumberIsSetUseCertificateManager(client.PlatformCertificateManager, client.Credentials.SignScheme, request);
                            }

                            return await EnsureRequestWechatpaySerialNumberIsSetUseCertificateManagerAsync<TRequest>((ICertificateManagerAsync)client.PlatformCertificateManager, client.Credentials.SignScheme, request).ConfigureAwait(false);
                        }

                    case PlatformAuthScheme.PublicKey:
                        {
                            if (client.PlatformPublicKeyManager is not IPublicKeyManagerAsync)
                            {
                                // 降级为同步调用
                                return EnsureRequestWechatpaySerialNumberIsSetUsePublicKeyManager(client.PlatformPublicKeyManager, client.Credentials.SignScheme, request);
                            }

                            return await EnsureRequestWechatpaySerialNumberIsSetUsePublicKeyManagerAsync<TRequest>((IPublicKeyManagerAsync)client.PlatformPublicKeyManager, client.Credentials.SignScheme, request).ConfigureAwait(false);
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
                throw new WechatTenpayException("Failed to set the wechatpay serial number of request. Please see the inner exception for more details.", ex);
            }
        }

        private static bool TryGetAlgorithmType(string signScheme, out string algorithmType)
        {
            algorithmType = // 签名方式与加密算法保持一致：RSA_SHA256 签名需 RSA 加密，SM3 签名需 SM2 加密
                SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256.Equals(signScheme) ? CertificateEntry.ALGORITHM_TYPE_RSA :
                SignSchemes.WECHATPAY2_SM2_WITH_SM3.Equals(signScheme) ? CertificateEntry.ALGORITHM_TYPE_SM2 :
                default!;
            return !string.IsNullOrEmpty(algorithmType);
        }

        private static TRequest EnsureRequestWechatpaySerialNumberIsSetUseCertificateManager<TRequest>(ICertificateManager manager, string signScheme, TRequest request)
            where TRequest : WechatTenpayRequest
        {
            if (string.IsNullOrEmpty(request.WechatpaySerialNumber))
            {
                if (!TryGetAlgorithmType(signScheme, out string algorithmType))
                    throw new NotSupportedException($"Unsupported signing scheme: \"{signScheme}\".");

                IEnumerable<CertificateEntry> entries = manager.AllEntries();
                entries = entries.Where(e => e.AlgorithmType == algorithmType).OrderByDescending(e => e.ExpireTime);
                if (!entries.Any())
                    throw new Exception("The platform certificate manager is empty. Please make sure you have downloaded platform (NOT merchant) certificates first.");

                CertificateEntry entry = entries.First();
                request.WechatpaySerialNumber = entry.SerialNumber;
            }

            return request;
        }

        private static async Task<TRequest> EnsureRequestWechatpaySerialNumberIsSetUseCertificateManagerAsync<TRequest>(ICertificateManagerAsync manager, string signScheme, TRequest request, CancellationToken cancellationToken = default)
            where TRequest : WechatTenpayRequest
        {
            if (string.IsNullOrEmpty(request.WechatpaySerialNumber))
            {
                if (!TryGetAlgorithmType(signScheme, out string algorithmType))
                    throw new NotSupportedException($"Unsupported signing scheme: \"{signScheme}\".");

                IEnumerable<CertificateEntry> entries = await manager.AllEntriesAsync(cancellationToken).ConfigureAwait(false);
                entries = entries.Where(e => e.AlgorithmType == algorithmType).OrderByDescending(e => e.ExpireTime);
                if (!entries.Any())
                    throw new Exception("The platform certificate manager is empty. Please make sure you have downloaded platform (NOT merchant) certificates first.");

                CertificateEntry entry = entries.First();
                request.WechatpaySerialNumber = entry.SerialNumber;
            }

            return request;
        }

        private static TRequest EnsureRequestWechatpaySerialNumberIsSetUsePublicKeyManager<TRequest>(IPublicKeyManager manager, string signScheme, TRequest request)
            where TRequest : WechatTenpayRequest
        {
            if (string.IsNullOrEmpty(request.WechatpaySerialNumber))
            {
                if (!TryGetAlgorithmType(signScheme, out string algorithmType))
                    throw new NotSupportedException($"Unsupported signing scheme: \"{signScheme}\".");

                IEnumerable<PublicKeyEntry> entries = manager.AllEntries();
                entries = entries.Where(e => e.AlgorithmType == algorithmType);
                if (!entries.Any())
                    throw new Exception("The platform public key manager is empty. Perhaps you forget to add one?");

                PublicKeyEntry entry = entries.First();
                request.WechatpaySerialNumber = entry.SerialNumber;
            }
            return request;
        }

        private static async Task<TRequest> EnsureRequestWechatpaySerialNumberIsSetUsePublicKeyManagerAsync<TRequest>(IPublicKeyManagerAsync manager, string signScheme, TRequest request, CancellationToken cancellationToken = default)
            where TRequest : WechatTenpayRequest
        {
            if (string.IsNullOrEmpty(request.WechatpaySerialNumber))
            {
                if (!TryGetAlgorithmType(signScheme, out string algorithmType))
                    throw new NotSupportedException($"Unsupported signing scheme: \"{signScheme}\".");

                IEnumerable<PublicKeyEntry> entries = await manager.AllEntriesAsync(cancellationToken).ConfigureAwait(false);
                entries = entries.Where(e => e.AlgorithmType == algorithmType);
                if (!entries.Any())
                    throw new Exception("The platform public key manager is empty. Perhaps you forget to add one?");

                PublicKeyEntry entry = entries.First();
                request.WechatpaySerialNumber = entry.SerialNumber;
            }
            return request;
        }
    }
}
