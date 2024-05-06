using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    public static class WechatTenpayGlobalClientRequestEncryptionExtensions
    {
        /// <summary>
        /// <para>加密请求中传入的敏感数据。该方法会改变传入的请求模型对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static TRequest EncryptRequestSensitiveProperty<TRequest>(this WechatTenpayGlobalClient client, TRequest request)
            where TRequest : WechatTenpayGlobalRequest
        {
            return WechatTenpayClientRequestEncryptionExtensions.EncryptRequestSensitiveProperty<TRequest>(client, request);
        }

        /// <summary>
        /// <para>异步加密请求中传入的敏感数据。该方法会改变传入的请求模型对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task<TRequest> EncryptRequestSensitivePropertyAsync<TRequest>(this WechatTenpayGlobalClient client, TRequest request, CancellationToken cancellationToken = default)
            where TRequest : WechatTenpayGlobalRequest
        {
            return WechatTenpayClientRequestEncryptionExtensions.EncryptRequestSensitivePropertyAsync<TRequest>(client, request, cancellationToken);
        }
    }
}
