﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Ads
{
    public static class WechatAdsClientExecuteAdCreativesExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /adcreatives/add 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdCreativesAddResponse> ExecuteAdCreativesAddAsync(this WechatAdsClient client, Models.AdCreativesAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "adcreatives", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdCreativesAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /adcreatives/update 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdCreativesUpdateResponse> ExecuteAdCreativesUpdateAsync(this WechatAdsClient client, Models.AdCreativesUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "adcreatives", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AdCreativesUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /adcreatives/get 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AdCreativesGetResponse> ExecuteAdCreativesGetAsync(this WechatAdsClient client, Models.AdCreativesGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "adcreatives", "get")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.AdCreativeId != null)
                flurlReq.SetQueryParam("adcreative_id", request.AdCreativeId.Value);

            if (request.Filters != null)
                flurlReq.SetQueryParam("filtering", client.JsonSerializer.Serialize(request.Filters));

            if (request.PageSize != null)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            if (request.Page != null)
                flurlReq.SetQueryParam("page", request.Page.Value);

            return await client.SendRequestWithJsonAsync<Models.AdCreativesGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
