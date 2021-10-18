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
    public static class WechatWorkClientExecuteCgibinLinkedCorpExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/linkedcorp/agent/get_perm_list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93172 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLinkedCorpAgentGetPermissionListResponse> ExecuteCgibinLinkedCorpAgentGetPermissionListAsync(this WechatWorkClient client, Models.CgibinLinkedCorpAgentGetPermissionListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "linkedcorp", "agent", "get_perm_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLinkedCorpAgentGetPermissionListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/linkedcorp/user/get 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93171 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLinkedCorpUserGetResponse> ExecuteCgibinLinkedCorpUserGetAsync(this WechatWorkClient client, Models.CgibinLinkedCorpUserGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "linkedcorp", "user", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLinkedCorpUserGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/linkedcorp/user/simplelist 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93168 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLinkedCorpUserSimpleListResponse> ExecuteCgibinLinkedCorpUserSimpleListAsync(this WechatWorkClient client, Models.CgibinLinkedCorpUserSimpleListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "linkedcorp", "user", "simplelist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLinkedCorpUserSimpleListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/linkedcorp/user/list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93169 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLinkedCorpUserListResponse> ExecuteCgibinLinkedCorpUserListAsync(this WechatWorkClient client, Models.CgibinLinkedCorpUserListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "linkedcorp", "user", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLinkedCorpUserListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/linkedcorp/department/list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/93170 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLinkedCorpDepartmentListResponse> ExecuteCgibinLinkedCorpDepartmentListAsync(this WechatWorkClient client, Models.CgibinLinkedCorpDepartmentListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "linkedcorp", "department", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLinkedCorpDepartmentListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Message
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/linkedcorp/message/send 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90250 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinLinkedCorpMessageSendResponse> ExecuteCgibinLinkedCorpMessageSendAsync(this WechatWorkClient client, Models.CgibinLinkedCorpMessageSendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId == null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "linkedcorp", "message", "send")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinLinkedCorpMessageSendResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
