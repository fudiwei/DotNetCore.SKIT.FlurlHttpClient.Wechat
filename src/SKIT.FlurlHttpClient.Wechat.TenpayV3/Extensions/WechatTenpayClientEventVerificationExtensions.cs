using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientEventVerificationExtensions
    {
        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">微信回调通知中的 "Wechatpay-Timestamp" 请求标头。</param>
        /// <param name="webhookNonce">微信回调通知中的 "Wechatpay-Nonce" 请求标头。</param>
        /// <param name="webhookBody">微信回调通知中请求正文。</param>
        /// <param name="webhookSignature">微信回调通知中的 "Wechatpay-Signature" 请求标头。</param>
        /// <param name="webhookSerialNumber">微信回调通知中的 "Wechatpay-Serial" 请求标头。</param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this WechatTenpayClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSerialNumber)
        {
            return VerifyEventSignature(
                client,
                webhookTimestamp: webhookTimestamp,
                webhookNonce: webhookNonce,
                webhookBody: webhookBody,
                webhookSignature: webhookSignature,
                webhookSignatureType: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256,
                webhookSerialNumber: webhookSerialNumber
            );
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">微信回调通知中的 "Wechatpay-Timestamp" 请求标头。</param>
        /// <param name="webhookNonce">微信回调通知中的 "Wechatpay-Nonce" 请求标头。</param>
        /// <param name="webhookBody">微信回调通知中请求正文。</param>
        /// <param name="webhookSignature">微信回调通知中的 "Wechatpay-Signature" 请求标头。</param>
        /// <param name="webhookSignatureType">微信回调通知中的 "Wechatpay-Signature-Type" 请求标头。</param>
        /// <param name="webhookSerialNumber">微信回调通知中的 "Wechatpay-Serial" 请求标头。</param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this WechatTenpayClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSignatureType, string webhookSerialNumber)
        {
            return VerifyEventSignature(
                client,
                webhookTimestamp: webhookTimestamp,
                webhookNonce: webhookNonce,
                webhookBody: webhookBody,
                webhookSignature: webhookSignature,
                webhookSignatureType: webhookSignatureType,
                webhookSerialNumber: webhookSerialNumber,
                out _
            );
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">微信回调通知中的 "Wechatpay-Timestamp" 请求标头。</param>
        /// <param name="webhookNonce">微信回调通知中的 "Wechatpay-Nonce" 请求标头。</param>
        /// <param name="webhookBody">微信回调通知中请求正文。</param>
        /// <param name="webhookSignature">微信回调通知中的 "Wechatpay-Signature" 请求标头。</param>
        /// <param name="webhookSerialNumber">微信回调通知中的 "Wechatpay-Serial" 请求标头。</param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this WechatTenpayClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSerialNumber, out Exception? error)
        {
            return VerifyEventSignature(
                client,
                webhookTimestamp: webhookTimestamp,
                webhookNonce: webhookNonce,
                webhookBody: webhookBody,
                webhookSignature: webhookSignature,
                webhookSignatureType: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256,
                webhookSerialNumber: webhookSerialNumber,
                out error
            );
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">微信回调通知中的 "Wechatpay-Timestamp" 请求标头。</param>
        /// <param name="webhookNonce">微信回调通知中的 "Wechatpay-Nonce" 请求标头。</param>
        /// <param name="webhookBody">微信回调通知中请求正文。</param>
        /// <param name="webhookSignature">微信回调通知中的 "Wechatpay-Signature" 请求标头。</param>
        /// <param name="webhookSignatureType">微信回调通知中的 "Wechatpay-Signature-Type" 请求标头。</param>
        /// <param name="webhookSerialNumber">微信回调通知中的 "Wechatpay-Serial" 请求标头。</param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this WechatTenpayClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSignatureType, string webhookSerialNumber, out Exception? error)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            bool ret = WechatTenpayClientSigningExtensions.VerifySignature(
                client,
                strTimestamp: webhookTimestamp,
                strNonce: webhookNonce,
                strContent: webhookBody,
                strSignature: webhookSignature,
                strSignScheme: webhookSignatureType,
                strSerialNumber: webhookSerialNumber,
                out error
            );

            if (!ret)
                error ??= new Exception($"Failed to verify webhook event. Maybe the raw signature \"{webhookSignature}\" is invalid.");

            return ret;
        }
    }
}
