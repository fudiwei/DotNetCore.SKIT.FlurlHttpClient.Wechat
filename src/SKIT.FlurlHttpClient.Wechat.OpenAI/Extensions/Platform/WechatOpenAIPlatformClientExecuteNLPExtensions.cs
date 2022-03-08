using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIPlatformClientExecuteNLPExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /nlp/tokenize/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/tokenize.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.NLPTokenizeResponse> ExecuteNLPTokenizeAsync(this WechatOpenAIPlatformClient client, Models.Platform.NLPTokenizeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "tokenize", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.Platform.NLPTokenizeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/ner/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/ner.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.NLPNERResponse> ExecuteNLPNERAsync(this WechatOpenAIPlatformClient client, Models.Platform.NLPNERRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "ner", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.Platform.NLPNERResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/sentiment/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/sentiment.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.NLPSentimentResponse> ExecuteNLPSentimentAsync(this WechatOpenAIPlatformClient client, Models.Platform.NLPSentimentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "sentiment", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.Platform.NLPSentimentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/ner-product/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/nerproduct.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.NLPNERProductResponse> ExecuteNLPNERProductAsync(this WechatOpenAIPlatformClient client, Models.Platform.NLPNERProductRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "ner-product", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.Platform.NLPNERProductResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/sensitive/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/sensitive.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.NLPSensitiveResponse> ExecuteNLPSensitiveAsync(this WechatOpenAIPlatformClient client, Models.Platform.NLPSensitiveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "sensitive", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.Platform.NLPSensitiveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/rank/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/rank.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.NLPRankResponse> ExecuteNLPRankAsync(this WechatOpenAIPlatformClient client, Models.Platform.NLPRankRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "rank", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.Platform.NLPRankResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/translate_en2cn/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/translate.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.NLPTranslateEnglish2ChineseResponse> ExecuteNLPTranslateEnglish2ChineseAsync(this WechatOpenAIPlatformClient client, Models.Platform.NLPTranslateEnglish2ChineseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "translate_en2cn", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.Platform.NLPTranslateEnglish2ChineseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/translate_cn2en/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/translate.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.NLPTranslateChinese2EnglishResponse> ExecuteNLPTranslateChinese2EnglishAsync(this WechatOpenAIPlatformClient client, Models.Platform.NLPTranslateChinese2EnglishRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "translate_cn2en", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.Platform.NLPTranslateChinese2EnglishResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/get_similar_query/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/similar_recommend.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.NLPGetSimilarQueryResponse> ExecuteNLPGetSimilarQueryAsync(this WechatOpenAIPlatformClient client, Models.Platform.NLPGetSimilarQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "get_similar_query", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.Platform.NLPGetSimilarQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/news-abstraction/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/summarize.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.NLPNewsAbstractionResponse> ExecuteNLPNewsAbstractionAsync(this WechatOpenAIPlatformClient client, Models.Platform.NLPNewsAbstractionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "news-abstraction", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.Platform.NLPNewsAbstractionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/document_classify/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/summarize.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.NLPDocumentClassifyResponse> ExecuteNLPDocumentClassifyAsync(this WechatOpenAIPlatformClient client, Models.Platform.NLPDocumentClassifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "document_classify", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.Platform.NLPDocumentClassifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/recommend_questions/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/rec_chat.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.NLPRecommendQuestionsResponse> ExecuteNLPRecommendQuestionsAsync(this WechatOpenAIPlatformClient client, Models.Platform.NLPRecommendQuestionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "recommend_questions", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.Platform.NLPRecommendQuestionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
