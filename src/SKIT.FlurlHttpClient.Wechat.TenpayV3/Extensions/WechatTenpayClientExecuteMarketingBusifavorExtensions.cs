using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMarketingBusifavorExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/stocks 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/merchant-exclusive-coupon/busi-favor/create-busifavor-stock.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/merchant-exclusive-coupon/busi-favor/create-busifavor-stock.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingBusifavorStockResponse> ExecuteCreateMarketingBusifavorStockAsync(this WechatTenpayClient client, Models.CreateMarketingBusifavorStockRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.BelongMerchantId is null)
                request.BelongMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "busifavor", "stocks");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingBusifavorStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/busifavor/stocks/{stock_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/merchant-exclusive-coupon/busi-favor/query-stock.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/merchant-exclusive-coupon/busi-favor/query-stock.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingBusifavorStockByStockIdResponse> ExecuteGetMarketingBusifavorStockByStockIdAsync(this WechatTenpayClient client, Models.GetMarketingBusifavorStockByStockIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "busifavor", "stocks", request.StockId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingBusifavorStockByStockIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /marketing/busifavor/stocks/{stock_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/merchant-exclusive-coupon/busi-favor/modify-stock-info.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/merchant-exclusive-coupon/busi-favor/modify-stock-info.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingBusifavorStockResponse> ExecuteUpdateMarketingBusifavorStockAsync(this WechatTenpayClient client, Models.UpdateMarketingBusifavorStockRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "marketing", "busifavor", "stocks", request.StockId);

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingBusifavorStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /marketing/busifavor/stocks/{stock_id}/budget 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/merchant-exclusive-coupon/busi-favor/modify-budget.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/merchant-exclusive-coupon/busi-favor/modify-budget.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingBusifavorStockBudgetResponse> ExecuteUpdateMarketingBusifavorStockBudgetAsync(this WechatTenpayClient client, Models.UpdateMarketingBusifavorStockBudgetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "marketing", "busifavor", "stocks", request.StockId, "budget");

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingBusifavorStockBudgetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/stocks/{stock_id}/couponcodes 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/merchant-exclusive-coupon/busi-favor/upload-coupon-code.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/merchant-exclusive-coupon/busi-favor/upload-coupon-code.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadMarketingBusifavorStockCouponCodesResponse> ExecuteUploadMarketingBusifavorStockCouponCodesAsync(this WechatTenpayClient client, Models.UploadMarketingBusifavorStockCouponCodesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "busifavor", "stocks", request.StockId, "couponcodes");

            return await client.SendFlurlRequestAsJsonAsync<Models.UploadMarketingBusifavorStockCouponCodesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/busifavor/users/{openid}/coupons/{coupon_code}/appids/{appid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/merchant-exclusive-coupon/coupon/query-coupon.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/merchant-exclusive-coupon/coupon/query-coupon.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingBusifavorUserCouponByCouponCodeResponse> ExecuteGetMarketingBusifavorUserCouponByCouponCodeAsync(this WechatTenpayClient client, Models.GetMarketingBusifavorUserCouponByCouponCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "busifavor", "users", request.OpenId, "coupons", request.CouponCode, "appids", request.AppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingBusifavorUserCouponByCouponCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/busifavor/users/{openid}/coupons 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/merchant-exclusive-coupon/coupon/list-coupons-by-filter.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/merchant-exclusive-coupon/coupon/list-coupons-by-filter.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingBusifavorUserCouponsResponse> ExecuteQueryMarketingBusifavorUserCouponsAsync(this WechatTenpayClient client, Models.QueryMarketingBusifavorUserCouponsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "busifavor", "users", request.OpenId, "coupons")
                .SetQueryParam("appid", request.AppId);

            if (request.StockId is not null)
                flurlReq.SetQueryParam("stock_id", request.StockId);

            if (request.CouponState is not null)
                flurlReq.SetQueryParam("coupon_state", request.CouponState);

            if (request.CreatorMerchantId is not null)
                flurlReq.SetQueryParam("creator_merchant", request.CreatorMerchantId);

            if (request.SenderMerchantId is not null)
                flurlReq.SetQueryParam("sender_merchant", request.SenderMerchantId);

            if (request.BelongMerchantId is not null)
                flurlReq.SetQueryParam("belong_merchant", request.BelongMerchantId);

            if (request.Limit is not null)
                flurlReq.SetQueryParam("limit", request.Limit.Value.ToString());

            if (request.Offset is not null)
                flurlReq.SetQueryParam("offset", request.Offset.Value.ToString());

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingBusifavorUserCouponsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/use 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/merchant-exclusive-coupon/coupon/use-coupon.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/merchant-exclusive-coupon/coupon/use-coupon.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetMarketingBusifavorCouponUsedResponse> ExecuteSetMarketingBusifavorCouponUsedAsync(this WechatTenpayClient client, Models.SetMarketingBusifavorCouponUsedRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "busifavor", "coupons", "use");

            return await client.SendFlurlRequestAsJsonAsync<Models.SetMarketingBusifavorCouponUsedResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/associate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/merchant-exclusive-coupon/coupon/associate-trade-info.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/merchant-exclusive-coupon/coupon/associate-trade-info.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AssociateMarketingBusifavorCouponResponse> ExecuteAssociateMarketingBusifavorCouponAsync(this WechatTenpayClient client, Models.AssociateMarketingBusifavorCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "busifavor", "coupons", "associate");

            return await client.SendFlurlRequestAsJsonAsync<Models.AssociateMarketingBusifavorCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/disassociate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/merchant-exclusive-coupon/coupon/disassociate-trade-info.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/merchant-exclusive-coupon/coupon/disassociate-trade-info.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DisassociateMarketingBusifavorCouponResponse> ExecuteDisassociateMarketingBusifavorCouponAsync(this WechatTenpayClient client, Models.DisassociateMarketingBusifavorCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "busifavor", "coupons", "disassociate");

            return await client.SendFlurlRequestAsJsonAsync<Models.DisassociateMarketingBusifavorCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/return 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/merchant-exclusive-coupon/coupon/return-coupon.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/merchant-exclusive-coupon/coupon/return-coupon.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingBusifavorCouponReturnResponse> ExecuteCreateMarketingBusifavorCouponReturnAsync(this WechatTenpayClient client, Models.CreateMarketingBusifavorCouponReturnRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "busifavor", "coupons", "return");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingBusifavorCouponReturnResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/deactivate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/merchant-exclusive-coupon/coupon/deactivate-coupon.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/merchant-exclusive-coupon/coupon/deactivate-coupon.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeactivateMarketingBusifavorCouponResponse> ExecuteDeactivateMarketingBusifavorCouponAsync(this WechatTenpayClient client, Models.DeactivateMarketingBusifavorCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "busifavor", "coupons", "deactivate");

            return await client.SendFlurlRequestAsJsonAsync<Models.DeactivateMarketingBusifavorCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/{card_id}/send 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendMarketingBusifavorCouponResponse> ExecuteSendMarketingBusifavorCouponAsync(this WechatTenpayClient client, Models.SendMarketingBusifavorCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "busifavor", "coupons", request.CardId, "send");

            return await client.SendFlurlRequestAsJsonAsync<Models.SendMarketingBusifavorCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/busifavor/callbacks 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/merchant-exclusive-coupon/call-back/get-coupon-notify.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/merchant-exclusive-coupon/call-back/get-coupon-notify.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingBusifavorCallbackResponse> ExecuteGetMarketingBusifavorCallbackAsync(this WechatTenpayClient client, Models.GetMarketingBusifavorCallbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "busifavor", "callbacks")
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingBusifavorCallbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/callbacks 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/merchant-exclusive-coupon/call-back/set-coupon-notify.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/merchant-exclusive-coupon/call-back/set-coupon-notify.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingBusifavorCallbackResponse> ExecuteUpdateMarketingBusifavorCallbackAsync(this WechatTenpayClient client, Models.UpdateMarketingBusifavorCallbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "busifavor", "callbacks");

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingBusifavorCallbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/subsidy/pay-receipts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_16.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_16.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingBusifavorSubsidyPayReceiptResponse> ExecuteCreateMarketingBusifavorSubsidyPayReceiptAsync(this WechatTenpayClient client, Models.CreateMarketingBusifavorSubsidyPayReceiptRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.PayerMerchantId is null)
                request.PayerMerchantId = client.Credentials.MerchantId;

            if (request.PayeeMerchantId is null)
                request.PayeeMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "busifavor", "subsidy", "pay-receipts");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingBusifavorSubsidyPayReceiptResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/busifavor/subsidy/pay-receipts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_19.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_19.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingBusifavorSubsidyPayReceiptsResponse> ExecuteQueryMarketingBusifavorSubsidyPayReceiptsAsync(this WechatTenpayClient client, Models.QueryMarketingBusifavorSubsidyPayReceiptsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "busifavor", "subsidy", "pay-receipts")
                .SetQueryParam("stock_id", request.StockId)
                .SetQueryParam("coupon_code", request.CouponCode);

            if (request.OutSubsidyNumber is not null)
                flurlReq.SetQueryParam("out_subsidy_no", request.OutSubsidyNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingBusifavorSubsidyPayReceiptsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/busifavor/subsidy/pay-receipts/{subsidy_receipt_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_18.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_18.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingBusifavorSubsidyPayReceiptBySubsidyReceiptIdResponse> ExecuteGetMarketingBusifavorSubsidyPayReceiptBySubsidyReceiptIdAsync(this WechatTenpayClient client, Models.GetMarketingBusifavorSubsidyPayReceiptBySubsidyReceiptIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "busifavor", "subsidy", "pay-receipts", request.SubsidyReceiptId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingBusifavorSubsidyPayReceiptBySubsidyReceiptIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/subsidy/return-receipts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_17.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_17.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingBusifavorSubsidyReturnReceiptResponse> ExecuteCreateMarketingBusifavorSubsidyReturnReceiptAsync(this WechatTenpayClient client, Models.CreateMarketingBusifavorSubsidyReturnReceiptRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.PayerMerchantId is null)
                request.PayerMerchantId = client.Credentials.MerchantId;

            if (request.PayeeMerchantId is null)
                request.PayeeMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "busifavor", "subsidy", "return-receipts");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingBusifavorSubsidyReturnReceiptResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
