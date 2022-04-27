using System;
using System.Linq;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientEventVerificationExtensions
    {
        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
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

            bool ret = WechatTenpayBusinessClientSignExtensions.VerifySignature(client, callbackAuthorization, callbackBody, out error);
            if (error != null)
                error = new Exceptions.WechatTenpayBusinessEventVerificationException("Verify signature of event failed. Please see the `InnerException` for more details.", error);
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
            return VerifyEventSignature(client, callbackTimestamp, callbackNonce, callbackBody, callbackSignature, callbackSerialNumber, Constants.SignAlgorithms.SHA245_WITH_RSA, out _);
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
        /// <param name="callbackSignAlgorithm"></param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this WechatTenpayBusinessClient client, string callbackTimestamp, string callbackNonce, string callbackBody, string callbackSignature, string callbackSerialNumber, string callbackSignAlgorithm)
        {
            return VerifyEventSignature(client, callbackTimestamp, callbackNonce, callbackBody, callbackSignature, callbackSerialNumber, callbackSignAlgorithm, out _);
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
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
            return VerifyEventSignature(client, callbackTimestamp, callbackNonce, callbackBody, callbackSignature, callbackSerialNumber, Constants.SignAlgorithms.SHA245_WITH_RSA, out error);
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp"></param>
        /// <param name="callbackNonce">。</param>
        /// <param name="callbackBody"></param>
        /// <param name="callbackSignature"></param>
        /// <param name="callbackSerialNumber"></param>
        /// <param name="callbackSignAlgorithm"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool VerifyEventSignature(this WechatTenpayBusinessClient client, string callbackTimestamp, string callbackNonce, string callbackBody, string callbackSignature, string callbackSerialNumber, string callbackSignAlgorithm, out Exception? error)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));

            bool ret = WechatTenpayBusinessClientSignExtensions.VerifySignature(client, callbackTimestamp, callbackNonce, callbackBody, callbackSignature, callbackSerialNumber, callbackSignAlgorithm, out error);
            if (error != null)
                error = new Exceptions.WechatTenpayBusinessEventVerificationException("Verify signature of event failed. Please see the `InnerException` for more details.", error);
            return ret;
        }
    }
}
