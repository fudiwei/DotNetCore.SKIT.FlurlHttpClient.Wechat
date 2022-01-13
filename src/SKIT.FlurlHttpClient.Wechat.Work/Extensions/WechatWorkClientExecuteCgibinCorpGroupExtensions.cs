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
    }
}
