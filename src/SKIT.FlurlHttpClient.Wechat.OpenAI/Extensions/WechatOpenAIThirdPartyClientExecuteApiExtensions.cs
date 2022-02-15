﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIThirdPartyClientExecuteApiExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /v2/api/get_welcome_msg 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/bot/get_welcomemsg.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ThirdParty.ApiGetWelcomeMessageResponse> ExecuteApiGetWelcomeMessageAsync(this WechatOpenAIThirdPartyClient client, Models.ThirdParty.ApiGetWelcomeMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "api", "get_welcome_msg");

            return await client.SendRequestWithJsonAsync<Models.ThirdParty.ApiGetWelcomeMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/api/set_welcome_msg 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/bot/set_welcomemsg.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ThirdParty.ApiSetWelcomeMessageResponse> ExecuteApiSetWelcomeMessageAsync(this WechatOpenAIThirdPartyClient client, Models.ThirdParty.ApiSetWelcomeMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "api", "set_welcome_msg");

            return await client.SendRequestWithJsonAsync<Models.ThirdParty.ApiSetWelcomeMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
