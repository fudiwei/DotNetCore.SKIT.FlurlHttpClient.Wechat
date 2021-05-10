using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/token 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Basic_Information/Get_access_token.html </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/access-token/auth.getAccessToken.html </para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/access-token/auth.getAccessToken.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTokenResponse> ExecuteCgibinTokenAsync(this WechatApiClient client, Models.CgibinTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "token")
                .SetOptions(request)
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("appid", client.AppId)
                .SetQueryParam("secret", client.AppSecret);

            return await client.SendRequestAsync<Models.CgibinTokenResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/ticket/getticket 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/OA_Web_Apps/JS-SDK.html#54 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinTicketGetTicketResponse> ExecuteCgibinTicketGetTicketAsync(this WechatApiClient client, Models.CgibinTicketGetTicketRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "ticket", "getticket")
                .SetOptions(request)
                .SetQueryParam("type", request.Type)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.CgibinTicketGetTicketResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/getcallbackip 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Basic_Information/Get_the_WeChat_server_IP_address.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGetCallbackIpResponse> ExecuteCgibinGetCallbackIpAsync(this WechatApiClient client, Models.CgibinGetCallbackIpRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "getcallbackip")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.CgibinGetCallbackIpResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/get_api_domain_ip 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Basic_Information/Get_the_WeChat_server_IP_address.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGetApiDomainIpResponse> ExecuteCgibinGetApiDomainIpAsync(this WechatApiClient client, Models.CgibinGetApiDomainIpRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "get_api_domain_ip")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.CgibinGetApiDomainIpResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
