using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientEventVerificationExtensions
    {
        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookAuthorization"></param>
        /// <param name="webhookBody"></param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this WechatTenpayBusinessClient client, string webhookAuthorization, string webhookBody)
        {
            return VerifyEventSignature(client, webhookAuthorization, webhookBody, out _);
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookAuthorization"></param>
        /// <param name="webhookBody"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this WechatTenpayBusinessClient client, string webhookAuthorization, string webhookBody, out Exception? error)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookAuthorization is null) throw new ArgumentNullException(nameof(webhookAuthorization));
            if (webhookBody is null) throw new ArgumentNullException(nameof(webhookBody));

            bool ret = WechatTenpayBusinessClientSigningExtensions.VerifySignature(
                client,
                strAuthorization: webhookAuthorization,
                strContent: webhookBody,
                out error
            );

            if (!ret)
                error ??= new Exception($"Failed to verify webhook event. Maybe the raw signature is invalid.");

            return ret;
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
        public static bool VerifyEventSignature(this WechatTenpayBusinessClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSerialNumber)
        {
            return VerifyEventSignature(
                client,
                webhookTimestamp: webhookTimestamp,
                webhookNonce: webhookNonce,
                webhookBody: webhookBody,
                webhookSignature: webhookSignature,
                webhookSignatureAlgorithm: Constants.SignAlgorithms.SHA245_WITH_RSA,
                webhookSerialNumber: webhookSerialNumber,
                out _
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
        public static bool VerifyEventSignature(this WechatTenpayBusinessClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSignatureAlgorithm, string webhookSerialNumber)
        {
            return VerifyEventSignature(
                client,
                webhookTimestamp: webhookTimestamp,
                webhookNonce: webhookNonce,
                webhookBody: webhookBody,
                webhookSignature: webhookSignature,
                webhookSignatureAlgorithm: webhookSignatureAlgorithm,
                webhookSerialNumber: webhookSerialNumber,
                out _
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
        /// <param name="error"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool VerifyEventSignature(this WechatTenpayBusinessClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSerialNumber, out Exception? error)
        {
            return VerifyEventSignature(
                client,
                webhookTimestamp: webhookTimestamp,
                webhookNonce: webhookNonce,
                webhookBody: webhookBody,
                webhookSignature: webhookSignature,
                webhookSignatureAlgorithm: Constants.SignAlgorithms.SHA245_WITH_RSA,
                webhookSerialNumber: webhookSerialNumber,
                out error
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
        /// <param name="error"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool VerifyEventSignature(this WechatTenpayBusinessClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSignatureAlgorithm, string webhookSerialNumber, out Exception? error)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            bool ret = WechatTenpayBusinessClientSigningExtensions.VerifySignature(
                client,
                strTimestamp: webhookTimestamp,
                strNonce: webhookNonce,
                strContent: webhookBody,
                strSignature: webhookSignature,
                strSignatureAlgorithm: webhookSignatureAlgorithm,
                strSerialNumber: webhookSerialNumber,
                out error
            );

            if (!ret)
                error ??= new Exception($"Failed to verify webhook event. Maybe the raw signature \"{webhookSignature}\" is invalid.");

            return ret;
        }
    }
}
