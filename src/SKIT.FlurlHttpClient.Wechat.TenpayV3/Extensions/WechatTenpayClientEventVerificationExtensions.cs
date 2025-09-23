using System;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Primitives;
    using SKIT.FlurlHttpClient.Wechat.TenpayV3.Constants;

    public static class WechatTenpayClientEventVerificationExtensions
    {
        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013053249 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013053420 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013059017 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013059030 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">微信回调通知中的 "Wechatpay-Timestamp" 请求标头。</param>
        /// <param name="webhookNonce">微信回调通知中的 "Wechatpay-Nonce" 请求标头。</param>
        /// <param name="webhookBody">微信回调通知中请求正文。</param>
        /// <param name="webhookSignature">微信回调通知中的 "Wechatpay-Signature" 请求标头。</param>
        /// <param name="webhookSerialNumber">微信回调通知中的 "Wechatpay-Serial" 请求标头。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignature(this WechatTenpayClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSerialNumber)
        {
            return VerifyEventSignature(
                client,
                webhookTimestamp: webhookTimestamp,
                webhookNonce: webhookNonce,
                webhookBody: webhookBody,
                webhookSignature: webhookSignature,
                webhookSignatureType: SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256,
                webhookSerialNumber: webhookSerialNumber
            );
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013053249 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013053420 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013059017 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013059030 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">微信回调通知中的 "Wechatpay-Timestamp" 请求标头。</param>
        /// <param name="webhookNonce">微信回调通知中的 "Wechatpay-Nonce" 请求标头。</param>
        /// <param name="webhookBody">微信回调通知中请求正文。</param>
        /// <param name="webhookSignature">微信回调通知中的 "Wechatpay-Signature" 请求标头。</param>
        /// <param name="webhookSignatureType">微信回调通知中的 "Wechatpay-Signature-Type" 请求标头。</param>
        /// <param name="webhookSerialNumber">微信回调通知中的 "Wechatpay-Serial" 请求标头。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignature(this WechatTenpayClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSignatureType, string webhookSerialNumber)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            return WechatTenpayClientSigningExtensions._VerifySignature(
                client,
                strTimestamp: webhookTimestamp,
                strNonce: webhookNonce,
                strContent: webhookBody,
                strSignature: webhookSignature,
                strSignScheme: webhookSignatureType,
                strSerialNumber: webhookSerialNumber
            );
        }

        /// <summary>
        /// <para>异步验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013053249 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013053420 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013059017 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013059030 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">微信回调通知中的 "Wechatpay-Timestamp" 请求标头。</param>
        /// <param name="webhookNonce">微信回调通知中的 "Wechatpay-Nonce" 请求标头。</param>
        /// <param name="webhookBody">微信回调通知中请求正文。</param>
        /// <param name="webhookSignature">微信回调通知中的 "Wechatpay-Signature" 请求标头。</param>
        /// <param name="webhookSerialNumber">微信回调通知中的 "Wechatpay-Serial" 请求标头。</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task<ErroredResult> VerifyEventSignatureAsync(this WechatTenpayClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSerialNumber, CancellationToken cancellationToken = default)
        {
            return VerifyEventSignatureAsync(
                client,
                webhookTimestamp: webhookTimestamp,
                webhookNonce: webhookNonce,
                webhookBody: webhookBody,
                webhookSignature: webhookSignature,
                webhookSignatureType: SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256,
                webhookSerialNumber: webhookSerialNumber,
                cancellationToken: cancellationToken
            );
        }

        /// <summary>
        /// <para>异步验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013053249 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013053420 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013059017 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013059030 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">微信回调通知中的 "Wechatpay-Timestamp" 请求标头。</param>
        /// <param name="webhookNonce">微信回调通知中的 "Wechatpay-Nonce" 请求标头。</param>
        /// <param name="webhookBody">微信回调通知中请求正文。</param>
        /// <param name="webhookSignature">微信回调通知中的 "Wechatpay-Signature" 请求标头。</param>
        /// <param name="webhookSignatureType">微信回调通知中的 "Wechatpay-Signature-Type" 请求标头。</param>
        /// <param name="webhookSerialNumber">微信回调通知中的 "Wechatpay-Serial" 请求标头。</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task<ErroredResult> VerifyEventSignatureAsync(this WechatTenpayClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSignatureType, string webhookSerialNumber, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            return WechatTenpayClientSigningExtensions._VerifySignatureAsync(
                client,
                strTimestamp: webhookTimestamp,
                strNonce: webhookNonce,
                strContent: webhookBody,
                strSignature: webhookSignature,
                strSignScheme: webhookSignatureType,
                strSerialNumber: webhookSerialNumber,
                cancellationToken: cancellationToken
            );
        }
    }
}
