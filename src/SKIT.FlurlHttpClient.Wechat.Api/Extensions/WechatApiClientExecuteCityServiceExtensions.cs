﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCityServiceExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cityservice/sendmsgdata 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/cityservice/cityservice-results-page.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CityServiceSendMessageDataResponse> ExecuteCityServiceSendMessageDataAsync(this WechatApiClient client, Models.CityServiceSendMessageDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cityservice", "sendmsgdata")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CityServiceSendMessageDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cityservice/getservicepath 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/cityservice/InterconnectionCapabilities/API/API.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CityServiceGetServicePathResponse> ExecuteCityServiceGetServicePathAsync(this WechatApiClient client, Models.CityServiceGetServicePathRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cityservice", "getservicepath")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CityServiceGetServicePathResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
