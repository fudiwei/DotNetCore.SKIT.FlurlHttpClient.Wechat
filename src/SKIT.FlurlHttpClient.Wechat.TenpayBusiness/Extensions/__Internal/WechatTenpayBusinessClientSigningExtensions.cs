using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    using SKIT.FlurlHttpClient.Primitives;

    internal static class WechatTenpayBusinessClientSigningExtensions
    {
        public static bool VerifySignature(this WechatTenpayBusinessClient client, string strAuthorization, string strContent, out Exception? error)
        {
            if (!string.IsNullOrEmpty(strAuthorization))
            {
                try
                {
                    IDictionary<string, string?> dictAuthorization = strAuthorization
                        .Split(',')
                        .Select(s => s.Trim().Split(new char[] { '=' }, 2, StringSplitOptions.RemoveEmptyEntries))
                        .ToDictionary(
                            k => k[0],
                            v => v.Length > 1 ? v[1].TrimStart('\"').TrimEnd('\"') : null
                        );
                    string strTimestamp = dictAuthorization.GetValueOrDefault("timestamp")!;
                    string strNonce = dictAuthorization.GetValueOrDefault("nonce")!;
                    string strSignature = dictAuthorization.GetValueOrDefault("signature")!;
                    string strSignAlgorithm = dictAuthorization.GetValueOrDefault("signature_algorithm")!;
                    string strSerialNumber = dictAuthorization.GetValueOrDefault("tbep_serial_number")!;

                    return VerifySignature(
                        client,
                        strTimestamp: strTimestamp,
                        strNonce: strNonce,
                        strContent: strContent,
                        strSignature: strSignature,
                        strSignatureAlgorithm: strSignAlgorithm,
                        strSerialNumber: strSerialNumber,
                        out error
                    );
                }
                catch (Exception ex)
                {
                    error = ex;
                    return false;
                }
            }

            error = new Exception("The value of \"TBEP-Authorization\" is empty.");
            return false;
        }

        public static bool VerifySignature(this WechatTenpayBusinessClient client, string strTimestamp, string strNonce, string strContent, string strSignature, string strSignatureAlgorithm, string strSerialNumber, out Exception? error)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            switch (strSignatureAlgorithm)
            {
                case Constants.SignAlgorithms.SHA256_WITH_RSA:
                    {
                        if (client.Credentials.TBEPCertificateSerialNumber is not null &&
                            client.Credentials.TBEPCertificatePublicKey is not null)
                        {
                            try
                            {
                                if (!string.Equals(client.Credentials.TBEPCertificateSerialNumber, strSerialNumber))
                                {
                                    error = new Exception($"There is no TBEP public key matched the serial number \"{strSerialNumber}\".");
                                    return false;
                                }

                                error = null;
                                return Utilities.RSAUtility.Verify(
                                    publicKeyPem: client.Credentials.TBEPCertificatePublicKey,
                                    message: GenerateMessageForSignature(timestamp: strTimestamp, nonce: strNonce, body: strContent),
                                    encodingSignature: new EncodedString(strSignature, EncodingKinds.Base64)
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
                        error = new Exception($"Unsupported sign algorithm: \"{strSignatureAlgorithm}\".");
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
