namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    using SKIT.FlurlHttpClient.Primitives;

    using __zroot__ = SKIT.FlurlHttpClient.Wechat.TenpayV3;

    public static class WechatTenpayGlobalClientEventVerificationExtensions
    {
        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012357149 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">回调通知中的 "Wechatpay-Timestamp" 请求标头。</param>
        /// <param name="webhookNonce">回调通知中的 "Wechatpay-Nonce" 请求标头。</param>
        /// <param name="webhookBody">回调通知中的请求正文。</param>
        /// <param name="webhookSignature">回调通知中的 "Wechatpay-Signature" 请求标头。</param>
        /// <param name="webhookSerialNumber">回调通知中的 "Wechatpay-Serial" 请求标头。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignature(this WechatTenpayGlobalClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSerialNumber)
        {
            return __zroot__.WechatTenpayClientEventVerificationExtensions.VerifyEventSignature(client.ProxyClient, webhookTimestamp, webhookNonce, webhookBody, webhookSignature, webhookSerialNumber);
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012357149 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">回调通知中的 "Wechatpay-Timestamp" 请求标头。</param>
        /// <param name="webhookNonce">回调通知中的 "Wechatpay-Nonce" 请求标头。</param>
        /// <param name="webhookBody">回调通知中的请求正文。</param>
        /// <param name="webhookSignature">回调通知中的 "Wechatpay-Signature" 请求标头。</param>
        /// <param name="webhookSignatureType">回调通知中的 "Wechatpay-Signature-Type" 请求标头。</param>
        /// <param name="webhookSerialNumber">回调通知中的 "Wechatpay-Serial" 请求标头。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignature(this WechatTenpayGlobalClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSignatureType, string webhookSerialNumber)
        {
            return __zroot__.WechatTenpayClientEventVerificationExtensions.VerifyEventSignature(client.ProxyClient, webhookTimestamp, webhookNonce, webhookBody, webhookSignature, webhookSignatureType, webhookSerialNumber);
        }

        /// <summary>
        /// <para>异步验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012357149 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">回调通知中的 "Wechatpay-Timestamp" 请求标头。</param>
        /// <param name="webhookNonce">回调通知中的 "Wechatpay-Nonce" 请求标头。</param>
        /// <param name="webhookBody">回调通知中的请求正文。</param>
        /// <param name="webhookSignature">回调通知中的 "Wechatpay-Signature" 请求标头。</param>
        /// <param name="webhookSerialNumber">回调通知中的 "Wechatpay-Serial" 请求标头。</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task<ErroredResult> VerifyEventSignatureAsync(this WechatTenpayGlobalClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSerialNumber, CancellationToken cancellationToken = default)
        {
            return __zroot__.WechatTenpayClientEventVerificationExtensions.VerifyEventSignatureAsync(client.ProxyClient, webhookTimestamp, webhookNonce, webhookBody, webhookSignature, webhookSerialNumber, cancellationToken);
        }

        /// <summary>
        /// <para>异步验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012357149 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">回调通知中的 "Wechatpay-Timestamp" 请求标头。</param>
        /// <param name="webhookNonce">回调通知中的 "Wechatpay-Nonce" 请求标头。</param>
        /// <param name="webhookBody">回调通知中的请求正文。</param>
        /// <param name="webhookSignature">回调通知中的 "Wechatpay-Signature" 请求标头。</param>
        /// <param name="webhookSignatureType">回调通知中的 "Wechatpay-Signature-Type" 请求标头。</param>
        /// <param name="webhookSerialNumber">回调通知中的 "Wechatpay-Serial" 请求标头。</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task<ErroredResult> VerifyEventSignatureAsync(this WechatTenpayGlobalClient client, string webhookTimestamp, string webhookNonce, string webhookBody, string webhookSignature, string webhookSignatureType, string webhookSerialNumber, CancellationToken cancellationToken = default)
        {
            return __zroot__.WechatTenpayClientEventVerificationExtensions.VerifyEventSignatureAsync(client.ProxyClient, webhookTimestamp, webhookNonce, webhookBody, webhookSignature, webhookSignatureType, webhookSerialNumber, cancellationToken);
        }
    }
}
