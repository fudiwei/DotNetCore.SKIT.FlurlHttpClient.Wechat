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
    public static class WechatAdsClientExecuteFundsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /fund_transfer/add 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FundTransferAddResponse> ExecuteFundTransferAddAsync(this WechatAdsClient client, Models.FundTransferAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "fund_transfer", "add")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.FundTransferAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /funds/get 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FundsGetResponse> ExecuteFundsGetAsync(this WechatAdsClient client, Models.FundsGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "funds", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.FundsGetResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /fund_statements_detailed/get 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.FundStatementsDetailedGetResponse> ExecuteFundStatementsDetailedGetAsync(this WechatAdsClient client, Models.FundStatementsDetailedGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "fund_statements_detailed", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            if (request.DateRange != null)
                flurlReq.SetQueryParam("date_range", client.JsonSerializer.Serialize(request.DateRange));

            if (!string.IsNullOrEmpty(request.TradeType))
                flurlReq.SetQueryParam("trade_type", request.TradeType);

            if (request.PageSize.HasValue)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            if (request.Page.HasValue)
                flurlReq.SetQueryParam("page", request.Page.Value);

            return await client.SendRequestAsync<Models.FundStatementsDetailedGetResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
