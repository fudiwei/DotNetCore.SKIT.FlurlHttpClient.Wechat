namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static partial class WechatApiClientExecuteExtensions
    {
        #region Article
        /// <summary>
        /// <para>异步调用 [POST] /datacube/getarticlesummary 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/news/api_getarticlesummary.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/news/api_getarticlesummary.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetArticleSummaryResponse> ExecuteDataCubeGetArticleSummaryAsync(this WechatApiClient client, Models.DataCubeGetArticleSummaryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getarticlesummary")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetArticleSummaryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getarticletotal 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/news/api_getarticletotal.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/news/api_getarticletotal.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetArticleTotalResponse> ExecuteDataCubeGetArticleTotalAsync(this WechatApiClient client, Models.DataCubeGetArticleTotalRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getarticletotal")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetArticleTotalResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region User
        /// <summary>
        /// <para>异步调用 [POST] /datacube/getusersummary 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/user/api_getusersummary.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/user/api_getusersummary.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUserSummaryResponse> ExecuteDataCubeGetUserSummaryAsync(this WechatApiClient client, Models.DataCubeGetUserSummaryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getusersummary")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetUserSummaryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getusercumulate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/user/api_getusercumulate.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/user/api_getusercumulate.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUserCumulateResponse> ExecuteDataCubeGetUserCumulateAsync(this WechatApiClient client, Models.DataCubeGetUserCumulateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getusercumulate")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetUserCumulateResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getuserread 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/news/api_getuserread.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/news/api_getuserread.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUserReadResponse> ExecuteDataCubeGetUserReadAsync(this WechatApiClient client, Models.DataCubeGetUserReadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getuserread")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetUserReadResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getuserreadhour 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/news/api_getuserreadhour.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/news/api_getuserreadhour.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUserReadHourResponse> ExecuteDataCubeGetUserReadHourAsync(this WechatApiClient client, Models.DataCubeGetUserReadHourRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getuserreadhour")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetUserReadHourResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getusershare 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/news/api_getusershare.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/news/api_getusershare.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUserShareResponse> ExecuteDataCubeGetUserShareAsync(this WechatApiClient client, Models.DataCubeGetUserShareRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getusershare")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetUserShareResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getusersharehour 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/news/api_getusersharehour.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/news/api_getusersharehour.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUserShareHourResponse> ExecuteDataCubeGetUserShareHourAsync(this WechatApiClient client, Models.DataCubeGetUserShareHourRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getusersharehour")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetUserShareHourResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region UpstreamMessage
        /// <summary>
        /// <para>异步调用 [POST] /datacube/getupstreammsg 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/mess/api_getupstreammsg.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/mess/api_getupstreammsg.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUpstreamMessageResponse> ExecuteDataCubeGetUpstreamMessageAsync(this WechatApiClient client, Models.DataCubeGetUpstreamMessageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getupstreammsg")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetUpstreamMessageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getupstreammsghour 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/mess/api_getupstreammsghour.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/mess/api_getupstreammsghour.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUpstreamMessageHourResponse> ExecuteDataCubeGetUpstreamMessageHourAsync(this WechatApiClient client, Models.DataCubeGetUpstreamMessageHourRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getupstreammsghour")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetUpstreamMessageHourResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getupstreammsgweek 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/mess/api_getupstreammsgweek.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/mess/api_getupstreammsgweek.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUpstreamMessageWeekResponse> ExecuteDataCubeGetUpstreamMessageWeekAsync(this WechatApiClient client, Models.DataCubeGetUpstreamMessageWeekRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getupstreammsgweek")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetUpstreamMessageWeekResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getupstreammsgmonth 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/mess/api_getupstreammsgmonth.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/mess/api_getupstreammsgmonth.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUpstreamMessageMonthResponse> ExecuteDataCubeGetUpstreamMessageMonthAsync(this WechatApiClient client, Models.DataCubeGetUpstreamMessageMonthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getupstreammsgmonth")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetUpstreamMessageMonthResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getupstreammsgdist 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/mess/api_getupstreammsgdist.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/mess/api_getupstreammsgdist.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUpstreamMessageDistributionResponse> ExecuteDataCubeGetUpstreamMessageDistributionAsync(this WechatApiClient client, Models.DataCubeGetUpstreamMessageDistributionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getupstreammsgdist")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetUpstreamMessageDistributionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getupstreammsgdistweek 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/mess/api_getupstreammsgdistweek.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/mess/api_getupstreammsgdistweek.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUpstreamMessageDistributionWeekResponse> ExecuteDataCubeGetUpstreamMessageDistributionWeekAsync(this WechatApiClient client, Models.DataCubeGetUpstreamMessageDistributionWeekRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getupstreammsgdistweek")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetUpstreamMessageDistributionWeekResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getupstreammsgdistmonth 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/mess/api_getupstreammsgdistmonth.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/mess/api_getupstreammsgdistmonth.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetUpstreamMessageDistributionMonthResponse> ExecuteDataCubeGetUpstreamMessageDistributionMonthAsync(this WechatApiClient client, Models.DataCubeGetUpstreamMessageDistributionMonthRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getupstreammsgdistmonth")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetUpstreamMessageDistributionMonthResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Interface
        /// <summary>
        /// <para>异步调用 [POST] /datacube/getinterfacesummary 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/api/api_getinterfacesummary.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/api/api_getinterfacesummary.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetInterfaceSummaryResponse> ExecuteDataCubeGetInterfaceSummaryAsync(this WechatApiClient client, Models.DataCubeGetInterfaceSummaryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getinterfacesummary")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetInterfaceSummaryResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getinterfacesummaryhour 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/wedata/api/api_getinterfacesummaryhour.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/wedata/api/api_getinterfacesummaryhour.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetInterfaceSummaryHourResponse> ExecuteDataCubeGetInterfaceSummaryHourAsync(this WechatApiClient client, Models.DataCubeGetInterfaceSummaryHourRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getinterfacesummaryhour")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetInterfaceSummaryHourResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Card
        /// <summary>
        /// <para>异步调用 [POST] /datacube/getcardbizuininfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/card/Managing_Coupons_Vouchers_and_Cards.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetCardBusinessInfoResponse> ExecuteDataCubeGetCardBusinessInfoAsync(this WechatApiClient client, Models.DataCubeGetCardBusinessInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getcardbizuininfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetCardBusinessInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getcardcardinfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/card/Managing_Coupons_Vouchers_and_Cards.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetCardCardInfoResponse> ExecuteDataCubeGetCardCardInfoAsync(this WechatApiClient client, Models.DataCubeGetCardCardInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getcardcardinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetCardCardInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getcardmembercardinfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/card/Managing_Coupons_Vouchers_and_Cards.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetCardMemberCardInfoResponse> ExecuteDataCubeGetCardMemberCardInfoAsync(this WechatApiClient client, Models.DataCubeGetCardMemberCardInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getcardmembercardinfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetCardMemberCardInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getcardmembercarddetail 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/card/Managing_Coupons_Vouchers_and_Cards.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetCardMemberCardDetailResponse> ExecuteDataCubeGetCardMemberCardDetailAsync(this WechatApiClient client, Models.DataCubeGetCardMemberCardDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getcardmembercarddetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetCardMemberCardDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region WeAnalysis
        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappiddailyretaininfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/data-analysis/visit-retain/api_getdailyretain.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdDailyRetainInfoResponse> ExecuteDataCubeGetWeAnalysisAppIdDailyRetainInfoAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdDailyRetainInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getweanalysisappiddailyretaininfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetWeAnalysisAppIdDailyRetainInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappidmonthlyretaininfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/data-analysis/visit-retain/api_getmonthlyretain.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdMonthlyRetainInfoResponse> ExecuteDataCubeGetWeAnalysisAppIdMonthlyRetainInfoAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdMonthlyRetainInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getweanalysisappidmonthlyretaininfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetWeAnalysisAppIdMonthlyRetainInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappidweeklyretaininfo 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/data-analysis/visit-retain/api_getweeklyretain.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdWeeklyRetainInfoResponse> ExecuteDataCubeGetWeAnalysisAppIdWeeklyRetainInfoAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdWeeklyRetainInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getweanalysisappidweeklyretaininfo")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetWeAnalysisAppIdWeeklyRetainInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappiddailysummarytrend 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/data-analysis/others/api_getdailysummary.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdDailySummaryTrendResponse> ExecuteDataCubeGetWeAnalysisAppIdDailySummaryTrendAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdDailySummaryTrendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getweanalysisappiddailysummarytrend")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetWeAnalysisAppIdDailySummaryTrendResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappiddailyvisittrend 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/data-analysis/visit-trend/api_getdailyvisittrend.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdDailyVisitTrendResponse> ExecuteDataCubeGetWeAnalysisAppIdDailyVisitTrendAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdDailyVisitTrendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getweanalysisappiddailyvisittrend")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetWeAnalysisAppIdDailyVisitTrendResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappidmonthlyvisittrend 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/data-analysis/visit-trend/api_getmonthlyvisittrend.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdMonthlyVisitTrendResponse> ExecuteDataCubeGetWeAnalysisAppIdMonthlyVisitTrendAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdMonthlyVisitTrendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getweanalysisappidmonthlyvisittrend")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetWeAnalysisAppIdMonthlyVisitTrendResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappidweeklyvisittrend 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/data-analysis/visit-trend/api_getweeklyvisittrend.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdWeeklyVisitTrendResponse> ExecuteDataCubeGetWeAnalysisAppIdWeeklyVisitTrendAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdWeeklyVisitTrendRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getweanalysisappidweeklyvisittrend")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetWeAnalysisAppIdWeeklyVisitTrendResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappiduserportrait 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/data-analysis/others/api_getuserportrait.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdUserPortraitResponse> ExecuteDataCubeGetWeAnalysisAppIdUserPortraitAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdUserPortraitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getweanalysisappiduserportrait")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetWeAnalysisAppIdUserPortraitResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappidvisitdistribution 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/data-analysis/others/api_getvisitdistribution.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdVisitDistributionResponse> ExecuteDataCubeGetWeAnalysisAppIdVisitDistributionAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdVisitDistributionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getweanalysisappidvisitdistribution")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetWeAnalysisAppIdVisitDistributionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /datacube/getweanalysisappidvisitpage 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/data-analysis/others/api_getvisitpage.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetWeAnalysisAppIdVisitPageResponse> ExecuteDataCubeGetWeAnalysisAppIdVisitPageAsync(this WechatApiClient client, Models.DataCubeGetWeAnalysisAppIdVisitPageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getweanalysisappidvisitpage")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetWeAnalysisAppIdVisitPageResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region GameAnalysis
        /// <summary>
        /// <para>异步调用 [POST] /datacube/getgameanalysisdata 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/api-backend/data-analysis/api_analysis.getgameanalysisdata.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DataCubeGetGameAnalysisDataResponse> ExecuteDataCubeGetGameAnalysisDataAsync(this WechatApiClient client, Models.DataCubeGetGameAnalysisDataRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "datacube", "getgameanalysisdata")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.DataCubeGetGameAnalysisDataResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
