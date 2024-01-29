using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteFundsToOverseaExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /funds-to-oversea/transactions/{transaction_id}/available_abroad_amounts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-funds-to-oversea/transaction-api/get-available-abroad-amount.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetFundsToOverseaTransactionAvailableAbroadAmountByTransactionIdResponse> ExecuteGetFundsToOverseaTransactionAvailableAbroadAmountByTransactionIdAsync(this WechatTenpayClient client, Models.GetFundsToOverseaTransactionAvailableAbroadAmountByTransactionIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "funds-to-oversea", "transactions", request.TransactionId, "available_abroad_amounts")
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetFundsToOverseaTransactionAvailableAbroadAmountByTransactionIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /funds-to-oversea/orders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-funds-to-oversea/funds-to-os-order-api/create-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateFundsToOverseaOrderResponse> ExecuteCreateFundsToOverseaOrderAsync(this WechatTenpayClient client, Models.CreateFundsToOverseaOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "funds-to-oversea", "orders");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateFundsToOverseaOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /funds-to-oversea/orders/{out_order_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-funds-to-oversea/funds-to-os-order-api/query-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetFundsToOverseaOrderByOutOrderIdResponse> ExecuteGetFundsToOverseaOrderByOutOrderIdAsync(this WechatTenpayClient client, Models.GetFundsToOverseaOrderByOutOrderIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "funds-to-oversea", "orders", request.OutOrderId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("transaction_id", request.TransactionId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetFundsToOverseaOrderByOutOrderIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /funds-to-oversea/bill-download-url 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-funds-to-oversea/purchase-payment-bill/query-download-info.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetFundsToOverseaBillDownloadUrlResponse> ExecuteGetFundsToOverseaBillDownloadUrlAsync(this WechatTenpayClient client, Models.GetFundsToOverseaBillDownloadUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "funds-to-oversea", "bill-download-url")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("bill_date", request.BillDateString);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetFundsToOverseaBillDownloadUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
