using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinCheckinExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/checkin/getcorpcheckinoption 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93384 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCheckinGetCorpCheckinOptionResponse> ExecuteCgibinCheckinGetCorpCheckinOptionAsync(this WechatWorkClient client, Models.CgibinCheckinGetCorpCheckinOptionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "checkin", "getcorpcheckinoption")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCheckinGetCorpCheckinOptionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/checkin/getcheckinoption 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90263 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94204 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCheckinGetCheckinOptionResponse> ExecuteCgibinCheckinGetCheckinOptionAsync(this WechatWorkClient client, Models.CgibinCheckinGetCheckinOptionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "checkin", "getcheckinoption")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCheckinGetCheckinOptionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/checkin/getcheckindata 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90262 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94205 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCheckinGetCheckinDataResponse> ExecuteCgibinCheckinGetCheckinDataAsync(this WechatWorkClient client, Models.CgibinCheckinGetCheckinDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "checkin", "getcheckindata")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCheckinGetCheckinDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/checkin/getcheckin_daydata 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93374 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94206 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCheckinGetCheckinDayDataResponse> ExecuteCgibinCheckinGetCheckinDayDataAsync(this WechatWorkClient client, Models.CgibinCheckinGetCheckinDayDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "checkin", "getcheckin_daydata")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCheckinGetCheckinDayDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/checkin/getcheckin_monthdata 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93387 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94207 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCheckinGetCheckinMonthDataResponse> ExecuteCgibinCheckinGetCheckinMonthDataAsync(this WechatWorkClient client, Models.CgibinCheckinGetCheckinMonthDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "checkin", "getcheckin_monthdata")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCheckinGetCheckinMonthDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/checkin/getcheckinschedulist 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93380 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94208 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCheckinGetCheckinScheduleListResponse> ExecuteCgibinCheckinGetCheckinScheduleListAsync(this WechatWorkClient client, Models.CgibinCheckinGetCheckinScheduleListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "checkin", "getcheckinschedulist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCheckinGetCheckinScheduleListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/checkin/setcheckinschedulist 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93385 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94209 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCheckinSetCheckinScheduleListResponse> ExecuteCgibinCheckinSetCheckinScheduleListAsync(this WechatWorkClient client, Models.CgibinCheckinSetCheckinScheduleListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "checkin", "setcheckinschedulist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCheckinSetCheckinScheduleListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/checkin/addcheckinuserface 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93378 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCheckinAddCheckinUserFaceResponse> ExecuteCgibinCheckinAddCheckinUserFaceAsync(this WechatWorkClient client, Models.CgibinCheckinAddCheckinUserFaceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "checkin", "addcheckinuserface")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCheckinAddCheckinUserFaceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/checkin/punch_correction 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95803 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCheckinPunchCorrectionResponse> ExecuteCgibinCheckinPunchCorrectionAsync(this WechatWorkClient client, Models.CgibinCheckinPunchCorrectionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "checkin", "punch_correction")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCheckinPunchCorrectionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
