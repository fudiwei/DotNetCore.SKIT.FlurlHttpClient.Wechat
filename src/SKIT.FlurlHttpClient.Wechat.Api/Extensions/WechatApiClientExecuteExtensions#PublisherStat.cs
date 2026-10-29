namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static partial class WechatApiClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /publisher/stat?action=publisher_adpos_general 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/guide/open-ability/ad/ad-data-interface.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PublisherStatAdposGeneralResponse> ExecutePublisherStatAdposGeneralAsync(this WechatApiClient client, Models.PublisherStatAdposGeneralRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "publisher", "stat")
                .SetQueryParam("action", "publisher_adpos_general")
                .SetQueryParam("ad_slot", request.AdSlotName)
                .SetQueryParam("start_date", request.StartDateString)
                .SetQueryParam("end_date", request.EndDateString)
                .SetQueryParam("page", request.Page)
                .SetQueryParam("page_size", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.PublisherStatAdposGeneralResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /publisher/stat?action=publisher_cps_general 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/guide/open-ability/ad/ad-data-interface.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PublisherStatCpsGeneralResponse> ExecutePublisherStatCpsGeneralAsync(this WechatApiClient client, Models.PublisherStatCpsGeneralRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "publisher", "stat")
                .SetQueryParam("action", "publisher_cps_general")
                .SetQueryParam("start_date", request.StartDateString)
                .SetQueryParam("end_date", request.EndDateString)
                .SetQueryParam("page", request.Page)
                .SetQueryParam("page_size", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.PublisherStatCpsGeneralResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /publisher/stat?action=publisher_settlement 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/minigame/dev/guide/open-ability/ad/ad-data-interface.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PublisherStatSettlementResponse> ExecutePublisherStatSettlementAsync(this WechatApiClient client, Models.PublisherStatSettlementRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "publisher", "stat")
                .SetQueryParam("action", "publisher_settlement")
                .SetQueryParam("start_date", request.StartDateString)
                .SetQueryParam("end_date", request.EndDateString)
                .SetQueryParam("page", request.Page)
                .SetQueryParam("page_size", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.PublisherStatSettlementResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
