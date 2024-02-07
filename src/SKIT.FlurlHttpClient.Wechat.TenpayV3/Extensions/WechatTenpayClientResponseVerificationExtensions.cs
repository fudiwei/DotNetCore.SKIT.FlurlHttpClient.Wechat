using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Primitives;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Constants;

    public static class WechatTenpayClientResponseVerificationExtensions
    {
        /// <summary>
        /// <para>验证响应签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html ]]>
        /// </para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static ErroredResult VerifyResponseSignature<TResponse>(this WechatTenpayClient client, TResponse response)
            where TResponse : WechatTenpayResponse
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (response is null) throw new ArgumentNullException(nameof(response));

            return VerifyResponseSignature(
                client,
                responseTimestamp: response.WechatpayTimestamp,
                responseNonce: response.WechatpayNonce,
                responseBody: Encoding.UTF8.GetString(response.GetRawBytes()),
                responseSignature: response.WechatpaySignature,
                responseSignatureType: response.WechatpaySignatureType,
                responseSerialNumber: response.WechatpayCertificateSerialNumber
            );
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="responseTimestamp"></param>
        /// <param name="responseNonce">。</param>
        /// <param name="responseBody"></param>
        /// <param name="responseSignature"></param>
        /// <param name="responseSerialNumber"></param>
        /// <returns></returns>
        public static ErroredResult VerifyResponseSignature(this WechatTenpayClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSerialNumber)
        {
            return VerifyResponseSignature(
                client,
                responseTimestamp: responseTimestamp,
                responseNonce: responseNonce,
                responseBody: responseBody,
                responseSignature: responseSignature,
                responseSignatureType: SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256,
                responseSerialNumber
            );
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html ]]>
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
        public static ErroredResult VerifyResponseSignature(this WechatTenpayClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSignatureType, string responseSerialNumber)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            return WechatTenpayClientSigningExtensions.VerifySignature(
                client,
                strTimestamp: responseTimestamp,
                strNonce: responseNonce,
                strContent: responseBody,
                strSignature: responseSignature,
                strSignScheme: responseSignatureType,
                strSerialNumber: responseSerialNumber
            );
        }

        /// <summary>
        /// <para>异步验证响应签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html ]]>
        /// </para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task<ErroredResult> VerifyResponseSignatureAsync<TResponse>(this WechatTenpayClient client, TResponse response, CancellationToken cancellationToken = default)
            where TResponse : WechatTenpayResponse
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (response is null) throw new ArgumentNullException(nameof(response));

            return VerifyResponseSignatureAsync(
                client,
                responseTimestamp: response.WechatpayTimestamp,
                responseNonce: response.WechatpayNonce,
                responseBody: Encoding.UTF8.GetString(response.GetRawBytes()),
                responseSignature: response.WechatpaySignature,
                responseSignatureType: response.WechatpaySignatureType,
                responseSerialNumber: response.WechatpayCertificateSerialNumber,
                cancellationToken: cancellationToken
            );
        }

        /// <summary>
        /// <para>异步验证响应签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html ]]>
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
        public static Task<ErroredResult> VerifyResponseSignatureAsync(this WechatTenpayClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSerialNumber, CancellationToken cancellationToken = default)
        {
            return VerifyResponseSignatureAsync(
                client,
                responseTimestamp: responseTimestamp,
                responseNonce: responseNonce,
                responseBody: responseBody,
                responseSignature: responseSignature,
                responseSignatureType: SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256,
                responseSerialNumber: responseSerialNumber,
                cancellationToken
            );
        }

        /// <summary>
        /// <para>异步验证响应签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html ]]>
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
        public static Task<ErroredResult> VerifyResponseSignatureAsync(this WechatTenpayClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSignatureType, string responseSerialNumber, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            return WechatTenpayClientSigningExtensions.VerifySignatureAsync(
                client,
                strTimestamp: responseTimestamp,
                strNonce: responseNonce,
                strContent: responseBody,
                strSignature: responseSignature,
                strSignScheme: responseSignatureType,
                strSerialNumber: responseSerialNumber,
                cancellationToken
            );
        }
    }
}
