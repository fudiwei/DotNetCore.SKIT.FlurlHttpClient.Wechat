using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinHealthExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/health/get_health_report_stat 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93676 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinHealthGetHealthReportStatisticsResponse> ExecuteCgibinHealthGetHealthReportStatisticsAsync(this WechatWorkClient client, Models.CgibinHealthGetHealthReportStatisticsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "health", "get_health_report_stat")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinHealthGetHealthReportStatisticsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/health/get_report_jobids 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93677 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinHealthGetReportJobIdsResponse> ExecuteCgibinHealthGetReportJobIdsAsync(this WechatWorkClient client, Models.CgibinHealthGetReportJobIdsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "health", "get_report_jobids")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinHealthGetReportJobIdsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/health/get_report_job_info 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93678 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinHealthGetReportJobInfoResponse> ExecuteCgibinHealthGetReportJobInfoAsync(this WechatWorkClient client, Models.CgibinHealthGetReportJobInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "health", "get_report_job_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinHealthGetReportJobInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/health/get_report_answer 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93679 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinHealthGetReportAnswerResponse> ExecuteCgibinHealthGetReportAnswerAsync(this WechatWorkClient client, Models.CgibinHealthGetReportAnswerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "health", "get_report_answer")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinHealthGetReportAnswerResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
