using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinExternalContactExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/externalcontact/get_follow_user_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92571 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92576 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetFollowUserListResponse> ExecuteCgibinExternalContactGetFollowUserListAsync(this WechatWorkClient client, Models.CgibinExternalContactGetFollowUserListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "externalcontact", "get_follow_user_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetFollowUserListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/close_temp_chat 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92572 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92577 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCloseTempChatResponse> ExecuteCgibinExternalContactCloseTempChatAsync(this WechatWorkClient client, Models.CgibinExternalContactCloseTempChatRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "close_temp_chat")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCloseTempChatResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/externalcontact/list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92113 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92264 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactListResponse> ExecuteCgibinExternalContactListAsync(this WechatWorkClient client, Models.CgibinExternalContactListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "externalcontact", "list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("userid", request.UserId);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/externalcontact/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92114 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92265 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92322 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91670 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetResponse> ExecuteCgibinExternalContactGetAsync(this WechatWorkClient client, Models.CgibinExternalContactGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "externalcontact", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("external_userid", request.ExternalUserId);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/batch/get_by_user 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92994 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93010 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactBatchGetByUserResponse> ExecuteCgibinExternalContactBatchGetByUserAsync(this WechatWorkClient client, Models.CgibinExternalContactBatchGetByUserRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "batch", "get_by_user")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactBatchGetByUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/remark 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92994 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92694 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactRemarkResponse> ExecuteCgibinExternalContactRemarkAsync(this WechatWorkClient client, Models.CgibinExternalContactRemarkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "remark")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactRemarkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/mark_tag 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92118 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92697 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactMarkTagResponse> ExecuteCgibinExternalContactMarkTagAsync(this WechatWorkClient client, Models.CgibinExternalContactMarkTagRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "mark_tag")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactMarkTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_unassigned_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92124 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92273 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetUnassignedListResponse> ExecuteCgibinExternalContactGetUnassignedListAsync(this WechatWorkClient client, Models.CgibinExternalContactGetUnassignedListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_unassigned_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetUnassignedListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_user_behavior_data 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92132 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92275 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetUserBehaviorDataResponse> ExecuteCgibinExternalContactGetUserBehaviorDataAsync(this WechatWorkClient client, Models.CgibinExternalContactGetUserBehaviorDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_user_behavior_data")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetUserBehaviorDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/unionid_to_external_userid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93274 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactUnionIdToExternalUserIdResponse> ExecuteCgibinExternalContactUnionIdToExternalUserIdAsync(this WechatWorkClient client, Models.CgibinExternalContactUnionIdToExternalUserIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "unionid_to_external_userid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactUnionIdToExternalUserIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/convert_to_openid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92323 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92292 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactConvertToOpenIdResponse> ExecuteCgibinExternalContactConvertToOpenIdAsync(this WechatWorkClient client, Models.CgibinExternalContactConvertToOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "convert_to_openid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactConvertToOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/batch_to_external_userid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92506 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactBatchToExternalUserIdResponse> ExecuteCgibinExternalContactBatchToExternalUserIdAsync(this WechatWorkClient client, Models.CgibinExternalContactBatchToExternalUserIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "batch_to_external_userid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactBatchToExternalUserIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/opengid_to_chatid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94822 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactOpenGroupIdToChatIdResponse> ExecuteCgibinExternalContactOpenGroupIdToChatIdAsync(this WechatWorkClient client, Models.CgibinExternalContactOpenGroupIdToChatIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "opengid_to_chatid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactOpenGroupIdToChatIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/to_service_external_userid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95195 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactToServiceExternalUserIdResponse> ExecuteCgibinExternalContactToServiceExternalUserIdAsync(this WechatWorkClient client, Models.CgibinExternalContactToServiceExternalUserIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "to_service_external_userid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactToServiceExternalUserIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region ContactWay
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/add_contact_way 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92228 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96348 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactAddContactWayResponse> ExecuteCgibinExternalContactAddContactWayAsync(this WechatWorkClient client, Models.CgibinExternalContactAddContactWayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "add_contact_way")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactAddContactWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_contact_way 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92228 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96348 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetContactWayResponse> ExecuteCgibinExternalContactGetContactWayAsync(this WechatWorkClient client, Models.CgibinExternalContactGetContactWayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_contact_way")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetContactWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/list_contact_way 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92228 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96348 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactListContactWayResponse> ExecuteCgibinExternalContactListContactWayAsync(this WechatWorkClient client, Models.CgibinExternalContactListContactWayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "list_contact_way")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactListContactWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/update_contact_way 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92228 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96348 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactUpdateContactWayResponse> ExecuteCgibinExternalContactUpdateContactWayAsync(this WechatWorkClient client, Models.CgibinExternalContactUpdateContactWayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "update_contact_way")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactUpdateContactWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/del_contact_way 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92228 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96348 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactDeleteContactWayResponse> ExecuteCgibinExternalContactDeleteContactWayAsync(this WechatWorkClient client, Models.CgibinExternalContactDeleteContactWayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "del_contact_way")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactDeleteContactWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region CorpTag
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_corp_tag_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92117 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92696 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetCorpTagListResponse> ExecuteCgibinExternalContactGetCorpTagListAsync(this WechatWorkClient client, Models.CgibinExternalContactGetCorpTagListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_corp_tag_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetCorpTagListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/add_corp_tag 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92117 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92696 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactAddCorpTagResponse> ExecuteCgibinExternalContactAddCorpTagAsync(this WechatWorkClient client, Models.CgibinExternalContactAddCorpTagRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "add_corp_tag")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactAddCorpTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/edit_corp_tag 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92117 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92696 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactEditCorpTagResponse> ExecuteCgibinExternalContactEditCorpTagAsync(this WechatWorkClient client, Models.CgibinExternalContactEditCorpTagRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "edit_corp_tag")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactEditCorpTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/del_corp_tag 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92117 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92696 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactDeleteCorpTagResponse> ExecuteCgibinExternalContactDeleteCorpTagAsync(this WechatWorkClient client, Models.CgibinExternalContactDeleteCorpTagRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "del_corp_tag")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactDeleteCorpTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region CustomerAcquisition
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/customer_acquisition/list_link 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97297 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/99484 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCustomerAcquisitionListLinkResponse> ExecuteCgibinExternalContactCustomerAcquisitionListLinkAsync(this WechatWorkClient client, Models.CgibinExternalContactCustomerAcquisitionListLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "customer_acquisition", "list_link")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCustomerAcquisitionListLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/customer_acquisition/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97297 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/99484 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCustomerAcquisitionGetResponse> ExecuteCgibinExternalContactCustomerAcquisitionGetAsync(this WechatWorkClient client, Models.CgibinExternalContactCustomerAcquisitionGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "customer_acquisition", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCustomerAcquisitionGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/customer_acquisition/create_link 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97297 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCustomerAcquisitionCreateLinkResponse> ExecuteCgibinExternalContactCustomerAcquisitionCreateLinkAsync(this WechatWorkClient client, Models.CgibinExternalContactCustomerAcquisitionCreateLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "customer_acquisition", "create_link")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCustomerAcquisitionCreateLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/customer_acquisition/update_link 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97297 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCustomerAcquisitionUpdateLinkResponse> ExecuteCgibinExternalContactCustomerAcquisitionUpdateLinkAsync(this WechatWorkClient client, Models.CgibinExternalContactCustomerAcquisitionUpdateLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "customer_acquisition", "update_link")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCustomerAcquisitionUpdateLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/customer_acquisition/delete_link 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97297 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCustomerAcquisitionDeleteLinkResponse> ExecuteCgibinExternalContactCustomerAcquisitionDeleteLinkAsync(this WechatWorkClient client, Models.CgibinExternalContactCustomerAcquisitionDeleteLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "customer_acquisition", "delete_link")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCustomerAcquisitionDeleteLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/customer_acquisition/customer 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97298 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCustomerAcquisitionCustomerResponse> ExecuteCgibinExternalContactCustomerAcquisitionCustomerAsync(this WechatWorkClient client, Models.CgibinExternalContactCustomerAcquisitionCustomerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "customer_acquisition", "customer")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCustomerAcquisitionCustomerResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/customer_acquisition_quota 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97375 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCustomerAcquisitionQuotaResponse> ExecuteCgibinExternalContactCustomerAcquisitionQuotaAsync(this WechatWorkClient client, Models.CgibinExternalContactCustomerAcquisitionQuotaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "customer_acquisition_quota")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCustomerAcquisitionQuotaResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/externalcontact/customer_acquisition/statistic 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97375 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/99483 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCustomerAcquisitionStatisticResponse> ExecuteCgibinExternalContactCustomerAcquisitionStatisticAsync(this WechatWorkClient client, Models.CgibinExternalContactCustomerAcquisitionStatisticRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "externalcontact", "customer_acquisition", "statistic")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("link_id", request.LinkId)
                .SetQueryParam("start_time", request.StartTimestamp)
                .SetQueryParam("end_time", request.EndTimestamp);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCustomerAcquisitionStatisticResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region CustomerStrategy
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/customer_strategy/list 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90000/90135/94883 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCustomerStrategyListResponse> ExecuteCgibinExternalContactCustomerStrategyListAsync(this WechatWorkClient client, Models.CgibinExternalContactCustomerStrategyListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "customer_strategy", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCustomerStrategyListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/customer_strategy/get 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90000/90135/94883 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCustomerStrategyGetResponse> ExecuteCgibinExternalContactCustomerStrategyGetAsync(this WechatWorkClient client, Models.CgibinExternalContactCustomerStrategyGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "customer_strategy", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCustomerStrategyGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/customer_strategy/get_range 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90000/90135/94883 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCustomerStrategyGetRangeResponse> ExecuteCgibinExternalContactCustomerStrategyGetRangeAsync(this WechatWorkClient client, Models.CgibinExternalContactCustomerStrategyGetRangeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "customer_strategy", "get_range")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCustomerStrategyGetRangeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/customer_strategy/create 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90000/90135/94883 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCustomerStrategyCreateResponse> ExecuteCgibinExternalContactCustomerStrategyCreateAsync(this WechatWorkClient client, Models.CgibinExternalContactCustomerStrategyCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "customer_strategy", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCustomerStrategyCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/customer_strategy/edit 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90000/90135/94883 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCustomerStrategyEditResponse> ExecuteCgibinExternalContactCustomerStrategyEditAsync(this WechatWorkClient client, Models.CgibinExternalContactCustomerStrategyEditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "customer_strategy", "edit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCustomerStrategyEditResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/customer_strategy/del 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90000/90135/94883 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCustomerStrategyDeleteResponse> ExecuteCgibinExternalContactCustomerStrategyDeleteAsync(this WechatWorkClient client, Models.CgibinExternalContactCustomerStrategyDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "customer_strategy", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCustomerStrategyDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region InterceptRule
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/add_intercept_rule 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95097 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95130 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactAddInterceptRuleResponse> ExecuteCgibinExternalContactAddInterceptRuleAsync(this WechatWorkClient client, Models.CgibinExternalContactAddInterceptRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "add_intercept_rule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactAddInterceptRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/externalcontact/get_intercept_rule_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95097 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95130 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetInterceptRuleListResponse> ExecuteCgibinExternalContactGetInterceptRuleListAsync(this WechatWorkClient client, Models.CgibinExternalContactGetInterceptRuleListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "externalcontact", "get_intercept_rule_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetInterceptRuleListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_intercept_rule 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95097 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95130 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetInterceptRuleResponse> ExecuteCgibinExternalContactGetInterceptRuleAsync(this WechatWorkClient client, Models.CgibinExternalContactGetInterceptRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_intercept_rule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetInterceptRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/update_intercept_rule 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95097 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95130 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactUpdateInterceptRuleResponse> ExecuteCgibinExternalContactUpdateInterceptRuleAsync(this WechatWorkClient client, Models.CgibinExternalContactUpdateInterceptRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "update_intercept_rule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactUpdateInterceptRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/del_intercept_rule 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95097 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95130 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactDeleteInterceptRuleResponse> ExecuteCgibinExternalContactDeleteInterceptRuleAsync(this WechatWorkClient client, Models.CgibinExternalContactDeleteInterceptRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "del_intercept_rule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactDeleteInterceptRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region GroupChat
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/groupchat/transfer 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92127 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93242 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupChatTransferResponse> ExecuteCgibinExternalContactGroupChatTransferAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupChatTransferRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "groupchat", "transfer")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGroupChatTransferResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/groupchat/onjob_transfer 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95703 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupChatOnJobTransferResponse> ExecuteCgibinExternalContactGroupChatOnJobTransferAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupChatOnJobTransferRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "groupchat", "onjob_transfer")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGroupChatOnJobTransferResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/groupchat/list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92120 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93414 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupChatListResponse> ExecuteCgibinExternalContactGroupChatListAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupChatListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "groupchat", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGroupChatListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/groupchat/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92122 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92707 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupChatGetResponse> ExecuteCgibinExternalContactGroupChatGetAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupChatGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "groupchat", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGroupChatGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region GroupChatStatistics
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/groupchat/statistic 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92133 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93476 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupChatStatisticsResponse> ExecuteCgibinExternalContactGroupChatStatisticsAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupChatStatisticsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "groupchat", "statistic")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGroupChatStatisticsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/groupchat/statistic_group_by_day 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92133 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93476 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupChatStatisticsGroupByDayResponse> ExecuteCgibinExternalContactGroupChatStatisticsGroupByDayAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupChatStatisticsGroupByDayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "groupchat", "statistic_group_by_day")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGroupChatStatisticsGroupByDayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region JoinWay
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/groupchat/add_join_way 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92229 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupChatAddJoinWayResponse> ExecuteCgibinExternalContactGroupChatAddJoinWayAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupChatAddJoinWayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "groupchat", "add_join_way")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGroupChatAddJoinWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/groupchat/get_join_way 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92229 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupChatGetJoinWayResponse> ExecuteCgibinExternalContactGroupChatGetJoinWayAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupChatGetJoinWayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "groupchat", "get_join_way")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGroupChatGetJoinWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/groupchat/update_join_way 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92229 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupChatUpdateJoinWayResponse> ExecuteCgibinExternalContactGroupChatUpdateJoinWayAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupChatUpdateJoinWayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "groupchat", "update_join_way")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGroupChatUpdateJoinWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/groupchat/del_join_way 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92229 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupChatDeleteJoinWayResponse> ExecuteCgibinExternalContactGroupChatDeleteJoinWayAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupChatDeleteJoinWayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "groupchat", "del_join_way")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGroupChatDeleteJoinWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region GroupMessage
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/add_msg_template 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92135 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92698 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactAddMessageTemplateResponse> ExecuteCgibinExternalContactAddMessageTemplateAsync(this WechatWorkClient client, Models.CgibinExternalContactAddMessageTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "add_msg_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactAddMessageTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_groupmsg_list_v2 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93338 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93439 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetGroupMessageListV2Response> ExecuteCgibinExternalContactGetGroupMessageListV2Async(this WechatWorkClient client, Models.CgibinExternalContactGetGroupMessageListV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_groupmsg_list_v2")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetGroupMessageListV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_groupmsg_task 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93338 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93439 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetGroupMessageTaskResponse> ExecuteCgibinExternalContactGetGroupMessageTaskAsync(this WechatWorkClient client, Models.CgibinExternalContactGetGroupMessageTaskRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_groupmsg_task")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetGroupMessageTaskResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_groupmsg_send_result 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93338 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93439 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetGroupMessageSendResultResponse> ExecuteCgibinExternalContactGetGroupMessageSendResultAsync(this WechatWorkClient client, Models.CgibinExternalContactGetGroupMessageSendResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_groupmsg_send_result")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetGroupMessageSendResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region GroupWelcome
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/send_welcome_msg 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92137 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92599 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactSendWelcomeMessageResponse> ExecuteCgibinExternalContactSendWelcomeMessageAsync(this WechatWorkClient client, Models.CgibinExternalContactSendWelcomeMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "send_welcome_msg")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactSendWelcomeMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/remind_groupmsg_send 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97610 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactRemindGroupMessageSendResponse> ExecuteCgibinExternalContactRemindGroupMessageSendAsync(this WechatWorkClient client, Models.CgibinExternalContactRemindGroupMessageSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "remind_groupmsg_send")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactRemindGroupMessageSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/cancel_groupmsg_send 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97611 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCancelGroupMessageSendResponse> ExecuteCgibinExternalContactCancelGroupMessageSendAsync(this WechatWorkClient client, Models.CgibinExternalContactCancelGroupMessageSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "cancel_groupmsg_send")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCancelGroupMessageSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/group_welcome_template/add 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92366 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93438 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupWelcomeTemplateAddResponse> ExecuteCgibinExternalContactGroupWelcomeTemplateAddAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupWelcomeTemplateAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "group_welcome_template", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGroupWelcomeTemplateAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/group_welcome_template/edit 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92366 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93438 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupWelcomeTemplateEditResponse> ExecuteCgibinExternalContactGroupWelcomeTemplateEditAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupWelcomeTemplateEditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "group_welcome_template", "edit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGroupWelcomeTemplateEditResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/group_welcome_template/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92366 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93438 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupWelcomeTemplateGetResponse> ExecuteCgibinExternalContactGroupWelcomeTemplateGetAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupWelcomeTemplateGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "group_welcome_template", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGroupWelcomeTemplateGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/group_welcome_template/del 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92366 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93438 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupWelcomeTemplateDeleteResponse> ExecuteCgibinExternalContactGroupWelcomeTemplateDeleteAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupWelcomeTemplateDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "group_welcome_template", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGroupWelcomeTemplateDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Message
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/message/send 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/91609 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92321 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92291 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactMessageSendResponse> ExecuteCgibinExternalContactMessageSendAsync(this WechatWorkClient client, Models.CgibinExternalContactMessageSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId is null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "message", "send")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactMessageSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Migration
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_new_external_userid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95327 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95435 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetNewExternalUserIdResponse> ExecuteCgibinExternalContactGetNewExternalUserIdAsync(this WechatWorkClient client, Models.CgibinExternalContactGetNewExternalUserIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_new_external_userid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetNewExternalUserIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/groupchat/get_new_external_userid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95327 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95435 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupChatGetNewExternalUserIdResponse> ExecuteCgibinExternalContactGroupChatGetNewExternalUserIdAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupChatGetNewExternalUserIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "groupchat", "get_new_external_userid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGroupChatGetNewExternalUserIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Moment
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_moment_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93333 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93443 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetMomentListResponse> ExecuteCgibinExternalContactGetMomentListAsync(this WechatWorkClient client, Models.CgibinExternalContactGetMomentListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_moment_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetMomentListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/add_moment_task 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95094 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95095 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactAddMomentTaskResponse> ExecuteCgibinExternalContactAddMomentTaskAsync(this WechatWorkClient client, Models.CgibinExternalContactAddMomentTaskRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "add_moment_task")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactAddMomentTaskResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/cancel_moment_task 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/97612 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactCancelMomentTaskResponse> ExecuteCgibinExternalContactCancelMomentTaskAsync(this WechatWorkClient client, Models.CgibinExternalContactCancelMomentTaskRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "cancel_moment_task")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactCancelMomentTaskResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_moment_task 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93333 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93443 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetMomentTaskResponse> ExecuteCgibinExternalContactGetMomentTaskAsync(this WechatWorkClient client, Models.CgibinExternalContactGetMomentTaskRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_moment_task")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetMomentTaskResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_moment_task_result 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95094 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95095 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetMomentTaskResultResponse> ExecuteCgibinExternalContactGetMomentTaskResultAsync(this WechatWorkClient client, Models.CgibinExternalContactGetMomentTaskResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_moment_task_result")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetMomentTaskResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_moment_customer_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93333 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93443 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetMomentCustomerListResponse> ExecuteCgibinExternalContactGetMomentCustomerListAsync(this WechatWorkClient client, Models.CgibinExternalContactGetMomentCustomerListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_moment_customer_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetMomentCustomerListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_moment_send_result 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93333 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93443 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetMomentSendResultResponse> ExecuteCgibinExternalContactGetMomentSendResultAsync(this WechatWorkClient client, Models.CgibinExternalContactGetMomentSendResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_moment_send_result")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetMomentSendResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_moment_comments 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93333 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93443 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetMomentCommentsResponse> ExecuteCgibinExternalContactGetMomentCommentsAsync(this WechatWorkClient client, Models.CgibinExternalContactGetMomentCommentsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_moment_comments")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetMomentCommentsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region MomentStrategy
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/moment_strategy/list 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90000/90135/94890 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactMomentStrategyListResponse> ExecuteCgibinExternalContactMomentStrategyListAsync(this WechatWorkClient client, Models.CgibinExternalContactMomentStrategyListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "moment_strategy", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactMomentStrategyListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/moment_strategy/get 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90000/90135/94883 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactMomentStrategyGetResponse> ExecuteCgibinExternalContactMomentStrategyGetAsync(this WechatWorkClient client, Models.CgibinExternalContactMomentStrategyGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "moment_strategy", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactMomentStrategyGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/moment_strategy/get_range 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90000/90135/94890 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactMomentStrategyGetRangeResponse> ExecuteCgibinExternalContactMomentStrategyGetRangeAsync(this WechatWorkClient client, Models.CgibinExternalContactMomentStrategyGetRangeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "moment_strategy", "get_range")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactMomentStrategyGetRangeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/moment_strategy/create 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90000/90135/94890 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactMomentStrategyCreateResponse> ExecuteCgibinExternalContactMomentStrategyCreateAsync(this WechatWorkClient client, Models.CgibinExternalContactMomentStrategyCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "moment_strategy", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactMomentStrategyCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/moment_strategy/edit 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90000/90135/94883 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactMomentStrategyEditResponse> ExecuteCgibinExternalContactMomentStrategyEditAsync(this WechatWorkClient client, Models.CgibinExternalContactMomentStrategyEditRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "moment_strategy", "edit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactMomentStrategyEditResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/moment_strategy/del 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90000/90135/94883 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactMomentStrategyDeleteResponse> ExecuteCgibinExternalContactMomentStrategyDeleteAsync(this WechatWorkClient client, Models.CgibinExternalContactMomentStrategyDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "moment_strategy", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactMomentStrategyDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ProductAlbum
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/add_product_album 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95096 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95131 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactAddProductAlbumResponse> ExecuteCgibinExternalContactAddProductAlbumAsync(this WechatWorkClient client, Models.CgibinExternalContactAddProductAlbumRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "add_product_album")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactAddProductAlbumResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_product_album_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95096 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95131 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetProductAlbumListResponse> ExecuteCgibinExternalContactGetProductAlbumListAsync(this WechatWorkClient client, Models.CgibinExternalContactGetProductAlbumListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_product_album_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetProductAlbumListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_product_album 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95096 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95131 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetProductAlbumResponse> ExecuteCgibinExternalContactGetProductAlbumAsync(this WechatWorkClient client, Models.CgibinExternalContactGetProductAlbumRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_product_album")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetProductAlbumResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/update_product_album 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95096 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95131 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactUpdateProductAlbumResponse> ExecuteCgibinExternalContactUpdateProductAlbumAsync(this WechatWorkClient client, Models.CgibinExternalContactUpdateProductAlbumRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "update_product_album")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactUpdateProductAlbumResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/delete_product_album 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95096 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95131 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactDeleteProductAlbumResponse> ExecuteCgibinExternalContactDeleteProductAlbumAsync(this WechatWorkClient client, Models.CgibinExternalContactDeleteProductAlbumRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "delete_product_album")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactDeleteProductAlbumResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Subscribe
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/externalcontact/get_subscribe_qr_code 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92320 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92197 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetSubscribeQrcodeResponse> ExecuteCgibinExternalContactGetSubscribeQrcodeAsync(this WechatWorkClient client, Models.CgibinExternalContactGetSubscribeQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "externalcontact", "get_subscribe_qr_code")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetSubscribeQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/set_subscribe_mode 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92318 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92290 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactSetSubscribeModeResponse> ExecuteCgibinExternalContactSetSubscribeModeAsync(this WechatWorkClient client, Models.CgibinExternalContactSetSubscribeModeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "set_subscribe_mode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactSetSubscribeModeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/externalcontact/get_subscribe_mode 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92318 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92290 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetSubscribeModeResponse> ExecuteCgibinExternalContactGetSubscribeModeAsync(this WechatWorkClient client, Models.CgibinExternalContactGetSubscribeModeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "externalcontact", "get_subscribe_mode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetSubscribeModeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region StrategyTag
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_strategy_tag_list 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90000/90135/94882 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGetStrategyTagListResponse> ExecuteCgibinExternalContactGetStrategyTagListAsync(this WechatWorkClient client, Models.CgibinExternalContactGetStrategyTagListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "get_strategy_tag_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactGetStrategyTagListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/add_strategy_tag 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90000/90135/94882 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactAddStrategyTagResponse> ExecuteCgibinExternalContactAddStrategyTagAsync(this WechatWorkClient client, Models.CgibinExternalContactAddStrategyTagRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "add_strategy_tag")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactAddStrategyTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/edit_strategy_tag 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90000/90135/94882 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactEditStrategyTagResponse> ExecuteCgibinExternalContactEditStrategyTagAsync(this WechatWorkClient client, Models.CgibinExternalContactEditStrategyTagRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "edit_strategy_tag")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactEditStrategyTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/del_strategy_tag 接口。</para>
        /// <para>REF: https://work.weixin.qq.com/api/doc/90000/90135/94882 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactDeleteStrategyTagResponse> ExecuteCgibinExternalContactDeleteStrategyTagAsync(this WechatWorkClient client, Models.CgibinExternalContactDeleteStrategyTagRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "del_strategy_tag")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactDeleteStrategyTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Transfer
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/transfer_customer 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92125 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94096 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactTransferCustomerResponse> ExecuteCgibinExternalContactTransferCustomerAsync(this WechatWorkClient client, Models.CgibinExternalContactTransferCustomerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "transfer_customer")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactTransferCustomerResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/transfer_result 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94088 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94097 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactTransferResultResponse> ExecuteCgibinExternalContactTransferResultAsync(this WechatWorkClient client, Models.CgibinExternalContactTransferResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "transfer_result")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactTransferResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/resigned/transfer_customer 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94081 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94100 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactResignedTransferCustomerResponse> ExecuteCgibinExternalContactResignedTransferCustomerAsync(this WechatWorkClient client, Models.CgibinExternalContactResignedTransferCustomerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "resigned", "transfer_customer")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactResignedTransferCustomerResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/resigned/transfer_result 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94082 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94101 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactResignedTransferResultResponse> ExecuteCgibinExternalContactResignedTransferResultAsync(this WechatWorkClient client, Models.CgibinExternalContactResignedTransferResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "externalcontact", "resigned", "transfer_result")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinExternalContactResignedTransferResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
