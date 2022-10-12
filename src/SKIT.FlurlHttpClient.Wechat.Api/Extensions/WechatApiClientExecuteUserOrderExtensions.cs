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
                .CreateRequest(request, HttpMethod.Post, "user-order", "orders")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.UserOrderOrdersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /user-order/orders/shippings 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/shopping-order/normal-shopping-detail/uploadShippingInfo.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "user-order", "orders", "shippings")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.UserOrderOrdersShippingsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /user-order/combine-orders 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/shopping-order/shopping-detail/uploadCombinedShoppingInfo.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "user-order", "combine-orders")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.UserOrderCombineOrdersResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /user-order/combine-orders/shippings 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/shopping-order/shopping-detail/uploadCombinedShippingInfo.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "user-order", "combine-orders", "shippings")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.UserOrderCombineOrdersShippingsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /user-order/shoppinginfo/verify 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/shopping-order/upload-result/ShoppingInfoVerifyUploadResult.html </para>
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
                .CreateRequest(request, HttpMethod.Post, "user-order", "shoppinginfo", "verify")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.UserOrderShoppingInfoVerifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
