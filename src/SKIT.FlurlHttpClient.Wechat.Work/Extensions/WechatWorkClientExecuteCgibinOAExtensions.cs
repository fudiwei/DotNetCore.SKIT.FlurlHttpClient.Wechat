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
    public static class WechatWorkClientExecuteCgibinOAExtensions
    {
        #region Approval
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/approval/copytemplate 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92630 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAApprovalCopyTemplateResponse> ExecuteCgibinOAApprovalCopyTemplateAsync(this WechatWorkClient client, Models.CgibinOAApprovalCopyTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "approval", "copytemplate")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAApprovalCopyTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/gettemplatedetail 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91982 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92631 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAGetTemplateDetailResponse> ExecuteCgibinOAGetTemplateDetailAsync(this WechatWorkClient client, Models.CgibinOAGetTemplateDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "gettemplatedetail")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAGetTemplateDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/applyevent 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91853 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92632 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAApplyEventResponse> ExecuteCgibinOAApplyEventAsync(this WechatWorkClient client, Models.CgibinOAApplyEventRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "applyevent")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAApplyEventResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/getapprovalinfo 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91816 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94603 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAGetApprovalInfoResponse> ExecuteCgibinOAGetApprovalInfoAsync(this WechatWorkClient client, Models.CgibinOAGetApprovalInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "getapprovalinfo")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAGetApprovalInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/getapprovaldetail 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91983 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92634 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAGetApprovalDetailResponse> ExecuteCgibinOAGetApprovalDetailAsync(this WechatWorkClient client, Models.CgibinOAGetApprovalDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "getapprovaldetail")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAGetApprovalDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Vacation
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/oa/vacation/getcorpconf 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93375 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94211 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAVacationGetCorpConfigResponse> ExecuteCgibinOAVacationGetCorpConfigAsync(this WechatWorkClient client, Models.CgibinOAVacationGetCorpConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "oa", "vacation", "getcorpconf")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.CgibinOAVacationGetCorpConfigResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/vacation/getuservacationquota 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93376 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94212 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAVacationGetUserVacationQuotaResponse> ExecuteCgibinOAVacationGetUserVacationQuotaAsync(this WechatWorkClient client, Models.CgibinOAVacationGetUserVacationQuotaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "vacation", "getuservacationquota")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAVacationGetUserVacationQuotaResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/vacation/setoneuserquota 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93377 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94213 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAVacationSetOneUserQuotaResponse> ExecuteCgibinOAVacationSetOneUserQuotaAsync(this WechatWorkClient client, Models.CgibinOAVacationSetOneUserQuotaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "vacation", "setoneuserquota")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAVacationSetOneUserQuotaResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Journal
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/journal/get_record_list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93393 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAJournalGetRecordListResponse> ExecuteCgibinOAJournalGetRecordListAsync(this WechatWorkClient client, Models.CgibinOAJournalGetRecordListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "journal", "get_record_list")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAJournalGetRecordListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/journal/get_record_detail 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93394 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAJournalGetRecordDetailResponse> ExecuteCgibinOAJournalGetRecordDetailAsync(this WechatWorkClient client, Models.CgibinOAJournalGetRecordDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "journal", "get_record_detail")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAJournalGetRecordDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/journal/get_stat_list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93395 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAJournalGetStatListResponse> ExecuteCgibinOAJournalGetStatListAsync(this WechatWorkClient client, Models.CgibinOAJournalGetStatListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "journal", "get_stat_list")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAJournalGetStatListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region MeetingRoom
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/add 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93619 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAMeetingRoomAddResponse> ExecuteCgibinOAMeetingRoomAddAsync(this WechatWorkClient client, Models.CgibinOAMeetingRoomAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "add")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAMeetingRoomAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93619 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAMeetingRoomListResponse> ExecuteCgibinOAMeetingRoomListAsync(this WechatWorkClient client, Models.CgibinOAMeetingRoomListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "list")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAMeetingRoomListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/edit 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93619 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAMeetingRoomEditResponse> ExecuteCgibinOAMeetingRoomEditAsync(this WechatWorkClient client, Models.CgibinOAMeetingRoomEditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "edit")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAMeetingRoomEditResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/del 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93619 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAMeetingRoomDeleteResponse> ExecuteCgibinOAMeetingRoomDeleteAsync(this WechatWorkClient client, Models.CgibinOAMeetingRoomDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "del")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAMeetingRoomDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region MeetingRoomBook
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/get_booking_info 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93620 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAMeetingRoomGetBookingInfoResponse> ExecuteCgibinOAMeetingRoomGetBookingInfoAsync(this WechatWorkClient client, Models.CgibinOAMeetingRoomGetBookingInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "get_booking_info")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAMeetingRoomGetBookingInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/book 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93620 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAMeetingRoomBookResponse> ExecuteCgibinOAMeetingRoomBookAsync(this WechatWorkClient client, Models.CgibinOAMeetingRoomBookRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "book")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAMeetingRoomBookResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/cancel_book 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93620 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAMeetingRoomCancelBookResponse> ExecuteCgibinOAMeetingRoomCancelBookAsync(this WechatWorkClient client, Models.CgibinOAMeetingRoomCancelBookRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "cancel_book")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAMeetingRoomCancelBookResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region Calendar
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/calendar/add 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93647 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93702 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOACalendarAddResponse> ExecuteCgibinOACalendarAddAsync(this WechatWorkClient client, Models.CgibinOACalendarAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "calendar", "add")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOACalendarAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/calendar/update 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93647 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93702 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOACalendarUpdateResponse> ExecuteCgibinOACalendarUpdateAsync(this WechatWorkClient client, Models.CgibinOACalendarUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "calendar", "update")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOACalendarUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/calendar/get 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93647 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93702 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOACalendarGetResponse> ExecuteCgibinOACalendarGetAsync(this WechatWorkClient client, Models.CgibinOACalendarGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "calendar", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOACalendarGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/calendar/del 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93647 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93702 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOACalendarDeleteResponse> ExecuteCgibinOACalendarDeleteAsync(this WechatWorkClient client, Models.CgibinOACalendarDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "calendar", "del")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOACalendarDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Schedule
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/schedule/add 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93648 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93703 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAScheduleAddResponse> ExecuteCgibinOAScheduleAddAsync(this WechatWorkClient client, Models.CgibinOAScheduleAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "schedule", "add")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAScheduleAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/schedule/update 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93648 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93703 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAScheduleUpdateResponse> ExecuteCgibinOAScheduleUpdateAsync(this WechatWorkClient client, Models.CgibinOAScheduleUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "schedule", "update")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAScheduleUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/schedule/get 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93648 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93703 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAScheduleGetResponse> ExecuteCgibinOAScheduleGetAsync(this WechatWorkClient client, Models.CgibinOAScheduleGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "schedule", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAScheduleGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/schedule/get_by_calendar 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93648 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93703 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAScheduleGetByCalendarResponse> ExecuteCgibinOAScheduleGetByCalendarAsync(this WechatWorkClient client, Models.CgibinOAScheduleGetByCalendarRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "schedule", "get_by_calendar")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAScheduleGetByCalendarResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/schedule/del 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93648 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93703 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAScheduleDeleteResponse> ExecuteCgibinOAScheduleDeleteAsync(this WechatWorkClient client, Models.CgibinOAScheduleDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "oa", "schedule", "del")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinOAScheduleDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
