using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    using SKIT.FlurlHttpClient.Primitives;

    internal static class WechatTenpayBusinessClientSigningExtensions
    {
        public static ErroredResult VerifySignature(this WechatTenpayBusinessClient client, string strAuthorization, string strContent)
        {
            ErroredResult result;

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

                result = VerifySignature(
                    client,
                    strTimestamp: strTimestamp,
                    strNonce: strNonce,
                    strContent: strContent,
                    strSignature: strSignature,
                    strSignatureAlgorithm: strSignAlgorithm,
                    strSerialNumber: strSerialNumber
                );
            }
            catch (Exception ex)
            {
                result = ErroredResult.Fail(ex);
            }

            return result;
        }

        public static ErroredResult VerifySignature(this WechatTenpayBusinessClient client, string strTimestamp, string strNonce, string strContent, string strSignature, string strSignatureAlgorithm, string strSerialNumber)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            ErroredResult result;

            switch (strSignatureAlgorithm)
            {
                case Constants.SignAlgorithms.SHA256_WITH_RSA:
                    {
                        try
                        {
                            if (!string.Equals(client.Credentials.TBEPCertificateSerialNumber, strSerialNumber))
                            {
                                result = ErroredResult.Fail(new Exception($"There is no TBEP public key matched the serial number \"{strSerialNumber}\"."));
                                break;
                            }

                            bool valid = Utilities.RSAUtility.VerifyWithSHA256(
                                publicKeyPem: client.Credentials.TBEPCertificatePublicKey,
                                messageData: GenerateMessageForSignature(timestamp: strTimestamp, nonce: strNonce, body: strContent),
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
                        result = ErroredResult.Fail(new Exception($"Unsupported sign algorithm: \"{strSignatureAlgorithm}\"."));
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
