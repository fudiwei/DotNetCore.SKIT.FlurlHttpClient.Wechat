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
    public static class WechatApiClientExecuteDataCubeExtensions
    {
        #region Article
        /// <summary>
        /// <para>异步调用 [POST] /datacube/getusersummary 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/User_Analysis_Data_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUserSummaryResponse> ExecuteDataCubeGetUserSummaryAsync(this WechatApiClient client, Models.DataCubeGetUserSummaryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getusersummary")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetUserSummaryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getusercumulate 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/User_Analysis_Data_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUserCumulateResponse> ExecuteDataCubeGetUserCumulateAsync(this WechatApiClient client, Models.DataCubeGetUserCumulateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getusercumulate")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetUserCumulateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getarticlesummary 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Graphic_Analysis_Data_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetArticleSummaryResponse> ExecuteDataCubeGetArticleSummaryAsync(this WechatApiClient client, Models.DataCubeGetArticleSummaryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getarticlesummary")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetArticleSummaryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getarticletotal 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Graphic_Analysis_Data_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetArticleTotalResponse> ExecuteDataCubeGetArticleTotalAsync(this WechatApiClient client, Models.DataCubeGetArticleTotalRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getarticletotal")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetArticleTotalResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region User
        /// <summary>
        /// <para>异步调用 [POST] /datacube/getuserread 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Graphic_Analysis_Data_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUserReadResponse> ExecuteDataCubeGetUserReadAsync(this WechatApiClient client, Models.DataCubeGetUserReadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getuserread")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetUserReadResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getuserreadhour 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Graphic_Analysis_Data_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUserReadHourResponse> ExecuteDataCubeGetUserReadHourAsync(this WechatApiClient client, Models.DataCubeGetUserReadHourRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getuserreadhour")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetUserReadHourResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getusershare 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Graphic_Analysis_Data_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUserShareResponse> ExecuteDataCubeGetUserShareAsync(this WechatApiClient client, Models.DataCubeGetUserShareRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getusershare")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetUserShareResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getusersharehour 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Graphic_Analysis_Data_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUserShareHourResponse> ExecuteDataCubeGetUserShareHourAsync(this WechatApiClient client, Models.DataCubeGetUserShareHourRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getusersharehour")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetUserShareHourResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region UpstreamMessage
        /// <summary>
        /// <para>异步调用 [POST] /datacube/getupstreammsg 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Message_analysis_data_interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUpstreamMessageResponse> ExecuteDataCubeGetUpstreamMessageAsync(this WechatApiClient client, Models.DataCubeGetUpstreamMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getupstreammsg")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetUpstreamMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getupstreammsghour 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Message_analysis_data_interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUpstreamMessageHourResponse> ExecuteDataCubeGetUpstreamMessageHourAsync(this WechatApiClient client, Models.DataCubeGetUpstreamMessageHourRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getupstreammsghour")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetUpstreamMessageHourResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getupstreammsgweek 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Message_analysis_data_interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUpstreamMessageWeekResponse> ExecuteDataCubeGetUpstreamMessageWeekAsync(this WechatApiClient client, Models.DataCubeGetUpstreamMessageWeekRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getupstreammsgweek")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetUpstreamMessageWeekResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getupstreammsgmonth 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Message_analysis_data_interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUpstreamMessageMonthResponse> ExecuteDataCubeGetUpstreamMessageMonthAsync(this WechatApiClient client, Models.DataCubeGetUpstreamMessageMonthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getupstreammsgmonth")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetUpstreamMessageMonthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getupstreammsgdist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Message_analysis_data_interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUpstreamMessageDistributionResponse> ExecuteDataCubeGetUpstreamMessageDistributionAsync(this WechatApiClient client, Models.DataCubeGetUpstreamMessageDistributionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getupstreammsgdist")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetUpstreamMessageDistributionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getupstreammsgdistweek 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Message_analysis_data_interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUpstreamMessageDistributionWeekResponse> ExecuteDataCubeGetUpstreamMessageDistributionWeekAsync(this WechatApiClient client, Models.DataCubeGetUpstreamMessageDistributionWeekRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getupstreammsgdistweek")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetUpstreamMessageDistributionWeekResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getupstreammsgdistmonth 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Message_analysis_data_interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUpstreamMessageDistributionMonthResponse> ExecuteDataCubeGetUpstreamMessageDistributionMonthAsync(this WechatApiClient client, Models.DataCubeGetUpstreamMessageDistributionMonthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getupstreammsgdistmonth")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetUpstreamMessageDistributionMonthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Interface
        /// <summary>
        /// <para>异步调用 [POST] /datacube/getinterfacesummary 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Analytics_API.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetInterfaceSummaryResponse> ExecuteDataCubeGetInterfaceSummaryAsync(this WechatApiClient client, Models.DataCubeGetInterfaceSummaryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getinterfacesummary")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetInterfaceSummaryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getinterfacesummaryhour 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Analytics/Analytics_API.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetInterfaceSummaryHourResponse> ExecuteDataCubeGetInterfaceSummaryHourAsync(this WechatApiClient client, Models.DataCubeGetInterfaceSummaryHourRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getinterfacesummaryhour")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetInterfaceSummaryHourResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Card
        /// <summary>
        /// <para>异步调用 [POST] /datacube/getcardbizuininfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Managing_Coupons_Vouchers_and_Cards.html#10 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetCardBusinessInfoResponse> ExecuteDataCubeGetCardBusinessInfoAsync(this WechatApiClient client, Models.DataCubeGetCardBusinessInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getcardbizuininfo")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetCardBusinessInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getcardcardinfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Managing_Coupons_Vouchers_and_Cards.html#11 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetCardCardInfoResponse> ExecuteDataCubeGetCardCardInfoAsync(this WechatApiClient client, Models.DataCubeGetCardCardInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getcardcardinfo")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetCardCardInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getcardmembercardinfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Managing_Coupons_Vouchers_and_Cards.html#12 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetCardMemberCardInfoResponse> ExecuteDataCubeGetCardMemberCardInfoAsync(this WechatApiClient client, Models.DataCubeGetCardMemberCardInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getcardmembercardinfo")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetCardMemberCardInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getcardmembercarddetail 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Cards_and_Offer/Managing_Coupons_Vouchers_and_Cards.html#13 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetCardMemberCardDetailResponse> ExecuteDataCubeGetCardMemberCardDetailAsync(this WechatApiClient client, Models.DataCubeGetCardMemberCardDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getcardmembercarddetail")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetCardMemberCardDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region WeAnalysis
        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappiddailyretaininfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/data-analysis/visit-retain/analysis.getDailyRetain.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdDailyRetainInfoResponse> ExecuteDataCubeGetWeAnalysisAppIdDailyRetainInfoAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdDailyRetainInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getweanalysisappiddailyretaininfo")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetWeAnalysisAppIdDailyRetainInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappidmonthlyretaininfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/data-analysis/visit-retain/analysis.getMonthlyRetain.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdMonthlyRetainInfoResponse> ExecuteDataCubeGetWeAnalysisAppIdMonthlyRetainInfoAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdMonthlyRetainInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getweanalysisappidmonthlyretaininfo")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetWeAnalysisAppIdMonthlyRetainInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappidweeklyretaininfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/data-analysis/visit-retain/analysis.getWeeklyRetain.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdWeeklyRetainInfoResponse> ExecuteDataCubeGetWeAnalysisAppIdWeeklyRetainInfoAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdWeeklyRetainInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getweanalysisappidweeklyretaininfo")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetWeAnalysisAppIdWeeklyRetainInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappiddailysummarytrend 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/data-analysis/analysis.getDailySummary.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdDailySummaryTrendResponse> ExecuteDataCubeGetWeAnalysisAppIdDailySummaryTrendAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdDailySummaryTrendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getweanalysisappiddailysummarytrend")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetWeAnalysisAppIdDailySummaryTrendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappiddailyvisittrend 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/data-analysis/visit-trend/analysis.getDailyVisitTrend.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdDailyVisitTrendResponse> ExecuteDataCubeGetWeAnalysisAppIdDailyVisitTrendAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdDailyVisitTrendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getweanalysisappiddailyvisittrend")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetWeAnalysisAppIdDailyVisitTrendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappidmonthlyvisittrend 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/data-analysis/visit-trend/analysis.getMonthlyVisitTrend.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdMonthlyVisitTrendResponse> ExecuteDataCubeGetWeAnalysisAppIdMonthlyVisitTrendAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdMonthlyVisitTrendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getweanalysisappidmonthlyvisittrend")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetWeAnalysisAppIdMonthlyVisitTrendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappidweeklyvisittrend 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/data-analysis/visit-trend/analysis.getWeeklyVisitTrend.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdWeeklyVisitTrendResponse> ExecuteDataCubeGetWeAnalysisAppIdWeeklyVisitTrendAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdWeeklyVisitTrendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getweanalysisappidweeklyvisittrend")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetWeAnalysisAppIdWeeklyVisitTrendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappiduserportrait 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/data-analysis/analysis.getUserPortrait.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdUserPortraitResponse> ExecuteDataCubeGetWeAnalysisAppIdUserPortraitAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdUserPortraitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getweanalysisappiduserportrait")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetWeAnalysisAppIdUserPortraitResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappidvisitdistribution 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/data-analysis/analysis.getVisitDistribution.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdVisitDistributionResponse> ExecuteDataCubeGetWeAnalysisAppIdVisitDistributionAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdVisitDistributionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getweanalysisappidvisitdistribution")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetWeAnalysisAppIdVisitDistributionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappidvisitpage 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/data-analysis/analysis.getVisitPage.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdVisitPageResponse> ExecuteDataCubeGetWeAnalysisAppIdVisitPageAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdVisitPageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getweanalysisappidvisitpage")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetWeAnalysisAppIdVisitPageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region GameAnalysis
        /// <summary>
        /// <para>异步调用 [POST] /datacube/getgameanalysisdata 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/data-analysis/analysis.getGameAnalysisData.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetGameAnalysisDataResponse> ExecuteDataCubeGetGameAnalysisDataAsync(this WechatApiClient client, Models.DataCubeGetGameAnalysisDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "datacube", "getgameanalysisdata")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DataCubeGetGameAnalysisDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
