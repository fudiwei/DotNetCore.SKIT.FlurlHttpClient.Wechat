using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIThirdPartyClientExecuteSlotExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /v2/slot/save 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/slot/save.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ThirdParty.SlotSaveResponse> ExecuteSlotSaveAsync(this WechatOpenAIThirdPartyClient client, Models.ThirdParty.SlotSaveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "slot", "save");

            return await client.SendRequestWithJsonAsync<Models.ThirdParty.SlotSaveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/slot/get_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/slot/get_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ThirdParty.SlotGetListResponse> ExecuteSlotGetListAsync(this WechatOpenAIThirdPartyClient client, Models.ThirdParty.SlotGetListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "slot", "get_list");

            return await client.SendRequestWithJsonAsync<Models.ThirdParty.SlotGetListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/slot/delete 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/slot/delete.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ThirdParty.SlotDeleteResponse> ExecuteSlotDeleteAsync(this WechatOpenAIThirdPartyClient client, Models.ThirdParty.SlotDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "slot", "delete");

            return await client.SendRequestWithJsonAsync<Models.ThirdParty.SlotDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
