using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIClientExecuteTokenExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /v2/token 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/aispeech/confapi/dialog/token.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TokenV2Response> ExecuteTokenV2Async(this WechatOpenAIClient client, Models.TokenV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "v2", "token");

            return await client.SendFlurlRequestAsJsonAsync<Models.TokenV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
