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
        public static bool VerifyResponseSignature<TResponse>(this WechatTenpayBusinessClient client, TResponse response, out Exception? error)
            where TResponse : WechatTenpayBusinessResponse
        {
            if (client == null) throw new ArgumentNullException(nameof(client));

            string? responseAuthHeader = response.RawHeaders.FirstOrDefault(e => string.Equals(e.Key, "TBEP-Authorization", StringComparison.OrdinalIgnoreCase)).Value;
            string responseBody = Encoding.UTF8.GetString(response.RawBytes);
            bool ret = WechatTenpayBusinessClientSignExtensions.VerifySignature(client, responseAuthHeader, responseBody, out error);
            if (error != null)
                error = new Exceptions.WechatTenpayBusinessResponseVerificationException("Verify signature of response failed. Please see the `InnerException` for more details.", error);
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
        public static bool VerifyResponseSignature(this WechatTenpayBusinessClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSerialNumber, string responseSignAlgorithm, out Exception? error)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));

            bool ret = WechatTenpayBusinessClientSignExtensions.VerifySignature(client, responseTimestamp, responseNonce, responseBody, responseSignature, responseSerialNumber, responseSignAlgorithm, out error);
            if (error != null)
                error = new Exceptions.WechatTenpayBusinessResponseVerificationException("Verify signature of response failed. Please see the `InnerException` for more details.", error);
            return ret;
        }
    }
}
