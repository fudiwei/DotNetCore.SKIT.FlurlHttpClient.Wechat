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
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012524936 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012690683 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateProfitSharingOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /profitsharing/orders/{out_order_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012525210 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012466850 ]]>
        /// </para>
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
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("transaction_id", request.TransactionId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetProfitSharingOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /profitsharing/return-orders 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012525287 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012466854 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateProfitSharingReturnOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /profitsharing/return-orders/{out_order_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012526279 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012466858 ]]>
        /// </para>
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
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("out_order_no", request.OutOrderNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetProfitSharingReturnOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /profitsharing/orders/unfreeze 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012526374 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012466860 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.SetProfitSharingOrderUnfrozenResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /profitsharing/transactions/{transaction_id}/amounts 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012457939 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012457927 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.GetProfitSharingTransactionAmountsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /profitsharing/merchant-configs/{sub_mchid} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/profit-sharing/merchants/query-merchant-ratio.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012466864 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.GetProfitSharingMerchantConfigsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /profitsharing/receivers/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012528995 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012690944 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.AddProfitSharingReceiverResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /profitsharing/receivers/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012529590 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012466868 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.DeleteProfitSharingReceiverResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region Bills
        /// <summary>
        /// <para>异步调用 [GET] /profitsharing/bills 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012529628 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012761131 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012761140 ]]>
        /// </para>
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
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("bill_date", request.BillDateString)
                .SetQueryParam("tar_type", request.TarType);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetProfitSharingBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
