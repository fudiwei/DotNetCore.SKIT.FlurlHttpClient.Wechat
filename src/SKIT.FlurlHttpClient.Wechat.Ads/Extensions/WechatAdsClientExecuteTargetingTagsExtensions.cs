using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Ads
{
    public static class WechatAdsClientExecuteTargetingTagsExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /targeting_tags/get 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TargetingTagsGetResponse> ExecuteTargetingTagsGetAsync(this WechatAdsClient client, Models.TargetingTagsGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "targeting_tags", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.TagType);

            return await client.SendFlurlRequestAsJsonAsync<Models.TargetingTagsGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
