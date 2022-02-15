using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinSoterExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/soter/verify_signature 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/soter/soter.verifySignature.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GgibinSoterVerifySignatureResponse> ExecuteGgibinSoterVerifySignatureAsync(this WechatApiClient client, Models.GgibinSoterVerifySignatureRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "soter", "verify_signature")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.GgibinSoterVerifySignatureResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
