using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinUserExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/create 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90195 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90331 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90814 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserCreateResponse> ExecuteCgibinUserCreateAsync(this WechatWorkClient client, Models.CgibinUserCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "user", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90196 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90332 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90815 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserGetResponse> ExecuteCgibinUserGetAsync(this WechatWorkClient client, Models.CgibinUserGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "user", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("userid", request.UserId);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/update 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90197 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90333 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90816 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserUpdateResponse> ExecuteCgibinUserUpdateAsync(this WechatWorkClient client, Models.CgibinUserUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "user", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/delete 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90198 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90334 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90817 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserDeleteResponse> ExecuteCgibinUserDeleteAsync(this WechatWorkClient client, Models.CgibinUserDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "user", "delete")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("userid", request.UserId);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/batchdelete 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90199 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90335 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90818 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserBatchDeleteResponse> ExecuteCgibinUserBatchDeleteAsync(this WechatWorkClient client, Models.CgibinUserBatchDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "user", "batchdelete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserBatchDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/simplelist 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90200 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90336 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90819 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserSimpleListResponse> ExecuteCgibinUserSimpleListAsync(this WechatWorkClient client, Models.CgibinUserSimpleListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "user", "simplelist")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("department_id", request.DepartmentId);

            if (request.RequireFetchChild != null)
                flurlReq.SetQueryParam("fetch_child", request.RequireFetchChild.Value ? 1 : 0);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserSimpleListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90201 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90337 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90820 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserListResponse> ExecuteCgibinUserListAsync(this WechatWorkClient client, Models.CgibinUserListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "user", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("department_id", request.DepartmentId);

            if (request.RequireFetchChild != null)
                flurlReq.SetQueryParam("fetch_child", request.RequireFetchChild.Value ? 1 : 0);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/convert_to_openid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90202 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90338 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90821 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserConvertToOpenIdResponse> ExecuteCgibinUserConvertToOpenIdAsync(this WechatWorkClient client, Models.CgibinUserConvertToOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "user", "convert_to_openid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserConvertToOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/convert_to_userid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90202 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90338 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90821 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserConvertToUserIdResponse> ExecuteCgibinUserConvertToUserIdAsync(this WechatWorkClient client, Models.CgibinUserConvertToUserIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "user", "convert_to_userid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserConvertToUserIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/getuserinfo 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91023 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91437 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91707 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91711 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserGetUserInfoResponse> ExecuteCgibinUserGetUserInfoAsync(this WechatWorkClient client, Models.CgibinUserGetUserInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "user", "getuserinfo")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("code", request.Code);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserGetUserInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/getuserid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91693 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserGetUserIdResponse> ExecuteCgibinUserGetUserIdAsync(this WechatWorkClient client, Models.CgibinUserGetUserIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "user", "getuserid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserGetUserIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/get_active_stat 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92714 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserGetActiveStatResponse> ExecuteCgibinUserGetActiveStatAsync(this WechatWorkClient client, Models.CgibinUserGetActiveStatRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "user", "get_active_stat")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserGetActiveStatResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/list_selected_ticket_user 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90001/90143/94894 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserListSelectedTicketUserResponse> ExecuteCgibinUserListSelectedTicketUserAsync(this WechatWorkClient client, Models.CgibinUserListSelectedTicketUserRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "user", "list_selected_ticket_user")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("selected_ticket", request.SelectedTicket);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserListSelectedTicketUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/list_id 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/40856 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserListIdResponse> ExecuteCgibinUserListIdAsync(this WechatWorkClient client, Models.CgibinUserListIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "user", "list_id")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserListIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Auth
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/authsucc 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90203 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90339 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90822 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserAuthSuccessResponse> ExecuteCgibinUserAuthSuccessAsync(this WechatWorkClient client, Models.CgibinUserAuthSuccessRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "user", "authsucc")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("userid", request.UserId);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserAuthSuccessResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/tfa_succ 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/99500 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserTAFSuccessResponse> ExecuteCgibinUserTAFSuccessAsync(this WechatWorkClient client, Models.CgibinUserTAFSuccessRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "user", "tfa_succ")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserTAFSuccessResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/list_member_auth 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94513 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserListMemberAuthResponse> ExecuteCgibinUserListMemberAuthAsync(this WechatWorkClient client, Models.CgibinUserListMemberAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "user", "list_member_auth")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.Cursor != null)
                flurlReq.SetQueryParam("cursor", request.Cursor);

            if (request.Limit != null)
                flurlReq.SetQueryParam("limit", request.Limit);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserListMemberAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/user/check_member_auth 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94514 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserCheckMemberAuthResponse> ExecuteCgibinUserCheckMemberAuthAsync(this WechatWorkClient client, Models.CgibinUserCheckMemberAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "user", "check_member_auth")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("open_userid", request.OpenUserId);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserCheckMemberAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
