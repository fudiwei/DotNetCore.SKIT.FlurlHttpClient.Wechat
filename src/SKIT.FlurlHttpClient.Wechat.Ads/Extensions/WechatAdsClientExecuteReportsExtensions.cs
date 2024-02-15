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
                .SetQueryParam("access_token", request.AccessToken);

            if (request.DateRange is not null)
                flurlReq.SetQueryParam("date_range", client.JsonSerializer.Serialize(request.DateRange));

            if (request.ReportType is not null)
                flurlReq.SetQueryParam("report_type", request.ReportType);

            if (request.ReportLevel is not null)
                flurlReq.SetQueryParam("level", request.ReportLevel);

            if (request.PageSize is not null)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            if (request.Page is not null)
                flurlReq.SetQueryParam("page", request.Page.Value);

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
                .SetQueryParam("level", request.Level);

            if (request.Filters is not null && request.Filters.Any())
                flurlReq.SetQueryParam("filtering", client.JsonSerializer.Serialize(request.Filters));

            return await client.SendFlurlRequestAsJsonAsync<Models.RealtimeCostGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
