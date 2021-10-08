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
    public static class WechatOpenAIClientExecuteAsyncExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /v1/async/fetch 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v1/task_fetch.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AsyncFetchResponse> ExecuteAsyncFetchAsync(this WechatOpenAIClient client, Models.AsyncFetchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "v1", "async", "fetch")
                .SetQueryParam("task_id", request.TaskId);

            return await client.SendRequestWithJsonAsync<Models.AsyncFetchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
