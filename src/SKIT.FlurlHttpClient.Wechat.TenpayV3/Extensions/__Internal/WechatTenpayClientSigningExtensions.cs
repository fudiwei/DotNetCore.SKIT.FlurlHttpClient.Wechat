using System;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Primitives;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Constants;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

    internal static class WechatTenpayClientSigningExtensions
    {
        public static ErroredResult VerifySignature(this WechatTenpayClient client, string strTimestamp, string strNonce, string strContent, string strSignature, string strSignScheme, string strSerialNumber)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            CertificateEntry? entry = client.PlatformCertificateManager.GetEntry(strSerialNumber);
            if (!entry.HasValue)
            {
                return ErroredResult.Fail(new Exception($"The platform certificate manager does not contain a certificate matched the serial number \"{strSerialNumber}\"."));
            }

            return GenerateSignatureResultByCertificate(
                scheme: strSignScheme,
                certificate: entry.Value.Certificate,
                message: GenerateMessageForSignature(timestamp: strTimestamp, nonce: strNonce, body: strContent),
                signature: strSignature
            );
        }

        public static async Task<ErroredResult> VerifySignatureAsync(this WechatTenpayClient client, string strTimestamp, string strNonce, string strContent, string strSignature, string strSignScheme, string strSerialNumber, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            if (client.PlatformCertificateManager is not ICertificateManagerAsync)
            {
                // 降级为同步调用
                return VerifySignature(client, strTimestamp, strNonce, strContent, strSignature, strSignScheme, strSerialNumber);
            }

            CertificateEntry? entry = await ((ICertificateManagerAsync)client.PlatformCertificateManager).GetEntryAsync(strSerialNumber, cancellationToken).ConfigureAwait(false);
            if (!entry.HasValue)
            {
                return ErroredResult.Fail(new Exception($"The platform certificate manager does not contain a certificate matched the serial number \"{strSerialNumber}\"."));
            }

            return GenerateSignatureResultByCertificate(
                scheme: strSignScheme,
                certificate: entry.Value.Certificate,
                message: GenerateMessageForSignature(timestamp: strTimestamp, nonce: strNonce, body: strContent),
                signature: strSignature
            );
        }

        private static string GenerateMessageForSignature(string timestamp, string nonce, string body)
        {
            return $"{timestamp}\n{nonce}\n{body}\n";
        }

        private static ErroredResult GenerateSignatureResultByCertificate(string scheme, string certificate, string message, string signature)
        {
            ErroredResult result;

            switch (scheme)
            {
                case SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256:
                    {
                        try
                        {
                            bool valid = Utilities.RSAUtility.VerifyWithSHA256ByCertificate(
                                certificatePem: certificate,
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
                            bool valid = Utilities.SM2Utility.VerifyWithSM3ByCertificate(
                                certificatePem: certificate,
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
                        result = ErroredResult.Fail(new Exception($"Unsupported signing scheme: \"{scheme}\"."));
                    }
                    break;
            }

            return result;
        }
    }
}
