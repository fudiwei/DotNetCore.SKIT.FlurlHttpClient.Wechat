using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    public static class WechatOpenAIThirdPartyClientExecuteUserExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /v1/user/register 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v1/user_register.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ThirdParty.UserRegisterResponse> ExecuteUserRegisterAsync(this WechatOpenAIThirdPartyClient client, Models.ThirdParty.UserRegisterRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v1", "user", "register")
                .WithHeader("Client-Id", client.Credentials.ClientId)
                .WithHeader("Client-Key", client.Credentials.ClientKey);

            return await client.SendRequestWithJsonAsync<Models.ThirdParty.UserRegisterResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
