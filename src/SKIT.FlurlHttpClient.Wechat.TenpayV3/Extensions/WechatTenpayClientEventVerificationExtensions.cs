using System;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供回调通知事件签名验证的扩展方法。
    /// </summary>
    public static class WechatTenpayClientEventVerificationExtensions
    {
        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay4_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/wechatpay/wechatpay4_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">微信回调通知中的 Wechatpay-Timestamp 字段。</param>
        /// <param name="callbackNonce">微信回调通知中的 Wechatpay-Nonce 字段。</param>
        /// <param name="callbackBody">微信回调通知中请求正文。</param>
        /// <param name="callbackSignature">微信回调通知中的 Wechatpay-Signature 字段。</param>
        /// <param name="callbackSerialNumber">微信回调通知中的 Wechatpay-Serial 字段。</param>
        /// <returns></returns>
        public static bool VerifyEventSignature(
            this WechatTenpayClient client, 
            string callbackTimestamp, 
            string callbackNonce, 
            string callbackBody,
            string callbackSignature,
            string callbackSerialNumber)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackTimestamp == null) throw new ArgumentNullException(nameof(callbackTimestamp));
            if (callbackNonce == null) throw new ArgumentNullException(nameof(callbackNonce));
            if (callbackBody == null) throw new ArgumentNullException(nameof(callbackBody));
            if (callbackSignature == null) throw new ArgumentNullException(nameof(callbackSignature));
            if (callbackSerialNumber == null) throw new ArgumentNullException(nameof(callbackSerialNumber));

            if (client.CertificateManager != null)
            {
                try
                {
                    string certificate = client.CertificateManager.GetCertificate(callbackSerialNumber)!;
                    string publicKey = Utilities.RSAUtility.ExportPublicKey(certificate);

                    return Utilities.RSAUtility.VerifyWithSHA256(
                        publicKey: publicKey,
                        plainText: GetPlainTextForSignature(timestamp: callbackTimestamp, nonce: callbackNonce, body: callbackBody),
                        signature: callbackSignature
                    );
                }
                catch { }
            }

            return false;
        }

        private static string GetPlainTextForSignature(string timestamp, string nonce, string body)
        {
            return $"{timestamp}\n{nonce}\n{body}\n";
        }
    }
}
