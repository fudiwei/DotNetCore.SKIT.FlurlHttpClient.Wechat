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
        /// <param name="callbackTimestamp">微信回调通知中的 "Wechatpay-Timestamp" 请求标头。</param>
        /// <param name="callbackNonce">微信回调通知中的 "Wechatpay-Nonce" 请求标头。</param>
        /// <param name="callbackBody">微信回调通知中请求正文。</param>
        /// <param name="callbackSignature">微信回调通知中的 "Wechatpay-Signature" 请求标头。</param>
        /// <param name="callbackSerialNumber">微信回调通知中的 "Wechatpay-Serial" 请求标头。</param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this WechatTenpayClient client, string callbackTimestamp, string callbackNonce, string callbackBody, string callbackSignature, string callbackSerialNumber)
        {
            return VerifyEventSignature(
                client,
                callbackTimestamp: callbackTimestamp,
                callbackNonce: callbackNonce,
                callbackBody: callbackBody,
                callbackSignature: callbackSignature,
                callbackSignatureType: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256,
                callbackSerialNumber: callbackSerialNumber
            );
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">微信回调通知中的 "Wechatpay-Timestamp" 请求标头。</param>
        /// <param name="callbackNonce">微信回调通知中的 "Wechatpay-Nonce" 请求标头。</param>
        /// <param name="callbackBody">微信回调通知中请求正文。</param>
        /// <param name="callbackSignature">微信回调通知中的 "Wechatpay-Signature" 请求标头。</param>
        /// <param name="callbackSignatureType">微信回调通知中的 "Wechatpay-Signature-Type" 请求标头。</param>
        /// <param name="callbackSerialNumber">微信回调通知中的 "Wechatpay-Serial" 请求标头。</param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this WechatTenpayClient client, string callbackTimestamp, string callbackNonce, string callbackBody, string callbackSignature, string callbackSignatureType, string callbackSerialNumber)
        {
            return VerifyEventSignature(
                client,
                callbackTimestamp: callbackTimestamp,
                callbackNonce: callbackNonce,
                callbackBody: callbackBody,
                callbackSignature: callbackSignature,
                callbackSignatureType: callbackSignatureType,
                callbackSerialNumber: callbackSerialNumber,
                out _
            );
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">微信回调通知中的 "Wechatpay-Timestamp" 请求标头。</param>
        /// <param name="callbackNonce">微信回调通知中的 "Wechatpay-Nonce" 请求标头。</param>
        /// <param name="callbackBody">微信回调通知中请求正文。</param>
        /// <param name="callbackSignature">微信回调通知中的 "Wechatpay-Signature" 请求标头。</param>
        /// <param name="callbackSerialNumber">微信回调通知中的 "Wechatpay-Serial" 请求标头。</param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this WechatTenpayClient client, string callbackTimestamp, string callbackNonce, string callbackBody, string callbackSignature, string callbackSerialNumber, out Exception? error)
        {
            return VerifyEventSignature(
                client,
                callbackTimestamp: callbackTimestamp,
                callbackNonce: callbackNonce,
                callbackBody: callbackBody,
                callbackSignature: callbackSignature,
                callbackSignatureType: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256,
                callbackSerialNumber: callbackSerialNumber,
                out error
            );
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/development/interface-rules/signature-verification.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/development/interface-rules/signature-verification.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">微信回调通知中的 "Wechatpay-Timestamp" 请求标头。</param>
        /// <param name="callbackNonce">微信回调通知中的 "Wechatpay-Nonce" 请求标头。</param>
        /// <param name="callbackBody">微信回调通知中请求正文。</param>
        /// <param name="callbackSignature">微信回调通知中的 "Wechatpay-Signature" 请求标头。</param>
        /// <param name="callbackSignatureType">微信回调通知中的 "Wechatpay-Signature-Type" 请求标头。</param>
        /// <param name="callbackSerialNumber">微信回调通知中的 "Wechatpay-Serial" 请求标头。</param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this WechatTenpayClient client, string callbackTimestamp, string callbackNonce, string callbackBody, string callbackSignature, string callbackSignatureType, string callbackSerialNumber, out Exception? error)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackTimestamp == null) throw new ArgumentNullException(nameof(callbackTimestamp));
            if (callbackNonce == null) throw new ArgumentNullException(nameof(callbackNonce));
            if (callbackBody == null) throw new ArgumentNullException(nameof(callbackBody));
            if (callbackSignature == null) throw new ArgumentNullException(nameof(callbackSignature));
            if (callbackSignatureType == null) throw new ArgumentNullException(nameof(callbackSignatureType));
            if (callbackSerialNumber == null) throw new ArgumentNullException(nameof(callbackSerialNumber));

            bool ret = WechatTenpayClientSignExtensions.VerifySignature(
                client,
                strTimestamp: callbackTimestamp,
                strNonce: callbackNonce,
                strContent: callbackBody,
                strSignature: callbackSignature,
                strSignatureScheme: callbackSignatureType,
                strSerialNumber: callbackSerialNumber,
                out error
            );

            if (error != null)
            {
                error = new Exceptions.WechatTenpayEventVerificationException("Verify signature of event failed. Please see the inner exception for more details.", error);
            }

            return ret;
        }
    }
}
