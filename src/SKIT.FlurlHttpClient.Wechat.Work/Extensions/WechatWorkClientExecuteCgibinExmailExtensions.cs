using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinExmailExtensions
    {
        #region Group
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/exmail/group/create 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95510 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExmailGroupCreateResponse> ExecuteCgibinExmailGroupCreateAsync(this WechatWorkClient client, Models.CgibinExmailGroupCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "exmail", "group", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExmailGroupCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/exmail/group/update 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95510 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExmailGroupUpdateResponse> ExecuteCgibinExmailGroupUpdateAsync(this WechatWorkClient client, Models.CgibinExmailGroupUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "exmail", "group", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExmailGroupUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/exmail/group/delete 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95510 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExmailGroupDeleteResponse> ExecuteCgibinExmailGroupDeleteAsync(this WechatWorkClient client, Models.CgibinExmailGroupDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "exmail", "group", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExmailGroupDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/exmail/group/search 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95510 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExmailGroupSearchResponse> ExecuteCgibinExmailGroupSearchAsync(this WechatWorkClient client, Models.CgibinExmailGroupSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "exmail", "group", "search")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("fuzzy", request.IsFuzzy ? 1 : 0);

            if (request.GroupId != null)
                flurlReq.SetQueryParam("groupid", request.GroupId);

            return await client.SendRequestWithJsonAsync<Models.CgibinExmailGroupSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/exmail/group/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95510 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExmailGroupGetResponse> ExecuteCgibinExmailGroupGetAsync(this WechatWorkClient client, Models.CgibinExmailGroupGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "exmail", "group", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("groupid", request.GroupId);

            return await client.SendRequestWithJsonAsync<Models.CgibinExmailGroupGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
