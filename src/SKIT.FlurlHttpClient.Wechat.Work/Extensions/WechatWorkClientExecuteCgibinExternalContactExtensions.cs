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
    public static class WechatWorkClientExecuteCgibinExternalContactExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/externalcontact/get_follow_user_list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92571 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92576 </para>
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
                .CreateRequest(HttpMethod.Get, "cgi-bin", "externalcontact", "get_follow_user_list")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.CgibinExternalContactGetFollowUserListResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/close_temp_chat 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92572 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92577 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "close_temp_chat")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactCloseTempChatResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/externalcontact/list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92113 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92264 </para>
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
                .CreateRequest(HttpMethod.Get, "cgi-bin", "externalcontact", "list")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("userid", request.UserId);

            return await client.SendRequestAsync<Models.CgibinExternalContactListResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/externalcontact/get 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92114 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92265 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92322 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/91670 </para>
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
                .CreateRequest(HttpMethod.Get, "cgi-bin", "externalcontact", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("external_userid", request.ExternalUserId);

            if (!string.IsNullOrEmpty(request.NextCursor))
                request.NextCursor = request.NextCursor;

            return await client.SendRequestAsync<Models.CgibinExternalContactGetResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/batch/get_by_user 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92115 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93010 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "batch", "get_by_user")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactBatchGetByUserResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/remark 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92994 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92694 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "remark")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactRemarkResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/mark_tag 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92118 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92697 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "mark_tag")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactMarkTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_unassigned_list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92124 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92273 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "get_unassigned_list")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGetUnassignedListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_user_behavior_data 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92132 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92275 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "get_user_behavior_data")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGetUserBehaviorDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/unionid_to_external_userid 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93274 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "unionid_to_external_userid")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactUnionIdToExternalUserIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/convert_to_openid 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92323 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92292 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "convert_to_openid")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactConvertToOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/batch_to_external_userid 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92506 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "batch_to_external_userid")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactBatchToExternalUserIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region ContactWay
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/add_contact_way 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92572 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92577 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "add_contact_way")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactAddContactWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_contact_way 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92572 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92577 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "get_contact_way")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGetContactWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/update_contact_way 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92572 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92577 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "update_contact_way")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactUpdateContactWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/del_contact_way 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92572 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92577 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "del_contact_way")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactDeleteContactWayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region CorpTag
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_corp_tag_list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92117 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92696 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "get_corp_tag_list")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGetCorpTagListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/add_corp_tag 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92117 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92696 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "add_corp_tag")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactAddCorpTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/edit_corp_tag 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92117 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92696 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "edit_corp_tag")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactEditCorpTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/del_corp_tag 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92117 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92696 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "del_corp_tag")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactDeleteCorpTagResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Transfer
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/transfer_customer 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92125 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94096 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "transfer_customer")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactTransferCustomerResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/transfer_result 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94088 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94097 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "transfer_result")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactTransferResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/resigned/transfer_customer 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94081 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94100 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "resigned", "transfer_customer")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactResignedTransferCustomerResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/transfer_result 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/94082 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/94101 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "resigned", "transfer_result")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactResignedTransferResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region GroupChat
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/groupchat/transfer 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92127 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93242 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "groupchat", "transfer")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGroupChatTransferResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/groupchat/list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92120 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93414 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "groupchat", "list")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGroupChatListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/groupchat/get 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92122 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92707 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "groupchat", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGroupChatGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region GroupChatStatistic
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/groupchat/statistic 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92133 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93476 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupChatStatisticResponse> ExecuteCgibinExternalContactGroupChatStatisticAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupChatStatisticRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "groupchat", "statistic")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGroupChatStatisticResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/groupchat/statistic_group_by_day 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92133 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93476 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactGroupChatStatisticGroupByDayResponse> ExecuteCgibinExternalContactGroupChatStatisticGroupByDayAsync(this WechatWorkClient client, Models.CgibinExternalContactGroupChatStatisticGroupByDayRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "groupchat", "statistic_group_by_day")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGroupChatStatisticGroupByDayResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        #endregion

        #region Moment
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_moment_list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93333 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93443 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "get_moment_list")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGetMomentListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_moment_task 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93333 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93443 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "get_moment_task")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGetMomentTaskResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_moment_customer_list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93333 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93443 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "get_moment_customer_list")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGetMomentCustomerListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_moment_send_result 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93333 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93443 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "get_moment_send_result")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGetMomentSendResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_moment_comments 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93333 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93443 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "get_moment_comments")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGetMomentCommentsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region GroupMessage
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/add_msg_template 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92135 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92698 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "add_msg_template")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactAddMessageTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_groupmsg_list_v2 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93338 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93439 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "get_groupmsg_list_v2")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGetGroupMessageListV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_groupmsg_task 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93338 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93439 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "get_groupmsg_task")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGetGroupMessageTaskResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/get_groupmsg_send_result 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93338 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93439 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "get_groupmsg_send_result")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGetGroupMessageSendResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region GroupWelcome
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/send_welcome_msg 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92137 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92599 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "send_welcome_msg")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactSendWelcomeMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/group_welcome_template/add 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92366 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93438 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "group_welcome_template", "add")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGroupWelcomeTemplateAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/group_welcome_template/edit 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92366 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93438 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "group_welcome_template", "edit")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGroupWelcomeTemplateEditResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/group_welcome_template/get 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92366 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93438 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "group_welcome_template", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGroupWelcomeTemplateGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/group_welcome_template/del 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92366 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/93438 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "group_welcome_template", "del")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactGroupWelcomeTemplateDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Message
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/message/send 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/91609 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92321 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92291 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExternalContactMessageSendResponse> ExecuteCgibinExternalContactMessageSendAsync(this WechatWorkClient client, Models.CgibinExternalContactMessageSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (!request.AgentId.HasValue)
                request.AgentId = client.AgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "message", "send")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactMessageSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Subscribe
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/externalcontact/get_subscribe_qr_code 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92320 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92197 </para>
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
                .CreateRequest(HttpMethod.Get, "cgi-bin", "externalcontact", "message", "get_subscribe_qr_code")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.CgibinExternalContactGetSubscribeQrcodeResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/externalcontact/set_subscribe_mode 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92318 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92290 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "externalcontact", "message", "set_subscribe_mode")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExternalContactSetSubscribeModeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/externalcontact/get_subscribe_mode 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/92318 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92290 </para>
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
                .CreateRequest(HttpMethod.Get, "cgi-bin", "externalcontact", "message", "get_subscribe_mode")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.CgibinExternalContactGetSubscribeModeResponse>(flurlReq, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
