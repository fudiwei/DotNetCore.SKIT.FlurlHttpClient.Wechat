using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIClientExecuteOpenApiLivingExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /openapi/batchreply/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/living/batchreply.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiBatchReplyResponse> ExecuteOpenApiBatchReplyAsync(this WechatOpenAIClient client, Models.OpenApiBatchReplyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "batchreply", client.Credentials.PushToken!);

            return await client.SendRequestWithJsonAsync<Models.OpenApiBatchReplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/setautoreply/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/living/setautoreply.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiBatchSetAutoReplyResponse> ExecuteOpenApiBatchSetAutoReplyAsync(this WechatOpenAIClient client, Models.OpenApiBatchSetAutoReplyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "setautoreply", client.Credentials.PushToken!);

            return await client.SendRequestWithJsonAsync<Models.OpenApiBatchSetAutoReplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/generatereport/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/living/setautoreply.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiGenerateReportResponse> ExecuteOpenApiGenerateReportAsync(this WechatOpenAIClient client, Models.OpenApiGenerateReportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "generatereport", client.Credentials.PushToken!);

            return await client.SendRequestWithJsonAsync<Models.OpenApiGenerateReportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
