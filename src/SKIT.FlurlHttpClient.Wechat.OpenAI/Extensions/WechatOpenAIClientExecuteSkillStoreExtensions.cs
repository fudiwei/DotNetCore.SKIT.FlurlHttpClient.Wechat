using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIClientExecuteSkillStoreExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /v2/skill_store/get_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/skill_store/get_store_skill_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SkillStoreGetListResponse> ExecuteSkillStoreGetListAsync(this WechatOpenAIClient client, Models.SkillStoreGetListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "skill_store", "get_list");

            return await client.SendRequestWithJsonAsync<Models.SkillStoreGetListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/skill_store/bot_acquire_state/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/skill_store/update_bot_acquire_state.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SkillStoreBotAcquireStateUpdateResponse> ExecuteSkillStoreBotAcquireStateUpdateAsync(this WechatOpenAIClient client, Models.SkillStoreBotAcquireStateUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "skill_store", "bot_acquire_state", "update");

            return await client.SendRequestWithJsonAsync<Models.SkillStoreBotAcquireStateUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/skill_store/bot_switch_state/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/skill_store/batch_update_state.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SkillStoreBotSwitchStateUpdateResponse> ExecuteSkillStoreBotSwitchStateUpdateAsync(this WechatOpenAIClient client, Models.SkillStoreBotSwitchStateUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "skill_store", "bot_switch_state", "update");

            return await client.SendRequestWithJsonAsync<Models.SkillStoreBotSwitchStateUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/skill_store/builtin_skill_switch/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/skill_store/update_builtin_skill_switch.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SkillStoreBuiltinSkillSwitchUpdateResponse> ExecuteSkillStoreBuiltinSkillSwitchUpdateAsync(this WechatOpenAIClient client, Models.SkillStoreBuiltinSkillSwitchUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "skill_store", "builtin_skill_switch", "update");

            return await client.SendRequestWithJsonAsync<Models.SkillStoreBuiltinSkillSwitchUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
