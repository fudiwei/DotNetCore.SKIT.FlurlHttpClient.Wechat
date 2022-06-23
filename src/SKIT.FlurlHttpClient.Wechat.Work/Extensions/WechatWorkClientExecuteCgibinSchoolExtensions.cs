using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinSchoolExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/set_teacher_view_mode 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92652 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolSetTeacherViewModeResponse> ExecuteCgibinSchoolSetTeacherViewModeAsync(this WechatWorkClient client, Models.CgibinSchoolSetTeacherViewModeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "set_teacher_view_mode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolSetTeacherViewModeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/school/get_teacher_view_mode 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92652 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolGetTeacherViewModeResponse> ExecuteCgibinSchoolGetTeacherViewModeAsync(this WechatWorkClient client, Models.CgibinSchoolGetTeacherViewModeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "school", "get_teacher_view_mode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolGetTeacherViewModeResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/set_arch_sync_mode 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92345 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92083 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolSetArchSyncModeResponse> ExecuteCgibinSchoolSetArchSyncModeAsync(this WechatWorkClient client, Models.CgibinSchoolSetArchSyncModeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "set_arch_sync_mode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolSetArchSyncModeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/set_upgrade_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92949 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92950 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolSetUpgradeInfoResponse> ExecuteCgibinSchoolSetUpgradeInfoAsync(this WechatWorkClient client, Models.CgibinSchoolSetUpgradeInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "set_upgrade_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolSetUpgradeInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/school/getuserinfo 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95791 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolGetUserInfoResponse> ExecuteCgibinSchoolGetUserInfoAsync(this WechatWorkClient client, Models.CgibinSchoolGetUserInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "school", "getuserinfo")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("code", request.Code);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolGetUserInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region User
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/school/user/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92337 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92038 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserGetResponse> ExecuteCgibinSchoolUserGetAsync(this WechatWorkClient client, Models.CgibinSchoolUserGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "school", "user", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("userid", request.StudentOrParentUserId);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserGetResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/school/user/list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92338 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92043 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserListResponse> ExecuteCgibinSchoolUserListAsync(this WechatWorkClient client, Models.CgibinSchoolUserListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "school", "user", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("department_id", request.DeparmentId);

            if (request.RequireFetchChild != null)
                flurlReq.SetQueryParam("fetch_child", request.RequireFetchChild.Value ? 1 : 0);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserListResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/school/user/list_parent 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92446 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserListParentResponse> ExecuteCgibinSchoolUserListParentAsync(this WechatWorkClient client, Models.CgibinSchoolUserListParentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "school", "user", "list_parent")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("department_id", request.DeparmentId);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserListParentResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        #region UserStudent
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/user/create_student 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92325 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92035 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserCreateStudentResponse> ExecuteCgibinSchoolUserCreateStudentAsync(this WechatWorkClient client, Models.CgibinSchoolUserCreateStudentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "user", "create_student")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserCreateStudentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/school/user/delete_student 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92326 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92039 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserDeleteStudentResponse> ExecuteCgibinSchoolUserDeleteStudentAsync(this WechatWorkClient client, Models.CgibinSchoolUserDeleteStudentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "school", "user", "delete_student")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("userid", request.StudentUserId);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserDeleteStudentResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/user/update_student 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92327 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92041 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserUpdateStudentResponse> ExecuteCgibinSchoolUserUpdateStudentAsync(this WechatWorkClient client, Models.CgibinSchoolUserUpdateStudentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "user", "update_student")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserUpdateStudentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/user/batch_create_student 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92328 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92037 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserBatchCreateStudentResponse> ExecuteCgibinSchoolUserBatchCreateStudentAsync(this WechatWorkClient client, Models.CgibinSchoolUserBatchCreateStudentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "user", "batch_create_student")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserBatchCreateStudentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/user/batch_delete_student 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92329 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92040 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserBatchDeleteStudentResponse> ExecuteCgibinSchoolUserBatchDeleteStudentAsync(this WechatWorkClient client, Models.CgibinSchoolUserBatchDeleteStudentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "user", "batch_delete_student")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserBatchDeleteStudentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/user/batch_update_student 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92330 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92042 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserBatchUpdateStudentResponse> ExecuteCgibinSchoolUserBatchUpdateStudentAsync(this WechatWorkClient client, Models.CgibinSchoolUserBatchUpdateStudentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "user", "batch_update_student")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserBatchUpdateStudentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region UserParent
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/user/create_parent 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92331 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92077 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserCreateParentResponse> ExecuteCgibinSchoolUserCreateParentAsync(this WechatWorkClient client, Models.CgibinSchoolUserCreateParentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "user", "create_parent")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserCreateParentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/school/user/delete_parent 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92332 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92079 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserDeleteParentResponse> ExecuteCgibinSchoolUserDeleteParentAsync(this WechatWorkClient client, Models.CgibinSchoolUserDeleteParentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "school", "user", "delete_parent")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("userid", request.ParentUserId);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserDeleteParentResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/user/update_parent 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92333 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92081 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserUpdateParentResponse> ExecuteCgibinSchoolUserUpdateParentAsync(this WechatWorkClient client, Models.CgibinSchoolUserUpdateParentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "user", "update_parent")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserUpdateParentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/user/batch_create_parent 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92334 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92078 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserBatchCreateParentResponse> ExecuteCgibinSchoolUserBatchCreateParentAsync(this WechatWorkClient client, Models.CgibinSchoolUserBatchCreateParentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "user", "batch_create_parent")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserBatchCreateParentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/user/batch_delete_parent 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92335 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92080 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserBatchDeleteParentResponse> ExecuteCgibinSchoolUserBatchDeleteParentAsync(this WechatWorkClient client, Models.CgibinSchoolUserBatchDeleteParentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "user", "batch_delete_parent")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserBatchDeleteParentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/user/batch_update_parent 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92336 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92082 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserBatchUpdateParentResponse> ExecuteCgibinSchoolUserBatchUpdateParentAsync(this WechatWorkClient client, Models.CgibinSchoolUserBatchUpdateParentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "user", "batch_update_parent")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserBatchUpdateParentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region UserHealth
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/user/get_teacher_customize_health_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93744 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserGetTeacherCustomizeHealthInfoResponse> ExecuteCgibinSchoolUserGetTeacherCustomizeHealthInfoAsync(this WechatWorkClient client, Models.CgibinSchoolUserGetTeacherCustomizeHealthInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "user", "get_teacher_customize_health_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserGetTeacherCustomizeHealthInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/user/get_student_customize_health_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93745 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserGetStudentCustomizeHealthInfoResponse> ExecuteCgibinSchoolUserGetStudentCustomizeHealthInfoAsync(this WechatWorkClient client, Models.CgibinSchoolUserGetStudentCustomizeHealthInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "user", "get_student_customize_health_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserGetStudentCustomizeHealthInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/user/get_health_qrcode 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93746 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolUserGetHealthQrcodeResponse> ExecuteCgibinSchoolUserGetHealthQrcodeAsync(this WechatWorkClient client, Models.CgibinSchoolUserGetHealthQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "user", "get_health_qrcode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolUserGetHealthQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region Department
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/department/create 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92340 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92296 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolDepartmentCreateResponse> ExecuteCgibinSchoolDepartmentCreateAsync(this WechatWorkClient client, Models.CgibinSchoolDepartmentCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "department", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolDepartmentCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/department/update 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92341 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92297 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolDepartmentUpdateResponse> ExecuteCgibinSchoolDepartmentUpdateAsync(this WechatWorkClient client, Models.CgibinSchoolDepartmentUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "department", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolDepartmentUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/school/department/delete 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92342 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92298 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolDepartmentDeleteResponse> ExecuteCgibinSchoolDepartmentDeleteAsync(this WechatWorkClient client, Models.CgibinSchoolDepartmentDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "school", "department", "delete")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("id", request.DepartmentId);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolDepartmentDeleteResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/school/department/list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92343 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92299 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolDepartmentListResponse> ExecuteCgibinSchoolDepartmentListAsync(this WechatWorkClient client, Models.CgibinSchoolDepartmentListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "school", "department", "list")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.ParentDepartmentId != null)
                flurlReq.SetQueryParam("id", request.ParentDepartmentId);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolDepartmentListResponse>(flurlReq, cancellationToken: cancellationToken);
        }
        #endregion

        #region Living
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/school/living/get_living_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93740 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93857 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolLivingGetLivingInfoResponse> ExecuteCgibinSchoolLivingGetLivingInfoAsync(this WechatWorkClient client, Models.CgibinSchoolLivingGetLivingInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "school", "living", "get_living_info")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("livingid", request.LivingId);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolLivingGetLivingInfoResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/living/get_watch_stat 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93741 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93858 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolLivingGetWatchStatisticsResponse> ExecuteCgibinSchoolLivingGetWatchStatisticsAsync(this WechatWorkClient client, Models.CgibinSchoolLivingGetWatchStatisticsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "living", "get_watch_stat")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolLivingGetWatchStatisticsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/living/get_unwatch_stat 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93742 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93859 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolLivingGetUnwatchStatisticsResponse> ExecuteCgibinSchoolLivingGetUnwatchStatisticsAsync(this WechatWorkClient client, Models.CgibinSchoolLivingGetUnwatchStatisticsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "living", "get_unwatch_stat")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolLivingGetUnwatchStatisticsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Payment
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/get_payment_result 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94470 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolGetPaymentResultResponse> ExecuteCgibinSchoolGetPaymentResultAsync(this WechatWorkClient client, Models.CgibinSchoolGetPaymentResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "get_payment_result")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolGetPaymentResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/school/get_trade 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94471 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolGetTradeResponse> ExecuteCgibinSchoolGetTradeAsync(this WechatWorkClient client, Models.CgibinSchoolGetTradeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "school", "get_trade")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolGetTradeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Agent
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/school/agent/get_allow_scope 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94895 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinSchoolAgentGetAllowScopeResponse> ExecuteCgibinSchoolAgentGetAllowScopeAsync(this WechatWorkClient client, Models.CgibinSchoolAgentGetAllowScopeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "school", "agent", "get_allow_scope")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinSchoolAgentGetAllowScopeResponse>(flurlReq, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
