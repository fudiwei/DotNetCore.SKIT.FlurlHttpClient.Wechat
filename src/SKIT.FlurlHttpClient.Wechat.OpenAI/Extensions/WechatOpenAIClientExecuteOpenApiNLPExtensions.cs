using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIClientExecuteOpenApiNLPExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /openapi/nlp/tokenize/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/tokenize.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiNLPTokenizeResponse> ExecuteOpenApiNLPTokenizeAsync(this WechatOpenAIClient client, Models.OpenApiNLPTokenizeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "nlp", "tokenize", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.OpenApiNLPTokenizeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/nlp/ner/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/ner.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiNLPNERResponse> ExecuteOpenApiNLPNERAsync(this WechatOpenAIClient client, Models.OpenApiNLPNERRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "nlp", "ner", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.OpenApiNLPNERResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/nlp/sentiment/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/sentiment.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiNLPSentimentResponse> ExecuteOpenApiNLPSentimentAsync(this WechatOpenAIClient client, Models.OpenApiNLPSentimentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "nlp", "sentiment", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.OpenApiNLPSentimentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/nlp/ner-product/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/nerproduct.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiNLPNERProductResponse> ExecuteOpenApiNLPNERProductAsync(this WechatOpenAIClient client, Models.OpenApiNLPNERProductRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "nlp", "ner-product", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.OpenApiNLPNERProductResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/nlp/sensitive/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/sensitive.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiNLPSensitiveResponse> ExecuteOpenApiNLPSensitiveAsync(this WechatOpenAIClient client, Models.OpenApiNLPSensitiveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "nlp", "sensitive", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.OpenApiNLPSensitiveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
