using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinTagExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tag/create 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90210 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90346 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90829 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagCreateResponse> ExecuteCgibinTagCreateAsync(this WechatWorkClient client, Models.CgibinTagCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "tag", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tag/update 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90211 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90347 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90830 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagUpdateResponse> ExecuteCgibinTagUpdateAsync(this WechatWorkClient client, Models.CgibinTagUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "tag", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/tag/delete 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90212 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90348 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90831 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagDeleteResponse> ExecuteCgibinTagDeleteAsync(this WechatWorkClient client, Models.CgibinTagDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "tag", "delete")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("tagid", request.TagId);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagDeleteResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/tag/list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90216 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90352 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90835 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagListResponse> ExecuteCgibinTagListAsync(this WechatWorkClient client, Models.CgibinTagListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "tag", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagListResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/tag/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90213 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90349 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90832 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagGetResponse> ExecuteCgibinTagGetAsync(this WechatWorkClient client, Models.CgibinTagGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "tag", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("tagid", request.TagId);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagGetResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        #region TagUser
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tag/addtagusers 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90214 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90350 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90833 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagAddTagUsersResponse> ExecuteCgibinTagAddTagUsersAsync(this WechatWorkClient client, Models.CgibinTagAddTagUsersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "tag", "addtagusers")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagAddTagUsersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tag/deltagusers 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90215 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90351 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90834 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTagDeleteTagUsersResponse> ExecuteCgibinTagDeleteTagUsersAsync(this WechatWorkClient client, Models.CgibinTagDeleteTagUsersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "tag", "deltagusers")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagDeleteTagUsersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
