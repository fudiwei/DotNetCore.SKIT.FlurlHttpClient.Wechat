using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    using SKIT.FlurlHttpClient.Primitives;

    public static class WechatTenpayGlobalClientResponseVerificationExtensions
    {
        /// <summary>
        /// <para>验证响应签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/wechatpay/wechatpay4_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static ErroredResult VerifyResponseSignature<TResponse>(this WechatTenpayClient client, TResponse response)
            where TResponse : WechatTenpayResponse
        {
            return WechatTenpayClientResponseVerificationExtensions.VerifyResponseSignature(client, response);
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/wechatpay/wechatpay4_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="responseTimestamp"></param>
        /// <param name="responseNonce">。</param>
        /// <param name="responseBody"></param>
        /// <param name="responseSignature"></param>
        /// <param name="responseSerialNumber"></param>
        /// <returns></returns>
        public static ErroredResult VerifyResponseSignature(this WechatTenpayGlobalClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSerialNumber)
        {
            return WechatTenpayClientResponseVerificationExtensions.VerifyResponseSignature(client, responseTimestamp, responseNonce, responseBody, responseSignature, responseSerialNumber);
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/wechatpay/wechatpay4_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="responseTimestamp"></param>
        /// <param name="responseNonce">。</param>
        /// <param name="responseBody"></param>
        /// <param name="responseSignature"></param>
        /// <param name="responseSignatureType"></param>
        /// <param name="responseSerialNumber"></param>
        /// <returns></returns>
        public static ErroredResult VerifyResponseSignature(this WechatTenpayGlobalClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSignatureType, string responseSerialNumber)
        {
            return WechatTenpayClientResponseVerificationExtensions.VerifyResponseSignature(client, responseTimestamp, responseNonce, responseBody, responseSignature, responseSignatureType, responseSerialNumber);
        }

        /// <summary>
        /// <para>异步验证响应签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/wechatpay/wechatpay4_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task<ErroredResult> VerifyResponseSignatureAsync<TResponse>(this WechatTenpayGlobalClient client, TResponse response, CancellationToken cancellationToken = default)
            where TResponse : WechatTenpayResponse
        {
            return WechatTenpayClientResponseVerificationExtensions.VerifyResponseSignatureAsync(client, response, cancellationToken);
        }

        /// <summary>
        /// <para>异步验证响应签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/wechatpay/wechatpay4_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="responseTimestamp"></param>
        /// <param name="responseNonce">。</param>
        /// <param name="responseBody"></param>
        /// <param name="responseSignature"></param>
        /// <param name="responseSerialNumber"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task<ErroredResult> VerifyResponseSignatureAsync(this WechatTenpayGlobalClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSerialNumber, CancellationToken cancellationToken = default)
        {
            return WechatTenpayClientResponseVerificationExtensions.VerifyResponseSignatureAsync(client, responseTimestamp, responseNonce, responseBody, responseSignature, responseSerialNumber, cancellationToken);
        }

        /// <summary>
        /// <para>异步验证响应签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/wechatpay/wechatpay4_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="responseTimestamp"></param>
        /// <param name="responseNonce">。</param>
        /// <param name="responseBody"></param>
        /// <param name="responseSignature"></param>
        /// <param name="responseSignatureType"></param>
        /// <param name="responseSerialNumber"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task<ErroredResult> VerifyResponseSignatureAsync(this WechatTenpayGlobalClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSignatureType, string responseSerialNumber, CancellationToken cancellationToken = default)
        {
            return WechatTenpayClientResponseVerificationExtensions.VerifyResponseSignatureAsync(client, responseTimestamp, responseNonce, responseBody, responseSignature, responseSignatureType, responseSerialNumber, cancellationToken);
        }
    }
}
