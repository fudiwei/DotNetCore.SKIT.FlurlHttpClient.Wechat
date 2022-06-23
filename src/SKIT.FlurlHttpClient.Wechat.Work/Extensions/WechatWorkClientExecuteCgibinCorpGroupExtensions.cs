using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinCorpGroupExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corpgroup/unionid_to_external_userid 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95342 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupUnionidToExternalUserIdResponse> ExecuteCgibinCorpGroupUnionidToExternalUserIdAsync(this WechatWorkClient client, Models.CgibinCorpGroupUnionidToExternalUserIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corpgroup", "unionid_to_external_userid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupUnionidToExternalUserIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corpgroup/import_chain_contact 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95821 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupImportChainContactResponse> ExecuteCgibinCorpGroupImportChainContactAsync(this WechatWorkClient client, Models.CgibinCorpGroupImportChainContactRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corpgroup", "import_chain_contact")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupImportChainContactResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/corpgroup/getresult 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95823 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupGetResultResponse> ExecuteCgibinCorpGroupGetResultAsync(this WechatWorkClient client, Models.CgibinCorpGroupGetResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "corpgroup", "getresult")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("jobid", request.JobId);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupGetResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Corp
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corpgroup/corp/list_app_share_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93403 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93405 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupCorpListAppShareInfoResponse> ExecuteCgibinCorpGroupCorpListAppShareInfoAsync(this WechatWorkClient client, Models.CgibinCorpGroupCorpListAppShareInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ParentAgentId == null)
                request.ParentAgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corpgroup", "corp", "list_app_share_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupCorpListAppShareInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corpgroup/corp/gettoken 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93359 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupCorpGetTokenResponse> ExecuteCgibinCorpGroupCorpGetTokenAsync(this WechatWorkClient client, Models.CgibinCorpGroupCorpGetTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corpgroup", "corp", "gettoken")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupCorpGetTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/corpgroup/corp/get_chain_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95315 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupCorpGetChainListResponse> ExecuteCgibinCorpGroupCorpGetChainListAsync(this WechatWorkClient client, Models.CgibinCorpGroupCorpGetChainListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "corpgroup", "corp", "get_chain_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupCorpGetChainListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corpgroup/corp/get_chain_group 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95315 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupCorpGetChainGroupResponse> ExecuteCgibinCorpGroupCorpGetChainGroupAsync(this WechatWorkClient client, Models.CgibinCorpGroupCorpGetChainGroupRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corpgroup", "corp", "get_chain_group")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupCorpGetChainGroupResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corpgroup/corp/get_chain_corpinfo_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95315 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupCorpGetChainCorpInfoListResponse> ExecuteCgibinCorpGroupCorpGetChainCorpInfoListAsync(this WechatWorkClient client, Models.CgibinCorpGroupCorpGetChainCorpInfoListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corpgroup", "corp", "get_chain_corpinfo_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupCorpGetChainCorpInfoListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corpgroup/corp/remove_corp 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95822 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupCorpRemoveCorpResponse> ExecuteCgibinCorpGroupCorpRemoveCorpAsync(this WechatWorkClient client, Models.CgibinCorpGroupCorpRemoveCorpRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corpgroup", "corp", "remove_corp")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupCorpRemoveCorpResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Rule
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corpgroup/rule/list_ids 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95631 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupRuleListIdsResponse> ExecuteCgibinCorpGroupRuleListIdsAsync(this WechatWorkClient client, Models.CgibinCorpGroupRuleListIdsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corpgroup", "rule", "list_ids")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupRuleListIdsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corpgroup/rule/delete_rule 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95632 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupRuleDeleteRuleResponse> ExecuteCgibinCorpGroupRuleDeleteRuleAsync(this WechatWorkClient client, Models.CgibinCorpGroupRuleDeleteRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corpgroup", "rule", "delete_rule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupRuleDeleteRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corpgroup/rule/get_rule_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95634 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupRuleGetRuleInfoResponse> ExecuteCgibinCorpGroupRuleGetRuleInfoAsync(this WechatWorkClient client, Models.CgibinCorpGroupRuleGetRuleInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corpgroup", "rule", "get_rule_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupRuleGetRuleInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corpgroup/rule/add_rule 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95634 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupRuleAddRuleResponse> ExecuteCgibinCorpGroupRuleAddRuleAsync(this WechatWorkClient client, Models.CgibinCorpGroupRuleAddRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corpgroup", "rule", "add_rule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupRuleAddRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corpgroup/rule/modify_rule 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95635 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupRuleModifyRuleResponse> ExecuteCgibinCorpGroupRuleModifyRuleAsync(this WechatWorkClient client, Models.CgibinCorpGroupRuleModifyRuleRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corpgroup", "rule", "modify_rule")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupRuleModifyRuleResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
