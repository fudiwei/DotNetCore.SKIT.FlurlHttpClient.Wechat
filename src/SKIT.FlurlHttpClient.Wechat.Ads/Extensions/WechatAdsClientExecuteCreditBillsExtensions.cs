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
    public static class WechatAdsClientExecuteCreditBillsExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /credit_bills/get 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreditBillsGetResponse> ExecuteCreditBillsGetAsync(this WechatAdsClient client, Models.CreditBillsGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "credit_bills", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("bill_year", request.BillYear)
                .SetQueryParam("bill_month", request.BillMonth);

            if (request.PageSize.HasValue)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            if (request.Page.HasValue)
                flurlReq.SetQueryParam("page", request.Page.Value);

            return await client.SendRequestWithJsonAsync<Models.CreditBillsGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
