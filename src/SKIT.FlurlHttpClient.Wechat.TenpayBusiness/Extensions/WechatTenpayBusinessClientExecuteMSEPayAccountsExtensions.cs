using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientExecuteMSEPayAccountsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/accounts/mse-pay/{platform_id}/bill 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMSEPayAccountBillResponse> ExecuteGetMSEPayAccountBillAsync(this WechatTenpayBusinessClient client, Models.GetMSEPayAccountBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mse-pay", "accounts", "mse-pay", client.Credentials.PlatformId, "bill");

            return await client.SendRequestWithJsonAsync<Models.GetMSEPayAccountBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /{download_url} 接口。</para>
        /// <para><i>（请注意此接口不受构造 <see cref="WechatTenpayBusinessClient" /> 时指定的 <see cref="WechatTenpayBusinessClientOptions.Endpoint"/> 参数控制。）</i></para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DownloadMSEPayAccountBillResponse> ExecuteDownloadMSEPayAccountBillAsync(this WechatTenpayBusinessClient client, Models.DownloadMSEPayAccountBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, request.DownloadUrl)
                .WithUrl(request.DownloadUrl);

            return await client.SendRequestWithJsonAsync<Models.DownloadMSEPayAccountBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
