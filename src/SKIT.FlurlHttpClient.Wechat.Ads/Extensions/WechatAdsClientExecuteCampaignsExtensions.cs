using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Ads
{
    public static class WechatAdsClientExecuteCampaignsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /campaigns/add 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CampaignsAddResponse> ExecuteCampaignsAddAsync(this WechatAdsClient client, Models.CampaignsAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "campaigns", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CampaignsAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /campaigns/update 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CampaignsUpdateResponse> ExecuteCampaignsUpdateAsync(this WechatAdsClient client, Models.CampaignsUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "campaigns", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CampaignsUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /campaigns/get 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CampaignsGetResponse> ExecuteCampaignsGetAsync(this WechatAdsClient client, Models.CampaignsGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "campaigns", "get")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.CampaignId != null)
                flurlReq.SetQueryParam("campaign_id", request.CampaignId.Value);

            if (request.Filters != null)
                flurlReq.SetQueryParam("filtering", client.JsonSerializer.Serialize(request.Filters));

            if (request.PageSize != null)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            if (request.Page != null)
                flurlReq.SetQueryParam("page", request.Page.Value);

            return await client.SendRequestWithJsonAsync<Models.CampaignsGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
