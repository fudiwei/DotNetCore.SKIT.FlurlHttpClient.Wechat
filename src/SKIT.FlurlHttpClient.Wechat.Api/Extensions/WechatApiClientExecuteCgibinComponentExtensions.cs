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
    public static class WechatApiClientExecuteCgibinComponentExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/api_start_push_ticket 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/ThirdParty/token/component_verify_ticket_service.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentApiStartPushTicketResponse> ExecuteCgibinComponentApiStartPushTicketAsync(this WechatApiClient client, Models.CgibinComponentApiStartPushTicketRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.ComponentAppId))
                request.ComponentAppId = client.AppId;

            if (string.IsNullOrEmpty(request.ComponentSecret))
                request.ComponentSecret = client.AppSecret;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "component", "api_start_push_ticket")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentApiStartPushTicketResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/api_component_token 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/ThirdParty/token/component_access_token.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentApiComponentTokenResponse> ExecuteCgibinComponentApiComponentTokenAsync(this WechatApiClient client, Models.CgibinComponentApiComponentTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.ComponentAppId))
                request.ComponentAppId = client.AppId;

            if (string.IsNullOrEmpty(request.ComponentSecret))
                request.ComponentSecret = client.AppSecret;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "component", "api_component_token")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentApiComponentTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/api_create_preauthcode 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/ThirdParty/token/pre_auth_code.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentApiCreatePreAuthCodeResponse> ExecuteCgibinComponentApiCreatePreAuthCodeAsync(this WechatApiClient client, Models.CgibinComponentApiCreatePreAuthCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.ComponentAppId))
                request.ComponentAppId = client.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "component", "api_create_preauthcode")
                .SetOptions(request)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentApiCreatePreAuthCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/api_query_auth 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/ThirdParty/token/authorization_info.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentApiQueryAuthResponse> ExecuteCgibinComponentApiQueryAuthAsync(this WechatApiClient client, Models.CgibinComponentApiQueryAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.ComponentAppId))
                request.ComponentAppId = client.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "component", "api_query_auth")
                .SetOptions(request)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentApiQueryAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/api_authorizer_token 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/ThirdParty/token/api_authorizer_token.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentApiAuthorizerTokenResponse> ExecuteCgibinComponentApiAuthorizerTokenAsync(this WechatApiClient client, Models.CgibinComponentApiAuthorizerTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.ComponentAppId))
                request.ComponentAppId = client.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "component", "api_authorizer_token")
                .SetOptions(request)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentApiAuthorizerTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/api_get_authorizer_info 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/ThirdParty/token/api_get_authorizer_info.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentApiGetAuthorizerInfoResponse> ExecuteCgibinComponentApiGetAuthorizerInfoAsync(this WechatApiClient client, Models.CgibinComponentApiGetAuthorizerInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.ComponentAppId))
                request.ComponentAppId = client.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "component", "api_get_authorizer_info")
                .SetOptions(request)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentApiGetAuthorizerInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/api_get_authorizer_list 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/ThirdParty/Account_Authorization/api_get_authorizer_list.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentApiGetAuthorizerListResponse> ExecuteCgibinComponentApiGetAuthorizerListAsync(this WechatApiClient client, Models.CgibinComponentApiGetAuthorizerListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.ComponentAppId))
                request.ComponentAppId = client.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "component", "api_get_authorizer_list")
                .SetOptions(request)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentApiGetAuthorizerListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/api_get_authorizer_option 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/ThirdParty/Account_Authorization/api_get_authorizer_option.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentApiGetAuthorizerOptionResponse> ExecuteCgibinComponentApiGetAuthorizerOptionAsync(this WechatApiClient client, Models.CgibinComponentApiGetAuthorizerOptionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.ComponentAppId))
                request.ComponentAppId = client.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "component", "api_get_authorizer_option")
                .SetOptions(request)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentApiGetAuthorizerOptionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/api_set_authorizer_option 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/ThirdParty/Account_Authorization/api_set_authorizer_option.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentApiSetAuthorizerOptionResponse> ExecuteCgibinComponentApiSetAuthorizerOptionAsync(this WechatApiClient client, Models.CgibinComponentApiSetAuthorizerOptionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.ComponentAppId))
                request.ComponentAppId = client.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "component", "api_set_authorizer_option")
                .SetOptions(request)
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentApiSetAuthorizerOptionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
