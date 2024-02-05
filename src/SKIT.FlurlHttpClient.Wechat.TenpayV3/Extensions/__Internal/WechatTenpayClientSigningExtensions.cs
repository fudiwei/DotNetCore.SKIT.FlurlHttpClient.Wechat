using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Primitives;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

    internal static class WechatTenpayClientSigningExtensions
    {
        public static ErroredResult VerifySignature(this WechatTenpayClient client, string strTimestamp, string strNonce, string strContent, string strSignature, string strSignScheme, string strSerialNumber)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            ErroredResult result;

            switch (strSignScheme)
            {
                case Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256:
                    {
                        try
                        {
                            if (client.PlatformCertificateManager is null)
                            {
                                result = ErroredResult.Fail(new Exception("The platform certificate manager is not initialized."));
                                break;
                            }

                            CertificateEntry? entry = client.PlatformCertificateManager.GetEntry(strSerialNumber);
                            if (!entry.HasValue)
                            {
                                result = ErroredResult.Fail(new Exception($"The platform certificate manager does not contain a certificate with serial number \"{strSerialNumber}\"."));
                                break;
                            }

                            bool valid = Utilities.RSAUtility.VerifyByCertificate(
                                certificatePem: entry.Value.Certificate,
                                message: GenerateMessageForSignature(timestamp: strTimestamp, nonce: strNonce, body: strContent),
                                encodingSignature: new EncodedString(strSignature, EncodingKinds.Base64)
                            );
                            if (valid)
                                result = ErroredResult.Ok();
                            else
                                result = ErroredResult.Fail(new Exception($"Signature does not match. Maybe \"{strSignature}\" is an illegal signature."));
                        }
                        catch (Exception ex)
                        {
                            result = ErroredResult.Fail(ex);
                        }
                    }
                    break;

                case Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3:
                    {
                        try
                        {
                            if (client.PlatformCertificateManager is null)
                            {
                                result = ErroredResult.Fail(new Exception("The platform certificate manager is not initialized."));
                                break;
                            }

                            CertificateEntry? entry = client.PlatformCertificateManager.GetEntry(strSerialNumber);
                            if (!entry.HasValue)
                            {
                                result = ErroredResult.Fail(new Exception($"The platform certificate manager does not contain a certificate with serial number \"{strSerialNumber}\"."));
                                break;
                            }

                            bool valid = Utilities.SM2Utility.VerifyWithSM3ByCertificate(
                                certificatePem: entry.Value.Certificate,
                                message: GenerateMessageForSignature(timestamp: strTimestamp, nonce: strNonce, body: strContent),
                                encodingSignature: new EncodedString(strSignature, EncodingKinds.Base64)
                            );
                            if (valid)
                                result = ErroredResult.Ok();
                            else
                                result = ErroredResult.Fail(new Exception($"Signature does not match. Maybe \"{strSignature}\" is an illegal signature."));
                        }
                        catch (Exception ex)
                        {
                            result = ErroredResult.Fail(ex);
                        }
                    }
                    break;

                default:
                    {
                        result = ErroredResult.Fail(new Exception($"Unsupported signing scheme: \"{strSignScheme}\"."));
                    }
                    break;
            }

            return result;
        }

        private static string GenerateMessageForSignature(string timestamp, string nonce, string body)
        {
            return $"{timestamp}\n{nonce}\n{body}\n";
        }
    }
}
