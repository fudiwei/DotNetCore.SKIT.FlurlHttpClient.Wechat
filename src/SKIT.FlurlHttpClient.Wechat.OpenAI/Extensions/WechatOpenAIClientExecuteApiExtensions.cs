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
    public static class WechatOpenAIClientExecuteApiExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /v2/api/get_welcome_msg 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/bot/get_welcomemsg.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApiGetWelcomeMessageResponse> ExecuteApiGetWelcomeMessageAsync(this WechatOpenAIClient client, Models.ApiGetWelcomeMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "api", "get_welcome_msg");

            return await client.SendRequestWithJsonAsync<Models.ApiGetWelcomeMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/api/set_welcome_msg 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/bot/set_welcomemsg.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApiSetWelcomeMessageResponse> ExecuteApiSetWelcomeMessageAsync(this WechatOpenAIClient client, Models.ApiSetWelcomeMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "api", "set_welcome_msg");

            return await client.SendRequestWithJsonAsync<Models.ApiSetWelcomeMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
