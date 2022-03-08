using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIThirdPartyClientExecuteSkillStoreExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /v2/skill_store/get_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/skill_store/get_store_skill_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ThirdParty.SkillStoreGetListResponse> ExecuteSkillStoreGetListAsync(this WechatOpenAIThirdPartyClient client, Models.ThirdParty.SkillStoreGetListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "skill_store", "get_list");

            return await client.SendRequestWithJsonAsync<Models.ThirdParty.SkillStoreGetListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/skill_store/bot_acquire_state/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/skill_store/update_bot_acquire_state.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ThirdParty.SkillStoreBotAcquireStateUpdateResponse> ExecuteSkillStoreBotAcquireStateUpdateAsync(this WechatOpenAIThirdPartyClient client, Models.ThirdParty.SkillStoreBotAcquireStateUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "skill_store", "bot_acquire_state", "update");

            return await client.SendRequestWithJsonAsync<Models.ThirdParty.SkillStoreBotAcquireStateUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/skill_store/bot_switch_state/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/skill_store/batch_update_state.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ThirdParty.SkillStoreBotSwitchStateUpdateResponse> ExecuteSkillStoreBotSwitchStateUpdateAsync(this WechatOpenAIThirdPartyClient client, Models.ThirdParty.SkillStoreBotSwitchStateUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "skill_store", "bot_switch_state", "update");

            return await client.SendRequestWithJsonAsync<Models.ThirdParty.SkillStoreBotSwitchStateUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/skill_store/builtin_skill_switch/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/skill_store/update_builtin_skill_switch.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ThirdParty.SkillStoreBuiltinSkillSwitchUpdateResponse> ExecuteSkillStoreBuiltinSkillSwitchUpdateAsync(this WechatOpenAIThirdPartyClient client, Models.ThirdParty.SkillStoreBuiltinSkillSwitchUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "skill_store", "builtin_skill_switch", "update");

            return await client.SendRequestWithJsonAsync<Models.ThirdParty.SkillStoreBuiltinSkillSwitchUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
