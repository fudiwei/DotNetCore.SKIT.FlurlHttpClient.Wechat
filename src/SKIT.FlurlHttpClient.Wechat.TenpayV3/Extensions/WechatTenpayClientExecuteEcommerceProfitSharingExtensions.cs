using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供电商收付通分账相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteEcommerceProfitSharingExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/profitsharing/orders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceProfitSharingOrderResponse> ExecuteCreateEcommerceProfitSharingOrderAsync(this WechatTenpayClient client, Models.CreateEcommerceProfitSharingOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "ecommerce", "profitsharing", "orders")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CreateEcommerceProfitSharingOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/profitsharing/orders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceProfitSharingOrderByOutOrderNumberResponse> ExecuteGetEcommerceProfitSharingOrderByOutOrderNumberAsync(this WechatTenpayClient client, Models.GetEcommerceProfitSharingOrderByOutOrderNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "ecommerce", "profitsharing", "orders")
                .SetOptions(request)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("transaction_id", request.TransactionId)
                .SetQueryParam("out_order_no", request.OutOrderNumber);

            return await client.SendRequestAsync<Models.GetEcommerceProfitSharingOrderByOutOrderNumberResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/profitsharing/returnorders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceProfitSharingReturnOrderResponse> ExecuteCreateEcommerceProfitSharingReturnOrderAsync(this WechatTenpayClient client, Models.CreateEcommerceProfitSharingReturnOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "ecommerce", "profitsharing", "returnorders")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CreateEcommerceProfitSharingReturnOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/profitsharing/returnorders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceProfitSharingReturnOrderByOutOrderNumberResponse> ExecuteGetEcommerceProfitSharingReturnOrderByOutOrderNumberAsync(this WechatTenpayClient client, Models.GetEcommerceProfitSharingReturnOrderByOutOrderNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "ecommerce", "profitsharing", "returnorders")
                .SetOptions(request)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("out_order_no", request.OutOrderNumber)
                .SetQueryParam("out_return_no", request.OutReturnNumber);

            return await client.SendRequestAsync<Models.GetEcommerceProfitSharingReturnOrderByOutOrderNumberResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/profitsharing/returnorders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceProfitSharingReturnOrderByOrderIdResponse> ExecuteGetEcommerceProfitSharingReturnOrderByOrderIdAsync(this WechatTenpayClient client, Models.GetEcommerceProfitSharingReturnOrderByOrderIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "ecommerce", "profitsharing", "returnorders")
                .SetOptions(request)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("order_id", request.OrderId)
                .SetQueryParam("out_return_no", request.OutReturnNumber);

            return await client.SendRequestAsync<Models.GetEcommerceProfitSharingReturnOrderByOrderIdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/profitsharing/finish-order 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetEcommerceProfitSharingOrderFinishResponse> ExecuteSetEcommerceProfitSharingOrderFinishAsync(this WechatTenpayClient client, Models.SetEcommerceProfitSharingOrderFinishRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "ecommerce", "profitsharing", "finish-order")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.SetEcommerceProfitSharingOrderFinishResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/profitsharing/orders/{transaction_id}/amounts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_9.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceProfitSharingOrderAmountsResponse> ExecuteGetEcommerceProfitSharingOrderAmountsAsync(this WechatTenpayClient client, Models.GetEcommerceProfitSharingOrderAmountsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "ecommerce", "profitsharing", "orders", request.TransactionId, "amounts", HttpMethod.Get)
                .SetOptions(request);

            return await client.SendRequestAsync<Models.GetEcommerceProfitSharingOrderAmountsResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/profitsharing/receivers/add 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_7.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddEcommerceProfitSharingReceiverResponse> ExecuteAddEcommerceProfitSharingReceiverAsync(this WechatTenpayClient client, Models.AddEcommerceProfitSharingReceiverRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "ecommerce", "profitsharing", "receivers", "add")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.AddEcommerceProfitSharingReceiverResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/profitsharing/receivers/delete 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_8.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteEcommerceProfitSharingReceiverResponse> ExecuteDeleteEcommerceProfitSharingReceiverAsync(this WechatTenpayClient client, Models.DeleteEcommerceProfitSharingReceiverRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "ecommerce", "profitsharing", "receivers", "delete")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.DeleteEcommerceProfitSharingReceiverResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
