using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIClientExecuteOpenApiBotExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /openapi/batchimportskill/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/skill/batchimportskill.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiBatchImportSkillResponse> ExecuteOpenApiBatchImportSkillAsync(this WechatOpenAIClient client, Models.OpenApiBatchImportSkillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "batchimportskill", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.OpenApiBatchImportSkillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/publish/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/skill/publish.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiPublishResponse> ExecuteOpenApiPublishAsync(this WechatOpenAIClient client, Models.OpenApiPublishRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "publish", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.OpenApiPublishResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/publish_progress/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/skill/publish_progress.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiPublishProgressResponse> ExecuteOpenApiPublishProgressAsync(this WechatOpenAIClient client, Models.OpenApiPublishProgressRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "publish_progress", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.OpenApiPublishProgressResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/setautoreply/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/living/setautoreply.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/skill/publish_progress.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiSetAutoReplyResponse> ExecuteOpenApiSetAutoReplyAsync(this WechatOpenAIClient client, Models.OpenApiSetAutoReplyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "setautoreply", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.OpenApiSetAutoReplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/label/batchset/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/batchsetlabel.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiLabelBatchSetResponse> ExecuteOpenApiLabelBatchSetAsync(this WechatOpenAIClient client, Models.OpenApiLabelBatchSetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "label", "batchset", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.OpenApiLabelBatchSetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
