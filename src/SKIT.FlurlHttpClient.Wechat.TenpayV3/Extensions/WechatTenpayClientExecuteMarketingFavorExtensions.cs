using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMarketingFavorExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/favor/coupon-stocks 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012534633 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012534537 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingFavorStockResponse> ExecuteCreateMarketingFavorStockAsync(this WechatTenpayClient client, Models.CreateMarketingFavorStockRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.BelongMerchantId is null)
                request.BelongMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "favor", "coupon-stocks");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingFavorStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/favor/stocks/{stock_id}/start 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012460137 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012460237 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.StartMarketingFavorStockResponse> ExecuteStartMarketingFavorStockAsync(this WechatTenpayClient client, Models.StartMarketingFavorStockRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.StockCreatorMerchantId is null)
                request.StockCreatorMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "favor", "stocks", request.StockId, "start");

            return await client.SendFlurlRequestAsJsonAsync<Models.StartMarketingFavorStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/favor/stocks/{stock_id}/pause 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012460305 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012460340 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PauseMarketingFavorStockResponse> ExecutePauseMarketingFavorStockAsync(this WechatTenpayClient client, Models.PauseMarketingFavorStockRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.StockCreatorMerchantId is null)
                request.StockCreatorMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "favor", "stocks", request.StockId, "pause");

            return await client.SendFlurlRequestAsJsonAsync<Models.PauseMarketingFavorStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/favor/stocks/{stock_id}/restart 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012460411 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012460448 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestartMarketingFavorStockResponse> ExecuteRestartMarketingFavorStockAsync(this WechatTenpayClient client, Models.RestartMarketingFavorStockRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.StockCreatorMerchantId is null)
                request.StockCreatorMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "favor", "stocks", request.StockId, "restart");

            return await client.SendFlurlRequestAsJsonAsync<Models.RestartMarketingFavorStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/stocks/{stock_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012460564 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012460606 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingFavorStockByStockIdResponse> ExecuteGetMarketingFavorStockByStockIdAsync(this WechatTenpayClient client, Models.GetMarketingFavorStockByStockIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.StockCreatorMerchantId is null)
                request.StockCreatorMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "favor", "stocks", request.StockId)
                .SetQueryParam("stock_creator_mchid", request.StockCreatorMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingFavorStockByStockIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/stocks 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012460489 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012460518 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingFavorStocksResponse> ExecuteQueryMarketingFavorStocksAsync(this WechatTenpayClient client, Models.QueryMarketingFavorStocksRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.StockCreatorMerchantId is null)
                request.StockCreatorMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "favor", "stocks")
                .SetQueryParam("stock_creator_mchid", request.StockCreatorMerchantId)
                .SetQueryParam("create_start_time", request.CreateStartTime.HasValue ? request.CreateStartTime.Value.ToString("yyyy-MM-dd'T'HH:mm:sszzz") : null)
                .SetQueryParam("create_end_time", request.CreateEndTime.HasValue ? request.CreateEndTime.Value.ToString("yyyy-MM-dd'T'HH:mm:sszzz") : null)
                .SetQueryParam("status", request.Status)
                .SetQueryParam("limit", request.Limit.ToString())
                .SetQueryParam("offset", request.Offset.ToString());

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingFavorStocksResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/stocks/{stock_id}/merchants 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012463358 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012463409 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingFavorStockMerchantsResponse> ExecuteQueryMarketingFavorStockMerchantsAsync(this WechatTenpayClient client, Models.QueryMarketingFavorStockMerchantsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.StockCreatorMerchantId is null)
                request.StockCreatorMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "favor", "stocks", request.StockId, "merchants")
                .SetQueryParam("stock_creator_mchid", request.StockCreatorMerchantId)
                .SetQueryParam("limit", request.Limit.ToString())
                .SetQueryParam("offset", request.Offset.ToString());

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingFavorStockMerchantsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/stocks/{stock_id}/items 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012463442 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012463475 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingFavorStockItemsResponse> ExecuteQueryMarketingFavorStockItemsAsync(this WechatTenpayClient client, Models.QueryMarketingFavorStockItemsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.StockCreatorMerchantId is null)
                request.StockCreatorMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "favor", "stocks", request.StockId, "items")
                .SetQueryParam("stock_creator_mchid", request.StockCreatorMerchantId)
                .SetQueryParam("limit", request.Limit.ToString())
                .SetQueryParam("offset", request.Offset.ToString());

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingFavorStockItemsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/stocks/{stock_id}/use-flow 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012463585 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012463698 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingFavorStockUseFlowResponse> ExecuteGetMarketingFavorStockUseFlowAsync(this WechatTenpayClient client, Models.GetMarketingFavorStockUseFlowRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "favor", "stocks", request.StockId, "use-flow");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingFavorStockUseFlowResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/stocks/{stock_id}/refund-flow 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012463523 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012463548 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingFavorStockRefundFlowResponse> ExecuteGetMarketingFavorStockRefundFlowAsync(this WechatTenpayClient client, Models.GetMarketingFavorStockRefundFlowRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "favor", "stocks", request.StockId, "refund-flow");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingFavorStockRefundFlowResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/favor/users/{openid}/coupons 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012463767 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012463807 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendMarketingFavorUserCouponResponse> ExecuteSendMarketingFavorUserCouponAsync(this WechatTenpayClient client, Models.SendMarketingFavorUserCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.StockCreatorMerchantId is null)
                request.StockCreatorMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "favor", "users", request.OpenId, "coupons");

            return await client.SendFlurlRequestAsJsonAsync<Models.SendMarketingFavorUserCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/users/{openid}/coupons/{coupon_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012486942 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012492796 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingFavorUserCouponByCouponIdResponse> ExecuteGetMarketingFavorUserCouponByCouponIdAsync(this WechatTenpayClient client, Models.GetMarketingFavorUserCouponByCouponIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "favor", "users", request.OpenId, "coupons", request.CouponId)
                .SetQueryParam("appid", request.AppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingFavorUserCouponByCouponIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/users/{openid}/coupons 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012534690 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012494237 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingFavorUserCouponsResponse> ExecuteQueryMarketingFavorUserCouponsAsync(this WechatTenpayClient client, Models.QueryMarketingFavorUserCouponsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "favor", "users", request.OpenId, "coupons")
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("stock_id", request.StockId)
                .SetQueryParam("creator_mchid", request.CreatorMerchantId)
                .SetQueryParam("sender_mchid", request.SenderMerchantId)
                .SetQueryParam("available_mchid", request.AvailableMerchantId)
                .SetQueryParam("status", request.Status)
                .SetQueryParam("business_type", request.BusinessType)
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("offset", request.Offset);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingFavorUserCouponsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/favor/callbacks 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012464198 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012464176 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingFavorCallbackResponse> ExecuteUpdateMarketingFavorCallbackAsync(this WechatTenpayClient client, Models.UpdateMarketingFavorCallbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "favor", "callbacks");

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingFavorCallbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/callbacks 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012464070 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012464155 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingFavorCallbackResponse> ExecuteGetMarketingFavorCallbackAsync(this WechatTenpayClient client, Models.GetMarketingFavorCallbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "favor", "callbacks")
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingFavorCallbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
