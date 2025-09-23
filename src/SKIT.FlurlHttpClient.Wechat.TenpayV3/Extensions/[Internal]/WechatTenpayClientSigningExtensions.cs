using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Primitives;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Constants;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

    internal static class WechatTenpayClientSigningExtensions
    {
        public static ErroredResult _VerifySignature(this WechatTenpayClient client, string strTimestamp, string strNonce, string strContent, string strSignature, string strSignScheme, string strSerialNumber)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            PlatformAuthScheme authSchema;
            if (!TryGetAuthScheme(client, strSerialNumber, out authSchema))
            {
                return ErroredResult.Fail(new Exception("Could not detect the platform auth schema because the serial number is missing or invalid."));
            }

            switch (authSchema)
            {
                case PlatformAuthScheme.Certificate:
                    {
                        return VerifySignatureUseCertificateManager(client.PlatformCertificateManager, strTimestamp: strTimestamp, strNonce: strNonce, strContent: strContent, strSignature: strSignature, strSignScheme: strSignScheme, strSerialNumber: strSerialNumber);
                    }

                case PlatformAuthScheme.PublicKey:
                    {
                        return VerifySignatureUsePublicKeyManager(client.PlatformPublicKeyManager, strTimestamp: strTimestamp, strNonce: strNonce, strContent: strContent, strSignature: strSignature, strSignScheme: strSignScheme, strSerialNumber: strSerialNumber);
                    }

                default:
                    return ErroredResult.Fail(new NotSupportedException($"Unsupported platform auth scheme: \"{client.PlatformAuthScheme}\"."));
            }
        }

        public static async Task<ErroredResult> _VerifySignatureAsync(this WechatTenpayClient client, string strTimestamp, string strNonce, string strContent, string strSignature, string strSignScheme, string strSerialNumber, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            PlatformAuthScheme authSchema;
            if (!TryGetAuthScheme(client, strSerialNumber, out authSchema))
            {
                return ErroredResult.Fail(new Exception("Could not detect the platform auth schema because the serial number is missing or invalid."));
            }

            switch (authSchema)
            {
                case PlatformAuthScheme.Certificate:
                    {
                        if (client.PlatformCertificateManager is not ICertificateManagerAsync)
                        {
                            // 降级为同步调用
                            return _VerifySignature(client, strTimestamp, strNonce, strContent, strSignature, strSignScheme, strSerialNumber);
                        }

                        return await VerifySignatureUseCertificateManagerAsync((ICertificateManagerAsync)client.PlatformCertificateManager, strTimestamp: strTimestamp, strNonce: strNonce, strContent: strContent, strSignature: strSignature, strSignScheme: strSignScheme, strSerialNumber: strSerialNumber, cancellationToken).ConfigureAwait(false);
                    }

                case PlatformAuthScheme.PublicKey:
                    {
                        if (client.PlatformCertificateManager is not IPublicKeyManagerAsync)
                        {
                            // 降级为同步调用
                            return _VerifySignature(client, strTimestamp, strNonce, strContent, strSignature, strSignScheme, strSerialNumber);
                        }

                        return await VerifySignatureUseCertificateManagerAsync((IPublicKeyManagerAsync)client.PlatformPublicKeyManager, strTimestamp: strTimestamp, strNonce: strNonce, strContent: strContent, strSignature: strSignature, strSignScheme: strSignScheme, strSerialNumber: strSerialNumber, cancellationToken).ConfigureAwait(false);
                    }

                default:
                    return ErroredResult.Fail(new NotSupportedException($"Unsupported platform auth scheme: \"{client.PlatformAuthScheme}\"."));
            }
        }

        private static ErroredResult VerifySignatureUseCertificateManager(ICertificateManager manager, string strTimestamp, string strNonce, string strContent, string strSignature, string strSignScheme, string strSerialNumber)
        {
            if (manager is null)
            {
                return ErroredResult.Fail(new NullReferenceException("The platform certificate manager is not configured."));
            }

            CertificateEntry? entry = manager.GetEntry(strSerialNumber);
            if (!entry.HasValue)
            {
                return ErroredResult.Fail(new Exception($"The platform certificate manager does not contain a certificate matched the serial number \"{strSerialNumber}\"."));
            }

            return GenerateVerifyResultByCertificate(
                scheme: strSignScheme,
                certificate: entry.Value.Certificate,
                message: GenerateMessageForSignature(timestamp: strTimestamp, nonce: strNonce, body: strContent),
                signature: strSignature
            );
        }

        private static async Task<ErroredResult> VerifySignatureUseCertificateManagerAsync(ICertificateManagerAsync manager, string strTimestamp, string strNonce, string strContent, string strSignature, string strSignScheme, string strSerialNumber, CancellationToken cancellationToken = default)
        {
            if (manager is null)
            {
                return ErroredResult.Fail(new NullReferenceException("The platform certificate manager is not configured."));
            }

            CertificateEntry? entry = await manager.GetEntryAsync(strSerialNumber, cancellationToken).ConfigureAwait(false);
            if (!entry.HasValue)
            {
                return ErroredResult.Fail(new Exception($"The platform certificate manager does not contain a certificate matched the serial number \"{strSerialNumber}\"."));
            }

            return GenerateVerifyResultByCertificate(
                scheme: strSignScheme,
                certificate: entry.Value.Certificate,
                message: GenerateMessageForSignature(timestamp: strTimestamp, nonce: strNonce, body: strContent),
                signature: strSignature
            );
        }

        private static ErroredResult VerifySignatureUsePublicKeyManager(IPublicKeyManager manager, string strTimestamp, string strNonce, string strContent, string strSignature, string strSignScheme, string strSerialNumber)
        {
            if (manager is null)
            {
                return ErroredResult.Fail(new NullReferenceException("The platform public key manager is not configured."));
            }

            PublicKeyEntry? entry = manager.GetEntry(strSerialNumber);
            if (!entry.HasValue)
            {
                return ErroredResult.Fail(new Exception($"The platform public key manager does not contain a key matched the serial number \"{strSerialNumber}\"."));
            }

            return GenerateVerifyResultByPublicKey(
                scheme: strSignScheme,
                publicKey: entry.Value.PublicKey,
                message: GenerateMessageForSignature(timestamp: strTimestamp, nonce: strNonce, body: strContent),
                signature: strSignature
            );
        }

        private static async Task<ErroredResult> VerifySignatureUseCertificateManagerAsync(IPublicKeyManagerAsync manager, string strTimestamp, string strNonce, string strContent, string strSignature, string strSignScheme, string strSerialNumber, CancellationToken cancellationToken = default)
        {
            if (manager is null)
            {
                return ErroredResult.Fail(new NullReferenceException("The platform public key manager is not configured."));
            }

            PublicKeyEntry? entry = await manager.GetEntryAsync(strSerialNumber, cancellationToken).ConfigureAwait(false);
            if (!entry.HasValue)
            {
                return ErroredResult.Fail(new Exception($"The platform public key manager does not contain a key matched the serial number \"{strSerialNumber}\"."));
            }

            return GenerateVerifyResultByPublicKey(
                scheme: strSignScheme,
                publicKey: entry.Value.PublicKey,
                message: GenerateMessageForSignature(timestamp: strTimestamp, nonce: strNonce, body: strContent),
                signature: strSignature
            );
        }

        private static bool TryGetAuthScheme(WechatTenpayClient client, string strSerialNumber, out PlatformAuthScheme authScheme)
        {
            authScheme = client.PlatformAuthScheme;
            if (client.PlatformAuthFallbackSwitch)
            {
                if (string.IsNullOrEmpty(strSerialNumber))
                {
                    return false;
                }

                if (Regex.IsMatch(strSerialNumber, "^PUB_KEY_ID_", RegexOptions.IgnoreCase))
                {
                    authScheme = PlatformAuthScheme.PublicKey;
                }
                else if (Regex.IsMatch(strSerialNumber, "^[A-Za-z0-9]+$", RegexOptions.IgnoreCase))
                {
                    authScheme = PlatformAuthScheme.Certificate;
                }
            }

            return true;
        }

        private static string GenerateMessageForSignature(string timestamp, string nonce, string body)
        {
            return $"{timestamp}\n{nonce}\n{body}\n";
        }

        private static ErroredResult GenerateVerifyResultByCertificate(string scheme, string certificate, string message, string signature)
        {
            string publicKey = string.Empty;

            switch (scheme)
            {
                case SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256:
                    {
                        try
                        {
                            publicKey = Utilities.RSAUtility.ExportPublicKeyFromCertificate(certificate);
                        }
                        catch (Exception ex)
                        {
                            return ErroredResult.Fail(ex);
                        }
                    }
                    break;

                case SignSchemes.WECHATPAY2_SM2_WITH_SM3:
                    {
                        try
                        {
                            publicKey = Utilities.SM2Utility.ExportPublicKeyFromCertificate(certificate);
                        }
                        catch (Exception ex)
                        {
                            return ErroredResult.Fail(ex);
                        }
                    }
                    break;
            }

            return GenerateVerifyResultByPublicKey(scheme, publicKey, message, signature);
        }

        private static ErroredResult GenerateVerifyResultByPublicKey(string scheme, string publicKey, string message, string signature)
        {
            ErroredResult result;

            switch (scheme)
            {
                case SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256:
                    {
                        try
                        {
                            bool valid = Utilities.RSAUtility.VerifyWithSHA256(
                                publicKeyPem: publicKey,
                                messageData: message,
                                encodingSignature: new EncodedString(signature, EncodingKinds.Base64)
                            );
                            if (valid)
                                result = ErroredResult.Ok();
                            else
                                result = ErroredResult.Fail(new Exception($"Signature does not match. Maybe \"{signature}\" is an illegal signature."));
                        }
                        catch (Exception ex)
                        {
                            result = ErroredResult.Fail(ex);
                        }
                    }
                    break;

                case SignSchemes.WECHATPAY2_SM2_WITH_SM3:
                    {
                        try
                        {
                            bool valid = Utilities.SM2Utility.VerifyWithSM3(
                                publicKeyPem: publicKey,
                                messageData: message,
                                encodingSignature: new EncodedString(signature, EncodingKinds.Base64)
                            );
                            if (valid)
                                result = ErroredResult.Ok();
                            else
                                result = ErroredResult.Fail(new Exception($"Signature does not match. Maybe \"{signature}\" is an illegal signature."));
                        }
                        catch (Exception ex)
                        {
                            result = ErroredResult.Fail(ex);
                        }
                    }
                    break;

                default:
                    {
                        result = ErroredResult.Fail(new NotSupportedException($"Unsupported signing scheme: \"{scheme}\"."));
                    }
                    break;
            }

            return result;
        }
    }
}
