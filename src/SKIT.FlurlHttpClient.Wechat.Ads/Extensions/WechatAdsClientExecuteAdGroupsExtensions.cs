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
                .CreateRequest(request, HttpMethod.Post, "adgroups", "add")
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
                .CreateRequest(request, HttpMethod.Post, "adgroups", "update")
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
                .CreateRequest(request, HttpMethod.Get, "adgroups", "get")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.AdGroupId.HasValue)
                flurlReq.SetQueryParam("adgroup_id", request.AdGroupId.Value);

            if (request.Filters != null && request.Filters.Any())
                flurlReq.SetQueryParam("filtering", client.FlurlJsonSerializer.Serialize(request.Filters));

            if (request.PageSize.HasValue)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            if (request.Page.HasValue)
                flurlReq.SetQueryParam("page", request.Page.Value);

            return await client.SendRequestWithJsonAsync<Models.AdGroupsGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
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
                .CreateRequest(request, HttpMethod.Post, "adgroups", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdGroupsDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
