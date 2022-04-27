using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientResponseVerificationExtensions
    {
        /// <summary>
        /// <para>验证响应签名。</para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static bool VerifyResponseSignature<TResponse>(this WechatTenpayBusinessClient client, TResponse response)
            where TResponse : WechatTenpayBusinessResponse
        {
            return VerifyResponseSignature(client, response, out _);
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool VerifyResponseSignature<TResponse>(this WechatTenpayBusinessClient client, TResponse response, out Exception? error)
            where TResponse : WechatTenpayBusinessResponse
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            string? strTBEPAuthorization = response.RawHeaders.FirstOrDefault(e => string.Equals(e.Key, "TBEP-Authorization", StringComparison.OrdinalIgnoreCase)).Value;
            if (!string.IsNullOrEmpty(strTBEPAuthorization))
            {
                try
                {
                    IDictionary<string, string?> dictTBEPAuthorization = strTBEPAuthorization
                        .Split(',')
                        .Select(s => s.Trim().Split('='))
                        .ToDictionary(
                            k => k[0],
                            v => v.Length > 1 ? v[1].TrimStart('\"').TrimEnd('\"') : null
                        );
                    string responseTimestamp = dictTBEPAuthorization["timestamp"]!;
                    string responseNonce = dictTBEPAuthorization["nonce"]!;
                    string responseSignature = dictTBEPAuthorization["signature"]!;
                    string responseSerialNumber = dictTBEPAuthorization["tbep_serial_number"]!;
                    string responseSignAlgorithm = dictTBEPAuthorization["signature_algorithm"]!;

                    return VerifyResponseSignature(client, responseTimestamp, responseNonce, Encoding.UTF8.GetString(response.RawBytes), responseSignature, responseSerialNumber, responseSignAlgorithm, out error);
                }
                catch (Exception ex)
                {
                    error = new Exceptions.WechatTenpayBusinessResponseVerificationException("Verify signature of response failed. Please see the `InnerException` for more details.", ex);
                    return false;
                }
            }

            error = new Exceptions.WechatTenpayBusinessResponseVerificationException("Verify signature of response failed, because could not read value of `TBEP-Authorization`.");
            return false;
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="responseTimestamp"></param>
        /// <param name="responseNonce">。</param>
        /// <param name="responseBody"></param>
        /// <param name="responseSignature"></param>
        /// <param name="responseSerialNumber"></param>
        /// <returns></returns>
        public static bool VerifyResponseSignature(this WechatTenpayBusinessClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSerialNumber)
        {
            return VerifyResponseSignature(client, responseTimestamp, responseNonce, responseBody, responseSignature, responseSerialNumber, Constants.SignAlgorithms.SHA245_WITH_RSA, out _);
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="responseTimestamp"></param>
        /// <param name="responseNonce">。</param>
        /// <param name="responseBody"></param>
        /// <param name="responseSignature"></param>
        /// <param name="responseSerialNumber"></param>
        /// <param name="responseSignAlgorithm"></param>
        /// <returns></returns>
        public static bool VerifyResponseSignature(this WechatTenpayBusinessClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSerialNumber, string responseSignAlgorithm)
        {
            return VerifyResponseSignature(client, responseTimestamp, responseNonce, responseBody, responseSignature, responseSerialNumber, responseSignAlgorithm, out _);
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="responseTimestamp"></param>
        /// <param name="responseNonce">。</param>
        /// <param name="responseBody"></param>
        /// <param name="responseSignature"></param>
        /// <param name="responseSerialNumber"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool VerifyResponseSignature(this WechatTenpayBusinessClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSerialNumber, out Exception? error)
        {
            return VerifyResponseSignature(client, responseTimestamp, responseNonce, responseBody, responseSignature, responseSerialNumber, Constants.SignAlgorithms.SHA245_WITH_RSA, out error);
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="responseTimestamp"></param>
        /// <param name="responseNonce">。</param>
        /// <param name="responseBody"></param>
        /// <param name="responseSignature"></param>
        /// <param name="responseSerialNumber"></param>
        /// <param name="responseSignAlgorithm"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool VerifyResponseSignature(this WechatTenpayBusinessClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSerialNumber, string responseSignAlgorithm, out Exception? error)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (responseTimestamp == null) throw new ArgumentNullException(nameof(responseTimestamp));
            if (responseNonce == null) throw new ArgumentNullException(nameof(responseNonce));
            if (responseBody == null) throw new ArgumentNullException(nameof(responseBody));
            if (responseSignature == null) throw new ArgumentNullException(nameof(responseSignature));
            if (responseSerialNumber == null) throw new ArgumentNullException(nameof(responseSerialNumber));
            if (responseSignAlgorithm == null) throw new ArgumentNullException(nameof(responseSignAlgorithm));

            switch (responseSignAlgorithm)
            {
                case Constants.SignAlgorithms.SHA245_WITH_RSA:
                    {
                        if (client.Credentials.TBEPCertificateSerialNumber != null &&
                            client.Credentials.TBEPCertificatePublicKey != null)
                        {
                            try
                            {
                                if (!string.Equals(client.Credentials.TBEPCertificateSerialNumber, responseSerialNumber))
                                {
                                    error = new Exceptions.WechatTenpayBusinessResponseVerificationException("Verify signature of response failed, because there is no TBEP public key matched the serial number.");
                                    return false;
                                }

                                error = null;
                                return Utilities.RSAUtility.VerifyWithSHA256(
                                    publicKey: client.Credentials.TBEPCertificatePublicKey,
                                    plainText: GetPlainTextForSignature(timestamp: responseTimestamp, nonce: responseNonce, body: responseBody),
                                    signature: responseSignature
                                );
                            }
                            catch (Exception ex)
                            {
                                error = new Exceptions.WechatTenpayBusinessResponseVerificationException("Verify signature of response failed. Please see the `InnerException` for more details.", ex);
                                return false;
                            }
                        }

                        error = new Exceptions.WechatTenpayBusinessResponseVerificationException("Verify signature of response failed, because there is no TBEP public key or serial number.");
                        return false;
                    }

                default:
                    {
                        error = new Exceptions.WechatTenpayBusinessRequestSignatureException("Unsupported authorization sign algorithm.");
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
