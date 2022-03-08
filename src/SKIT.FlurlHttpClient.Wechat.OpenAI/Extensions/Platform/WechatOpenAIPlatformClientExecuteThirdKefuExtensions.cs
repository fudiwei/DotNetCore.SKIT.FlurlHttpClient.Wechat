using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIPlatformClientExecuteThirdKefuExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /sendmsg/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/thirdkefu/sendmsg.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/sendmsg.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.SendMessageResponse> ExecuteSendMessageAsync(this WechatOpenAIPlatformClient client, Models.Platform.SendMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "sendmsg", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.SendMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /kefustate/get/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/thirdkefu/getstate.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.KefuStateGetResponse> ExecuteKefuStateGetAsync(this WechatOpenAIPlatformClient client, Models.Platform.KefuStateGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "kefustate", "get", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.KefuStateGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /kefustate/change/{TOKEN} 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/platform/thirdkefu/getstate.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.Platform.KefuStateChangeResponse> ExecuteKefuStateChangeAsync(this WechatOpenAIPlatformClient client, Models.Platform.KefuStateChangeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId == null)
                request.AppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "kefustate", "change", client.Credentials.Token!);

            return await client.SendRequestWithJsonAsync<Models.Platform.KefuStateChangeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
