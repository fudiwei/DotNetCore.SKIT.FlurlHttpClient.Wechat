using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Ads
{
    public static class WechatAdsClientExecuteSpEntrustmentExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /sp_entrustment/add 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SpEntrustmentAddResponse> ExecuteSpEntrustmentAddAsync(this WechatAdsClient client, Models.SpEntrustmentAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "sp_entrustment", "add")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.SpEntrustmentAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /sp_entrustment/get 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SpEntrustmentGetResponse> ExecuteSpEntrustmentGetAsync(this WechatAdsClient client, Models.SpEntrustmentGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "sp_entrustment", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.SpEntrustmentGetResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
