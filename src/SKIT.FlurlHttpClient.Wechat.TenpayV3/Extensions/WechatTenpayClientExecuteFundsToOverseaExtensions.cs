using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供电商收付通跨境付款相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteFundsToOverseaExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /funds-to-oversea/transactions/{transaction_id}/available_abroad_amounts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_10_1.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "funds-to-oversea", "transactions", request.TransactionId, "available_abroad_amounts")
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetFundsToOverseaTransactionAvailableAbroadAmountByTransactionIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /funds-to-oversea/orders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_10_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "funds-to-oversea", "orders");

            return await client.SendRequestWithJsonAsync<Models.CreateFundsToOverseaOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /funds-to-oversea/orders/{out_order_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_10_3.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "funds-to-oversea", "orders", request.OutOrderId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("transaction_id", request.TransactionId);

            return await client.SendRequestWithJsonAsync<Models.GetFundsToOverseaOrderByOutOrderIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /funds-to-oversea/bill-download-url 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_10_4.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "funds-to-oversea", "bill-download-url")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("bill_date", request.BillDateString);

            return await client.SendRequestWithJsonAsync<Models.GetFundsToOverseaBillDownloadUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
