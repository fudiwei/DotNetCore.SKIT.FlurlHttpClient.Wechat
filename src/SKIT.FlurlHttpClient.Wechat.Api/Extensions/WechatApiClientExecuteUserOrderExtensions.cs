using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteUserOrderExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /user-order/orders 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/shopping-order/normal-shopping-detail/uploadShoppingInfo.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/shopping-orders/uploadShoppingInfo.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserOrderOrdersResponse> ExecuteUserOrderOrdersAsync(this WechatApiClient client, Models.UserOrderOrdersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "user-order", "orders")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UserOrderOrdersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /user-order/orders/shippings 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/shopping-order/normal-shopping-detail/uploadShippingInfo.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/shopping-orders/uploadShippingInfo.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserOrderOrdersShippingsResponse> ExecuteUserOrderOrdersShippingsAsync(this WechatApiClient client, Models.UserOrderOrdersShippingsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "user-order", "orders", "shippings")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UserOrderOrdersShippingsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /user-order/combine-orders 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/shopping-order/shopping-detail/uploadCombinedShoppingInfo.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/shopping-orders/uploadCombinedShoppingInfo.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserOrderCombineOrdersResponse> ExecuteUserOrderCombineOrdersAsync(this WechatApiClient client, Models.UserOrderCombineOrdersRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "user-order", "combine-orders")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UserOrderCombineOrdersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /user-order/combine-orders/shippings 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/shopping-order/shopping-detail/uploadCombinedShippingInfo.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/shopping-orders/uploadCombinedShippingInfo.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserOrderCombineOrdersShippingsResponse> ExecuteUserOrderCombineOrdersShippingsAsync(this WechatApiClient client, Models.UserOrderCombineOrdersShippingsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "user-order", "combine-orders", "shippings")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UserOrderCombineOrdersShippingsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /user-order/shoppinginfo/verify 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/shopping-order/upload-result/ShoppingInfoVerifyUploadResult.html </para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/shopping-orders/ShoppingInfoVerifyUploadResult.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserOrderShoppingInfoVerifyResponse> ExecuteUserOrderShoppingInfoVerifyAsync(this WechatApiClient client, Models.UserOrderShoppingInfoVerifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "user-order", "shoppinginfo", "verify")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UserOrderShoppingInfoVerifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region OrdersPermission
        /// <summary>
        /// <para>异步调用 [POST] /user-order/orders-permission/open 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/shopping-orders/openShoppingOrderProductPermission.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserOrderOrdersPermissionOpenResponse> ExecuteUserOrderOrdersPermissionOpenAsync(this WechatApiClient client, Models.UserOrderOrdersPermissionOpenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "user-order", "orders-permission", "open")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UserOrderOrdersPermissionOpenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /user-order/orders-permission/confirm 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/shopping-orders/confirmProductPermission.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UserOrderOrdersPermissionConfirmResponse> ExecuteUserOrderOrdersPermissionConfirmAsync(this WechatApiClient client, Models.UserOrderOrdersPermissionConfirmRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "user-order", "orders-permission", "confirm")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.UserOrderOrdersPermissionConfirmResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
