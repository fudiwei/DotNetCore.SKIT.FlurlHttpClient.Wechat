namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static partial class WechatApiClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /wxa/servicemarket 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/wx-service-market/api_invokeservice.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/partner/service_market/buyer_guideline/API/invokeService.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaServiceMarketResponse> ExecuteWxaServiceMarketAsync(this WechatApiClient client, Models.WxaServiceMarketRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "servicemarket")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaServiceMarketResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/servicemarketretrieve 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/wx-service-market/api_servicemarketretrieve.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaServiceMarketRetrieveResponse> ExecuteWxaServiceMarketRetrieveAsync(this WechatApiClient client, Models.WxaServiceMarketRetrieveRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "servicemarketretrieve")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaServiceMarketRetrieveResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/servicemarket/service/get_service_buyer_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/partner/service_market/interface/value_added/servicemarket_get_service_buyer_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaServiceMarketServiceGetServiceBuyerListResponse> ExecuteWxaServiceMarketServiceGetServiceBuyerListAsync(this WechatApiClient client, Models.WxaServiceMarketServiceGetServiceBuyerListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "servicemarket", "service", "get_service_buyer_list")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaServiceMarketServiceGetServiceBuyerListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/servicemarket/service/get_service_buyer 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/partner/service_market/interface/value_added/servicemarket_get_service_buyer.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaServiceMarketServiceGetServiceBuyerResponse> ExecuteWxaServiceMarketServiceGetServiceBuyerAsync(this WechatApiClient client, Models.WxaServiceMarketServiceGetServiceBuyerRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "servicemarket", "service", "get_service_buyer")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaServiceMarketServiceGetServiceBuyerResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/servicemarket/get_paid_order_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/partner/service_market/interface/value_added/servicemarket_get_paid_order_list.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaServiceMarketGetPaidOrderListResponse> ExecuteWxaServiceMarketGetPaidOrderListAsync(this WechatApiClient client, Models.WxaServiceMarketGetPaidOrderListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "servicemarket", "get_paid_order_list")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaServiceMarketGetPaidOrderListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/servicemarket/service/login_auth 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/partner/service_market/interface/value_added/servicemarket_login_auth.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaServiceMarketServiceLoginAuthResponse> ExecuteWxaServiceMarketServiceLoginAuthAsync(this WechatApiClient client, Models.WxaServiceMarketServiceLoginAuthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "servicemarket", "service", "login_auth")
                .SetQueryParam("access_token", request.ComponentAccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaServiceMarketServiceLoginAuthResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
