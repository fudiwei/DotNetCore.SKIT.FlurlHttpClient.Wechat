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
    }
}
