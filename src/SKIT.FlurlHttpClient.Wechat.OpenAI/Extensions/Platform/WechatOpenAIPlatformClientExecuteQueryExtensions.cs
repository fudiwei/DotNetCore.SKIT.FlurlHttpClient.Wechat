using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIPlatformClientExecuteQueryExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /sign/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/confapi/INTERFACEDOCUMENT.html#_1-%E8%8E%B7%E5%8F%96signature%E6%8E%A5%E5%8F%A3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.SignResponse> ExecuteSignAsync(this WechatOpenAIPlatformClient client, Models.Platform.SignRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "sign", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.SignResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /aibot/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/confapi/INTERFACEDOCUMENT.html#_2-%E6%99%BA%E8%83%BD%E5%AF%B9%E8%AF%9D%E6%8E%A5%E5%8F%A3 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.AIBotResponse> ExecuteAIBotAsync(this WechatOpenAIPlatformClient client, Models.Platform.AIBotRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "aibot", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.AIBotResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /gethotquerylist/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/api/gethotquerylist.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.GetHotQueryListResponse> ExecuteGetHotQueryListAsync(this WechatOpenAIPlatformClient client, Models.Platform.GetHotQueryListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "gethotquerylist", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.GetHotQueryListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
