using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinCustomServiceExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/customservice/getkflist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Service_Center_messages.html#5 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Customer_Service_Management.html#0 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCustomServiceGetKfListResponse> ExecuteCgibinCustomServiceGetKfListAsync(this WechatApiClient client, Models.CgibinCustomServiceGetKfListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "customservice", "getkflist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCustomServiceGetKfListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/customservice/getonlinekflist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Customer_Service_Management.html#0 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCustomServiceGetOnlineKfListResponse> ExecuteCgibinCustomServiceGetOnlineKfListAsync(this WechatApiClient client, Models.CgibinCustomServiceGetOnlineKfListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "customservice", "getonlinekflist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCustomServiceGetOnlineKfListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
