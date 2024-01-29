using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinAgentExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/agent/get 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90227 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90363 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90845 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAgentGetResponse> ExecuteCgibinAgentGetAsync(this WechatWorkClient client, Models.CgibinAgentGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId is null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "agent", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("agentid", request.AgentId);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAgentGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/agent/list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90227 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90363 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90845 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAgentListResponse> ExecuteCgibinAgentListAsync(this WechatWorkClient client, Models.CgibinAgentListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "agent", "list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAgentListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/agent/set 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90228 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAgentSetResponse> ExecuteCgibinAgentSetAsync(this WechatWorkClient client, Models.CgibinAgentSetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId is null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "agent", "set")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAgentSetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/agent/set_scope 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90583 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/90807 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAgentSetScopeResponse> ExecuteCgibinAgentSetScopeAsync(this WechatWorkClient client, Models.CgibinAgentSetScopeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId is null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "agent", "set_scope")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAgentSetScopeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/agent/migrate_to_customized_app 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/96072 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAgentMigrateToCustomizedAppResponse> ExecuteCgibinAgentMigrateToCustomizedAppAsync(this WechatWorkClient client, Models.CgibinAgentMigrateToCustomizedAppRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "agent", "migrate_to_customized_app")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAgentMigrateToCustomizedAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/agent/get_permissions 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/99052 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAgentGetPermissionsResponse> ExecuteCgibinAgentGetPermissionsAsync(this WechatWorkClient client, Models.CgibinAgentGetPermissionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "agent", "get_permissions")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAgentGetPermissionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Workbench
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/agent/set_workbench_template 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92535 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94620 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAgentSetWorkbenchTemplateResponse> ExecuteCgibinAgentSetWorkbenchTemplateAsync(this WechatWorkClient client, Models.CgibinAgentSetWorkbenchTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId is null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "agent", "set_workbench_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAgentSetWorkbenchTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/agent/get_workbench_template 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92535 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94620 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAgentGetWorkbenchTemplateResponse> ExecuteCgibinAgentGetWorkbenchTemplateAsync(this WechatWorkClient client, Models.CgibinAgentGetWorkbenchTemplateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId is null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "agent", "get_workbench_template")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAgentGetWorkbenchTemplateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/agent/set_workbench_data 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/92535 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/94620 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinAgentSetWorkbenchDataResponse> ExecuteCgibinAgentSetWorkbenchDataAsync(this WechatWorkClient client, Models.CgibinAgentSetWorkbenchDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AgentId is null)
                request.AgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "agent", "set_workbench_data")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinAgentSetWorkbenchDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
