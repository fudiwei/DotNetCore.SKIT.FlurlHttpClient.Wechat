namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static partial class WechatTenpayClientExecuteExtensions
    {
        #region ECTradeRisk
        /// <summary>
        /// <para>异步调用 [POST] /merchant-risk-manage/ec-trade-risk/query-risk-trades 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013894247 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMerchantRiskManageECTradeRiskTradesResponse> ExecuteQueryMerchantRiskManageECTradeRiskTradesAsync(this WechatTenpayClient client, Models.QueryMerchantRiskManageECTradeRiskTradesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant-risk-manage", "ec-trade-risk", "query-risk-trades");

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMerchantRiskManageECTradeRiskTradesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant-risk-manage/ec-trade-risk/recv-dispose-result 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013894250 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantRiskManageECTradeRiskResultResponse> ExecuteCreateMerchantRiskManageECTradeRiskResultAsync(this WechatTenpayClient client, Models.CreateMerchantRiskManageECTradeRiskResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant-risk-manage", "ec-trade-risk", "recv-dispose-result");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantRiskManageECTradeRiskResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant-risk-manage/ec-trade-risk/query-risk-trades 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013894221 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMerchantRiskManagePartnerECTradeRiskTradesResponse> ExecuteQueryMerchantRiskManagePartnerECTradeRiskTradesAsync(this WechatTenpayClient client, Models.QueryMerchantRiskManagePartnerECTradeRiskTradesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant-risk-manage", "ec-trade-risk", "query-risk-trades");

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMerchantRiskManagePartnerECTradeRiskTradesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant-risk-manage/ec-trade-risk/recv-dispose-result 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013894227 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantRiskManagePartnerECTradeRiskResultResponse> ExecuteCreateMerchantRiskManagePartnerECTradeRiskResultAsync(this WechatTenpayClient client, Models.CreateMerchantRiskManagePartnerECTradeRiskResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant-risk-manage", "ec-trade-risk", "recv-dispose-result");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantRiskManagePartnerECTradeRiskResultResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
