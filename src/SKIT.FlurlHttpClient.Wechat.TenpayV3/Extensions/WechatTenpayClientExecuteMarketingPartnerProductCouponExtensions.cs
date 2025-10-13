using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient;
    using SKIT.FlurlHttpClient.Primitives;

    public static class WechatTenpayClientExecuteMarketingPartnerProductCouponExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/product-coupon/product-coupons 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781289 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingPartnerProductCouponResponse> ExecuteCreateMarketingPartnerProductCouponAsync(this WechatTenpayClient client, Models.CreateMarketingPartnerProductCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "product-coupon", "product-coupons");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingPartnerProductCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/partner/product-coupon/product-coupons/{product_coupon_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781284 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingPartnerProductCouponByProductCouponIdResponse> ExecuteGetMarketingPartnerProductCouponByProductCouponIdAsync(this WechatTenpayClient client, Models.GetMarketingPartnerProductCouponByProductCouponIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "partner", "product-coupon", "product-coupons", request.ProductCouponId)
                .SetQueryParam("brand_id", request.BrandId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingPartnerProductCouponByProductCouponIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /marketing/partner/product-coupon/product-coupons/{product_coupon_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781296 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingPartnerProductCouponResponse> ExecuteUpdateMarketingPartnerProductCouponAsync(this WechatTenpayClient client, Models.UpdateMarketingPartnerProductCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "marketing", "partner", "product-coupon", "product-coupons", request.ProductCouponId);

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingPartnerProductCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/deactivate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781290 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeactivateMarketingPartnerProductCouponResponse> ExecuteDeactivateMarketingPartnerProductCouponAsync(this WechatTenpayClient client, Models.DeactivateMarketingPartnerProductCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "product-coupon", "product-coupons", request.ProductCouponId, "deactivate");

            return await client.SendFlurlRequestAsJsonAsync<Models.DeactivateMarketingPartnerProductCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/product-coupon/media/upload-image 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781275 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadMarketingPartnerProductCouponMediaImageResponse> ExecuteUploadMarketingPartnerProductCouponMediaImageAsync(this WechatTenpayClient client, Models.UploadMarketingPartnerProductCouponMediaImageRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName is null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (request.FileHash is null)
                request.FileHash = EncodedString.ToHexString(Utilities.SHA256Utility.Hash(request.FileBytes)).Value!.ToLower();

            if (request.FileContentType is null)
                request.FileContentType = MimeTypes.GetMimeMapping(request.FileName!);

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "product-coupon", "media", "image-upload");

            using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, fileMetaJson: client.JsonSerializer.Serialize(request));
            return await client.SendFlurlRequestAsync<Models.UploadMarketingPartnerProductCouponMediaImageResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region NotifyConfigs
        /// <summary>
        /// <para>异步调用 [GET] /marketing/partner/product-coupon/notify-configs 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781284 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingPartnerProductCouponNotifyConfigResponse> ExecuteGetMarketingPartnerProductCouponNotifyConfigAsync(this WechatTenpayClient client, Models.GetMarketingPartnerProductCouponNotifyConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "partner", "product-coupon", "notify-configs");

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingPartnerProductCouponNotifyConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/product-coupon/notify-configs 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781286 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingPartnerProductCouponNotifyConfigResponse> ExecuteUpdateMarketingPartnerProductCouponNotifyConfigAsync(this WechatTenpayClient client, Models.UpdateMarketingPartnerProductCouponNotifyConfigRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "product-coupon", "notify-configs");

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingPartnerProductCouponNotifyConfigResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Stocks
        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781304 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingPartnerProductCouponStockResponse> ExecuteCreateMarketingPartnerProductCouponStockAsync(this WechatTenpayClient client, Models.CreateMarketingPartnerProductCouponStockRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "product-coupon", "product-coupons", request.ProductCouponId, "stocks");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingPartnerProductCouponStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781553 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingPartnerProductCouponStocksResponse> ExecuteQueryMarketingPartnerProductCouponStocksAsync(this WechatTenpayClient client, Models.QueryMarketingPartnerProductCouponStocksRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "partner", "product-coupon", "product-coupons", request.ProductCouponId, "stocks")
                .SetQueryParam("brand_id", request.BrandId)
                .SetQueryParam("state", request.StockState)
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingPartnerProductCouponStocksResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks/{stock_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781542 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingPartnerProductCouponStockByStockIdResponse> ExecuteGetMarketingPartnerProductCouponStockByStockIdAsync(this WechatTenpayClient client, Models.GetMarketingPartnerProductCouponStockByStockIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "partner", "product-coupon", "product-coupons", request.ProductCouponId, "stocks", request.StockId)
                .SetQueryParam("brand_id", request.BrandId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingPartnerProductCouponStockByStockIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks/{stock_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781556 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingPartnerProductCouponStockResponse> ExecuteUpdateMarketingPartnerProductCouponStockAsync(this WechatTenpayClient client, Models.UpdateMarketingPartnerProductCouponStockRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "marketing", "partner", "product-coupon", "product-coupons", request.ProductCouponId, "stocks", request.StockId);

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingPartnerProductCouponStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks/{stock_id}/deactivate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781532 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeactivateMarketingPartnerProductCouponStockResponse> ExecuteDeactivateMarketingPartnerProductCouponStockAsync(this WechatTenpayClient client, Models.DeactivateMarketingPartnerProductCouponStockRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "product-coupon", "product-coupons", request.ProductCouponId, "stocks", request.StockId, "deactivate");

            return await client.SendFlurlRequestAsJsonAsync<Models.DeactivateMarketingPartnerProductCouponStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks/{stock_id}/update-budget 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781561 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingPartnerProductCouponStockBudgetResponse> ExecuteUpdateMarketingPartnerProductCouponStockBudgetAsync(this WechatTenpayClient client, Models.UpdateMarketingPartnerProductCouponStockBudgetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "product-coupon", "product-coupons", request.ProductCouponId, "stocks", request.StockId, "update-budget");

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingPartnerProductCouponStockBudgetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks/{stock_id}/upload-coupon-codes 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781572 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadMarketingPartnerProductCouponStockCouponCodesResponse> ExecuteUploadMarketingPartnerProductCouponStockCouponCodesAsync(this WechatTenpayClient client, Models.UploadMarketingPartnerProductCouponStockCouponCodesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "product-coupon", "product-coupons", request.ProductCouponId, "stocks", request.StockId, "upload-coupon-codes");

            return await client.SendFlurlRequestAsJsonAsync<Models.UploadMarketingPartnerProductCouponStockCouponCodesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        #region /Stocks/Stores
        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks/{stock_id}/associate-stores 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781302 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AssociateMarketingPartnerProductCouponStockToStoresResponse> ExecuteAssociateMarketingPartnerProductCouponStockToStoresAsync(this WechatTenpayClient client, Models.AssociateMarketingPartnerProductCouponStockToStoresRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "product-coupon", "product-coupons", request.ProductCouponId, "stocks", request.StockId, "associate-stores");

            return await client.SendFlurlRequestAsJsonAsync<Models.AssociateMarketingPartnerProductCouponStockToStoresResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks/{stock_id}/disassociate-stores 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781537 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DisassociateMarketingPartnerProductCouponStockFromStoresResponse> ExecuteDisassociateMarketingPartnerProductCouponStockFromStoresAsync(this WechatTenpayClient client, Models.DisassociateMarketingPartnerProductCouponStockFromStoresRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "product-coupon", "product-coupons", request.ProductCouponId, "stocks", request.StockId, "disassociate-stores");

            return await client.SendFlurlRequestAsJsonAsync<Models.DisassociateMarketingPartnerProductCouponStockFromStoresResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/partner/product-coupon/product-coupons/{product_coupon_id}/stocks/{stock_id}/associated-stores 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781546 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingPartnerProductCouponStockAssociatedStoresResponse> ExecuteQueryMarketingPartnerProductCouponStockAssociatedStoresAsync(this WechatTenpayClient client, Models.QueryMarketingPartnerProductCouponStockAssociatedStoresRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "partner", "product-coupon", "product-coupons", request.ProductCouponId, "stocks", request.StockId, "associated-stores")
                .SetQueryParam("brand_id", request.BrandId)
                .SetQueryParam("page_token", request.PageToken)
                .SetQueryParam("page_size", request.PageSize);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingPartnerProductCouponStockAssociatedStoresResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
        #endregion

        #region UserCoupons
        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/product-coupon/users/{openid}/coupons 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781605 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendMarketingPartnerProductCouponUserCouponResponse> ExecuteSendMarketingPartnerProductCouponUserCouponAsync(this WechatTenpayClient client, Models.SendMarketingPartnerProductCouponUserCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "product-coupon", "users", request.OpenId, "coupons");

            return await client.SendFlurlRequestAsJsonAsync<Models.SendMarketingPartnerProductCouponUserCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/partner/product-coupon/users/{openid}/coupons 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781590 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingPartnerProductCouponUserCouponsResponse> ExecuteQueryMarketingPartnerProductCouponUserCouponsAsync(this WechatTenpayClient client, Models.QueryMarketingPartnerProductCouponUserCouponsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "partner", "product-coupon", "users", request.OpenId, "coupons")
                .SetQueryParam("brand_id", request.BrandId)
                .SetQueryParam("product_coupon_id", request.ProductCouponId)
                .SetQueryParam("stock_id", request.StockId)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("coupon_state", request.CouponState)
                .SetQueryParam("page_size", request.PageSize)
                .SetQueryParam("page_token", request.PageToken);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingPartnerProductCouponUserCouponsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/partner/product-coupon/users/{openid}/coupons/{coupon_code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781582 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingPartnerProductCouponUserCouponByCouponCodeResponse> ExecuteGetMarketingPartnerProductCouponUserCouponByCouponCodeAsync(this WechatTenpayClient client, Models.GetMarketingPartnerProductCouponUserCouponByCouponCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "partner", "product-coupon", "users", request.OpenId, "coupons", request.CouponCode)
                .SetQueryParam("brand_id", request.BrandId)
                .SetQueryParam("product_coupon_id", request.ProductCouponId)
                .SetQueryParam("stock_id", request.StockId)
                .SetQueryParam("appid", request.AppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingPartnerProductCouponUserCouponByCouponCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/product-coupon/users/{openid}/coupons/{coupon_code}/confirm 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781575 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ConfirmMarketingPartnerProductCouponUserCouponResponse> ExecuteConfirmMarketingPartnerProductCouponUserCouponAsync(this WechatTenpayClient client, Models.ConfirmMarketingPartnerProductCouponUserCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "product-coupon", "users", request.OpenId, "coupons", request.CouponCode, "confirm");

            return await client.SendFlurlRequestAsJsonAsync<Models.ConfirmMarketingPartnerProductCouponUserCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/product-coupon/users/{openid}/coupons/{coupon_code}/use 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781608 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UseMarketingPartnerProductCouponUserCouponResponse> ExecuteUseMarketingPartnerProductCouponUserCouponAsync(this WechatTenpayClient client, Models.UseMarketingPartnerProductCouponUserCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "product-coupon", "users", request.OpenId, "coupons", request.CouponCode, "use");

            return await client.SendFlurlRequestAsJsonAsync<Models.UseMarketingPartnerProductCouponUserCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/product-coupon/users/{openid}/coupons/{coupon_code}/deactivate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781578 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeactivateMarketingPartnerProductCouponUserCouponResponse> ExecuteDeactivateMarketingPartnerProductCouponUserCouponAsync(this WechatTenpayClient client, Models.DeactivateMarketingPartnerProductCouponUserCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "product-coupon", "users", request.OpenId, "coupons", request.CouponCode, "deactivate");

            return await client.SendFlurlRequestAsJsonAsync<Models.DeactivateMarketingPartnerProductCouponUserCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/product-coupon/users/{openid}/coupons/{coupon_code}/return 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015781599 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReturnMarketingPartnerProductCouponUserCouponResponse> ExecuteReturnMarketingPartnerProductCouponUserCouponAsync(this WechatTenpayClient client, Models.ReturnMarketingPartnerProductCouponUserCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "product-coupon", "users", request.OpenId, "coupons", request.CouponCode, "return");

            return await client.SendFlurlRequestAsJsonAsync<Models.ReturnMarketingPartnerProductCouponUserCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
