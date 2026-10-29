namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static partial class WechatApiClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/token 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/base/api_getaccesstoken.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/base/api_getaccesstoken.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/mp-access-token/api_getaccesstoken.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/access-token/api_getaccesstoken.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/api/basic/api_getaccesstoken.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/apimgnt/common/api_getaccesstoken.html ]]> <br/>
        /// <![CDATA[ https://dev.weixin.qq.com/docs/framework/dev/openapi/getaccesstoken.html ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/stable_token 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/base/api_getstableaccesstoken.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/base/api_getstableaccesstoken.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/mp-access-token/api_getstableaccesstoken.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/access-token/api_getstableaccesstoken.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/api/basic/api_getstableaccesstoken.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/apimgnt/common/api_getstableaccesstoken.html ]]>
        /// </para>
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
            {
                request.AppId = client.Credentials.AppId;
            }

            if (request.AppSecret is null)
            {
                request.AppSecret = client.Credentials.AppSecret;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "stable_token");

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinStableTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/ticket/getticket 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/webdev/jssdk/api_getticket.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/webdev/js/api_getticket.html ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinTicketGetTicketResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/getcallbackip 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/base/api_getcallbackip.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/base/api_getcallbackip.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/api/basic/api_getcallbackip.html ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinGetCallbackIpResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/get_api_domain_ip 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/base/api_getapidomainip.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/base/api_getapidomainip.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/api/basic/api_getapidomainip.html ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinGetApiDomainIpResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/callback/check 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/base/api_callbackcheck.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/base/api_callbackcheck.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/api/basic/api_callbackcheck.html ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinCallbackCheckResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/changeopenid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/usermanage/changeopenid/api_changeopenid.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/usermanage/changeopenid/api_changeopenid.html ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinChangeOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/get_current_autoreply_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/notify/autoreplies/api_getcurrentautoreplyinfo.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/notify/autoreplies/api_getcurrentautoreplyinfo.html ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinGetCurrentAutoReplyInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
