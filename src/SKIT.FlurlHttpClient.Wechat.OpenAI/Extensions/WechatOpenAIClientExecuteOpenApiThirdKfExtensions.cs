using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIClientExecuteOpenApiThirdKfExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /openapi/sendmsg/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/thirdkefu/sendmsg.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiSendMessageResponse> ExecuteOpenApiSendMessageAsync(this WechatOpenAIClient client, Models.OpenApiSendMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "sendmsg", client.Credentials.PushToken!);

            return await client.SendRequestWithJsonAsync<Models.OpenApiSendMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/kefustate/get/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/thirdkefu/getstate.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiKefuStateGetResponse> ExecuteOpenApiKefuStateGetAsync(this WechatOpenAIClient client, Models.OpenApiKefuStateGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "kefustate", "get", client.Credentials.PushToken!);

            return await client.SendRequestWithJsonAsync<Models.OpenApiKefuStateGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/kefustate/change/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/thirdkefu/getstate.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiKefuStateChangeResponse> ExecuteOpenApiKefuStateChangeAsync(this WechatOpenAIClient client, Models.OpenApiKefuStateChangeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "kefustate", "change", client.Credentials.PushToken!);

            return await client.SendRequestWithJsonAsync<Models.OpenApiKefuStateChangeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
