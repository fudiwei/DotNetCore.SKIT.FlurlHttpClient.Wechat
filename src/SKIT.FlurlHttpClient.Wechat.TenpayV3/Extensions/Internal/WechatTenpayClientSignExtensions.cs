using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    internal static class WechatTenpayClientSignExtensions
    {
        public static bool VerifySignature(this WechatTenpayClient client, string strTimestamp, string strNonce, string strContent, string strSignature, string strSignatureScheme, string strSerialNumber, out Exception? error)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));

            switch (strSignatureScheme)
            {
                case Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256:
                    {
                        if (client.PlatformCertificateManager == null)
                        {
                            error = new Exception("The platform certificate manager is not initialized.");
                            return false;
                        }

                        var entry = client.PlatformCertificateManager.GetEntry(strSerialNumber);
                        if (!entry.HasValue)
                        {
                            error = new Exception($"There is no platform certificate matched the serial number: \"{strSerialNumber}\", please make sure you have downloaded platform certificates first.");
                            return false;
                        }

                        if (!Settings.CertificateEntry.ALGORITHM_TYPE_RSA.Equals(entry.Value.AlgorithmType))
                        {
                            error = new Exception($"The platform certificate with serial number: \"{strSerialNumber}\" is not for RSA.");
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
                        if (client.PlatformCertificateManager == null)
                        {
                            error = new Exception("The platform certificate manager is not initialized.");
                            return false;
                        }

                        var entry = client.PlatformCertificateManager.GetEntry(strSerialNumber);
                        if (!entry.HasValue)
                        {
                            error = new Exception($"There is no platform certificate matched the serial number: \"{strSerialNumber}\", please make sure you have downloaded platform certificates first.");
                            return false;
                        }

                        if (!Settings.CertificateEntry.ALGORITHM_TYPE_SM2.Equals(entry.Value.AlgorithmType))
                        {
                            error = new Exception($"The platform certificate with serial number: \"{strSerialNumber}\" is not for SM2.");
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
                        error = new Exception($"Unsupported signature scheme: \"{strSignatureScheme}\".");
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
