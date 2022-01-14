using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinFreePublishExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/freepublish/submit 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Publish/Publish.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinFreePublishSubmitResponse> ExecuteCgibinFreePublishSubmitAsync(this WechatApiClient client, Models.CgibinFreePublishSubmitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "freepublish", "submit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinFreePublishSubmitResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/freepublish/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Publish/Get_status.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinFreePublishGetResponse> ExecuteCgibinFreePublishGetAsync(this WechatApiClient client, Models.CgibinFreePublishGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "freepublish", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinFreePublishGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/freepublish/delete 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Publish/Delete_posts.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinFreePublishDeleteResponse> ExecuteCgibinFreePublishDeleteAsync(this WechatApiClient client, Models.CgibinFreePublishDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "freepublish", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinFreePublishDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/freepublish/getarticle 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Publish/Get_article_from_id.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinFreePublishGetArticleResponse> ExecuteCgibinFreePublishGetArticleAsync(this WechatApiClient client, Models.CgibinFreePublishGetArticleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "freepublish", "getarticle")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinFreePublishGetArticleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/freepublish/batchget 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Publish/Get_publication_records.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinFreePublishBatchGetResponse> ExecuteCgibinFreePublishBatchGetAsync(this WechatApiClient client, Models.CgibinFreePublishBatchGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "freepublish", "batchget")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinFreePublishBatchGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
