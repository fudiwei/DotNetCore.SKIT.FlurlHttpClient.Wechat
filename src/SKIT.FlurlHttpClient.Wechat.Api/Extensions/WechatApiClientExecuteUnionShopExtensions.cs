using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteUnionShopExtensions
    {
        #region Open
        /// <summary>
        /// <para>异步调用 [POST] /union/shop/open/set_commission 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/shop/set_commission.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionShopOpenSetCommissionResponse> ExecuteUnionShopOpenSetCommissionAsync(this WechatApiClient client, Models.UnionShopOpenSetCommissionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "union", "shop", "open", "set_commission")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.UnionShopOpenSetCommissionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/shop/open/get_commission 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/shop/set_commission.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionShopOpenGetCommissionResponse> ExecuteUnionShopOpenGetCommissionAsync(this WechatApiClient client, Models.UnionShopOpenGetCommissionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "union", "shop", "open", "get_commission")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.UnionShopOpenGetCommissionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/shop/open/delete_commission 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/shop/set_commission.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionShopOpenDeleteCommissionResponse> ExecuteUnionShopOpenDeleteCommissionAsync(this WechatApiClient client, Models.UnionShopOpenDeleteCommissionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "union", "shop", "open", "delete_commission")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.UnionShopOpenDeleteCommissionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Order
        /// <summary>
        /// <para>异步调用 [GET] /union/shop/order/search_normal_order 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/shop/order-info.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionShopOrderSearchNormalOrderResponse> ExecuteUnionShopOrderSearchNormalOrderAsync(this WechatApiClient client, Models.UnionShopOrderSearchNormalOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "union", "shop", "order", "search_normal_order")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            if (request.Query != null)
                flurlReq.SetQueryParam("query", request.Query);

            if (request.AllianceAppId != null)
                flurlReq.SetQueryParam("allianceAppid", request.AllianceAppId);

            if (request.OrderId != null)
                flurlReq.SetQueryParam("orderId", request.OrderId.Value);

            if (request.OutOrderId != null)
                flurlReq.SetQueryParam("outOrderId", request.OutOrderId);

            if (request.OutOrderIdList != null)
                flurlReq.SetQueryParam("outOrderIdList", string.Join(",", request.OutOrderId));

            if (request.TransactionId != null)
                flurlReq.SetQueryParam("tradeNo", request.TransactionId);

            if (request.TransactionIdList != null)
                flurlReq.SetQueryParam("transactionIdList", string.Join(",", request.TransactionIdList));

            if (request.StartPayTimestamp != null)
                flurlReq.SetQueryParam("startPayTime", request.StartPayTimestamp.Value);

            if (request.EndPayTimestamp != null)
                flurlReq.SetQueryParam("endPayTime", request.EndPayTimestamp.Value);

            if (request.CommissionStatus != null)
                flurlReq.SetQueryParam("commissionStatus", request.CommissionStatus);

            if (request.StartStatusUpdateTimestamp != null)
                flurlReq.SetQueryParam("startStatusUpdateTime", request.StartStatusUpdateTimestamp.Value);

            if (request.EndStatusUpdateTimestamp != null)
                flurlReq.SetQueryParam("endStatusUpdateTime", request.EndStatusUpdateTimestamp.Value);

            if (request.SortBy != null)
                flurlReq.SetQueryParam("sortBy", request.SortBy);

            if (request.SortOrder != null)
                flurlReq.SetQueryParam("sortOrder", request.SortOrder);

            return await client.SendRequestWithJsonAsync<Models.UnionShopOrderSearchNormalOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
