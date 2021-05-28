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
    public static class WechatApiClientExecuteCgibinTagsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tags/create 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/User_Management/User_Tag_Management.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagsCreateResponse> ExecuteCgibinTagsCreateAsync(this WechatApiClient client, Models.CgibinTagsCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "tags", "create")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagsCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/tags/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/User_Management/User_Tag_Management.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagsGetResponse> ExecuteCgibinTagsGetAsync(this WechatApiClient client, Models.CgibinTagsGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "tags", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.CgibinTagsGetResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tags/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/User_Management/User_Tag_Management.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagsUpdateResponse> ExecuteCgibinTagsUpdateAsync(this WechatApiClient client, Models.CgibinTagsUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "tags", "update")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagsUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tags/delete 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/User_Management/User_Tag_Management.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagsDeleteResponse> ExecuteCgibinTagsDeleteAsync(this WechatApiClient client, Models.CgibinTagsDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "tags", "delete")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagsDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/user/tag/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/User_Management/User_Tag_Management.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinUserTagGetResponse> ExecuteCgibinUserTagGetAsync(this WechatApiClient client, Models.CgibinUserTagGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "user", "tag", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinUserTagGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Members
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tags/members/batchtagging 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/User_Management/User_Tag_Management.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagsMembersBatchTaggingResponse> ExecuteCgibinTagsMembersBatchTaggingAsync(this WechatApiClient client, Models.CgibinTagsMembersBatchTaggingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "tags", "members", "batchtagging")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagsMembersBatchTaggingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tags/members/batchuntagging 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/User_Management/User_Tag_Management.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagsMembersBatchUntaggingResponse> ExecuteCgibinTagsMembersBatchUntaggingAsync(this WechatApiClient client, Models.CgibinTagsMembersBatchUntaggingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "tags", "members", "batchuntagging")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagsMembersBatchUntaggingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tags/getidlist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/User_Management/User_Tag_Management.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagsGetIdListResponse> ExecuteCgibinTagsGetIdListAsync(this WechatApiClient client, Models.CgibinTagsGetIdListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "tags", "getidlist")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagsGetIdListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region MembersBlackList
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tags/members/getblacklist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/User_Management/Manage_blacklist.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagsMembersGetBlackListResponse> ExecuteCgibinTagsMembersGetBlackListAsync(this WechatApiClient client, Models.CgibinTagsMembersGetBlackListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "tags", "members", "getblacklist")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagsMembersGetBlackListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tags/members/batchblacklist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/User_Management/Manage_blacklist.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagsMembersBatchBlackListResponse> ExecuteCgibinTagsMembersBatchBlackListAsync(this WechatApiClient client, Models.CgibinTagsMembersBatchBlackListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "tags", "members", "batchblacklist")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagsMembersBatchBlackListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tags/members/batchunblacklist 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/User_Management/Manage_blacklist.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagsMembersBatchUnblackListResponse> ExecuteCgibinTagsMembersBatchUnblackListAsync(this WechatApiClient client, Models.CgibinTagsMembersBatchUnblackListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "tags", "members", "batchunblacklist")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagsMembersBatchUnblackListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
