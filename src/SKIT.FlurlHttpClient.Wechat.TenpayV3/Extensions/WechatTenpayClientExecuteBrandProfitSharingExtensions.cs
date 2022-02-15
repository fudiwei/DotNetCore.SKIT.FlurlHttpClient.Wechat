﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供连锁品牌分账相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteBrandProfitSharingExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /brand/profitsharing/orders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_7_1.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "brand", "profitsharing", "orders");

            return await client.SendRequestWithJsonAsync<Models.CreateBrandProfitSharingOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/profitsharing/orders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_7_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "brand", "profitsharing", "orders")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("transaction_id", request.TransactionId)
                .SetQueryParam("out_order_no", request.OutOrderNumber);

            return await client.SendRequestWithJsonAsync<Models.GetBrandProfitSharingOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/profitsharing/returnorders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_7_3.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "brand", "profitsharing", "returnorders");

            return await client.SendRequestWithJsonAsync<Models.CreateBrandProfitSharingReturnOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/profitsharing/returnorders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_7_4.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "brand", "profitsharing", "returnorders")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("out_order_no", request.OutOrderNumber)
                .SetQueryParam("out_return_no", request.OutReturnNumber);

            return await client.SendRequestWithJsonAsync<Models.GetBrandProfitSharingReturnOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/profitsharing/returnorders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_7_4.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "brand", "profitsharing", "returnorders")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("order_id", request.OrderId)
                .SetQueryParam("out_return_no", request.OutReturnNumber);

            return await client.SendRequestWithJsonAsync<Models.GetBrandProfitSharingReturnOrderByOrderIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/profitsharing/finish-order 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_7_5.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "brand", "profitsharing", "finish-order");

            return await client.SendRequestWithJsonAsync<Models.SetBrandProfitSharingOrderFinishResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/profitsharing/orders/{transaction_id}/amounts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_7_9.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "brand", "profitsharing", "orders", request.TransactionId, "amounts");

            return await client.SendRequestWithJsonAsync<Models.GetBrandProfitSharingOrderAmountsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /brand/profitsharing/brand-configs/{brand_mchid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_7_10.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "brand", "profitsharing", "brand-configs", request.BrandMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetBrandProfitSharingBrandConfigsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/profitsharing/receivers/add 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_7_7.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "brand", "profitsharing", "receivers", "add");

            return await client.SendRequestWithJsonAsync<Models.AddBrandProfitSharingReceiverResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /brand/profitsharing/receivers/delete 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_7_8.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "brand", "profitsharing", "receivers", "delete");

            return await client.SendRequestWithJsonAsync<Models.DeleteBrandProfitSharingReceiverResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
