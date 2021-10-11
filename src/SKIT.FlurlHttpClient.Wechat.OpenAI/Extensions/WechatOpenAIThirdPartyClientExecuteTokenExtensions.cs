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
    public static class WechatOpenAIThirdPartyClientExecuteTokenExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /v1/token 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v1/get_token.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ThirdParty.TokenResponse> ExecuteTokenAsync(this WechatOpenAIThirdPartyClient client, Models.ThirdParty.TokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v1", "token")
                .WithHeader("Client-Id", client.Credentials.ClientId)
                .WithHeader("Client-Key", client.Credentials.ClientKey);

            return await client.SendRequestWithJsonAsync<Models.ThirdParty.TokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
