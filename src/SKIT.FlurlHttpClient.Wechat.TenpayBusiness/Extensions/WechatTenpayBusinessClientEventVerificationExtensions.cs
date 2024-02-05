using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    using SKIT.FlurlHttpClient.Primitives;

    public static class WechatTenpayBusinessClientEventVerificationExtensions
    {
        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookAuthorization"></param>
        /// <param name="webhookBody"></param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignature(this WechatTenpayBusinessClient client, string webhookAuthorization, string webhookBody)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            return WechatTenpayBusinessClientSigningExtensions.VerifySignature(
                client,
                strAuthorization: webhookAuthorization,
                strContent: webhookBody
            );
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp"></param>
        /// <param name="webhookNonce">。</param>
        /// <param name="webhookBody"></param>
        /// <param name="webhookSignature"></param>
        /// <param name="webhookSerialNumber"></param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignature(this WechatTenpayBusinessClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSerialNumber)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            return VerifyEventSignature(
                client,
                webhookTimestamp: webhookTimestamp,
                webhookNonce: webhookNonce,
                webhookBody: webhookBody,
                webhookSignature: webhookSignature,
                webhookSignatureAlgorithm: Constants.SignAlgorithms.SHA256_WITH_RSA,
                webhookSerialNumber: webhookSerialNumber
            );
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp"></param>
        /// <param name="webhookNonce">。</param>
        /// <param name="webhookBody"></param>
        /// <param name="webhookSignature"></param>
        /// <param name="webhookSignatureAlgorithm"></param>
        /// <param name="webhookSerialNumber"></param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignature(this WechatTenpayBusinessClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSignatureAlgorithm, string webhookSerialNumber)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            return WechatTenpayBusinessClientSigningExtensions.VerifySignature(
                client,
                strTimestamp: webhookTimestamp,
                strNonce: webhookNonce,
                strContent: webhookBody,
                strSignature: webhookSignature,
                strSignatureAlgorithm: webhookSignatureAlgorithm,
                strSerialNumber: webhookSerialNumber
            );
        }
    }
}
