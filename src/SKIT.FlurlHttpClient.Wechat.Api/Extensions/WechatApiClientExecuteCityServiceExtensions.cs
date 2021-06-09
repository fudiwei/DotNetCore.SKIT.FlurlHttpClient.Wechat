using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
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
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/framework/cityservice/cityservice-results-page.html </para>
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
                .CreateRequest(HttpMethod.Post, "cityservice", "sendmsgdata")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CityServiceSendMessageDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
