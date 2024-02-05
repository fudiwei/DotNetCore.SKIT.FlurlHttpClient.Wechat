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
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/shop/set_commission.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "shop", "open", "set_commission")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionShopOpenSetCommissionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/shop/open/get_commission 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/shop/set_commission.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "shop", "open", "get_commission")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionShopOpenGetCommissionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/shop/open/delete_commission 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/shop/set_commission.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "shop", "open", "delete_commission")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionShopOpenDeleteCommissionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Order
        /// <summary>
        /// <para>异步调用 [GET] /union/shop/order/search_normal_order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/shop/order-info.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "union", "shop", "order", "search_normal_order")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("offset", request.Offset)
                .SetQueryParam("limit", request.Limit);

            if (request.Query is not null)
                flurlReq.SetQueryParam("query", request.Query);

            if (request.AllianceAppId is not null)
                flurlReq.SetQueryParam("allianceAppid", request.AllianceAppId);

            if (request.OrderId is not null)
                flurlReq.SetQueryParam("orderId", request.OrderId.Value);

            if (request.OutOrderId is not null)
                flurlReq.SetQueryParam("outOrderId", request.OutOrderId);

            if (request.OutOrderIdList is not null)
                flurlReq.SetQueryParam("outOrderIdList", string.Join(",", request.OutOrderId));

            if (request.TransactionId is not null)
                flurlReq.SetQueryParam("tradeNo", request.TransactionId);

            if (request.TransactionIdList is not null)
                flurlReq.SetQueryParam("transactionIdList", string.Join(",", request.TransactionIdList));

            if (request.StartPayTimestamp is not null)
                flurlReq.SetQueryParam("startPayTime", request.StartPayTimestamp.Value);

            if (request.EndPayTimestamp is not null)
                flurlReq.SetQueryParam("endPayTime", request.EndPayTimestamp.Value);

            if (request.CommissionStatus is not null)
                flurlReq.SetQueryParam("commissionStatus", request.CommissionStatus);

            if (request.StartStatusUpdateTimestamp is not null)
                flurlReq.SetQueryParam("startStatusUpdateTime", request.StartStatusUpdateTimestamp.Value);

            if (request.EndStatusUpdateTimestamp is not null)
                flurlReq.SetQueryParam("endStatusUpdateTime", request.EndStatusUpdateTimestamp.Value);

            if (request.SortBy is not null)
                flurlReq.SetQueryParam("sortBy", request.SortBy);

            if (request.SortOrder is not null)
                flurlReq.SetQueryParam("sortOrder", request.SortOrder);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionShopOrderSearchNormalOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Target
        /// <summary>
        /// <para>异步调用 [POST] /union/shop/target/add_plan 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/shop/target_plan/target_plan.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionShopTargetAddPlanResponse> ExecuteUnionShopTargetAddPlanAsync(this WechatApiClient client, Models.UnionShopTargetAddPlanRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "shop", "target", "add_plan")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionShopTargetAddPlanResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /union/shop/target/plan_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/shop/target_plan/target_plan.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionShopTargetPlanListResponse> ExecuteUnionShopTargetPlanListAsync(this WechatApiClient client, Models.UnionShopTargetPlanListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "union", "shop", "target", "plan_list")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.Offset is not null)
                flurlReq.SetQueryParam("offset", request.Offset.Value);

            if (request.Limit is not null)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            if (request.PlanStatus is not null)
                flurlReq.SetQueryParam("planStatus", request.PlanStatus);

            if (request.PlanId is not null)
                flurlReq.SetQueryParam("planId", request.PlanId);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionShopTargetPlanListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /union/shop/target/product_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/shop/target_plan/target_plan.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionShopTargetProductListResponse> ExecuteUnionShopTargetProductListAsync(this WechatApiClient client, Models.UnionShopTargetProductListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "union", "shop", "target", "product_list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("planId", request.PlanId);

            if (request.Offset is not null)
                flurlReq.SetQueryParam("offset", request.Offset.Value);

            if (request.Limit is not null)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionShopTargetProductListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /union/shop/target/promoter_list 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/shop/target_plan/target_plan.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionShopTargetPromoterListResponse> ExecuteUnionShopTargetPromoterListAsync(this WechatApiClient client, Models.UnionShopTargetPromoterListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "union", "shop", "target", "promoter_list")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("planId", request.PlanId);

            if (request.Offset is not null)
                flurlReq.SetQueryParam("offset", request.Offset.Value);

            if (request.Limit is not null)
                flurlReq.SetQueryParam("limit", request.Limit.Value);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionShopTargetPromoterListResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/shop/target/update_plan 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/shop/target_plan/target_plan.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionShopTargetUpdatePlanResponse> ExecuteUnionShopTargetUpdatePlanAsync(this WechatApiClient client, Models.UnionShopTargetUpdatePlanRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "shop", "target", "update_plan")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionShopTargetUpdatePlanResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /union/shop/target/update_promoter 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/union/custom_component/api/shop/target_plan/target_plan.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UnionShopTargetUpdatePromoterResponse> ExecuteUnionShopTargetUpdatePromoterAsync(this WechatApiClient client, Models.UnionShopTargetUpdatePromoterRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "union", "shop", "target", "update_promoter")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UnionShopTargetUpdatePromoterResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
