using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIPlatformClientExecuteLivingExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /batchreply/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/living/batchreply.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.BatchReplyResponse> ExecuteBatchReplyAsync(this WechatOpenAIPlatformClient client, Models.Platform.BatchReplyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "batchreply", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.BatchReplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /generatereport/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/living/setautoreply.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.GenerateReportResponse> ExecuteGenerateReportAsync(this WechatOpenAIPlatformClient client, Models.Platform.GenerateReportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "generatereport", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.GenerateReportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
