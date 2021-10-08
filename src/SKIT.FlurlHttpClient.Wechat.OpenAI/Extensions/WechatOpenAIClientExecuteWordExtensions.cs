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
    public static class WechatOpenAIClientExecuteWordExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /v2/word/update/batch 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v1/word/batch_update.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WordUpdateBatchResponse> ExecuteWordUpdateBatchAsync(this WechatOpenAIClient client, Models.WordUpdateBatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "word", "update", "batch");

            return await client.SendRequestWithJsonAsync<Models.WordUpdateBatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/word/delete/batch 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v1/word/batch_delete.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WordDeleteBatchResponse> ExecuteWordDeleteBatchAsync(this WechatOpenAIClient client, Models.WordDeleteBatchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "word", "delete", "batch");

            return await client.SendRequestWithJsonAsync<Models.WordDeleteBatchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/word/import 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/word/import.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WordImportResponse> ExecuteWordImportAsync(this WechatOpenAIClient client, Models.WordImportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "word", "import");

            return await client.SendRequestWithJsonAsync<Models.WordImportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/word/import/json 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/word/json_import.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WordImportJsonResponse> ExecuteWordImportJsonAsync(this WechatOpenAIClient client, Models.WordImportJsonRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "word", "import", "json");

            return await client.SendRequestWithJsonAsync<Models.WordImportJsonResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /v2/word/export 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v2/word/export.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WordExportResponse> ExecuteWordExportAsync(this WechatOpenAIClient client, Models.WordExportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v2", "word", "export");

            return await client.SendRequestWithJsonAsync<Models.WordExportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
