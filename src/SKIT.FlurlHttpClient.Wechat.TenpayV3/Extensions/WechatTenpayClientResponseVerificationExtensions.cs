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

            if (client.CertificateManager != null)
            {
                try
                {
                    string certificate = client.CertificateManager.GetCertificate(response.WechatpayCertSerialNumber)!;
                    string publicKey = Utilities.RSAUtility.ExportPublicKey(certificate);

                    return Utilities.RSAUtility.VerifyWithSHA256(
                        publicKey: publicKey,
                        plainText: GetPlainTextForSignature(response),
                        signature: response.WechatpaySignature
                    );
                }
                catch { }
            }

            return false;
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
