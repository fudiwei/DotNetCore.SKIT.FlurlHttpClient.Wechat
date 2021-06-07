using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteMerchantExtensions
    {
        #region Product
        /// <summary>
        /// <para>异步调用 [POST] /merchant/create 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantCreateResponse> ExecuteMerchantCreateAsync(this WechatApiClient client, Models.MerchantCreateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "create")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantCreateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/del 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantDeleteResponse> ExecuteMerchantDeleteAsync(this WechatApiClient client, Models.MerchantDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "del")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantUpdateResponse> ExecuteMerchantUpdateAsync(this WechatApiClient client, Models.MerchantUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "update")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantGetResponse> ExecuteMerchantGetAsync(this WechatApiClient client, Models.MerchantGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "merchant", "get")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("product_id", request.ProductId);

            return await client.SendRequestAsync<Models.MerchantGetResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/getbystatus 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantGetByStatusResponse> ExecuteMerchantGetByStatusAsync(this WechatApiClient client, Models.MerchantGetByStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "getbystatus")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantGetByStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/modproductstatus 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantModifyProductStatusResponse> ExecuteMerchantModifyProductStatusAsync(this WechatApiClient client, Models.MerchantModifyProductStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "modproductstatus")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantModifyProductStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Category
        /// <summary>
        /// <para>异步调用 [POST] /merchant/category/getsub 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantCategoryGetSubResponse> ExecuteMerchantCategoryGetSubAsync(this WechatApiClient client, Models.MerchantCategoryGetSubRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "category", "getsub")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantCategoryGetSubResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/category/getsku 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantCategoryGetSKUResponse> ExecuteMerchantCategoryGetSKUAsync(this WechatApiClient client, Models.MerchantCategoryGetSKURequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "category", "getsku")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantCategoryGetSKUResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/category/getproperty 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantCategoryGetPropertyResponse> ExecuteMerchantCategoryGetPropertyAsync(this WechatApiClient client, Models.MerchantCategoryGetPropertyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "category", "getproperty")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantCategoryGetPropertyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Stock
        /// <summary>
        /// <para>异步调用 [POST] /merchant/stock/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantStockAddResponse> ExecuteMerchantStockAddAsync(this WechatApiClient client, Models.MerchantStockAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "stock", "add")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantStockAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/stock/reduce 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantStockReduceResponse> ExecuteMerchantStockReduceAsync(this WechatApiClient client, Models.MerchantStockReduceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "stock", "reduce")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantStockReduceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Express
        /// <summary>
        /// <para>异步调用 [POST] /merchant/express/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantExpressAddResponse> ExecuteMerchantExpressAddAsync(this WechatApiClient client, Models.MerchantExpressAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "express", "add")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantExpressAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/express/del 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantExpressDeleteResponse> ExecuteMerchantExpressDeleteAsync(this WechatApiClient client, Models.MerchantExpressDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "express", "del")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantExpressDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/express/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantExpressUpdateResponse> ExecuteMerchantExpressUpdateAsync(this WechatApiClient client, Models.MerchantExpressUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "express", "update")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantExpressUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/express/getbyid 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantExpressGetByIdResponse> ExecuteMerchantExpressGetByIdAsync(this WechatApiClient client, Models.MerchantExpressGetByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "express", "getbyid")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantExpressGetByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant/express/getall 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantExpressGetAllResponse> ExecuteMerchantExpressGetAllAsync(this WechatApiClient client, Models.MerchantExpressGetAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "merchant", "express", "getall")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.MerchantExpressGetAllResponse>(flurlReq, cancellationToken: cancellationToken);
        }
        #endregion

        #region Group
        /// <summary>
        /// <para>异步调用 [POST] /merchant/group/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantGroupAddResponse> ExecuteMerchantGroupAddAsync(this WechatApiClient client, Models.MerchantGroupAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "group", "add")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantGroupAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/group/del 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantGroupDeleteResponse> ExecuteMerchantGroupDeleteAsync(this WechatApiClient client, Models.MerchantGroupDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "group", "del")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantGroupDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/group/propertymod 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantGroupPropertyModifyResponse> ExecuteMerchantGroupPropertyModifyAsync(this WechatApiClient client, Models.MerchantGroupPropertyModifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "group", "propertymod")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantGroupPropertyModifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/group/productmod 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantGroupProductModifyResponse> ExecuteMerchantGroupProductModifyAsync(this WechatApiClient client, Models.MerchantGroupProductModifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "group", "productmod")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantGroupProductModifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/group/getbyid 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantGroupGetByIdResponse> ExecuteMerchantGroupGetByIdAsync(this WechatApiClient client, Models.MerchantGroupGetByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "group", "getbyid")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantGroupGetByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant/group/getall 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantGroupGetAllResponse> ExecuteMerchantGroupGetAllAsync(this WechatApiClient client, Models.MerchantGroupGetAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "merchant", "group", "getall")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.MerchantGroupGetAllResponse>(flurlReq, cancellationToken: cancellationToken);
        }
        #endregion

        #region Shelf
        /// <summary>
        /// <para>异步调用 [POST] /merchant/shelf/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantShelfAddResponse> ExecuteMerchantShelfAddAsync(this WechatApiClient client, Models.MerchantShelfAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "shelf", "add")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantShelfAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/shelf/del 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantShelfDeleteResponse> ExecuteMerchantShelfDeleteAsync(this WechatApiClient client, Models.MerchantShelfDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "shelf", "del")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantShelfDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/shelf/mod 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantShelfModifyResponse> ExecuteMerchantShelfModifyAsync(this WechatApiClient client, Models.MerchantShelfModifyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "shelf", "mod")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantShelfModifyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/shelf/getbyid 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantShelfGetByIdResponse> ExecuteMerchantShelfGetByIdAsync(this WechatApiClient client, Models.MerchantShelfGetByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "shelf", "getbyid")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantShelfGetByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant/shelf/getall 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantShelfGetAllResponse> ExecuteMerchantShelfGetAllAsync(this WechatApiClient client, Models.MerchantShelfGetAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "merchant", "shelf", "getall")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.MerchantShelfGetAllResponse>(flurlReq, cancellationToken: cancellationToken);
        }
        #endregion

        #region Order
        /// <summary>
        /// <para>异步调用 [POST] /merchant/order/getbyid 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantOrderGetByIdResponse> ExecuteMerchantOrderGetByIdAsync(this WechatApiClient client, Models.MerchantOrderGetByIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "order", "getbyid")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantOrderGetByIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/order/getbyfilter 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantOrderGetByFilterResponse> ExecuteMerchantOrderGetByFilterAsync(this WechatApiClient client, Models.MerchantOrderGetByFilterRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "order", "getbyfilter")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantOrderGetByFilterResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/order/setdelivery 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantOrderSetDeliveryResponse> ExecuteMerchantOrderSetDeliveryAsync(this WechatApiClient client, Models.MerchantOrderSetDeliveryRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "order", "setdelivery")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantOrderSetDeliveryResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /merchant/order/close 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantOrderCloseResponse> ExecuteMerchantOrderCloseAsync(this WechatApiClient client, Models.MerchantOrderCloseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "order", "close")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.MerchantOrderCloseResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Common
        /// <summary>
        /// <para>异步调用 [POST] /merchant/common/upload_img 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Instant_Stores/WeChat_Store_Interface.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.MerchantCommonUploadImageResponse> ExecuteMerchantCommonUploadImageAsync(this WechatApiClient client, Models.MerchantCommonUploadImageRequest request, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(request.FileName))
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "merchant", "common", "upload_img")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            using var httpContent = new ByteArrayContent(request.FileBytes ?? new byte[0]);
            return await client.SendRequestAsync<Models.MerchantCommonUploadImageResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
}
        #endregion
    }
}
