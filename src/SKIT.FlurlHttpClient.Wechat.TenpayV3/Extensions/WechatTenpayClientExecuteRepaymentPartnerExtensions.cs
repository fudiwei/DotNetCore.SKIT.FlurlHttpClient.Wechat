using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteRepaymentPartnerExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /repayment/combine-transactions/partner/prepay 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015124463 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateRepaymentPartnerCombineTransactionResponse> ExecuteCreateRepaymentPartnerCombineTransactionAsync(this WechatTenpayClient client, Models.CreateRepaymentPartnerCombineTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.CombineMerchantId is null)
                request.CombineMerchantId = client.Credentials.MerchantId;

            if (request.SubOrderList is not null)
            {
                foreach (var subOrder in request.SubOrderList)
                {
                    if (subOrder.MerchantId is null)
                        subOrder.MerchantId = request.CombineMerchantId;
                }
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "repayment", "combine-transactions", "partner", "prepay");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateRepaymentPartnerCombineTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /repayment/combine-transactions/partner/out-trade-no/{combine_out_trade_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015124483 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetRepaymentPartnerCombineTransactionByOutTradeNumberResponse> ExecuteGetRepaymentPartnerCombineTransactionByOutTradeNumberAsync(this WechatTenpayClient client, Models.GetRepaymentPartnerCombineTransactionByOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "repayment", "combine-transactions", "partner", "out-trade-no", request.CombineOutTradeNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetRepaymentPartnerCombineTransactionByOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /repayment/combine-transactions/partner/out-trade-no/{combine_out_trade_no}/close 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015124497 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CloseRepaymentPartnerCombineTransactionResponse> ExecuteCloseRepaymentPartnerCombineTransactionAsync(this WechatTenpayClient client, Models.CloseRepaymentPartnerCombineTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "repayment", "combine-transactions", "partner", "out-trade-no", request.CombineOutTradeNumber, "close");

            return await client.SendFlurlRequestAsJsonAsync<Models.CloseRepaymentPartnerCombineTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
