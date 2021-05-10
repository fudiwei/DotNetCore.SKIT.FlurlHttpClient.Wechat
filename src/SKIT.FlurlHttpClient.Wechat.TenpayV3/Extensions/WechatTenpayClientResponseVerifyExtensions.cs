using System;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供响应签名验证的扩展方法。
    /// </summary>
    public static class WechatTenpayClientResponseVerifyExtensions
    {
        /// <summary>
        /// <para>验证响应签名（使用微信支付平台证书公钥）。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_1.shtml </para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <param name="publicKey"></param>
        /// <returns></returns>
        public static bool VerifyResponseSignature<TResponse>(this WechatTenpayClient client, TResponse response, string publicKey)
            where TResponse : WechatTenpayResponse
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));
            if (string.IsNullOrEmpty(publicKey)) throw new ArgumentNullException(publicKey);

            try
            {
                return Utilities.RsaUtil.VerifyWithSHA256(
                    publicKey: publicKey,
                    plainText: GetPlainTextForSignature(response),
                    signature: response.WechatpaySignature
                );
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatTenpayResponseVerificationException("Verify response signature failed.", ex);
            }
        }

        /// <summary>
        /// <para>验证响应签名（使用微信支付平台证书）。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_1.shtml </para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <param name="certificate"></param>
        /// <returns></returns>
        public static bool VerifyResponseSignatureByCertificate<TResponse>(this WechatTenpayClient client, TResponse response, string certificate)
            where TResponse : WechatTenpayResponse
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));
            if (string.IsNullOrEmpty(certificate)) throw new ArgumentNullException(certificate);

            try
            {
                return Utilities.RsaUtil.VerifyWithSHA256ByCertificate(
                    certificate: certificate,
                    plainText: GetPlainTextForSignature(response),
                    signature: response.WechatpaySignature
                );
            }
            catch (Exception ex)
            {
                throw new Exceptions.WechatTenpayResponseVerificationException("Verify response signature failed.", ex);
            }
        }

        private static string GetPlainTextForSignature(WechatTenpayResponse response)
        {
            string timestamp = response.WechatpayTimestamp;
            string nonce = response.WechatpayNonce;
            string body = Encoding.UTF8.GetString(response.RawBytes);
            return $"{timestamp}\n{nonce}\n{body}\n";
        }
    }
}
