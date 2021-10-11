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

        /// <summary>
        /// <para>异步调用 [POST] /openapi/nlp/rank/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/rank.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiNLPRankResponse> ExecuteOpenApiNLPRankAsync(this WechatOpenAIClient client, Models.OpenApiNLPRankRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "nlp", "rank", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.OpenApiNLPRankResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/nlp/translate_en2cn/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/translate.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiNLPTranslateEnglish2ChineseResponse> ExecuteOpenApiNLPTranslateEnglish2ChineseAsync(this WechatOpenAIClient client, Models.OpenApiNLPTranslateEnglish2ChineseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "nlp", "translate_en2cn", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.OpenApiNLPTranslateEnglish2ChineseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/nlp/translate_cn2en/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/translate.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiNLPTranslateChinese2EnglishResponse> ExecuteOpenApiNLPTranslateChinese2EnglishAsync(this WechatOpenAIClient client, Models.OpenApiNLPTranslateChinese2EnglishRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "nlp", "translate_cn2en", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.OpenApiNLPTranslateChinese2EnglishResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/nlp/get_similar_query/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/similar_recommend.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiNLPGetSimilarQueryResponse> ExecuteOpenApiNLPGetSimilarQueryAsync(this WechatOpenAIClient client, Models.OpenApiNLPGetSimilarQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "nlp", "get_similar_query", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.OpenApiNLPGetSimilarQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/nlp/news-abstraction/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/summarize.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiNLPNewsAbstractionResponse> ExecuteOpenApiNLPNewsAbstractionAsync(this WechatOpenAIClient client, Models.OpenApiNLPNewsAbstractionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "nlp", "news-abstraction", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.OpenApiNLPNewsAbstractionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/nlp/document_classify/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/summarize.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiNLPDocumentClassifyResponse> ExecuteOpenApiNLPDocumentClassifyAsync(this WechatOpenAIClient client, Models.OpenApiNLPDocumentClassifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "nlp", "document_classify", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.OpenApiNLPDocumentClassifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /openapi/nlp/recommend_questions/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/rec_chat.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OpenApiNLPRecommendQuestionsResponse> ExecuteOpenApiNLPRecommendQuestionsAsync(this WechatOpenAIClient client, Models.OpenApiNLPRecommendQuestionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "openapi", "nlp", "recommend_questions", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.OpenApiNLPRecommendQuestionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
