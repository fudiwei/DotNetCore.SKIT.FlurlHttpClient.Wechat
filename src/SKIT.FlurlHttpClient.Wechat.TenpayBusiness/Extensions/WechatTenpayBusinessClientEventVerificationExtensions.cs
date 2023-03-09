using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientEventVerificationExtensions
    {
        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackAuthorization"></param>
        /// <param name="callbackBody"></param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this WechatTenpayBusinessClient client, string callbackAuthorization, string callbackBody)
        {
            return VerifyEventSignature(client, callbackAuthorization, callbackBody, out _);
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackAuthorization"></param>
        /// <param name="callbackBody"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this WechatTenpayBusinessClient client, string callbackAuthorization, string callbackBody, out Exception? error)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackAuthorization == null) throw new ArgumentNullException(nameof(callbackAuthorization));
            if (callbackBody == null) throw new ArgumentNullException(nameof(callbackBody));

            bool ret = WechatTenpayBusinessClientSignExtensions.VerifySignature(
                client,
                strAuthorization: callbackAuthorization,
                strContent: callbackBody,
                out error
            );

            if (error != null)
            {
                error = new Exceptions.WechatTenpayBusinessEventVerificationException("Verify signature of event failed. Please see the inner exception for more details.", error);
            }

            return ret;
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp"></param>
        /// <param name="callbackNonce">。</param>
        /// <param name="callbackBody"></param>
        /// <param name="callbackSignature"></param>
        /// <param name="callbackSerialNumber"></param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this WechatTenpayBusinessClient client, string callbackTimestamp, string callbackNonce, string callbackBody, string callbackSignature, string callbackSerialNumber)
        {
            return VerifyEventSignature(
                client,
                callbackTimestamp: callbackTimestamp,
                callbackNonce: callbackNonce,
                callbackBody: callbackBody,
                callbackSignature: callbackSignature,
                callbackSignatureAlgorithm: Constants.SignAlgorithms.SHA245_WITH_RSA,
                callbackSerialNumber: callbackSerialNumber,
                out _
            );
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp"></param>
        /// <param name="callbackNonce">。</param>
        /// <param name="callbackBody"></param>
        /// <param name="callbackSignature"></param>
        /// <param name="callbackSignatureAlgorithm"></param>
        /// <param name="callbackSerialNumber"></param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this WechatTenpayBusinessClient client, string callbackTimestamp, string callbackNonce, string callbackBody, string callbackSignature, string callbackSignatureAlgorithm, string callbackSerialNumber)
        {
            return VerifyEventSignature(
                client,
                callbackTimestamp: callbackTimestamp,
                callbackNonce: callbackNonce,
                callbackBody: callbackBody,
                callbackSignature: callbackSignature,
                callbackSignatureAlgorithm: callbackSignatureAlgorithm,
                callbackSerialNumber: callbackSerialNumber,
                out _
            );
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp"></param>
        /// <param name="callbackNonce">。</param>
        /// <param name="callbackBody"></param>
        /// <param name="callbackSignature"></param>
        /// <param name="callbackSerialNumber"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool VerifyEventSignature(this WechatTenpayBusinessClient client, string callbackTimestamp, string callbackNonce, string callbackBody, string callbackSignature, string callbackSerialNumber, out Exception? error)
        {
            return VerifyEventSignature(
                client,
                callbackTimestamp: callbackTimestamp,
                callbackNonce: callbackNonce,
                callbackBody: callbackBody,
                callbackSignature: callbackSignature,
                callbackSignatureAlgorithm: Constants.SignAlgorithms.SHA245_WITH_RSA,
                callbackSerialNumber: callbackSerialNumber,
                out error
            );
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp"></param>
        /// <param name="callbackNonce">。</param>
        /// <param name="callbackBody"></param>
        /// <param name="callbackSignature"></param>
        /// <param name="callbackSignatureAlgorithm"></param>
        /// <param name="callbackSerialNumber"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool VerifyEventSignature(this WechatTenpayBusinessClient client, string callbackTimestamp, string callbackNonce, string callbackBody, string callbackSignature, string callbackSignatureAlgorithm, string callbackSerialNumber, out Exception? error)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));

            bool ret = WechatTenpayBusinessClientSignExtensions.VerifySignature(
                client,
                strTimestamp: callbackTimestamp,
                strNonce: callbackNonce,
                strContent: callbackBody,
                strSignature: callbackSignature,
                strSignatureAlgorithm: callbackSignatureAlgorithm,
                strSerialNumber: callbackSerialNumber,
                out error
            );

            if (error != null)
            {
                error = new Exceptions.WechatTenpayBusinessEventVerificationException("Verify signature of event failed. Please see the inner exception for more details.", error);
            }

            return ret;
        }
    }
}
