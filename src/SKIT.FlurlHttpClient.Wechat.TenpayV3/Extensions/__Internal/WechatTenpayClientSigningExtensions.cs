using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings;

    internal static class WechatTenpayClientSigningExtensions
    {
        public static bool VerifySignature(this WechatTenpayClient client, string strTimestamp, string strNonce, string strContent, string strSignature, string strSignScheme, string strSerialNumber, out Exception? error)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            switch (strSignScheme)
            {
                case Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256:
                    {
                        if (client.PlatformCertificateManager is null)
                        {
                            error = new Exception("The platform certificate manager is not initialized.");
                            return false;
                        }

                        CertificateEntry? entry = client.PlatformCertificateManager.GetEntry(strSerialNumber);
                        if (!entry.HasValue)
                        {
                            error = new Exception($"The platform certificate manager does not contain a certificate with serial number \"{strSerialNumber}\".");
                            return false;
                        }

                        if (!CertificateEntry.ALGORITHM_TYPE_RSA.Equals(entry.Value.AlgorithmType))
                        {
                            error = new Exception($"The platform certificate with serial number \"{strSerialNumber}\" is not for RSA.");
                            return false;
                        }

                        error = null;
                        try
                        {
                            return Utilities.RSAUtility.VerifyWithSHA256ByCertificate(
                                certificate: entry.Value.Certificate,
                                message: GenerateMessageForSignature(timestamp: strTimestamp, nonce: strNonce, body: strContent),
                                signature: strSignature
                            );
                        }
                        catch (Exception ex)
                        {
                            error = ex;
                            return false;
                        }
                    }

                case Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3:
                    {
                        if (client.PlatformCertificateManager is null)
                        {
                            error = new Exception("The platform certificate manager is not initialized.");
                            return false;
                        }

                        CertificateEntry? entry = client.PlatformCertificateManager.GetEntry(strSerialNumber);
                        if (!entry.HasValue)
                        {
                            error = new Exception($"The platform certificate manager does not contain a certificate with serial number \"{strSerialNumber}\".");
                            return false;
                        }

                        if (!CertificateEntry.ALGORITHM_TYPE_SM2.Equals(entry.Value.AlgorithmType))
                        {
                            error = new Exception($"The platform certificate with serial number \"{strSerialNumber}\" is not for SM2.");
                            return false;
                        }

                        error = null;
                        try
                        {
                            return Utilities.SM2Utility.VerifyWithSM3ByCertificate(
                                certificate: entry.Value.Certificate,
                                message: GenerateMessageForSignature(timestamp: strTimestamp, nonce: strNonce, body: strContent),
                                signature: strSignature
                            );
                        }
                        catch (Exception ex)
                        {
                            error = ex;
                            return false;
                        }
                    }

                default:
                    {
                        error = new Exception($"Unsupported signing scheme: \"{strSignScheme}\".");
                        return false;
                    }
            }
        }

        private static string GenerateMessageForSignature(string timestamp, string nonce, string body)
        {
            return $"{timestamp}\n{nonce}\n{body}\n";
        }
    }
}
