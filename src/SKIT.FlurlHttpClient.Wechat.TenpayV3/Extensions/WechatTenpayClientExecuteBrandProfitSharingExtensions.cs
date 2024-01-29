using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteBrandProfitSharingExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /brand/profitsharing/orders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/brand-profit-sharing/orders/create-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateBrandProfitSharingOrderResponse> ExecuteCreateBrandProfitSharingOrderAsync(this WechatTenpayClient client, Models.CreateBrandProfitSharingOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "profitsharing", "orders");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateBrandProfitSharingOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/profitsharing/orders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/brand-profit-sharing/orders/query-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBrandProfitSharingOrderByOutOrderNumberResponse> ExecuteGetBrandProfitSharingOrderByOutOrderNumberAsync(this WechatTenpayClient client, Models.GetBrandProfitSharingOrderByOutOrderNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "brand", "profitsharing", "orders")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("transaction_id", request.TransactionId)
                .SetQueryParam("out_order_no", request.OutOrderNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBrandProfitSharingOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/profitsharing/returnorders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/brand-profit-sharing/return-orders/create-return-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateBrandProfitSharingReturnOrderResponse> ExecuteCreateBrandProfitSharingReturnOrderAsync(this WechatTenpayClient client, Models.CreateBrandProfitSharingReturnOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "profitsharing", "returnorders");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateBrandProfitSharingReturnOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/profitsharing/returnorders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/brand-profit-sharing/return-orders/query-return-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBrandProfitSharingReturnOrderByOutOrderNumberResponse> ExecuteGetBrandProfitSharingReturnOrderByOutOrderNumberAsync(this WechatTenpayClient client, Models.GetBrandProfitSharingReturnOrderByOutOrderNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "brand", "profitsharing", "returnorders")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("out_order_no", request.OutOrderNumber)
                .SetQueryParam("out_return_no", request.OutReturnNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBrandProfitSharingReturnOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/profitsharing/returnorders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/brand-profit-sharing/return-orders/query-return-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBrandProfitSharingReturnOrderByOrderIdResponse> ExecuteGetBrandProfitSharingReturnOrderByOrderIdAsync(this WechatTenpayClient client, Models.GetBrandProfitSharingReturnOrderByOrderIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "brand", "profitsharing", "returnorders")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("order_id", request.OrderId)
                .SetQueryParam("out_return_no", request.OutReturnNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBrandProfitSharingReturnOrderByOrderIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/profitsharing/finish-order 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/brand-profit-sharing/orders/finish-order.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetBrandProfitSharingOrderFinishResponse> ExecuteSetBrandProfitSharingOrderFinishAsync(this WechatTenpayClient client, Models.SetBrandProfitSharingOrderFinishRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "profitsharing", "finish-order");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetBrandProfitSharingOrderFinishResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/profitsharing/orders/{transaction_id}/amounts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/brand-profit-sharing/orders/query-order-amount.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBrandProfitSharingOrderAmountsResponse> ExecuteGetBrandProfitSharingOrderAmountsAsync(this WechatTenpayClient client, Models.GetBrandProfitSharingOrderAmountsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "brand", "profitsharing", "orders", request.TransactionId, "amounts");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBrandProfitSharingOrderAmountsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/profitsharing/brand-configs/{brand_mchid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/brand-profit-sharing/merchants/query-brand-merchant-ratio.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBrandProfitSharingBrandConfigsResponse> ExecuteGetBrandProfitSharingBrandConfigsAsync(this WechatTenpayClient client, Models.GetBrandProfitSharingBrandConfigsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "brand", "profitsharing", "brand-configs", request.BrandMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBrandProfitSharingBrandConfigsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/profitsharing/receivers/add 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/brand-profit-sharing/receivers/add-receiver.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddBrandProfitSharingReceiverResponse> ExecuteAddBrandProfitSharingReceiverAsync(this WechatTenpayClient client, Models.AddBrandProfitSharingReceiverRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "profitsharing", "receivers", "add");

            return await client.SendFlurlRequestAsJsonAsync<Models.AddBrandProfitSharingReceiverResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/profitsharing/receivers/delete 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/brand-profit-sharing/receivers/delete-receiver.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteBrandProfitSharingReceiverResponse> ExecuteDeleteBrandProfitSharingReceiverAsync(this WechatTenpayClient client, Models.DeleteBrandProfitSharingReceiverRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "brand", "profitsharing", "receivers", "delete");

            return await client.SendFlurlRequestAsJsonAsync<Models.DeleteBrandProfitSharingReceiverResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
