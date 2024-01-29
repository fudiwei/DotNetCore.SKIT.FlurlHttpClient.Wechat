using System;
using System.Net.Http;
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
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/mp-access-token/getAccessToken.html </para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/access-token/auth.getAccessToken.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/basics/getaccesstoken.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/windowproduct/getaccesstoken.html </para>
        /// <para>REF: https://dev.weixin.qq.com/docs/framework/dev/openapi/getaccesstoken.html </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "token")
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("appid", client.Credentials.AppId)
                .SetQueryParam("secret", client.Credentials.AppSecret);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/stable_token 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Basic_Information/getStableAccessToken.html </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/mp-access-token/getStableAccessToken.html </para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/access-token/auth.getStableAccessToken.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinStableTokenResponse> ExecuteCgibinStableTokenAsync(this WechatApiClient client, Models.CgibinStableTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
                request.AppId = client.Credentials.AppId;

            if (request.AppSecret is null)
                request.AppSecret = client.Credentials.AppSecret;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "stable_token");

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinStableTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/ticket/getticket 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/OA_Web_Apps/JS-SDK.html#54 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/E_Invoice/Vendor_API_List.html#1 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Invoice/Nontax_Bill/API_list.html#2.1 </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "ticket", "getticket")
                .SetQueryParam("type", request.Type)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinTicketGetTicketResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
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
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "getcallbackip")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinGetCallbackIpResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
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
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "get_api_domain_ip")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinGetApiDomainIpResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/callback/check 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Basic_Information/Network_Detection.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinCallbackCheckResponse> ExecuteCgibinCallbackCheckAsync(this WechatApiClient client, Models.CgibinCallbackCheckRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "callback", "check")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinCallbackCheckResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/changeopenid 接口。</para>
        /// <para>REF: https://kf.qq.com/faq/1901177NrqMr190117nqYJze.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinChangeOpenIdResponse> ExecuteCgibinChangeOpenIdAsync(this WechatApiClient client, Models.CgibinChangeOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "changeopenid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChangeOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/get_current_autoreply_info 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Message_Management/Getting_Rules_for_Auto_Replies.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinGetCurrentAutoReplyInfoResponse> ExecuteCgibinGetCurrentAutoReplyInfoAsync(this WechatApiClient client, Models.CgibinGetCurrentAutoReplyInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "cgi-bin", "get_current_autoreply_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinGetCurrentAutoReplyInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
