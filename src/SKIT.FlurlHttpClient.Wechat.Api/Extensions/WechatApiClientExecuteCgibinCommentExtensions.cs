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
    public static class WechatApiClientExecuteCgibinCommentExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/comment/open 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Comments_management/Image_Comments_Management_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCommentOpenResponse> ExecuteCgibinCommentOpenAsync(this WechatApiClient client, Models.CgibinCommentOpenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "comment", "open")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCommentOpenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/comment/close 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Comments_management/Image_Comments_Management_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCommentCloseResponse> ExecuteCgibinCommentCloseAsync(this WechatApiClient client, Models.CgibinCommentCloseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "comment", "close")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCommentCloseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/comment/list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Comments_management/Image_Comments_Management_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCommentListResponse> ExecuteCgibinCommentListAsync(this WechatApiClient client, Models.CgibinCommentListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "comment", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCommentListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/comment/markelect 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Comments_management/Image_Comments_Management_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCommentMarkElectResponse> ExecuteCgibinCommentMarkElectAsync(this WechatApiClient client, Models.CgibinCommentMarkElectRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "comment", "markelect")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCommentMarkElectResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/comment/unmarkelect 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Comments_management/Image_Comments_Management_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCommentUnmarkElectResponse> ExecuteCgibinCommentUnmarkElectAsync(this WechatApiClient client, Models.CgibinCommentUnmarkElectRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "comment", "unmarkelect")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCommentUnmarkElectResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/comment/delete 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Comments_management/Image_Comments_Management_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCommentDeleteResponse> ExecuteCgibinCommentDeleteAsync(this WechatApiClient client, Models.CgibinCommentDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "comment", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCommentDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Reply
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/comment/reply/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Comments_management/Image_Comments_Management_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCommentReplyAddResponse> ExecuteCgibinCommentReplyAddAsync(this WechatApiClient client, Models.CgibinCommentReplyAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "comment", "reply", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCommentReplyAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/comment/reply/delete 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Comments_management/Image_Comments_Management_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCommentReplyDeleteResponse> ExecuteCgibinCommentReplyDeleteAsync(this WechatApiClient client, Models.CgibinCommentReplyDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "comment", "reply", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCommentReplyDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
