namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static partial class WechatApiClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /wxa/checksession 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/user-login/api_checksessionkey.html ]]>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/login/api_checksessionkey.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaCheckSessionResponse> ExecuteWxaCheckSessionAsync(this WechatApiClient client, Models.WxaCheckSessionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxa", "checksession")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("sig_method", request.SignMethod);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaCheckSessionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxa/resetusersessionkey 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/user-login/api_resetusersessionkey.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/login/api_resetusersessionkey.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaResetUserSessionKeyResponse> ExecuteWxaResetUserSessionKeyAsync(this WechatApiClient client, Models.WxaResetUserSessionKeyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxa", "resetusersessionkey")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("sig_method", request.SignMethod);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaResetUserSessionKeyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxa/getpaidunionid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/user-info/basic-info/api_getpaidunionid.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetPaidUnionIdResponse> ExecuteWxaGetPaidUnionIdAsync(this WechatApiClient client, Models.WxaGetPaidUnionIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxa", "getpaidunionid")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("mch_id", request.MerchantId)
                .SetQueryParam("out_trade_no", request.OutTradeNumber)
                .SetQueryParam("transaction_id", request.TransactionId);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetPaidUnionIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/getpluginopenpid 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/user-info/basic-info/api_getpluginopenpid.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetPluginOpenIdResponse> ExecuteWxaGetPluginOpenIdAsync(this WechatApiClient client, Models.WxaGetPluginOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "getpluginopenpid")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetPluginOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Analysis
        /// <summary>
        /// <para>异步调用 [POST] /wxa/business/performance/boot 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/data-analysis/others/api_getperformancedata.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaBusinessPerformanceBootResponse> ExecuteWxaBusinessPerformanceBootAsync(this WechatApiClient client, Models.WxaBusinessPerformanceBootRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "business", "performance", "boot")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaBusinessPerformanceBootResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Charge
        /// <summary>
        /// <para>异步调用 [GET] /wxa/charge/usage/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/charge/api_getusagedetail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaChargeUsageGetResponse> ExecuteWxaChargeUsageGetAsync(this WechatApiClient client, Models.WxaChargeUsageGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxa", "charge", "usage", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("spuId", request.SPUId)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaChargeUsageGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxa/charge/usage/get_recent_average 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/charge/api_getrecentaverageusage.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaChargeUsageGetRecentAverageResponse> ExecuteWxaChargeUsageGetRecentAverageAsync(this WechatApiClient client, Models.WxaChargeUsageGetRecentAverageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxa", "charge", "usage", "get_recent_average")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("spuId", request.SPUId);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaChargeUsageGetRecentAverageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region HardwareDevice
        /// <summary>
        /// <para>异步调用 [POST] /wxa/getsnticket 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/hardware-device/api_getsnticket.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetSnTicketResponse> ExecuteWxaGetSnTicketAsync(this WechatApiClient client, Models.WxaGetSnTicketRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "getsnticket")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetSnTicketResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region LockStep
        /// <summary>
        /// <para>异步调用 [POST] /wxa/createwxagameroom 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/lock-step/api_lock-step.creategameroom.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaCreateWxaGameRoomResponse> ExecuteWxaCreateWxaGameRoomAsync(this WechatApiClient client, Models.WxaCreateWxaGameRoomRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "createwxagameroom")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaCreateWxaGameRoomResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxa/getwxagameframe 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/lock-step/api_lock-step.creategameroom.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetWxaGameFrameResponse> ExecuteWxaGetWxaGameFrameAsync(this WechatApiClient client, Models.WxaGetWxaGameFrameRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxa", "getwxagameframe")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("access_info", request.AccessInformation)
                .SetQueryParam("begin_frame_id", request.BeginFrameId)
                .SetQueryParam("end_frame_id", request.EndFrameId);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetWxaGameFrameResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxa/getwxagameidentityinfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/lock-step/api_lock-step.getgameidentityinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetWxaGameIdentityInfoResponse> ExecuteWxaGetWxaGameIdentityInfoAsync(this WechatApiClient client, Models.WxaGetWxaGameIdentityInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxa", "getwxagameidentityinfo")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("access_info", request.AccessInformation);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetWxaGameIdentityInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxa/getwxagameroominfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/lock-step/api_lock-step.getgameroominfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetWxaGameRoomInfoResponse> ExecuteWxaGetWxaGameRoomInfoAsync(this WechatApiClient client, Models.WxaGetWxaGameRoomInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxa", "getwxagameroominfo")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("access_info", request.AccessInformation);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetWxaGameRoomInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region NearybyPOI
        /// <summary>
        /// <para>异步调用 [POST] /wxa/addnearbypoi 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/nearby-poi/api_addnearbypoi.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaAddNearbyPOIResponse> ExecuteWxaAddNearbyPOIAsync(this WechatApiClient client, Models.WxaAddNearbyPOIRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "addnearbypoi")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaAddNearbyPOIResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/delnearbypoi 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/nearby-poi/api_deletenearbypoi.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaDeleteNearbyPOIResponse> ExecuteWxaDeleteNearbyPOIAsync(this WechatApiClient client, Models.WxaDeleteNearbyPOIRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "delnearbypoi")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaDeleteNearbyPOIResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxa/getnearbypoilist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/nearby-poi/api_getnearbypoilist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetNearbyPOIListResponse> ExecuteWxaGetNearbyPOIListAsync(this WechatApiClient client, Models.WxaGetNearbyPOIListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxa", "getnearbypoilist")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("page", request.Page)
                .SetQueryParam("page_rows", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetNearbyPOIListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/setnearbypoishowstatus 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/nearby-poi/api_setshowstatus.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSetNearbyPOIShowStatusResponse> ExecuteWxaSetNearbyPOIShowStatusAsync(this WechatApiClient client, Models.WxaSetNearbyPOIShowStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "setnearbypoishowstatus")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaSetNearbyPOIShowStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Operation
        /// <summary>
        /// <para>异步调用 [GET] /wxa/getwxadevinfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/operation/api_getdomaininfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetWxaDevInfoResponse> ExecuteWxaGetWxaDevInfoAsync(this WechatApiClient client, Models.WxaGetWxaDevInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxa", "getwxadevinfo")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("action", request.Action);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetWxaDevInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Plugin
        /// <summary>
        /// <para>异步调用 [POST] /wxa/plugin?action=apply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/plugin-management/api_manageplugin.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaPluginApplyResponse> ExecuteWxaPluginApplyAsync(this WechatApiClient client, Models.WxaPluginApplyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            request.Action = "apply";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "plugin")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaPluginApplyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/plugin?action=unbind 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/plugin-management/api_manageplugin.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaPluginUnbindResponse> ExecuteWxaPluginUnbindAsync(this WechatApiClient client, Models.WxaPluginUnbindRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            request.Action = "unbind";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "plugin")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaPluginUnbindResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/plugin?action=list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/plugin-management/api_manageplugin.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaPluginListResponse> ExecuteWxaPluginListAsync(this WechatApiClient client, Models.WxaPluginListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            request.Action = "list";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "plugin")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaPluginListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/devplugin?action=dev_apply_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/plugin-management/api_managepluginapplication.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaDevPluginDevApplyListResponse> ExecuteWxaDevPluginDevApplyListAsync(this WechatApiClient client, Models.WxaDevPluginDevApplyListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            request.Action = "dev_apply_list";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "devplugin")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaDevPluginDevApplyListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/devplugin?action=dev_agree 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/plugin-management/api_managepluginapplication.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaDevPluginDevAgreeResponse> ExecuteWxaDevPluginDevAgreeAsync(this WechatApiClient client, Models.WxaDevPluginDevAgreeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            request.Action = "dev_agree";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "devplugin")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaDevPluginDevAgreeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/devplugin?action=dev_refuse 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/plugin-management/api_managepluginapplication.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaDevPluginDevRefuseResponse> ExecuteWxaDevPluginDevRefuseAsync(this WechatApiClient client, Models.WxaDevPluginDevRefuseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            request.Action = "dev_refuse";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "devplugin")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaDevPluginDevRefuseResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/devplugin?action=dev_delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/plugin-management/api_managepluginapplication.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaDevPluginDevDeleteResponse> ExecuteWxaDevPluginDevDeleteAsync(this WechatApiClient client, Models.WxaDevPluginDevDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            request.Action = "dev_delete";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "devplugin")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaDevPluginDevDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region RiskControl
        /// <summary>
        /// <para>异步调用 [POST] /wxa/getuserriskrank 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/sec-center/safety-control-capability/api_getuserriskrank.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/safety-control-capability/api_getuserriskrank.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetUserRiskRankResponse> ExecuteWxaGetUserRiskRankAsync(this WechatApiClient client, Models.WxaGetUserRiskRankRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.AppId is null)
            {
                request.AppId = client.Credentials.AppId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "getuserriskrank")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetUserRiskRankResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Search
        /// <summary>
        /// <para>异步调用 [POST] /wxa/search/wxaapi_submitpages 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/wxsearch/api_submitpages.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSearchWxaApiSubmitPagesResponse> ExecuteWxaSearchWxaApiSubmitPagesAsync(this WechatApiClient client, Models.WxaSearchWxaApiSubmitPagesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "search", "wxaapi_submitpages")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaSearchWxaApiSubmitPagesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Security
        /// <summary>
        /// <para>异步调用 [POST] /wxa/img_sec_check 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2026-07-13 下线。")]
        public static async Task<Models.WxaImageSecurityCheckResponse> ExecuteWxaImageSecurityCheckAsync(this WechatApiClient client, Models.WxaImageSecurityCheckRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "img_sec_check")
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "image.png", fileBytes: request.FileBytes, fileContentType: "image/png", formDataName: "media");
            return await client.SendFlurlRequestAsync<Models.WxaImageSecurityCheckResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/media_check_async 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/sec-center/sec-check/api_mediacheckasync.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/wxa-sec-check/api_mediacheckasync.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaMediaCheckResponse> ExecuteWxaMediaCheckAsync(this WechatApiClient client, Models.WxaMediaCheckRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "media_check_async")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaMediaCheckResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/msg_sec_check 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/sec-center/sec-check/api_msgseccheck.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/wxa-sec-check/api_gamemsgseccheck.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaMessageSecurityCheckResponse> ExecuteWxaMessageSecurityCheckAsync(this WechatApiClient client, Models.WxaMessageSecurityCheckRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "msg_sec_check")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaMessageSecurityCheckResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ServiceMarket
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
        #endregion

        #region ShortLink
        /// <summary>
        /// <para>异步调用 [POST] /wxa/genwxashortlink 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/qrcode-link/short-link/api_generateshortlink.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGenerateWxaShortLinkResponse> ExecuteWxaGenerateWxaShortLinkAsync(this WechatApiClient client, Models.WxaGenerateWxaShortLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "genwxashortlink")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGenerateWxaShortLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Storage
        /// <summary>
        /// <para>异步调用 [POST] /wxa/remove_user_storage 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/data/api_storage.removeuserstorage.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaRemoveUserStorageResponse> ExecuteWxaRemoveUserStorageAsync(this WechatApiClient client, Models.WxaRemoveUserStorageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "remove_user_storage")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("sig_method", request.SignMethod);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaRemoveUserStorageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/setuserinteractivedata 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/data/api_storage.setuserinteractivedata.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSetUserInteractiveDataResponse> ExecuteWxaSetUserInteractiveDataAsync(this WechatApiClient client, Models.WxaSetUserInteractiveDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "setuserinteractivedata")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("sig_method", request.SignMethod);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaSetUserInteractiveDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/set_user_storage 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/data/api_storage.setuserstorage.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSetUserStorageResponse> ExecuteWxaSetUserStorageAsync(this WechatApiClient client, Models.WxaSetUserStorageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "set_user_storage")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("openid", request.OpenId)
                .SetQueryParam("signature", request.Signature)
                .SetQueryParam("sig_method", request.SignMethod);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaSetUserStorageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region UrlLink
        /// <summary>
        /// <para>异步调用 [POST] /wxa/generate_urllink 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/qrcode-link/url-link/api_generateurllink.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/url-link/api_generateurllink.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGenerateUrlLinkResponse> ExecuteWxaGenerateUrlLinkAsync(this WechatApiClient client, Models.WxaGenerateUrlLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "generate_urllink")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGenerateUrlLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/query_urllink 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/qrcode-link/url-link/api_queryurllink.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/url-link/api_queryurllink.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaQueryUrlLinkResponse> ExecuteWxaQueryUrlLinkAsync(this WechatApiClient client, Models.WxaQueryUrlLinkRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "query_urllink")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaQueryUrlLinkResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region UrlScheme
        /// <summary>
        /// <para>异步调用 [POST] /wxa/generatescheme 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/qrcode-link/url-scheme/api_generatescheme.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/url-scheme/api_generatescheme.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGenerateSchemeResponse> ExecuteWxaGenerateSchemeAsync(this WechatApiClient client, Models.WxaGenerateSchemeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "generatescheme")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGenerateSchemeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/queryscheme 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/qrcode-link/url-scheme/api_queryscheme.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/url-scheme/api_queryscheme.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaQuerySchemeResponse> ExecuteWxaQuerySchemeAsync(this WechatApiClient client, Models.WxaQuerySchemeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "queryscheme")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaQuerySchemeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/generatenfcscheme 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/qrcode-link/url-scheme/api_generatenfcscheme.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGenerateNFCSchemeResponse> ExecuteWxaGenerateNFCSchemeAsync(this WechatApiClient client, Models.WxaGenerateNFCSchemeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "generatenfcscheme")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGenerateNFCSchemeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region UserNotify
        /// <summary>
        /// <para>异步调用 [POST] /wxa/set_user_notify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/mp-message-management/subscribe-message/api_setusernotify.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSetUserNotifyResponse> ExecuteWxaSetUserNotifyAsync(this WechatApiClient client, Models.WxaSetUserNotifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "set_user_notify")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaSetUserNotifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/get_user_notify 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/mp-message-management/subscribe-message/api_getusernotify.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetUserNotifyResponse> ExecuteWxaGetUserNotifyAsync(this WechatApiClient client, Models.WxaGetUserNotifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "get_user_notify")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetUserNotifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/set_user_notifyext 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/mp-message-management/subscribe-message/api_setusernotifyext.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSetUserNotifyExtraResponse> ExecuteWxaSetUserNotifyExtraAsync(this WechatApiClient client, Models.WxaSetUserNotifyExtraRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "set_user_notifyext")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaSetUserNotifyExtraResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Vip
        /// <summary>
        /// <para>异步调用 [POST] /wxa/vip/user/info/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/wxamember/wxa/api_v3_wxa_adduserinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaVipUserInfoAddResponse> ExecuteWxaVipUserInfoAddAsync(this WechatApiClient client, Models.WxaVipUserInfoAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "vip", "user", "info", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaVipUserInfoAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/vip/user/info/update 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/wxamember/wxa/api_v3_wxa_updateuserinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaVipUserInfoUpdateResponse> ExecuteWxaVipUserInfoUpdateAsync(this WechatApiClient client, Models.WxaVipUserInfoUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "vip", "user", "info", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaVipUserInfoUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/vip/user/info/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/wxamember/wxa/api_v3_wxa_getuserinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaVipUserInfoGetResponse> ExecuteWxaVipUserInfoGetAsync(this WechatApiClient client, Models.WxaVipUserInfoGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "vip", "user", "info", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaVipUserInfoGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/vip/user/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/wxamember/wxa/api_v3_wxa_getuserlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaVipUserListGetResponse> ExecuteWxaVipUserListGetAsync(this WechatApiClient client, Models.WxaVipUserListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "vip", "user", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaVipUserListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/vip/user/info/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/wxamember/wxa/api_v3_wxa_deluserinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaVipUserInfoDeleteResponse> ExecuteWxaVipUserInfoDeleteAsync(this WechatApiClient client, Models.WxaVipUserInfoDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "vip", "user", "info", "delete")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaVipUserInfoDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/vip/shop/list/get 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/store/shop/API/wxamember/wxa/api_v3_wxa_getshoplist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaVipShopListGetResponse> ExecuteWxaVipShopListGetAsync(this WechatApiClient client, Models.WxaVipShopListGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "vip", "shop", "list", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaVipShopListGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region WxaCode
        /// <summary>
        /// <para>异步调用 [POST] /wxa/getwxacode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/qrcode-link/qr-code/api_getqrcode.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/qr-code/api_getqrcode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetWxaCodeResponse> ExecuteWxaGetWxaCodeAsync(this WechatApiClient client, Models.WxaGetWxaCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "getwxacode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetWxaCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/getwxacodeunlimit 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/qrcode-link/qr-code/api_getunlimitedqrcode.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/qr-code/api_getunlimitedqrcode.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetWxaCodeUnlimitResponse> ExecuteWxaGetWxaCodeUnlimitAsync(this WechatApiClient client, Models.WxaGetWxaCodeUnlimitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "getwxacodeunlimit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetWxaCodeUnlimitResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region WxaStore
        /// <summary>
        /// <para>异步调用 [GET] /wxa/get_merchant_category 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/stores/miniapp/api_getwxastorecatelist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/stores/miniapp/api_getwxastorecatelist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetMerchantCategoryResponse> ExecuteWxaGetMerchantCategoryAsync(this WechatApiClient client, Models.WxaGetMerchantCategoryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxa", "get_merchant_category")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetMerchantCategoryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/apply_merchant 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/stores/miniapp/api_applywxastore.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/stores/miniapp/api_applywxastore.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaApplyMerchantResponse> ExecuteWxaApplyMerchantAsync(this WechatApiClient client, Models.WxaApplyMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "apply_merchant")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaApplyMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxa/get_merchant_audit_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/stores/miniapp/api_getwxastoreauditinfo.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/stores/miniapp/api_getwxastoreauditinfo.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetMerchantAuditInfoResponse> ExecuteWxaGetMerchantAuditInfoAsync(this WechatApiClient client, Models.WxaGetMerchantAuditInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxa", "get_merchant_audit_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetMerchantAuditInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/modify_merchant 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/stores/miniapp/api_modifywxastore.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/stores/miniapp/api_modifywxastore.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaModifyMerchantResponse> ExecuteWxaModifyMerchantAsync(this WechatApiClient client, Models.WxaModifyMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "modify_merchant")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaModifyMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /wxa/get_district 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/stores/miniapp/api_getdistrictlist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/stores/miniapp/api_getdistrictlist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetDistrictResponse> ExecuteWxaGetDistrictAsync(this WechatApiClient client, Models.WxaGetDistrictRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "wxa", "get_district")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetDistrictResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/search_map_poi 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/stores/miniapp/api_poilistsearch.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/stores/miniapp/api_poilistsearch.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaSearchMapPOIResponse> ExecuteWxaSearchMapPOIAsync(this WechatApiClient client, Models.WxaSearchMapPOIRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "search_map_poi")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaSearchMapPOIResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/create_map_poi 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/stores/miniapp/api_createnewpoid.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/stores/miniapp/api_createnewpoid.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaCreateMapPOIResponse> ExecuteWxaCreateMapPOIAsync(this WechatApiClient client, Models.WxaCreateMapPOIRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "create_map_poi")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaCreateMapPOIResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/add_store 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/stores/miniapp/api_addentityshop.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/stores/miniapp/api_addentityshop.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaAddStoreResponse> ExecuteWxaAddStoreAsync(this WechatApiClient client, Models.WxaAddStoreRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "add_store")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaAddStoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/update_store 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/stores/miniapp/api_newupdatepoi.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/stores/miniapp/api_newupdatepoi.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaUpdateStoreResponse> ExecuteWxaUpdateStoreAsync(this WechatApiClient client, Models.WxaUpdateStoreRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "update_store")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaUpdateStoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/get_store_info 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/stores/miniapp/api_newgetpoi.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/stores/miniapp/api_newgetpoi.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetStoreInfoResponse> ExecuteWxaGetStoreInfoAsync(this WechatApiClient client, Models.WxaGetStoreInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "get_store_info")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetStoreInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/get_store_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/stores/miniapp/api_newgetpoilist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/stores/miniapp/api_newgetpoilist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaGetStoreListResponse> ExecuteWxaGetStoreListAsync(this WechatApiClient client, Models.WxaGetStoreListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "get_store_list")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaGetStoreListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /wxa/del_store 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/stores/miniapp/api_newdelpoi.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/stores/miniapp/api_newdelpoi.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.WxaDeleteStoreResponse> ExecuteWxaDeleteStoreAsync(this WechatApiClient client, Models.WxaDeleteStoreRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "wxa", "del_store")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.WxaDeleteStoreResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
