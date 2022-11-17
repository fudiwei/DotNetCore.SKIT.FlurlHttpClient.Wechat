using System;
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
        public static bool VerifyResponseSignature<TResponse>(this WechatTenpayBusinessClient client, TResponse response, out Exception? error)
            where TResponse : WechatTenpayBusinessResponse
        {
            if (client == null) throw new ArgumentNullException(nameof(client));

            bool ret = WechatTenpayBusinessClientSignExtensions.VerifySignature(
                client,
                strAuthorization: response.RawHeaders.FirstOrDefault(e => string.Equals(e.Key, "TBEP-Authorization", StringComparison.OrdinalIgnoreCase)).Value,
                strContent: Encoding.UTF8.GetString(response.RawBytes),
                out error
            );

            if (error != null)
            {
                error = new Exceptions.WechatTenpayBusinessResponseVerificationException("Verify signature of response failed. Please see the `InnerException` for more details.", error);
            }

            return ret;
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
            return VerifyResponseSignature(
                client,
                responseTimestamp: responseTimestamp,
                responseNonce: responseNonce,
                responseBody: responseBody,
                responseSignature: responseSignature,
                responseSignatureAlgorithm: Constants.SignAlgorithms.SHA245_WITH_RSA,
                responseSerialNumber: responseSerialNumber,
                out _
            );
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="responseTimestamp"></param>
        /// <param name="responseNonce">。</param>
        /// <param name="responseBody"></param>
        /// <param name="responseSignature"></param>
        /// <param name="responseSignatureAlgorithm"></param>
        /// <param name="responseSerialNumber"></param>
        /// <returns></returns>
        public static bool VerifyResponseSignature(this WechatTenpayBusinessClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSignatureAlgorithm, string responseSerialNumber)
        {
            return VerifyResponseSignature(
                client,
                responseTimestamp: responseTimestamp,
                responseNonce: responseNonce,
                responseBody: responseBody,
                responseSignature: responseSignature,
                responseSignatureAlgorithm: responseSignatureAlgorithm,
                responseSerialNumber: responseSerialNumber,
                out _
            );
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
        /// <param name="error"></param>
        /// <returns></returns>
        public static bool VerifyResponseSignature(this WechatTenpayBusinessClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSerialNumber, out Exception? error)
        {
            return VerifyResponseSignature(
                client,
                responseTimestamp: responseTimestamp,
                responseNonce: responseNonce,
                responseBody: responseBody,
                responseSignature: responseSignature,
                responseSignatureAlgorithm: Constants.SignAlgorithms.SHA245_WITH_RSA,
                responseSerialNumber: responseSerialNumber,
                out error
            );
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="responseTimestamp"></param>
        /// <param name="responseNonce">。</param>
        /// <param name="responseBody"></param>
        /// <param name="responseSignature"></param>
        /// <param name="responseSignatureAlgorithm"></param>
        /// <param name="responseSerialNumber"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static bool VerifyResponseSignature(this WechatTenpayBusinessClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSignatureAlgorithm, string responseSerialNumber, out Exception? error)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));

            bool ret = WechatTenpayBusinessClientSignExtensions.VerifySignature(
                client,
                strTimestamp: responseTimestamp,
                strNonce: responseNonce,
                strContent: responseBody,
                strSignature: responseSignature,
                strSignatureAlgorithm: responseSignatureAlgorithm,
                strSerialNumber: responseSerialNumber,
                out error
            );

            if (error != null)
            {
                error = new Exceptions.WechatTenpayBusinessResponseVerificationException("Verify signature of response failed. Please see the `InnerException` for more details.", error);
            }

            return ret;
        }
    }
}
