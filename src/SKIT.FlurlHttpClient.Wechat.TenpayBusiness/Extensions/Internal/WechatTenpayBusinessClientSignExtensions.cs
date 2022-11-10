using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    internal static class WechatTenpayBusinessClientSignExtensions
    {
        public static bool VerifySignature(this WechatTenpayBusinessClient client, string strAuthorization, string strContent, out Exception? error)
        {
            if (!string.IsNullOrEmpty(strAuthorization))
            {
                try
                {
                    IDictionary<string, string?> dictTBEPAuthorization = strAuthorization
                        .Split(',')
                        .Select(s => s.Trim().Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries))
                        .ToDictionary(
                            k => k[0],
                            v => v.Length > 1 ? v[1].TrimStart('\"').TrimEnd('\"') : null
                        );
                    string strTimestamp = dictTBEPAuthorization["timestamp"]!;
                    string strNonce = dictTBEPAuthorization["nonce"]!;
                    string strSignature = dictTBEPAuthorization["signature"]!;
                    string strSignAlgorithm = dictTBEPAuthorization["signature_algorithm"]!;
                    string strSerialNumber = dictTBEPAuthorization["tbep_serial_number"]!;

                    return VerifySignature(
                        client,
                        strTimestamp: strTimestamp,
                        strNonce: strNonce,
                        strContent: strContent,
                        strSignature: strSignature,
                        strSignatureAlgorithm: strSignAlgorithm,
                        strSerialNumber: strSerialNumber, out error);
                }
                catch (Exception ex)
                {
                    error = ex;
                    return false;
                }
            }

            error = new Exception("Could not read value of `TBEP-Authorization`.");
            return false;
        }

        public static bool VerifySignature(this WechatTenpayBusinessClient client, string strTimestamp, string strNonce, string strContent, string strSignature, string strSignatureAlgorithm, string strSerialNumber, out Exception? error)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));

            switch (strSignatureAlgorithm)
            {
                case Constants.SignAlgorithms.SHA245_WITH_RSA:
                    {
                        if (client.Credentials.TBEPCertificateSerialNumber != null &&
                            client.Credentials.TBEPCertificatePublicKey != null)
                        {
                            try
                            {
                                if (!string.Equals(client.Credentials.TBEPCertificateSerialNumber, strSerialNumber))
                                {
                                    error = new Exception("There is no TBEP public key matched the serial number.");
                                    return false;
                                }

                                error = null;
                                return Utilities.RSAUtility.VerifyWithSHA256(
                                    publicKey: client.Credentials.TBEPCertificatePublicKey,
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

                        error = new Exception("There is no TBEP public key or serial number.");
                        return false;
                    }

                default:
                    {
                        error = new Exception("Unsupported sign algorithm.");
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
