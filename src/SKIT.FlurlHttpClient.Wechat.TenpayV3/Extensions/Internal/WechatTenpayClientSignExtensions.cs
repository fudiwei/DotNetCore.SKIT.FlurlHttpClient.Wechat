using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    internal static class WechatTenpayClientSignExtensions
    {
        public static bool VerifySignature(this WechatTenpayClient client, string strTimestamp, string strNonce, string strBody, string strSignature, string strSerialNumber)
        {
            return VerifySignature(client, strTimestamp, strNonce, strBody, strSignature, strSerialNumber, Constants.SignSchemes.WECHATPAY2_SHA256_RSA2048, out _);
        }

        public static bool VerifySignature(this WechatTenpayClient client, string strTimestamp, string strNonce, string strBody, string strSignature, string strSerialNumber, string strSignScheme)
        {
            return VerifySignature(client, strTimestamp, strNonce, strBody, strSignature, strSerialNumber, strSignScheme, out _);
        }

        public static bool VerifySignature(this WechatTenpayClient client, string strTimestamp, string strNonce, string strBody, string strSignature, string strSerialNumber, out Exception? error)
        {
            return VerifySignature(client, strTimestamp, strNonce, strBody, strSignature, strSerialNumber, Constants.SignSchemes.WECHATPAY2_SHA256_RSA2048, out error);
        }

        public static bool VerifySignature(this WechatTenpayClient client, string strTimestamp, string strNonce, string strBody, string strSignature, string strSerialNumber, string strSignScheme, out Exception? error)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));

            switch (strSignScheme)
            {
                case Constants.SignSchemes.WECHATPAY2_SHA256_RSA2048:
                    {
                        if (client.PlatformCertificateManager != null)
                        {
                            try
                            {
                                var cert = client.PlatformCertificateManager.GetEntry(strSerialNumber);
                                if (!cert.HasValue)
                                {
                                    error = new Exceptions.WechatTenpayEventVerificationException("There is no platform certificate matched the serial number.");
                                    return false;
                                }

                                error = null;
                                return Utilities.RSAUtility.VerifyWithSHA256ByCertificate(
                                    certificate: cert.Value.Certificate,
                                    plainText: GetPlainTextForSignature(timestamp: strTimestamp, nonce: strNonce, body: strBody),
                                    signature: strSignature
                                );
                            }
                            catch (Exception ex)
                            {
                                error = ex;
                                return false;
                            }
                        }

                        error = new Exception("There is no platform certificate in the certificate manager.");
                        return false;
                    }

                default:
                    {
                        error = new Exception("Unsupported sign scheme.");
                        return false;
                    }
            }
        }

        private static string GetPlainTextForSignature(string timestamp, string nonce, string body)
        {
            return $"{timestamp}\n{nonce}\n{body}\n";
        }
    }
}
