using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIClientExecuteNLPExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /nlp/tokenize/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/tokenize.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NLPTokenizeResponse> ExecuteNLPTokenizeAsync(this WechatOpenAIClient client, Models.NLPTokenizeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "tokenize", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.NLPTokenizeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/ner/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/ner.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NLPNERResponse> ExecuteNLPNERAsync(this WechatOpenAIClient client, Models.NLPNERRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "ner", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.NLPNERResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/sentiment/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/sentiment.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NLPSentimentResponse> ExecuteNLPSentimentAsync(this WechatOpenAIClient client, Models.NLPSentimentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "sentiment", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.NLPSentimentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/ner-product/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/nerproduct.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NLPNERProductResponse> ExecuteNLPNERProductAsync(this WechatOpenAIClient client, Models.NLPNERProductRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "ner-product", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.NLPNERProductResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/sensitive/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/sensitive.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NLPSensitiveResponse> ExecuteNLPSensitiveAsync(this WechatOpenAIClient client, Models.NLPSensitiveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "sensitive", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.NLPSensitiveResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/rank/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/rank.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NLPRankResponse> ExecuteNLPRankAsync(this WechatOpenAIClient client, Models.NLPRankRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "rank", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.NLPRankResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/translate_en2cn/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/translate.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NLPTranslateEnglish2ChineseResponse> ExecuteNLPTranslateEnglish2ChineseAsync(this WechatOpenAIClient client, Models.NLPTranslateEnglish2ChineseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "translate_en2cn", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.NLPTranslateEnglish2ChineseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/translate_cn2en/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/translate.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NLPTranslateChinese2EnglishResponse> ExecuteNLPTranslateChinese2EnglishAsync(this WechatOpenAIClient client, Models.NLPTranslateChinese2EnglishRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "translate_cn2en", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.NLPTranslateChinese2EnglishResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/get_similar_query/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/similar_recommend.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NLPGetSimilarQueryResponse> ExecuteNLPGetSimilarQueryAsync(this WechatOpenAIClient client, Models.NLPGetSimilarQueryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "get_similar_query", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.NLPGetSimilarQueryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/news-abstraction/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/summarize.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NLPNewsAbstractionResponse> ExecuteNLPNewsAbstractionAsync(this WechatOpenAIClient client, Models.NLPNewsAbstractionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "news-abstraction", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.NLPNewsAbstractionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/document_classify/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/summarize.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NLPDocumentClassifyResponse> ExecuteNLPDocumentClassifyAsync(this WechatOpenAIClient client, Models.NLPDocumentClassifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "document_classify", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.NLPDocumentClassifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /nlp/recommend_questions/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/nlp/rec_chat.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NLPRecommendQuestionsResponse> ExecuteNLPRecommendQuestionsAsync(this WechatOpenAIClient client, Models.NLPRecommendQuestionsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "nlp", "recommend_questions", client.Credentials.Token!);

            return await client.SendRequestWithUrlEncodedAsync<Models.NLPRecommendQuestionsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
