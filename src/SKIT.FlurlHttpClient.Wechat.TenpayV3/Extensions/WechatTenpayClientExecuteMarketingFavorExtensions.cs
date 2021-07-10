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
    /// 为 <see cref="WechatTenpayClient"/> 提供代金券相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteMarketingFavorExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/favor/coupon-stocks 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_1_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_1_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingFavorStockResponse> ExecuteCreateMarketingFavorStockAsync(this WechatTenpayClient client, Models.CreateMarketingFavorStockRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.BelongMerchantId))
                request.BelongMerchantId = client.WechatMerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "marketing", "favor", "coupon-stocks")
                ;

            return await client.SendRequestWithJsonAsync<Models.CreateMarketingFavorStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/favor/stocks/{stock_id}/start 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_1_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_1_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.StartMarketingFavorStockResponse> ExecuteStartMarketingFavorStockAsync(this WechatTenpayClient client, Models.StartMarketingFavorStockRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.StockCreatorMerchantId))
                request.StockCreatorMerchantId = client.WechatMerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "marketing", "favor", "stocks", request.StockId, "start")
                ;

            return await client.SendRequestWithJsonAsync<Models.StartMarketingFavorStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/favor/stocks/{stock_id}/pause 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_1_13.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_1_13.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PauseMarketingFavorStockResponse> ExecutePauseMarketingFavorStockAsync(this WechatTenpayClient client, Models.PauseMarketingFavorStockRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.StockCreatorMerchantId))
                request.StockCreatorMerchantId = client.WechatMerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "marketing", "favor", "stocks", request.StockId, "pause")
                ;

            return await client.SendRequestWithJsonAsync<Models.PauseMarketingFavorStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/favor/stocks/{stock_id}/restart 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_1_14.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_1_14.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.RestartMarketingFavorStockResponse> ExecuteRestartMarketingFavorStockAsync(this WechatTenpayClient client, Models.RestartMarketingFavorStockRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.StockCreatorMerchantId))
                request.StockCreatorMerchantId = client.WechatMerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "marketing", "favor", "stocks", request.StockId, "restart")
                ;

            return await client.SendRequestWithJsonAsync<Models.RestartMarketingFavorStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/stocks/{stock_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_1_5.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_1_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingFavorStockByStockIdResponse> ExecuteGetMarketingFavorStockByStockIdAsync(this WechatTenpayClient client, Models.GetMarketingFavorStockByStockIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.StockCreatorMerchantId))
                request.StockCreatorMerchantId = client.WechatMerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "marketing", "favor", "stocks", request.StockId)
                .SetQueryParam("stock_creator_mchid", request.StockCreatorMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetMarketingFavorStockByStockIdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/stocks 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_1_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_1_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingFavorStocksResponse> ExecuteQueryMarketingFavorStocksAsync(this WechatTenpayClient client, Models.QueryMarketingFavorStocksRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.StockCreatorMerchantId))
                request.StockCreatorMerchantId = client.WechatMerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "marketing", "favor", "stocks")
                .SetQueryParam("stock_creator_mchid", request.StockCreatorMerchantId)
                .SetQueryParam("limit", request.Limit.ToString())
                .SetQueryParam("offset", request.Offset.ToString());

            if (request.CreateStartTime.HasValue)
                flurlReq.SetQueryParam("create_start_time", request.CreateStartTime.Value.ToString("yyyy-MM-dd'T'HH:mm:sszzz"));

            if (request.CreateEndTime.HasValue)
                flurlReq.SetQueryParam("create_end_time", request.CreateEndTime.Value.ToString("yyyy-MM-dd'T'HH:mm:sszzz"));

            if (!string.IsNullOrEmpty(request.Status))
                flurlReq.SetQueryParam("status", request.Status);

            return await client.SendRequestWithJsonAsync<Models.QueryMarketingFavorStocksResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/stocks/{stock_id}/merchants 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_1_7.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_1_7.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingFavorStockMerchantsResponse> ExecuteQueryMarketingFavorStockMerchantsAsync(this WechatTenpayClient client, Models.QueryMarketingFavorStockMerchantsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.StockCreatorMerchantId))
                request.StockCreatorMerchantId = client.WechatMerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "marketing", "favor", "stocks", request.StockId, "merchants")
                .SetQueryParam("stock_creator_mchid", request.StockCreatorMerchantId)
                .SetQueryParam("limit", request.Limit.ToString())
                .SetQueryParam("offset", request.Offset.ToString());

            return await client.SendRequestWithJsonAsync<Models.QueryMarketingFavorStockMerchantsResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/stocks/{stock_id}/items 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_1_8.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_1_8.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingFavorStockItemsResponse> ExecuteQueryMarketingFavorStockItemsAsync(this WechatTenpayClient client, Models.QueryMarketingFavorStockItemsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.StockCreatorMerchantId))
                request.StockCreatorMerchantId = client.WechatMerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "marketing", "favor", "stocks", request.StockId, "items")
                .SetQueryParam("stock_creator_mchid", request.StockCreatorMerchantId)
                .SetQueryParam("limit", request.Limit.ToString())
                .SetQueryParam("offset", request.Offset.ToString());

            return await client.SendRequestWithJsonAsync<Models.QueryMarketingFavorStockItemsResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/stocks/{stock_id}/use-flow 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_1_10.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_1_10.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "marketing", "favor", "stocks", request.StockId, "use-flow")
                ;

            return await client.SendRequestWithJsonAsync<Models.GetMarketingFavorStockUseFlowResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/stocks/{stock_id}/refund-flow 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_1_11.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_1_11.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "marketing", "favor", "stocks", request.StockId, "refund-flow")
                ;

            return await client.SendRequestWithJsonAsync<Models.GetMarketingFavorStockRefundFlowResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/favor/users/{openid}/coupons 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_1_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_1_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendMarketingFavorUserCouponResponse> ExecuteSendMarketingFavorUserCouponAsync(this WechatTenpayClient client, Models.SendMarketingFavorUserCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.StockCreatorMerchantId))
                request.StockCreatorMerchantId = client.WechatMerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "marketing", "favor", "users", request.OpenId, "coupons")
                ;

            return await client.SendRequestWithJsonAsync<Models.SendMarketingFavorUserCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/users/{openid}/coupons/{coupon_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_1_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_1_6.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "marketing", "favor", "users", request.OpenId, "coupons", request.CouponId)
                .SetQueryParam("appid", request.AppId);

            return await client.SendRequestWithJsonAsync<Models.GetMarketingFavorUserCouponByCouponIdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/favor/users/{openid}/coupons 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_1_9.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_1_9.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "marketing", "favor", "users", request.OpenId, "coupons")
                .SetQueryParam("appid", request.AppId);

            if (!string.IsNullOrEmpty(request.StockId))
                flurlReq.SetQueryParam("stock_id", request.StockId);

            if (!string.IsNullOrEmpty(request.Status))
                flurlReq.SetQueryParam("status", request.Status);

            if (!string.IsNullOrEmpty(request.CreatorMerchantId))
                flurlReq.SetQueryParam("creator_mchid", request.CreatorMerchantId);

            if (!string.IsNullOrEmpty(request.SenderMerchantId))
                flurlReq.SetQueryParam("sender_mchid", request.SenderMerchantId);

            if (!string.IsNullOrEmpty(request.AvailableMerchantId))
                flurlReq.SetQueryParam("available_mchid", request.AvailableMerchantId);

            if (request.Limit.HasValue)
                flurlReq.SetQueryParam("limit", request.Limit.Value.ToString());

            if (request.Offset.HasValue)
                flurlReq.SetQueryParam("offset", request.Offset.Value.ToString());

            return await client.SendRequestWithJsonAsync<Models.QueryMarketingFavorUserCouponsResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/favor/callbacks 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_1_12.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_1_12.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingFavorCallbackResponse> ExecuteUpdateMarketingFavorCallbackAsync(this WechatTenpayClient client, Models.UpdateMarketingFavorCallbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.MerchantId))
                request.MerchantId = client.WechatMerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "marketing", "favor", "callbacks")
                ;

            return await client.SendRequestWithJsonAsync<Models.UpdateMarketingFavorCallbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
