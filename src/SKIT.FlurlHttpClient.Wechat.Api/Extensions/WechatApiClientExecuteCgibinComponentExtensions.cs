using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
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

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            if (request.ComponentSecret == null)
                request.ComponentSecret = client.Credentials.AppSecret;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "api_start_push_ticket");

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

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            if (request.ComponentSecret == null)
                request.ComponentSecret = client.Credentials.AppSecret;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "api_component_token");

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

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "api_create_preauthcode")
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

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "api_query_auth")
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

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "api_authorizer_token")
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

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "api_get_authorizer_info")
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

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "api_get_authorizer_list")
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

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "api_get_authorizer_option")
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

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "api_set_authorizer_option")
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentApiSetAuthorizerOptionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/fastregisterweapp?action=create 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/Register_Mini_Programs/Fast_Registration_Interface_document.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentFastRegisterWeappCreateResponse> ExecuteCgibinComponentFastRegisterWeappCreateAsync(this WechatApiClient client, Models.CgibinComponentFastRegisterWeappCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "fastregisterweapp")
                .SetQueryParam("action", "create")
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentFastRegisterWeappCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/fastregisterweapp?action=search 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/Register_Mini_Programs/Fast_Registration_Interface_document.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentFastRegisterWeappSearchResponse> ExecuteCgibinComponentFastRegisterWeappSearchAsync(this WechatApiClient client, Models.CgibinComponentFastRegisterWeappSearchRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "fastregisterweapp")
                .SetQueryParam("action", "search")
                .SetQueryParam("component_access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentFastRegisterWeappSearchResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/modify_wxa_server_domain 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/ThirdParty/domain/modify_server_domain.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentModifyWxaServerDomainResponse> ExecuteCgibinComponentModifyWxaServerDomainAsync(this WechatApiClient client, Models.CgibinComponentModifyWxaServerDomainRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "modify_wxa_server_domain")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentModifyWxaServerDomainResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/get_domain_confirmfile 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/ThirdParty/domain/get_domain_confirmfile.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentGetDomainConfirmFileResponse> ExecuteCgibinComponentGetDomainConfirmFileAsync(this WechatApiClient client, Models.CgibinComponentGetDomainConfirmFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "get_domain_confirmfile")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentGetDomainConfirmFileResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/modify_wxa_jump_domain 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/ThirdParty/domain/modify_jump_domain.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentModifyWxaJumpDomainResponse> ExecuteCgibinComponentModifyWxaJumpDomainAsync(this WechatApiClient client, Models.CgibinComponentModifyWxaJumpDomainRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "modify_wxa_jump_domain")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentModifyWxaJumpDomainResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/setprivacysetting 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/privacy_config/set_privacy_setting.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentSetPrivacySettingResponse> ExecuteCgibinComponentSetPrivacySettingAsync(this WechatApiClient client, Models.CgibinComponentSetPrivacySettingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "setprivacysetting")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentSetPrivacySettingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/getprivacysetting 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/privacy_config/get_privacy_setting.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentGetPrivacySettingResponse> ExecuteCgibinComponentGetPrivacySettingAsync(this WechatApiClient client, Models.CgibinComponentGetPrivacySettingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "getprivacysetting")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinComponentGetPrivacySettingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/component/uploadprivacyextfile 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/privacy_config/upload_privacy_exfile.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinComponentUploadPrivacyExtraFileResponse> ExecuteCgibinComponentUploadPrivacyExtraFileAsync(this WechatApiClient client, Models.CgibinComponentUploadPrivacyExtraFileRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName == null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".txt";

            if (request.FileContentType == null)
                request.FileContentType = "text/plain";

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "component", "uploadprivacyextfile")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, formDataName: "file");
            return await client.SendRequestAsync<Models.CgibinComponentUploadPrivacyExtraFileResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken);
        }
    }
}
