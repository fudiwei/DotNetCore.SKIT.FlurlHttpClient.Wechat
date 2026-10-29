namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    public static partial class WechatTenpayGlobalClientExecuteExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /refunds 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356624 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateRefundResponse> ExecuteCreateRefundAsync(this WechatTenpayGlobalClient client, Models.CreateRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "refunds");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /refunds/out-refund-no/{out_refund_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356625 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetRefundByOutRefundNumberResponse> ExecuteGetRefundByOutRefundNumberAsync(this WechatTenpayGlobalClient client, Models.GetRefundByOutRefundNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.OutRefundNumber, "out_refund_no");

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "refunds", "out-refund-no", request.OutRefundNumber!)
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetRefundByOutRefundNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /refunds/id/{refund_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356625 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetRefundByIdResponse> ExecuteGetRefundByIdAsync(this WechatTenpayGlobalClient client, Models.GetRefundByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            Utilities.HttpRequestGuard.AgainstEmptyPathVariable(request.RefundId, "refund_id");

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "refunds", "id", request.RefundId!)
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetRefundByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /refunds 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356627 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryRefundsResponse> ExecuteQueryRefundsAsync(this WechatTenpayGlobalClient client, Models.QueryRefundsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "refunds")
                .SetQueryParam("mchid", request.MerchantId)
                .SetQueryParam("out_trade_no", request.OutTradeNumber)
                .SetQueryParam("transaction_id", request.TransactionId)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("count", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryRefundsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
