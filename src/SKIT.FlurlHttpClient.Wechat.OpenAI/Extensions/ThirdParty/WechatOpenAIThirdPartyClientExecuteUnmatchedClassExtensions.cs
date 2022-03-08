using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIThirdPartyClientExecuteUnmatchedClassExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /v1/unmatched/class/list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/bot/unmatched_class_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ThirdParty.UnmatchedClassListResponse> ExecuteUnmatchedClassListAsync(this WechatOpenAIThirdPartyClient client, Models.ThirdParty.UnmatchedClassListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v1", "unmatched", "class", "list");

            return await client.SendRequestWithJsonAsync<Models.ThirdParty.UnmatchedClassListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v1/unmatched/class/detail 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/bot/unmatched_class_detail.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ThirdParty.UnmatchedClassDetailResponse> ExecuteUnmatchedClassDetailAsync(this WechatOpenAIThirdPartyClient client, Models.ThirdParty.UnmatchedClassDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v1", "unmatched", "class", "detail");

            return await client.SendRequestWithJsonAsync<Models.ThirdParty.UnmatchedClassDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
