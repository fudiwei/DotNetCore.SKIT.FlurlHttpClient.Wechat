﻿using System;
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
        /// <para>异步调用 [POST] /cgi-bin/corpgroup/corp/list_app_share_info 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93403 </para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93405 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupCropListAppShareInfoResponse> ExecuteCgibinCorpGroupCropListAppShareInfoAsync(this WechatWorkClient client, Models.CgibinCorpGroupCropListAppShareInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ParentAgentId == null)
                request.ParentAgentId = client.Credentials.AgentId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corpgroup", "corp", "list_app_share_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupCropListAppShareInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corpgroup/corp/gettoken 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/93359 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupCropGetTokenResponse> ExecuteCgibinCorpGroupCropGetTokenAsync(this WechatWorkClient client, Models.CgibinCorpGroupCropGetTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corpgroup", "corp", "gettoken")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupCropGetTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/corpgroup/corp/get_chain_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95315 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupCropGetChainListResponse> ExecuteCgibinCorpGroupCropGetChainListAsync(this WechatWorkClient client, Models.CgibinCorpGroupCropGetChainListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "corpgroup", "corp", "get_chain_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupCropGetChainListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corpgroup/corp/get_chain_group 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95315 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupCropGetChainGroupResponse> ExecuteCgibinCorpGroupCropGetChainGroupAsync(this WechatWorkClient client, Models.CgibinCorpGroupCropGetChainGroupRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corpgroup", "corp", "get_chain_group")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupCropGetChainGroupResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/corpgroup/corp/get_chain_corpinfo_list 接口。</para>
        /// <para>REF: https://developer.work.weixin.qq.com/document/path/95315 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCorpGroupCropGetChainCorpInfoListResponse> ExecuteCgibinCorpGroupCropGetChainCorpInfoListAsync(this WechatWorkClient client, Models.CgibinCorpGroupCropGetChainCorpInfoListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "corpgroup", "corp", "get_chain_corpinfo_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinCorpGroupCropGetChainCorpInfoListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

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
