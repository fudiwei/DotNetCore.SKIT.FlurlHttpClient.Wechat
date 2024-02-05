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
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90210 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90346 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90829 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "tag", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinTagCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tag/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90211 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90347 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90830 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "tag", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinTagUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/tag/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90212 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90348 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90831 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "tag", "delete")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("tagid", request.TagId);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinTagDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/tag/list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90216 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90352 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90835 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "tag", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinTagListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/tag/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90213 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90349 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90832 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "tag", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("tagid", request.TagId);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinTagGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region TagUser
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tag/addtagusers 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90214 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90350 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90833 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "tag", "addtagusers")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinTagAddTagUsersResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/tag/deltagusers 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90215 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90351 ]]> <br/>
        /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90834 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "tag", "deltagusers")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinTagDeleteTagUsersResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
