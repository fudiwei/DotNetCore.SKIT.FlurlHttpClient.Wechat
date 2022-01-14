using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteRedPacketCoverExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /redpacketcover/wxapp/cover_url/get_by_token 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/redpacketcover/redpacketcover.getAuthenticationUrl.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RedPacketCoverWxAppCoverUrlGetByTokenResponse> ExecuteRedPacketCoverWxAppCoverUrlGetByTokenAsync(this WechatApiClient client, Models.RedPacketCoverWxAppCoverUrlGetByTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "redpacketcover", "wxapp", "cover_url", "get_by_token")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.RedPacketCoverWxAppCoverUrlGetByTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
