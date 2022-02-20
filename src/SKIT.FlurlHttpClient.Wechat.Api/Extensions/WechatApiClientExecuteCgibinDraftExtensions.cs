﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinDraftExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/draft/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Draft_Box/Add_draft.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDraftAddResponse> ExecuteCgibinDraftAddAsync(this WechatApiClient client, Models.CgibinDraftAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "draft", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinDraftAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/draft/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Draft_Box/Add_draft.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDraftGetResponse> ExecuteCgibinDraftGetAsync(this WechatApiClient client, Models.CgibinDraftGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "draft", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinDraftGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/draft/delete 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Draft_Box/Delete_draft.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDraftDeleteResponse> ExecuteCgibinDraftDeleteAsync(this WechatApiClient client, Models.CgibinDraftDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "draft", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinDraftDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/draft/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Draft_Box/Update_draft.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDraftUpdateResponse> ExecuteCgibinDraftUpdateAsync(this WechatApiClient client, Models.CgibinDraftUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "draft", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinDraftUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/draft/count 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Draft_Box/Count_drafts.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDraftCountResponse> ExecuteCgibinDraftCountAsync(this WechatApiClient client, Models.CgibinDraftCountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "draft", "count")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinDraftCountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/draft/batchget 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Draft_Box/Get_draft_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinDraftBatchGetResponse> ExecuteCgibinDraftBatchGetAsync(this WechatApiClient client, Models.CgibinDraftBatchGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "draft", "batchget")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinDraftBatchGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/draft/switch 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Draft_Box/Temporary_MP_Switch.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2022-02-25 下线。")]
        public static async Task<Models.CgibinDraftSwitchResponse> ExecuteCgibinDraftSwitchAsync(this WechatApiClient client, Models.CgibinDraftSwitchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "draft", "switch")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.OnlyCheck != null)
                flurlReq.SetQueryParam("checkonly", request.OnlyCheck.Value ? 1 : 0);

            return await client.SendRequestWithJsonAsync<Models.CgibinDraftSwitchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
