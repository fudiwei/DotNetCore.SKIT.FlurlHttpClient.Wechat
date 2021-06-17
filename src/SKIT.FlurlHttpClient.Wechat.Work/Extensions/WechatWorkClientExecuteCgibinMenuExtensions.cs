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
    public static class WechatWorkClientExecuteCgibinMenuExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/menu/create 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90231 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMenuCreateResponse> ExecuteCgibinMenuCreateAsync(this WechatWorkClient client, Models.CgibinMenuCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (!request.AgentId.HasValue)
                request.AgentId = client.WechatAgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "menu", "create")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("agentid", request.AgentId);

            return await client.SendRequestWithJsonAsync<Models.CgibinMenuCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/menu/get 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90232 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMenuGetResponse> ExecuteCgibinMenuGetAsync(this WechatWorkClient client, Models.CgibinMenuGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (!request.AgentId.HasValue)
                request.AgentId = client.WechatAgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "menu", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("agentid", request.AgentId);

            return await client.SendRequestAsync<Models.CgibinMenuGetResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/menu/delete 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90233 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinMenuDeleteResponse> ExecuteCgibinMenuDeleteAsync(this WechatWorkClient client, Models.CgibinMenuDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (!request.AgentId.HasValue)
                request.AgentId = client.WechatAgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "menu", "delete")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("agentid", request.AgentId);

            return await client.SendRequestAsync<Models.CgibinMenuDeleteResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
