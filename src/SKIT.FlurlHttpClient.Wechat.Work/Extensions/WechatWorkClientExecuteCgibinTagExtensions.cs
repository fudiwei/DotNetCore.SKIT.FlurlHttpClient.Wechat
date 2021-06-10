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
    public static class WechatWorkClientExecuteCgibinTagExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tag/create 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90210 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90346 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90829 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "tag", "create")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tag/update 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90211 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90347 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90830 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "tag", "update")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/tag/delete 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90212 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90348 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90831 </para>
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
                .CreateRequest(HttpMethod.Get, "cgi-bin", "tag", "delete")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("tagid", request.TagId);

            return await client.SendRequestAsync<Models.CgibinTagDeleteResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/tag/list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90216 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90352 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90835 </para>
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
                .CreateRequest(HttpMethod.Get, "cgi-bin", "tag", "list")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.CgibinTagListResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/tag/get 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90213 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90349 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90832 </para>
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
                .CreateRequest(HttpMethod.Get, "cgi-bin", "tag", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("tagid", request.TagId);

            return await client.SendRequestAsync<Models.CgibinTagGetResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        #region TagUser
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tag/addtagusers 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90214 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90350 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90833 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "tag", "addtagusers")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagAddTagUsersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tag/deltagusers 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90215 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90351 </para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90834 </para>
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
                .CreateRequest(HttpMethod.Post, "cgi-bin", "tag", "deltagusers")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinTagDeleteTagUsersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
