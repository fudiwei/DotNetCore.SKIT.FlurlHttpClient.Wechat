namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    public static class WechatTenpayGlobalClientResponseDecryptionExtensions
    {
        /// <summary>
        /// <para>解密响应中返回的敏感数据。该方法会改变传入的响应模型对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static Models.QueryCertificatesResponse DecryptResponseSensitiveProperty(this WechatTenpayGlobalClient client, Models.QueryCertificatesResponse response)
        {
            return WechatTenpayClientResponseDecryptionExtensions.DecryptResponseSensitiveProperty(client, response);
        }

        /// <summary>
        /// <para>解密响应中返回的敏感数据。该方法会改变传入的响应模型对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static TResponse DecryptResponseSensitiveProperty<TResponse>(this WechatTenpayGlobalClient client, TResponse response)
            where TResponse : WechatTenpayGlobalResponse
        {
            return WechatTenpayClientResponseDecryptionExtensions.DecryptResponseSensitiveProperty(client, response);
        }
    }
}
