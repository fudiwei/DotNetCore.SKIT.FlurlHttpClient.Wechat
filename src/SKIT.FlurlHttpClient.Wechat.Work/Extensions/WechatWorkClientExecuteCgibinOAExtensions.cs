using System;
using System.Net.Http;
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
        /// <para>异步调用 [POST] /cgi-bin/oa/applyevent 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91853 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92632 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "applyevent")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAApplyEventResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/getapprovalinfo 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91816 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94603 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "getapprovalinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAGetApprovalInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/getapprovaldetail 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91983 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92634 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "getapprovaldetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAGetApprovalDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/approval/copytemplate 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92630 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "approval", "copytemplate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAApprovalCopyTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/gettemplatedetail 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91982 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92631 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "gettemplatedetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAGetTemplateDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/approval/create_template 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97437 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAApprovalCreateTemplateResponse> ExecuteCgibinOAApprovalCreateTemplateAsync(this WechatWorkClient client, Models.CgibinOAApprovalCreateTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "approval", "create_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAApprovalCreateTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/approval/update_template 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97438 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAApprovalUpdateTemplateResponse> ExecuteCgibinOAApprovalUpdateTemplateAsync(this WechatWorkClient client, Models.CgibinOAApprovalUpdateTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "approval", "update_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAApprovalUpdateTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Vacation
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/oa/vacation/getcorpconf 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93375 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94211 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "oa", "vacation", "getcorpconf")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAVacationGetCorpConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/vacation/getuservacationquota 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93376 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94212 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "vacation", "getuservacationquota")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAVacationGetUserVacationQuotaResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/vacation/setoneuserquota 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93377 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94213 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "vacation", "setoneuserquota")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAVacationSetOneUserQuotaResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Journal
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/journal/get_record_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93393 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "journal", "get_record_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAJournalGetRecordListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/journal/get_record_detail 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93394 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "journal", "get_record_detail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAJournalGetRecordDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/journal/get_stat_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93395 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "journal", "get_stat_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAJournalGetStatListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/journal/export_doc 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96108 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAJournalExportDocumentResponse> ExecuteCgibinOAJournalExportDocumentAsync(this WechatWorkClient client, Models.CgibinOAJournalExportDocumentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "journal", "export_doc")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAJournalExportDocumentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/journal/get_export_doc_result 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96108 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAJournalGetExportDocumentResultResponse> ExecuteCgibinOAJournalGetExportDocumentResultAsync(this WechatWorkClient client, Models.CgibinOAJournalGetExportDocumentResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "journal", "get_export_doc_result")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAJournalGetExportDocumentResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region MeetingRoom
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/add 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93619 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAMeetingRoomAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93619 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAMeetingRoomListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/edit 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93619 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "edit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAMeetingRoomEditResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/del 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93619 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAMeetingRoomDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region MeetingRoom/Book
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/get_booking_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93620 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "get_booking_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAMeetingRoomGetBookingInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/get_booking_info_by_meeting_id 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93620 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAMeetingRoomGetBookingInfoByMeetingIdResponse> ExecuteCgibinOAMeetingRoomGetBookingInfoByMeetingIdAsync(this WechatWorkClient client, Models.CgibinOAMeetingRoomGetBookingInfoByMeetingIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "get_booking_info_by_meeting_id")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAMeetingRoomGetBookingInfoByMeetingIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/book 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93620 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "book")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAMeetingRoomBookResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/book_by_schedule 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93620 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAMeetingRoomBookByScheduleResponse> ExecuteCgibinOAMeetingRoomBookByScheduleAsync(this WechatWorkClient client, Models.CgibinOAMeetingRoomBookByScheduleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "book_by_schedule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAMeetingRoomBookByScheduleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/book_by_meeting 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93620 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAMeetingRoomBookByMeetingResponse> ExecuteCgibinOAMeetingRoomBookByMeetingAsync(this WechatWorkClient client, Models.CgibinOAMeetingRoomBookByMeetingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "book_by_meeting")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAMeetingRoomBookByMeetingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/cancel_book 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93620 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "cancel_book")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAMeetingRoomCancelBookResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/meetingroom/bookinfo/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93620 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAMeetingRoomBookInfoGetResponse> ExecuteCgibinOAMeetingRoomBookInfoGetAsync(this WechatWorkClient client, Models.CgibinOAMeetingRoomBookInfoGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "meetingroom", "bookinfo", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAMeetingRoomBookInfoGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region Calendar
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/calendar/add 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93647 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93702 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "calendar", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOACalendarAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/calendar/update 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97716 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "calendar", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOACalendarUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/calendar/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97717 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "calendar", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOACalendarGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/calendar/del 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97718 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "calendar", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOACalendarDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Schedule
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/schedule/add 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93648 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93703 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "schedule", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAScheduleAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/schedule/update 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93648 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93703 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "schedule", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAScheduleUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/schedule/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93648 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93703 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "schedule", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAScheduleGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/schedule/get_by_calendar 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93648 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93703 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "schedule", "get_by_calendar")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAScheduleGetByCalendarResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/schedule/del 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93648 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93703 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "schedule", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAScheduleDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region ScheduleAttendees
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/schedule/add_attendees 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93648 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93703 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAScheduleAddAttendeesResponse> ExecuteCgibinOAScheduleAddAttendeesAsync(this WechatWorkClient client, Models.CgibinOAScheduleAddAttendeesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "schedule", "add_attendees")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAScheduleAddAttendeesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/oa/schedule/del_attendees 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93648 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93703 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOAScheduleDeleteAttendeesResponse> ExecuteCgibinOAScheduleDeleteAttendeesAsync(this WechatWorkClient client, Models.CgibinOAScheduleDeleteAttendeesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "oa", "schedule", "del_attendees")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOAScheduleDeleteAttendeesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion
    }
}
