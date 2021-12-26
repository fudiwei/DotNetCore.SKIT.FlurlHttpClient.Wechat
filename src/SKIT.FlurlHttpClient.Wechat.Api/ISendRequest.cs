using System;
using System.Threading;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public interface ISendRequest<TResponse> where TResponse : WechatApiResponse
    {
        string? AccessToken { get; set; }
        Task<TResponse> Send(WechatApiClient client, CancellationToken cancellationToken);
    }

}
