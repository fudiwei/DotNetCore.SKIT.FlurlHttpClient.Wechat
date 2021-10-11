using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIPlatformClientExecuteBotExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /batchimportskill/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/skill/batchimportskill.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.BatchImportSkillResponse> ExecuteBatchImportSkillAsync(this WechatOpenAIPlatformClient client, Models.Platform.BatchImportSkillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "batchimportskill", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.BatchImportSkillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /publish/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/skill/publish.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.PublishResponse> ExecutePublishAsync(this WechatOpenAIPlatformClient client, Models.Platform.PublishRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "publish", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.PublishResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /publish_progress/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/skill/publish_progress.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.PublishProgressResponse> ExecutePublishProgressAsync(this WechatOpenAIPlatformClient client, Models.Platform.PublishProgressRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "publish_progress", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.PublishProgressResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /setautoreply/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/living/setautoreply.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/skill/publish_progress.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.SetAutoReplyResponse> ExecuteSetAutoReplyAsync(this WechatOpenAIPlatformClient client, Models.Platform.SetAutoReplyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "setautoreply", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.SetAutoReplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /label/batchset/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/batchsetlabel.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.LabelBatchSetResponse> ExecuteLabelBatchSetAsync(this WechatOpenAIPlatformClient client, Models.Platform.LabelBatchSetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "label", "batchset", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.LabelBatchSetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
