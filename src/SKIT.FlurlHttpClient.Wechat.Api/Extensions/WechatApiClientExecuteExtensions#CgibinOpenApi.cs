namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static partial class WechatApiClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/clear_quota 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/apimanage/api_clearquota.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/apimanage/api_clearquota.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/openApi-mgnt/api_clearquota.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/api/basic/api_clearquota.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/apimgnt/common/api_clearquota.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/openapi/api_clearquota.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinClearQuotaResponse> ExecuteCgibinClearQuotaAsync(this WechatApiClient client, Models.CgibinClearQuotaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "clear_quota")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinClearQuotaResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/clear_quota/v2 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/apimanage/api_clearquotabyappsecret.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/apimanage/api_clearquotabyappsecret.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/openApi-mgnt/api_clearquotabyappsecret.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/api/basic/api_clearquotabyappsecret.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/apimgnt/common/api_clearquotabyappsecret.html ]]>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/openapi/api_componentclearquota_v2.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinClearQuotaV2Response> ExecuteCgibinClearQuotaV2Async(this WechatApiClient client, Models.CgibinClearQuotaV2Request request, CancellationToken cancellationToken = default)
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "clear_quota", "v2")
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("appsecret", request.AppSecret);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinClearQuotaV2Response>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openapi/quota/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/apimanage/api_getapiquota.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/apimanage/api_getapiquota.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/openApi-mgnt/api_getapiquota.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/api/basic/api_getapiquota.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/apimgnt/common/api_getapiquota.html ]]>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/openapi/api_getapiquota.html ]]> <br/>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenApiQuotaGetResponse> ExecuteCgibinOpenApiQuotaGetAsync(this WechatApiClient client, Models.CgibinOpenApiQuotaGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "openapi", "quota", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOpenApiQuotaGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openapi/quota/clear 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/apimanage/api_clearapiquota.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/apimanage/api_clearapiquota.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/openApi-mgnt/api_clearapiquota.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/api/basic/api_clearapiquota.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/apimgnt/common/api_clearapiquota.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenApiQuotaClearResponse> ExecuteCgibinOpenApiQuotaClearAsync(this WechatApiClient client, Models.CgibinOpenApiQuotaClearRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "openapi", "quota", "clear")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOpenApiQuotaClearResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/openapi/rid/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/apimanage/api_getridinfo.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/apimanage/api_getridinfo.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/openApi-mgnt/api_getridinfo.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/channels/api/basic/api_getridinfo.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/apimgnt/common/api_getridinfo.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/openapi/api_getridinfo.html ]]> <br/>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinOpenApiRequestIdGetResponse> ExecuteCgibinOpenApiRequestIdGetAsync(this WechatApiClient client, Models.CgibinOpenApiRequestIdGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "cgi-bin", "openapi", "rid", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.CgibinOpenApiRequestIdGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
