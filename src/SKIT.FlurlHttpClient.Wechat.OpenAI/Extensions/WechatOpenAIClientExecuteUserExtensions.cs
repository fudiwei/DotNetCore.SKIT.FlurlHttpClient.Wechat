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
    public static class WechatOpenAIClientExecuteUserExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /v1/user/register 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/aispeech/openapi/api/v1/user_register.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserRegisterResponse> ExecuteUserRegisterAsync(this WechatOpenAIClient client, Models.UserRegisterRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "v1", "user", "register")
                .WithHeader("Client-Id", client.Credentials.ClientId)
                .WithHeader("Client-Key", client.Credentials.ClientKey);

            return await client.SendRequestWithJsonAsync<Models.UserRegisterResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
