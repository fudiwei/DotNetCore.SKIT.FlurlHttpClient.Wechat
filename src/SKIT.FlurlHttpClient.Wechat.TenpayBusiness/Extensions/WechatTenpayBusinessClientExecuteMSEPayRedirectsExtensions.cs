using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientExecuteMSEPayRedirectsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/redirects 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMSEPayRedirectLinkResponse> ExecuteCreateMSEPayRedirectLinkAsync(this WechatTenpayBusinessClient client, Models.CreateMSEPayRedirectLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mse-pay", "redirects");

            return await client.SendRequestWithJsonAsync<Models.CreateMSEPayRedirectLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
