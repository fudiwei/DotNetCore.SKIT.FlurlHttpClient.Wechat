namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    public static partial class WechatTenpayGlobalClientExecutePartnerExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /refunds 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356446 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356480 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356498 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356520 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356537 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356556 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356624 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreatePartnerRefundResponse> ExecuteCreatePartnerRefundAsync(this WechatTenpayGlobalClient client, Models.CreatePartnerRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "refunds");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreatePartnerRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /refunds/out-refund-no/{out_refund_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356449 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356481 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356499 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356521 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356538 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356557 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356625 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPartnerRefundByOutRefundNumberResponse> ExecuteGetPartnerRefundByOutRefundNumberAsync(this WechatTenpayGlobalClient client, Models.GetPartnerRefundByOutRefundNumberRequest request, CancellationToken cancellationToken = default)
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
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPartnerRefundByOutRefundNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /refunds/id/{refund_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356449 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356481 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356499 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356521 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356538 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356557 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356625 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPartnerRefundByIdResponse> ExecuteGetPartnerRefundByIdAsync(this WechatTenpayGlobalClient client, Models.GetPartnerRefundByIdRequest request, CancellationToken cancellationToken = default)
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
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPartnerRefundByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /refunds 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356452 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356482 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356500 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356522 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356539 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356558 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/global/v3/en/4012356627 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryPartnerRefundsResponse> ExecuteQueryPartnerRefundsAsync(this WechatTenpayGlobalClient client, Models.QueryPartnerRefundsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
            {
                request.MerchantId = client.Credentials.MerchantId;
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "refunds")
                .SetQueryParam("sp_mchid", request.MerchantId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("out_trade_no", request.OutTradeNumber)
                .SetQueryParam("transaction_id", request.TransactionId)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("count", request.Limit);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryPartnerRefundsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
