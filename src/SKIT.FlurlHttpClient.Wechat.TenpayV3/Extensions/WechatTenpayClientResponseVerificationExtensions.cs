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
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (response == null) throw new ArgumentNullException(nameof(response));

            if (client.WechatCertificateStorer == null)
            {
                throw new Exceptions.WechatTenpayResponseVerificationException($"You must set an instance of `{nameof(Settings.ICertificateStorer)}` at first.");
            }
            else
            {
                if (response.WechatpayCertSerialNumber == null)
                    throw new Exceptions.WechatTenpayResponseVerificationException("Cannot read the serial number in headers of this response.");

                string? certificate = client.WechatCertificateStorer.Get(response.WechatpayCertSerialNumber);
                if (certificate == null)
                    throw new Exceptions.WechatTenpayResponseVerificationException("Cannot get certificate by the serial number, may not be stored.");

                string? publicKey = null;
                try
                {
                    publicKey = Utilities.RSAUtility.ExportPublicKey(certificate);
                }
                catch (Exception ex)
                {
                    throw new Exceptions.WechatTenpayResponseVerificationException("Cannot get public key of the certificate, may not be a valid certificate data.", ex);
                }

                try
                {
                    return Utilities.RSAUtility.VerifyWithSHA256(
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
