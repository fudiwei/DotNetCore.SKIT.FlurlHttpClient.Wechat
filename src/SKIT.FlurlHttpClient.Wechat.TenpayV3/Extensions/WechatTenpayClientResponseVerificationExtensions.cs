using System;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientResponseVerificationExtensions
    {
        /// <summary>
        /// <para>验证响应签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html </para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static bool VerifyResponseSignature<TResponse>(this WechatTenpayClient client, TResponse response)
            where TResponse : WechatTenpayResponse
        {
            return VerifyResponseSignature(client, response, out _);
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html </para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static bool VerifyResponseSignature<TResponse>(this WechatTenpayClient client, TResponse response, out Exception? error)
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
                responseSerialNumber: response.WechatpayCertificateSerialNumber,
                out error
            );
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="responseTimestamp"></param>
        /// <param name="responseNonce">。</param>
        /// <param name="responseBody"></param>
        /// <param name="responseSignature"></param>
        /// <param name="responseSerialNumber"></param>
        /// <returns></returns>
        public static bool VerifyResponseSignature(this WechatTenpayClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSerialNumber)
        {
            return VerifyResponseSignature(
                client,
                responseTimestamp: responseTimestamp,
                responseNonce: responseNonce,
                responseBody: responseBody,
                responseSignature: responseSignature,
                responseSignatureType: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256,
                responseSerialNumber: responseSerialNumber
            );
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="responseTimestamp"></param>
        /// <param name="responseNonce">。</param>
        /// <param name="responseBody"></param>
        /// <param name="responseSignature"></param>
        /// <param name="responseSignatureType"></param>
        /// <param name="responseSerialNumber"></param>
        /// <returns></returns>
        public static bool VerifyResponseSignature(this WechatTenpayClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSignatureType, string responseSerialNumber)
        {
            return VerifyResponseSignature(
                client,
                responseTimestamp: responseTimestamp,
                responseNonce: responseNonce,
                responseBody: responseBody,
                responseSignature: responseSignature,
                responseSignatureType: responseSignatureType,
                responseSerialNumber,
                out _
            );
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="responseTimestamp"></param>
        /// <param name="responseNonce">。</param>
        /// <param name="responseBody"></param>
        /// <param name="responseSignature"></param>
        /// <param name="responseSerialNumber"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static bool VerifyResponseSignature(this WechatTenpayClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSerialNumber, out Exception? error)
        {
            return VerifyResponseSignature(
                client,
                responseTimestamp: responseTimestamp,
                responseNonce: responseNonce,
                responseBody: responseBody,
                responseSignature: responseSignature,
                responseSignatureType: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256,
                responseSerialNumber,
                out error
            );
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="responseTimestamp"></param>
        /// <param name="responseNonce">。</param>
        /// <param name="responseBody"></param>
        /// <param name="responseSignature"></param>
        /// <param name="responseSignatureType"></param>
        /// <param name="responseSerialNumber"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static bool VerifyResponseSignature(this WechatTenpayClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSignatureType, string responseSerialNumber, out Exception? error)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            bool ret = WechatTenpayClientSigningExtensions.VerifySignature(
                client,
                strTimestamp: responseTimestamp,
                strNonce: responseNonce,
                strContent: responseBody,
                strSignature: responseSignature,
                strSignScheme: responseSignatureType,
                strSerialNumber: responseSerialNumber,
                out error
            );

            if (!ret)
                error ??= new Exception($"Failed to verify response. Maybe the raw signature \"{responseSignature}\" is invalid.");

            return ret;
        }
    }
}
