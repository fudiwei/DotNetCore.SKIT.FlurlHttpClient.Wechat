using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteProfitSharingExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /profitsharing/orders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/profit-sharing/orders/create-order.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/profit-sharing/orders/create-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateProfitSharingOrderResponse> ExecuteCreateProfitSharingOrderAsync(this WechatTenpayClient client, Models.CreateProfitSharingOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "profitsharing", "orders");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateProfitSharingOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /profitsharing/orders/{out_order_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/profit-sharing/orders/query-order.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/profit-sharing/orders/query-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetProfitSharingOrderByOutOrderNumberResponse> ExecuteGetProfitSharingOrderByOutOrderNumberAsync(this WechatTenpayClient client, Models.GetProfitSharingOrderByOutOrderNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "profitsharing", "orders", request.OutOrderNumber)
                .SetQueryParam("transaction_id", request.TransactionId);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetProfitSharingOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /profitsharing/return-orders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/profit-sharing/return-orders/create-return-order.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/profit-sharing/return-orders/create-return-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateProfitSharingReturnOrderResponse> ExecuteCreateProfitSharingReturnOrderAsync(this WechatTenpayClient client, Models.CreateProfitSharingReturnOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "profitsharing", "return-orders");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateProfitSharingReturnOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /profitsharing/return-orders/{out_order_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/profit-sharing/return-orders/query-return-order.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/profit-sharing/return-orders/query-return-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetProfitSharingReturnOrderByOutOrderNumberResponse> ExecuteGetProfitSharingReturnOrderByOutOrderNumberAsync(this WechatTenpayClient client, Models.GetProfitSharingReturnOrderByOutOrderNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "profitsharing", "return-orders", request.OutReturnNumber)
                .SetQueryParam("out_order_no", request.OutOrderNumber);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetProfitSharingReturnOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /profitsharing/orders/unfreeze 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/profit-sharing/orders/unfreeze-order.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/profit-sharing/orders/unfreeze-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetProfitSharingOrderUnfrozenResponse> ExecuteSetProfitSharingOrderUnfrozenAsync(this WechatTenpayClient client, Models.SetProfitSharingOrderUnfrozenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "profitsharing", "orders", "unfreeze");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetProfitSharingOrderUnfrozenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /profitsharing/transactions/{transaction_id}/amounts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/profit-sharing/transactions/query-order-amount.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/profit-sharing/transactions/query-order-amount.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetProfitSharingTransactionAmountsResponse> ExecuteGetProfitSharingTransactionAmountsAsync(this WechatTenpayClient client, Models.GetProfitSharingTransactionAmountsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "profitsharing", "transactions", request.TransactionId, "amounts");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetProfitSharingTransactionAmountsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /profitsharing/merchant-configs/{sub_mchid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/profit-sharing/merchants/query-merchant-ratio.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/profit-sharing/merchants/query-merchant-ratio.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetProfitSharingMerchantConfigsResponse> ExecuteGetProfitSharingMerchantConfigsAsync(this WechatTenpayClient client, Models.GetProfitSharingMerchantConfigsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "profitsharing", "merchant-configs", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetProfitSharingMerchantConfigsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /profitsharing/receivers/add 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/profit-sharing/receivers/add-receiver.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/profit-sharing/receivers/add-receiver.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddProfitSharingReceiverResponse> ExecuteAddProfitSharingReceiverAsync(this WechatTenpayClient client, Models.AddProfitSharingReceiverRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "profitsharing", "receivers", "add");

            return await client.SendFlurlRequestAsJsonAsync<Models.AddProfitSharingReceiverResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /profitsharing/receivers/delete 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/profit-sharing/receivers/delete-receiver.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/profit-sharing/receivers/delete-receiver.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteProfitSharingReceiverResponse> ExecuteDeleteProfitSharingReceiverAsync(this WechatTenpayClient client, Models.DeleteProfitSharingReceiverRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "profitsharing", "receivers", "delete");

            return await client.SendFlurlRequestAsJsonAsync<Models.DeleteProfitSharingReceiverResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Bills
        /// <summary>
        /// <para>异步调用 [GET] /profitsharing/bills 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/profit-sharing/bill-shipment/split-bill.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/profit-sharing/bill-shipment/split-bill.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-bill-download/split-bill.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetProfitSharingBillResponse> ExecuteGetProfitSharingBillAsync(this WechatTenpayClient client, Models.GetProfitSharingBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "profitsharing", "bills")
                .SetQueryParam("bill_date", request.BillDateString);

            if (request.SubMerchantId is not null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            if (request.TarType is not null)
                flurlReq.SetQueryParam("tar_type", request.TarType);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetProfitSharingBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
