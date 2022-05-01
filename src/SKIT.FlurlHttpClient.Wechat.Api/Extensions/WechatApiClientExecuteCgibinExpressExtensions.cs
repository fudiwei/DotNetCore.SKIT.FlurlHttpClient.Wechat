using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCgibinExpressExtensions
    {
        private static T InitRequest<T>(WechatApiClient client, ref T request)
            where T : Models.CgibinExpressLocalBusinessRequestBase, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(request));
            if (client == null) throw new ArgumentNullException(nameof(request));

            if (request.ShopId == null)
            {
                request.ShopId = client.Credentials.ImmeDeliveryAppKey;
            }

            if (request.DeliverySignature == null)
            {
                string plainText = $"{request.ShopId}{request.ShopOrderId}{client.Credentials.ImmeDeliveryAppSecret}";
                request.DeliverySignature = Utilities.SHA1Utility.Hash(plainText).ToLower();
            }

            return request;
        }

        #region LocalBusiness
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/local/business/order/pre_add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-business/immediateDelivery.preAddOrder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressLocalBusinessOrderPreAddResponse> ExecuteCgibinExpressLocalBusinessOrderPreAddAsync(this WechatApiClient client, Models.CgibinExpressLocalBusinessOrderPreAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "local", "business", "order", "pre_add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressLocalBusinessOrderPreAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/local/business/order/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-business/immediateDelivery.addOrder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressLocalBusinessOrderAddResponse> ExecuteCgibinExpressLocalBusinessOrderAddAsync(this WechatApiClient client, Models.CgibinExpressLocalBusinessOrderAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "local", "business", "order", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressLocalBusinessOrderAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/local/business/order/readd 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-business/logistics.addOrder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressLocalBusinessOrderReAddResponse> ExecuteCgibinExpressLocalBusinessOrderReAddAsync(this WechatApiClient client, Models.CgibinExpressLocalBusinessOrderReAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "local", "business", "order", "readd")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressLocalBusinessOrderReAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/local/business/order/addtips 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-business/immediateDelivery.addTip.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressLocalBusinessOrderAddTipsResponse> ExecuteCgibinExpressLocalBusinessOrderAddTipsAsync(this WechatApiClient client, Models.CgibinExpressLocalBusinessOrderAddTipsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "local", "business", "order", "addtips")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressLocalBusinessOrderAddTipsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/local/business/order/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-business/immediateDelivery.getOrder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressLocalBusinessOrderGetResponse> ExecuteCgibinExpressLocalBusinessOrderGetAsync(this WechatApiClient client, Models.CgibinExpressLocalBusinessOrderGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "local", "business", "order", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressLocalBusinessOrderGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/local/business/order/precancel 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-business/immediateDelivery.preCancelOrder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressLocalBusinessOrderPreCancelResponse> ExecuteCgibinExpressLocalBusinessOrderPreCancelAsync(this WechatApiClient client, Models.CgibinExpressLocalBusinessOrderPreCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "local", "business", "order", "precancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressLocalBusinessOrderPreCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/local/business/order/cancel 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-business/immediateDelivery.cancelOrder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressLocalBusinessOrderCancelResponse> ExecuteCgibinExpressLocalBusinessOrderCancelAsync(this WechatApiClient client, Models.CgibinExpressLocalBusinessOrderCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "local", "business", "order", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressLocalBusinessOrderCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/local/business/order/confirm_return 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-business/immediateDelivery.abnormalConfirm.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressLocalBusinessOrderConfirmReturnResponse> ExecuteCgibinExpressLocalBusinessOrderConfirmReturnAsync(this WechatApiClient client, Models.CgibinExpressLocalBusinessOrderConfirmReturnRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "local", "business", "order", "confirm_return")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressLocalBusinessOrderConfirmReturnResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/local/business/delivery/getall 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-business/immediateDelivery.getAllImmeDelivery.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressLocalBusinessDeliveryGetAllResponse> ExecuteCgibinExpressLocalBusinessDeliveryGetAllAsync(this WechatApiClient client, Models.CgibinExpressLocalBusinessDeliveryGetAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "local", "business", "delivery", "getall")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressLocalBusinessDeliveryGetAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/local/business/shop/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-business/immediateDelivery.bindAccount.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressLocalBusinessShopAddResponse> ExecuteCgibinExpressLocalBusinessShopAddAsync(this WechatApiClient client, Models.CgibinExpressLocalBusinessShopAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "local", "business", "shop", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressLocalBusinessShopAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/local/business/shop/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-business/immediateDelivery.getBindAccount.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressLocalBusinessShopGetResponse> ExecuteCgibinExpressLocalBusinessShopGetAsync(this WechatApiClient client, Models.CgibinExpressLocalBusinessShopGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "local", "business", "shop", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressLocalBusinessShopGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/local/business/test_update_order 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-business/immediateDelivery.mockUpdateOrder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressLocalBusinessTestUpdateOrderResponse> ExecuteCgibinExpressLocalBusinessTestUpdateOrderAsync(this WechatApiClient client, Models.CgibinExpressLocalBusinessTestUpdateOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "local", "business", "test_update_order")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressLocalBusinessTestUpdateOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/local/business/realmock_update_order 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-business/immediateDelivery.mockUpdateOrder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressLocalBusinessRealMockUpdateOrderResponse> ExecuteCgibinExpressLocalBusinessRealMockUpdateOrderAsync(this WechatApiClient client, Models.CgibinExpressLocalBusinessRealMockUpdateOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "local", "business", "realmock_update_order")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressLocalBusinessRealMockUpdateOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/local/business/open 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-business/immediateDelivery.openDelivery.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressLocalBusinessOpenResponse> ExecuteCgibinExpressLocalBusinessOpenAsync(this WechatApiClient client, Models.CgibinExpressLocalBusinessOpenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "local", "business", "open")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressLocalBusinessOpenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/local/business/update_order 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/immediate-delivery/by-provider/immediateDelivery.updateOrder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressLocalBusinessUpdateOrderResponse> ExecuteCgibinExpressLocalBusinessUpdateOrderAsync(this WechatApiClient client, Models.CgibinExpressLocalBusinessUpdateOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            InitRequest(client, ref request);

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "local", "business", "update_order")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressLocalBusinessUpdateOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Business
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/business/order/add 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-business/logistics.addOrder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressBusinessOrderAddResponse> ExecuteCgibinExpressBusinessOrderAddAsync(this WechatApiClient client, Models.CgibinExpressBusinessOrderAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "business", "order", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressBusinessOrderAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/business/order/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-business/logistics.getOrder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressBusinessOrderGetResponse> ExecuteCgibinExpressBusinessOrderGetAsync(this WechatApiClient client, Models.CgibinExpressBusinessOrderGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "business", "order", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressBusinessOrderGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/business/order/batchget 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-business/logistics.batchGetOrder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressBusinessOrderBatchGetResponse> ExecuteCgibinExpressBusinessOrderBatchGetAsync(this WechatApiClient client, Models.CgibinExpressBusinessOrderBatchGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "business", "order", "batchget")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressBusinessOrderBatchGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/business/order/cancel 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-business/logistics.cancelOrder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressBusinessOrderCancelResponse> ExecuteCgibinExpressBusinessOrderCancelAsync(this WechatApiClient client, Models.CgibinExpressBusinessOrderCancelRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "business", "order", "cancel")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressBusinessOrderCancelResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/business/path/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-business/logistics.getPath.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressBusinessPathGetResponse> ExecuteCgibinExpressBusinessPathGetAsync(this WechatApiClient client, Models.CgibinExpressBusinessPathGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "business", "path", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressBusinessPathGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/express/business/delivery/getall 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-business/logistics.getAllDelivery.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressBusinessDeliveryGetAllResponse> ExecuteCgibinExpressBusinessDeliveryGetAllAsync(this WechatApiClient client, Models.CgibinExpressBusinessDeliveryGetAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "express", "business", "delivery", "getall")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressBusinessDeliveryGetAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/express/business/account/getall 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-business/logistics.getAllAccount.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressBusinessAccountGetAllResponse> ExecuteCgibinExpressBusinessAccountGetAllAsync(this WechatApiClient client, Models.CgibinExpressBusinessAccountGetAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "express", "business", "account", "getall")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressBusinessAccountGetAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/business/account/bind 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-business/logistics.bindAccount.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressBusinessAccountBindResponse> ExecuteCgibinExpressBusinessAccountBindAsync(this WechatApiClient client, Models.CgibinExpressBusinessAccountBindRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "business", "account", "bind")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressBusinessAccountBindResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/express/business/printer/getall 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-business/logistics.getPrinter.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressBusinessPrinterGetAllResponse> ExecuteCgibinExpressBusinessPrinterGetAllAsync(this WechatApiClient client, Models.CgibinExpressBusinessPrinterGetAllRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "cgi-bin", "express", "business", "printer", "getall")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressBusinessPrinterGetAllResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/business/printer/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-business/logistics.updatePrinter.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressBusinessPrinterUpdateResponse> ExecuteCgibinExpressBusinessPrinterUpdateAsync(this WechatApiClient client, Models.CgibinExpressBusinessPrinterUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "business", "printer", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressBusinessPrinterUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/business/quota/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-business/logistics.getQuota.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressBusinessQuotaGetResponse> ExecuteCgibinExpressBusinessQuotaGetAsync(this WechatApiClient client, Models.CgibinExpressBusinessQuotaGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "business", "quota", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressBusinessQuotaGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/business/test_update_order 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-business/logistics.testUpdateOrder.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressBusinessTestUpdateOrderResponse> ExecuteCgibinExpressBusinessTestUpdateOrderAsync(this WechatApiClient client, Models.CgibinExpressBusinessTestUpdateOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "business", "test_update_order")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressBusinessTestUpdateOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Delivery
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/delivery/contact/get 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-provider/logistics.getContact.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressDeliveryContactGetResponse> ExecuteCgibinExpressDeliveryContactGetAsync(this WechatApiClient client, Models.CgibinExpressDeliveryContactGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "delivery", "contact", "get")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressDeliveryContactGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/delivery/template/preview 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-provider/logistics.previewTemplate.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressDeliveryTemplatePreviewResponse> ExecuteCgibinExpressDeliveryTemplatePreviewAsync(this WechatApiClient client, Models.CgibinExpressDeliveryTemplatePreviewRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "delivery", "template", "preview")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressDeliveryTemplatePreviewResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/delivery/service/business/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-provider/logistics.updateBusiness.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressDeliveryServiceBusinessUpdateResponse> ExecuteCgibinExpressDeliveryServiceBusinessUpdateAsync(this WechatApiClient client, Models.CgibinExpressDeliveryServiceBusinessUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "delivery", "service", "business", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressDeliveryServiceBusinessUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/delivery/path/update 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-provider/logistics.updatePath.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressDeliveryPathUpdateResponse> ExecuteCgibinExpressDeliveryPathUpdateAsync(this WechatApiClient client, Models.CgibinExpressDeliveryPathUpdateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "delivery", "path", "update")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressDeliveryPathUpdateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/delivery/open_msg/follow_waybill 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/express_open_msg.html#_4-1%E3%80%81%E4%BC%A0%E8%BF%90%E5%8D%95%E6%8E%A5%E5%8F%A3-follow-waybill </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressDeliveryOpenMessageFollowWaybillResponse> ExecuteCgibinExpressDeliveryOpenMessageFollowWaybillAsync(this WechatApiClient client, Models.CgibinExpressDeliveryOpenMessageFollowWaybillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "delivery", "open_msg", "follow_waybill")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressDeliveryOpenMessageFollowWaybillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/delivery/open_msg/query_follow_trace 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/express_open_msg.html#_4-1%E3%80%81%E4%BC%A0%E8%BF%90%E5%8D%95%E6%8E%A5%E5%8F%A3-follow-waybill </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressDeliveryOpenMessageQueryFollowTraceResponse> ExecuteCgibinExpressDeliveryOpenMessageQueryFollowTraceAsync(this WechatApiClient client, Models.CgibinExpressDeliveryOpenMessageQueryFollowTraceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "delivery", "open_msg", "query_follow_trace")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressDeliveryOpenMessageQueryFollowTraceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/delivery/open_msg/update_follow_waybill_goods 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/express_open_msg.html#_4-1%E3%80%81%E4%BC%A0%E8%BF%90%E5%8D%95%E6%8E%A5%E5%8F%A3-follow-waybill </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressDeliveryOpenMessageUpdateFollowWaybillGoodsResponse> ExecuteCgibinExpressDeliveryOpenMessageUpdateFollowWaybillGoodsAsync(this WechatApiClient client, Models.CgibinExpressDeliveryOpenMessageUpdateFollowWaybillGoodsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "delivery", "open_msg", "update_follow_waybill_goods")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressDeliveryOpenMessageUpdateFollowWaybillGoodsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/express/delivery/return/open_return 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/Business/express/open_return.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinExpressDeliveryReturnOpenReturnResponse> ExecuteCgibinExpressDeliveryReturnOpenReturnAsync(this WechatApiClient client, Models.CgibinExpressDeliveryReturnOpenReturnRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "cgi-bin", "express", "delivery", "return", "open_return")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinExpressDeliveryReturnOpenReturnResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
