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
        /// <para>异步调用 [GET] /cgi-bin/corpgroup/corp/get_chain_corpinfo_list 接口。</para>
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
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "corpgroup", "corp", "get_chain_corpinfo_list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("chain_id", request.ChainId);

            if (request.GroupId != null)
                flurlReq.SetQueryParam("groupid", request.GroupId.Value);

            if (request.RequireFetchChild != null)
                flurlReq.SetQueryParam("fetch_child", request.RequireFetchChild.Value ? 1 : 0);

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
    }
}
