using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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
                .CreateRequest(request, HttpMethod.Get, "daily_reports", "get")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.DateRange != null)
                flurlReq.SetQueryParam("date_range", client.JsonSerializer.Serialize(request.DateRange));

            if (!string.IsNullOrEmpty(request.ReportType))
                flurlReq.SetQueryParam("report_type", request.ReportType);

            if (!string.IsNullOrEmpty(request.ReportLevel))
                flurlReq.SetQueryParam("level", request.ReportLevel);

            if (request.PageSize.HasValue)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            if (request.Page.HasValue)
                flurlReq.SetQueryParam("page", request.Page.Value);

            return await client.SendRequestWithJsonAsync<Models.DailyReportsGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
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
                .CreateRequest(request, HttpMethod.Get, "realtime_cost", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("date", request.DateString)
                .SetQueryParam("level", request.Level);

            if (request.Filters != null && request.Filters.Any())
                flurlReq.SetQueryParam("filtering", client.JsonSerializer.Serialize(request.Filters));

            return await client.SendRequestWithJsonAsync<Models.RealtimeCostGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
