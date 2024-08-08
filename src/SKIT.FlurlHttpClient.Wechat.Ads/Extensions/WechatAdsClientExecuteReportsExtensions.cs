using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Ads
{
    public static class WechatAdsClientExecuteReportsExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /daily_reports/get 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DailyReportsGetResponse> ExecuteDailyReportsGetAsync(this WechatAdsClient client, Models.DailyReportsGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "daily_reports", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date_range", request.DateRange is null ? null : client.JsonSerializer.Serialize(request.DateRange))
                .SetQueryParam("report_type", request.ReportType)
                .SetQueryParam("level", request.ReportLevel)
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page", request.Page);

            return await client.SendFlurlRequestAsJsonAsync<Models.DailyReportsGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /realtime_cost/get 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RealtimeCostGetResponse> ExecuteRealtimeCostGetAsync(this WechatAdsClient client, Models.RealtimeCostGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "realtime_cost", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date", request.DateString)
                .SetQueryParam("level", request.Level)
                .SetQueryParam("filtering", request.Filters is null ? null : client.JsonSerializer.Serialize(request.Filters));

            return await client.SendFlurlRequestAsJsonAsync<Models.RealtimeCostGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
