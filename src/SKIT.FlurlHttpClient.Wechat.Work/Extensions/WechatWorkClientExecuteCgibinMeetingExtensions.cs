using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinMeetingExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/create 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93706 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98148 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingCreateResponse> ExecuteCgibinMeetingCreateAsync(this WechatWorkClient client, Models.CgibinMeetingCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/update 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93710 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98154 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingUpdateResponse> ExecuteCgibinMeetingUpdateAsync(this WechatWorkClient client, Models.CgibinMeetingUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/cancel 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93709 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98153 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingCancelResponse> ExecuteCgibinMeetingCancelAsync(this WechatWorkClient client, Models.CgibinMeetingCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/get_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93708 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98149 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingGetInfoResponse> ExecuteCgibinMeetingGetInfoAsync(this WechatWorkClient client, Models.CgibinMeetingGetInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "get_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingGetInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/get_user_meetingid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93707 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98714 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingGetUserMeetingIdResponse> ExecuteCgibinMeetingGetUserMeetingIdAsync(this WechatWorkClient client, Models.CgibinMeetingGetUserMeetingIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "get_user_meetingid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingGetUserMeetingIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/get_invitees 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98160 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingGetInviteesResponse> ExecuteCgibinMeetingGetInviteesAsync(this WechatWorkClient client, Models.CgibinMeetingGetInviteesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "get_invitees")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingGetInviteesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/set_invitees 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98162 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingSetInviteesResponse> ExecuteCgibinMeetingSetInviteesAsync(this WechatWorkClient client, Models.CgibinMeetingSetInviteesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "set_invitees")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingSetInviteesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/create_customer_short_url 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98818 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingCreateCustomerShortUrlResponse> ExecuteCgibinMeetingCreateCustomerShortUrlAsync(this WechatWorkClient client, Models.CgibinMeetingCreateCustomerShortUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "create_customer_short_url")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingCreateCustomerShortUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/get_customer_short_url 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98819 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingGetCustomerShortUrlResponse> ExecuteCgibinMeetingGetCustomerShortUrlAsync(this WechatWorkClient client, Models.CgibinMeetingGetCustomerShortUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "get_customer_short_url")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingGetCustomerShortUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/get_realtime_attendee_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98157 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingGetRealtimeAttendeeListResponse> ExecuteCgibinMeetingGetRealtimeAttendeeListAsync(this WechatWorkClient client, Models.CgibinMeetingGetRealtimeAttendeeListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "get_realtime_attendee_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingGetRealtimeAttendeeListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/get_attendee_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98156 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingGetAttendeeListResponse> ExecuteCgibinMeetingGetAttendeeListAsync(this WechatWorkClient client, Models.CgibinMeetingGetAttendeeListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "get_attendee_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingGetAttendeeListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/waitingroom/get_current_user_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98163 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingWaitingRoomGetCurrentUserListResponse> ExecuteCgibinMeetingWaitingRoomGetCurrentUserListAsync(this WechatWorkClient client, Models.CgibinMeetingWaitingRoomGetCurrentUserListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "waitingroom", "get_current_user_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingWaitingRoomGetCurrentUserListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/waitingroom/get_user_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98164 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingWaitingRoomGetUserListResponse> ExecuteCgibinMeetingWaitingRoomGetUserListAsync(this WechatWorkClient client, Models.CgibinMeetingWaitingRoomGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "waitingroom", "get_user_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingWaitingRoomGetUserListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/check_device_in_meeting 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98164 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingCheckDeviceInMeetingResponse> ExecuteCgibinMeetingCheckDeviceInMeetingAsync(this WechatWorkClient client, Models.CgibinMeetingCheckDeviceInMeetingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "check_device_in_meeting")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingCheckDeviceInMeetingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/get_guests 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/99039 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingGetGuestsResponse> ExecuteCgibinMeetingGetGuestsAsync(this WechatWorkClient client, Models.CgibinMeetingGetGuestsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "get_guests")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingGetGuestsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/set_guests 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/99040 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingSetGuestsResponse> ExecuteCgibinMeetingSetGuestsAsync(this WechatWorkClient client, Models.CgibinMeetingSetGuestsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "set_guests")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingSetGuestsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/get_quality 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98821 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingGetQualityResponse> ExecuteCgibinMeetingGetQualityAsync(this WechatWorkClient client, Models.CgibinMeetingGetQualityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "get_quality")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingGetQualityResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Enroll
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/enroll/set_config 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98821 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingEnrollSetConfigResponse> ExecuteCgibinMeetingEnrollSetConfigAsync(this WechatWorkClient client, Models.CgibinMeetingEnrollSetConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "enroll", "set_config")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingEnrollSetConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/enroll/get_config 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98821 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingEnrollGetConfigResponse> ExecuteCgibinMeetingEnrollGetConfigAsync(this WechatWorkClient client, Models.CgibinMeetingEnrollGetConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "enroll", "get_config")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingEnrollGetConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/enroll/query_by_tmp_openid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98794 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingEnrollQueryByTempOpenIdResponse> ExecuteCgibinMeetingEnrollQueryByTempOpenIdAsync(this WechatWorkClient client, Models.CgibinMeetingEnrollQueryByTempOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "enroll", "query_by_tmp_openid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingEnrollQueryByTempOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/enroll/list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98810 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingEnrollListResponse> ExecuteCgibinMeetingEnrollListAsync(this WechatWorkClient client, Models.CgibinMeetingEnrollListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "enroll", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingEnrollListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/enroll/approve 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98807 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingEnrollApproveResponse> ExecuteCgibinMeetingEnrollApproveAsync(this WechatWorkClient client, Models.CgibinMeetingEnrollApproveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "enroll", "approve")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingEnrollApproveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/enroll/import 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98816 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingEnrollImportResponse> ExecuteCgibinMeetingEnrollImportAsync(this WechatWorkClient client, Models.CgibinMeetingEnrollImportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "enroll", "import")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingEnrollImportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/enroll/delete 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98817 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingEnrollDeleteResponse> ExecuteCgibinMeetingEnrollDeleteAsync(this WechatWorkClient client, Models.CgibinMeetingEnrollDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "enroll", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingEnrollDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region MRA
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/mra/query_status 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98786 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingMRAQueryStatusResponse> ExecuteCgibinMeetingMRAQueryStatusAsync(this WechatWorkClient client, Models.CgibinMeetingMRAQueryStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "mra", "query_status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingMRAQueryStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/mra/set_default_layout 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98787 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingMRASetDefaultLayoutResponse> ExecuteCgibinMeetingMRASetDefaultLayoutAsync(this WechatWorkClient client, Models.CgibinMeetingMRASetDefaultLayoutRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "mra", "set_default_layout")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingMRASetDefaultLayoutResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/mra/set_raise_hand 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98788 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingMRASetRaiseHandResponse> ExecuteCgibinMeetingMRASetRaiseHandAsync(this WechatWorkClient client, Models.CgibinMeetingMRASetRaiseHandRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "mra", "set_raise_hand")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingMRASetRaiseHandResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/mra/hangup 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98789 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingMRAHangupResponse> ExecuteCgibinMeetingMRAHangupAsync(this WechatWorkClient client, Models.CgibinMeetingMRAHangupRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "mra", "hangup")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingMRAHangupResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Phone
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/phone/callout 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98823 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingPhoneCalloutResponse> ExecuteCgibinMeetingPhoneCalloutAsync(this WechatWorkClient client, Models.CgibinMeetingPhoneCalloutRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "phone", "callout")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingPhoneCalloutResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/phone/get_callout_status 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98824 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingPhoneGetCalloutStatusResponse> ExecuteCgibinMeetingPhoneGetCalloutStatusAsync(this WechatWorkClient client, Models.CgibinMeetingPhoneGetCalloutStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "phone", "get_callout_status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingPhoneGetCalloutStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/phone/get_tmp_openid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98825 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingPhoneGetTempOpenIdResponse> ExecuteCgibinMeetingPhoneGetTempOpenIdAsync(this WechatWorkClient client, Models.CgibinMeetingPhoneGetTempOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "phone", "get_tmp_openid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingPhoneGetTempOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Poll
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/poll/create_theme 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98834 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingPollCreateThemeResponse> ExecuteCgibinMeetingPollCreateThemeAsync(this WechatWorkClient client, Models.CgibinMeetingPollCreateThemeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "poll", "create_theme")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingPollCreateThemeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/poll/update_theme 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98835 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingPollUpdateThemeResponse> ExecuteCgibinMeetingPollUpdateThemeAsync(this WechatWorkClient client, Models.CgibinMeetingPollUpdateThemeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "poll", "update_theme")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingPollUpdateThemeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/poll/get_poll_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98836 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingPollGetPollListResponse> ExecuteCgibinMeetingPollGetPollListAsync(this WechatWorkClient client, Models.CgibinMeetingPollGetPollListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "poll", "get_poll_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingPollGetPollListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/poll/get_theme_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98837 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingPollGetThemeInfoResponse> ExecuteCgibinMeetingPollGetThemeInfoAsync(this WechatWorkClient client, Models.CgibinMeetingPollGetThemeInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "poll", "get_theme_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingPollGetThemeInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/poll/get_poll_detail 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98838 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingPollGetPollDetailResponse> ExecuteCgibinMeetingPollGetPollDetailAsync(this WechatWorkClient client, Models.CgibinMeetingPollGetPollDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "poll", "get_poll_detail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingPollGetPollDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/poll/delete 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98839 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingPollDeleteResponse> ExecuteCgibinMeetingPollDeleteAsync(this WechatWorkClient client, Models.CgibinMeetingPollDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "poll", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingPollDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/poll/start 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98840 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingPollStartResponse> ExecuteCgibinMeetingPollStartAsync(this WechatWorkClient client, Models.CgibinMeetingPollStartRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "poll", "start")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingPollStartResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/poll/finish 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98841 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingPollFinishResponse> ExecuteCgibinMeetingPollFinishAsync(this WechatWorkClient client, Models.CgibinMeetingPollFinishRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "poll", "finish")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingPollFinishResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region RealControl
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/realcontrol/set 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98175 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRealControlSetResponse> ExecuteCgibinMeetingRealControlSetAsync(this WechatWorkClient client, Models.CgibinMeetingRealControlSetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "realcontrol", "set")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRealControlSetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/realcontrol/set_cohost 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98180 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRealControlSetCoHostResponse> ExecuteCgibinMeetingRealControlSetCoHostAsync(this WechatWorkClient client, Models.CgibinMeetingRealControlSetCoHostRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "realcontrol", "set_cohost")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRealControlSetCoHostResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/realcontrol/mute_user 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98184 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRealControlMuteUserResponse> ExecuteCgibinMeetingRealControlMuteUserAsync(this WechatWorkClient client, Models.CgibinMeetingRealControlMuteUserRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "realcontrol", "mute_user")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRealControlMuteUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/realcontrol/switch_user_video 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98189 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRealControlSwitchUserVideoResponse> ExecuteCgibinMeetingRealControlSwitchUserVideoAsync(this WechatWorkClient client, Models.CgibinMeetingRealControlSwitchUserVideoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "realcontrol", "switch_user_video")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRealControlSwitchUserVideoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/realcontrol/close_screen_share 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98185 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRealControlCloseScreenShareResponse> ExecuteCgibinMeetingRealControlCloseScreenShareAsync(this WechatWorkClient client, Models.CgibinMeetingRealControlCloseScreenShareRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "realcontrol", "close_screen_share")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRealControlCloseScreenShareResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/realcontrol/set_nicknames 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98188 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRealControlSetNicknamesResponse> ExecuteCgibinMeetingRealControlSetNicknamesAsync(this WechatWorkClient client, Models.CgibinMeetingRealControlSetNicknamesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "realcontrol", "set_nicknames")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRealControlSetNicknamesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/realcontrol/manage_waiting_room_users 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98186 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRealControlManageWaitingRoomUsersResponse> ExecuteCgibinMeetingRealControlManageWaitingRoomUsersAsync(this WechatWorkClient client, Models.CgibinMeetingRealControlManageWaitingRoomUsersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "realcontrol", "manage_waiting_room_users")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRealControlManageWaitingRoomUsersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/realcontrol/kickout_users 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98181 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRealControlKickoutUsersResponse> ExecuteCgibinMeetingRealControlKickoutUsersAsync(this WechatWorkClient client, Models.CgibinMeetingRealControlKickoutUsersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "realcontrol", "kickout_users")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRealControlKickoutUsersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/realcontrol/dismiss 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98187 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRealControlDismissResponse> ExecuteCgibinMeetingRealControlDismissAsync(this WechatWorkClient client, Models.CgibinMeetingRealControlDismissRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "realcontrol", "dismiss")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRealControlDismissResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Record
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/record/list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98192 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRecordListResponse> ExecuteCgibinMeetingRecordListAsync(this WechatWorkClient client, Models.CgibinMeetingRecordListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "record", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRecordListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/record/get_statistics 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98209 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRecordGetStatisticsResponse> ExecuteCgibinMeetingRecordGetStatisticsAsync(this WechatWorkClient client, Models.CgibinMeetingRecordGetStatisticsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "record", "get_statistics")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRecordGetStatisticsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/record/update_sharing_config 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98208 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRecordUpdateSharingConfigResponse> ExecuteCgibinMeetingRecordUpdateSharingConfigAsync(this WechatWorkClient client, Models.CgibinMeetingRecordUpdateSharingConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "record", "update_sharing_config")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRecordUpdateSharingConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/record/delete 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98206 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRecordDeleteResponse> ExecuteCgibinMeetingRecordDeleteAsync(this WechatWorkClient client, Models.CgibinMeetingRecordDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "record", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRecordDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/record/delete_file 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98207 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRecordDeleteFileResponse> ExecuteCgibinMeetingRecordDeleteFileAsync(this WechatWorkClient client, Models.CgibinMeetingRecordDeleteFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "record", "delete_file")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRecordDeleteFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Rooms
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/rooms/book 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98791 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRoomsBookResponse> ExecuteCgibinMeetingRoomsBookAsync(this WechatWorkClient client, Models.CgibinMeetingRoomsBookRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "rooms", "book")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRoomsBookResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/rooms/release 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98792 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRoomsReleaseResponse> ExecuteCgibinMeetingRoomsReleaseAsync(this WechatWorkClient client, Models.CgibinMeetingRoomsReleaseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "rooms", "release")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRoomsReleaseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/rooms/list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98795 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRoomsListResponse> ExecuteCgibinMeetingRoomsListAsync(this WechatWorkClient client, Models.CgibinMeetingRoomsListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "rooms", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRoomsListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/rooms/get_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98793 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRoomsGetInfoResponse> ExecuteCgibinMeetingRoomsGetInfoAsync(this WechatWorkClient client, Models.CgibinMeetingRoomsGetInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "rooms", "get_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRoomsGetInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/rooms/get_config 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98802 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRoomsGetConfigResponse> ExecuteCgibinMeetingRoomsGetConfigAsync(this WechatWorkClient client, Models.CgibinMeetingRoomsGetConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "rooms", "get_config")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRoomsGetConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/rooms/list_meetings 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98796 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRoomsListMeetingsResponse> ExecuteCgibinMeetingRoomsListMeetingsAsync(this WechatWorkClient client, Models.CgibinMeetingRoomsListMeetingsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "rooms", "list_meetings")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRoomsListMeetingsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/rooms/list_devices 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98798 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRoomsListDevicesResponse> ExecuteCgibinMeetingRoomsListDevicesAsync(this WechatWorkClient client, Models.CgibinMeetingRoomsListDevicesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "rooms", "list_devices")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRoomsListDevicesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/rooms/list_controllers 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98799 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRoomsListControllersResponse> ExecuteCgibinMeetingRoomsListControllersAsync(this WechatWorkClient client, Models.CgibinMeetingRoomsListControllersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "rooms", "list_controllers")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRoomsListControllersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/rooms/get_inventory 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98809 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRoomsGetInventoryResponse> ExecuteCgibinMeetingRoomsGetInventoryAsync(this WechatWorkClient client, Models.CgibinMeetingRoomsGetInventoryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "rooms", "get_inventory")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRoomsGetInventoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/rooms/call 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98804 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRoomsCallResponse> ExecuteCgibinMeetingRoomsCallAsync(this WechatWorkClient client, Models.CgibinMeetingRoomsCallRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "rooms", "call")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRoomsCallResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/rooms/cancel_call 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98805 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRoomsCancelCallResponse> ExecuteCgibinMeetingRoomsCancelCallAsync(this WechatWorkClient client, Models.CgibinMeetingRoomsCancelCallRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "rooms", "cancel_call")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRoomsCancelCallResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/rooms/get_response_status 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98806 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingRoomsGetResponseStatusResponse> ExecuteCgibinMeetingRoomsGetResponseStatusAsync(this WechatWorkClient client, Models.CgibinMeetingRoomsGetResponseStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "rooms", "get_response_status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingRoomsGetResponseStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Webinar
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/webinar/create 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98842 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingWebinarCreateResponse> ExecuteCgibinMeetingWebinarCreateAsync(this WechatWorkClient client, Models.CgibinMeetingWebinarCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "webinar", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingWebinarCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/webinar/update 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98843 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingWebinarUpdateResponse> ExecuteCgibinMeetingWebinarUpdateAsync(this WechatWorkClient client, Models.CgibinMeetingWebinarUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "webinar", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingWebinarUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/webinar/cancel 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98843 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingWebinarCancelResponse> ExecuteCgibinMeetingWebinarCancelAsync(this WechatWorkClient client, Models.CgibinMeetingWebinarCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "webinar", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingWebinarCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/webinar/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98860 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingWebinarGetResponse> ExecuteCgibinMeetingWebinarGetAsync(this WechatWorkClient client, Models.CgibinMeetingWebinarGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "webinar", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingWebinarGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/webinar/list_guest 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98871 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingWebinarListGuestResponse> ExecuteCgibinMeetingWebinarListGuestAsync(this WechatWorkClient client, Models.CgibinMeetingWebinarListGuestRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "webinar", "list_guest")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingWebinarListGuestResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/webinar/update_guest_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98872 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingWebinarUpdateGuestListResponse> ExecuteCgibinMeetingWebinarUpdateGuestListAsync(this WechatWorkClient client, Models.CgibinMeetingWebinarUpdateGuestListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "webinar", "update_guest_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingWebinarUpdateGuestListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/webinar/update_warm_up 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98882 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingWebinarUpdateWarmUpResponse> ExecuteCgibinMeetingWebinarUpdateWarmUpAsync(this WechatWorkClient client, Models.CgibinMeetingWebinarUpdateWarmUpRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "webinar", "update_warm_up")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingWebinarUpdateWarmUpResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region /Webinar/Enroll
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/webinar/enroll/set_config 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98875 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingWebinarEnrollSetConfigResponse> ExecuteCgibinMeetingWebinarEnrollSetConfigAsync(this WechatWorkClient client, Models.CgibinMeetingWebinarEnrollSetConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "webinar", "enroll", "set_config")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingWebinarEnrollSetConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/webinar/enroll/get_config 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98874 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingWebinarEnrollGetConfigResponse> ExecuteCgibinMeetingWebinarEnrollGetConfigAsync(this WechatWorkClient client, Models.CgibinMeetingWebinarEnrollGetConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "webinar", "enroll", "get_config")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingWebinarEnrollGetConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/webinar/enroll/query_by_tmp_openid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98873 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingWebinarEnrollQueryByTempOpenIdResponse> ExecuteCgibinMeetingWebinarEnrollQueryByTempOpenIdAsync(this WechatWorkClient client, Models.CgibinMeetingWebinarEnrollQueryByTempOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "webinar", "enroll", "query_by_tmp_openid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingWebinarEnrollQueryByTempOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/webinar/enroll/list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98876 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingWebinarEnrollListResponse> ExecuteCgibinMeetingWebinarEnrollListAsync(this WechatWorkClient client, Models.CgibinMeetingWebinarEnrollListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "webinar", "enroll", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingWebinarEnrollListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/webinar/enroll/approve 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98877 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingWebinarEnrollApproveResponse> ExecuteCgibinMeetingWebinarEnrollApproveAsync(this WechatWorkClient client, Models.CgibinMeetingWebinarEnrollApproveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "webinar", "enroll", "approve")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingWebinarEnrollApproveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/webinar/enroll/import 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98880 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingWebinarEnrollImportResponse> ExecuteCgibinMeetingWebinarEnrollImportAsync(this WechatWorkClient client, Models.CgibinMeetingWebinarEnrollImportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "webinar", "enroll", "import")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingWebinarEnrollImportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/meeting/webinar/enroll/delete 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/98881 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMeetingWebinarEnrollDeleteResponse> ExecuteCgibinMeetingWebinarEnrollDeleteAsync(this WechatWorkClient client, Models.CgibinMeetingWebinarEnrollDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "meeting", "webinar", "enroll", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinMeetingWebinarEnrollDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion
    }
}
