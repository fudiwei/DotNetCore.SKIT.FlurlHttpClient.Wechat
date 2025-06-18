using System;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    using SKIT.FlurlHttpClient.Primitives;

    public static class WechatTenpayBusinessClientResponseVerificationExtensions
    {
        /// <summary>
        /// <para>验证响应签名。</para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static ErroredResult VerifyResponseSignature<TResponse>(this WechatTenpayBusinessClient client, TResponse response)
            where TResponse : WechatTenpayBusinessResponse
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            return WechatTenpayBusinessClientSigningExtensions.VerifySignature(
                client,
                strAuthorization: response.GetRawHeaders().GetFirstValueOrEmpty("TBEP-Authorization"),
                strContent: Encoding.UTF8.GetString(response.GetRawBytes())
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
        /// <returns></returns>
        public static ErroredResult VerifyResponseSignature(this WechatTenpayBusinessClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSerialNumber)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            return VerifyResponseSignature(
                client,
                responseTimestamp: responseTimestamp,
                responseNonce: responseNonce,
                responseBody: responseBody,
                responseSignature: responseSignature,
                responseSignatureAlgorithm: Constants.SignAlgorithms.SHA256_WITH_RSA,
                responseSerialNumber: responseSerialNumber
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
        public static ErroredResult VerifyResponseSignature(this WechatTenpayBusinessClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSignatureAlgorithm, string responseSerialNumber)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            return WechatTenpayBusinessClientSigningExtensions.VerifySignature(
                client,
                strTimestamp: responseTimestamp,
                strNonce: responseNonce,
                strContent: responseBody,
                strSignature: responseSignature,
                strSignatureAlgorithm: responseSignatureAlgorithm,
                strSerialNumber: responseSerialNumber
            );
        }
    }
}
