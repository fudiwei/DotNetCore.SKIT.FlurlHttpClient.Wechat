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
    public static class WechatApiClientExecuteSnsExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /sns/oauth2/access_token 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/OA_Web_Apps/Wechat_webpage_authorization.html#1 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Mobile_App/WeChat_Login/Development_Guide.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Website_App/WeChat_Login/Wechat_Login.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SnsOAuth2AccessTokenResponse> ExecuteSnsOAuth2AccessTokenAsync(this WechatApiClient client, Models.SnsOAuth2AccessTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "sns", "oauth2", "access_token")
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("appid", client.Credentials.AppId)
                .SetQueryParam("secret", client.Credentials.AppSecret)
                .SetQueryParam("code", request.Code);

            return await client.SendRequestWithJsonAsync<Models.SnsOAuth2AccessTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /sns/oauth2/refresh_token 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/OA_Web_Apps/Wechat_webpage_authorization.html#1 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Mobile_App/WeChat_Login/Development_Guide.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Website_App/WeChat_Login/Wechat_Login.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SnsOAuth2RefreshTokenResponse> ExecuteSnsOAuth2RefreshTokenAsync(this WechatApiClient client, Models.SnsOAuth2RefreshTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "sns", "oauth2", "refresh_token")
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("appid", client.Credentials.AppId)
                .SetQueryParam("refresh_token", request.RefreshToken);

            return await client.SendRequestWithJsonAsync<Models.SnsOAuth2RefreshTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /sns/userinfo 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/OA_Web_Apps/Wechat_webpage_authorization.html#3 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Mobile_App/WeChat_Login/Authorized_API_call_UnionID.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Website_App/WeChat_Login/Authorized_Interface_Calling_UnionID.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SnsUserInfoResponse> ExecuteSnsUserInfoAsync(this WechatApiClient client, Models.SnsUserInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "sns", "userinfo")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("lang", request.Language);

            return await client.SendRequestWithJsonAsync<Models.SnsUserInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /sns/auth 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/OA_Web_Apps/Wechat_webpage_authorization.html#4 </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Mobile_App/WeChat_Login/Development_Guide.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Website_App/WeChat_Login/Wechat_Login.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SnsAuthResponse> ExecuteSnsAuthAsync(this WechatApiClient client, Models.SnsAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "sns", "auth")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId);

            return await client.SendRequestWithJsonAsync<Models.SnsAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /sns/jscode2session 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/login/auth.code2Session.html </para>
        /// <para>REF: https://developers.weixin.qq.com/minigame/dev/api-backend/open-api/login/auth.code2Session.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SnsJsCode2SessionResponse> ExecuteSnsJsCode2SessionAsync(this WechatApiClient client, Models.SnsJsCode2SessionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "sns", "jscode2session")
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("appid", client.Credentials.AppId)
                .SetQueryParam("secret", client.Credentials.AppSecret)
                .SetQueryParam("js_code", request.JsCode);

            return await client.SendRequestWithJsonAsync<Models.SnsJsCode2SessionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Component
        /// <summary>
        /// <para>异步调用 [GET] /sns/component/jscode2session 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/others/WeChat_login.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SnsComponentJsCode2SessionResponse> ExecuteSnsComponentJsCode2SessionAsync(this WechatApiClient client, Models.SnsComponentJsCode2SessionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.ComponentAppId == null)
                request.ComponentAppId = client.Credentials.AppId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "sns", "component", "jscode2session")
                .SetQueryParam("grant_type", request.GrantType)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("component_appid", request.ComponentAppId)
                .SetQueryParam("component_access_token", request.ComponentAccessToken)
                .SetQueryParam("js_code", request.JsCode);

            return await client.SendRequestWithJsonAsync<Models.SnsComponentJsCode2SessionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
