using System;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供响应签名验证的扩展方法。
    /// </summary>
    public static class WechatTenpayClientResponseVerificationExtensions
    {
        /// <summary>
        /// <para>验证响应签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_1.shtml </para>
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
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_1.shtml </para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool VerifyResponseSignature<TResponse>(this WechatTenpayClient client, TResponse response, out Exception? error)
            where TResponse : WechatTenpayResponse
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            return VerifyResponseSignature(client, response.WechatpayTimestamp, response.WechatpayNonce, Encoding.UTF8.GetString(response.RawBytes), response.WechatpaySignature, response.WechatpayCertificateSerialNumber, out error);
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_1.shtml </para>
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
            return VerifyResponseSignature(client, responseTimestamp, responseNonce, responseBody, responseSignature, responseSerialNumber, out _);
        }

        /// <summary>
        /// <para>验证响应签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_1.shtml </para>
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
        public static bool VerifyResponseSignature(this WechatTenpayClient client, string responseTimestamp, string responseNonce, string responseBody, string responseSignature, string responseSerialNumber, out Exception? error)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (responseTimestamp == null) throw new ArgumentNullException(nameof(responseTimestamp));
            if (responseNonce == null) throw new ArgumentNullException(nameof(responseNonce));
            if (responseBody == null) throw new ArgumentNullException(nameof(responseBody));
            if (responseSignature == null) throw new ArgumentNullException(nameof(responseSignature));
            if (responseSerialNumber == null) throw new ArgumentNullException(nameof(responseSerialNumber));

            bool ret = WechatTenpayClientSignExtensions.VerifySignature(client, responseTimestamp, responseNonce, responseBody, responseSignature, responseSerialNumber, out error);
            if (error != null)
                error = new Exceptions.WechatTenpayEventVerificationException("Verify signature of response failed. Please see the `InnerException` for more details.", error);
            return ret;
        }
    }
}
