using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Ads
{
    public static class WechatAdsClientExecuteAdGroupsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /adgroups/add 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdGroupsAddResponse> ExecuteAdGroupsAddAsync(this WechatAdsClient client, Models.AdGroupsAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "adgroups", "add")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdGroupsAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /adgroups/update 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdGroupsUpdateResponse> ExecuteAdGroupsUpdateAsync(this WechatAdsClient client, Models.AdGroupsUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "adgroups", "update")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdGroupsUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /adgroups/get 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdGroupsGetResponse> ExecuteAdGroupsGetAsync(this WechatAdsClient client, Models.AdGroupsGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "adgroups", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            if (request.AdGroupId.HasValue)
                flurlReq.SetQueryParam("adgroup_id", request.AdGroupId.Value);

            if (request.Filters != null && request.Filters.Any())
                flurlReq.SetQueryParam("filtering", client.JsonSerializer.Serialize(request.Filters));

            if (request.PageSize.HasValue)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            if (request.Page.HasValue)
                flurlReq.SetQueryParam("page", request.Page.Value);

            return await client.SendRequestAsync<Models.AdGroupsGetResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /adgroups/delete 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdGroupsDeleteResponse> ExecuteAdGroupsDeleteAsync(this WechatAdsClient client, Models.AdGroupsDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "adgroups", "delete")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdGroupsDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
