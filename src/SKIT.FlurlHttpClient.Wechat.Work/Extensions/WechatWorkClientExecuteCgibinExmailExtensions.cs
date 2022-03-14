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

        #region PublicMail
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/exmail/publicmail/create 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95511 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExmailPublicMailCreateResponse> ExecuteCgibinExmailPublicMailCreateAsync(this WechatWorkClient client, Models.CgibinExmailPublicMailCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "exmail", "publicmail", "create")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExmailPublicMailCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/exmail/publicmail/update 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95511 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExmailPublicMailUpdateResponse> ExecuteCgibinExmailPublicMailUpdateAsync(this WechatWorkClient client, Models.CgibinExmailPublicMailUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "exmail", "publicmail", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExmailPublicMailUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/exmail/publicmail/delete 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95511 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExmailPublicMailDeleteResponse> ExecuteCgibinExmailPublicMailDeleteAsync(this WechatWorkClient client, Models.CgibinExmailPublicMailDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "exmail", "publicmail", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExmailPublicMailDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/exmail/publicmail/search 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95510 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExmailPublicMailSearchResponse> ExecuteCgibinExmailPublicMailSearchAsync(this WechatWorkClient client, Models.CgibinExmailPublicMailSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "exmail", "publicmail", "search")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("fuzzy", request.IsFuzzy ? 1 : 0);

            if (request.EmailOrName != null)
                flurlReq.SetQueryParam("email", request.EmailOrName);

            return await client.SendRequestWithJsonAsync<Models.CgibinExmailPublicMailSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/exmail/publicmail/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95510 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExmailPublicMailGetResponse> ExecuteCgibinExmailPublicMailGetAsync(this WechatWorkClient client, Models.CgibinExmailPublicMailGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "exmail", "publicmail", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExmailPublicMailGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        
        #region Account
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/exmail/account/act_email 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95512 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExmailAccountActiveEmailResponse> ExecuteCgibinExmailAccountActiveEmailAsync(this WechatWorkClient client, Models.CgibinExmailAccountActiveEmailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "exmail", "account", "act_email")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExmailAccountActiveEmailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
        
        #region UserOption
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/exmail/useroption/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95513 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExmailUserOptionGetResponse> ExecuteCgibinExmailUserOptionGetAsync(this WechatWorkClient client, Models.CgibinExmailUserOptionGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "exmail", "useroption", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExmailUserOptionGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/exmail/useroption/update 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95513 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExmailUserOptionUpdateResponse> ExecuteCgibinExmailUserOptionUpdateAsync(this WechatWorkClient client, Models.CgibinExmailUserOptionUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "exmail", "useroption", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExmailUserOptionUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
