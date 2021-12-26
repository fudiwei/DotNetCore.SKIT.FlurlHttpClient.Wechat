using System;
using System.Threading;
using System.Threading.Tasks;
using SKIT.FlurlHttpClient.Wechat.Api.UnitTests;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    internal static class SendRequestExtensions
    {

        public static async Task<TResponse> Send<TResponse>(this ISendRequest<TResponse> request, CancellationToken cancellationToken = default)
        where TResponse : WechatApiResponse
        {
            // 第三方使用本包的时候，基本需要提供两个参数：AccessToken，WechatApiClient
            // 那么也就可以在这个扩展方法提供，统一封装调用，甚至处理错误
            request.AccessToken ??= TestConfigs.WechatAccessToken;
            TResponse response = await request.Send(TestClients.Instance, cancellationToken);
            if (!response.IsSuccessful())
            {
                // log 记录错误
            }
            return response;
        }
    }

}
