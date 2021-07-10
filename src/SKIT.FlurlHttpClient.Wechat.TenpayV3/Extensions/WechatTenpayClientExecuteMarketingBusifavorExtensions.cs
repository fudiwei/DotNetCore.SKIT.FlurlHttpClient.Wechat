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
    /// 为 <see cref="WechatTenpayClient"/> 提供商家券相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteMarketingBusifavorExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/stocks 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingBusifavorStockResponse> ExecuteCreateMarketingBusifavorStockAsync(this WechatTenpayClient client, Models.CreateMarketingBusifavorStockRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.BelongMerchantId))
                request.BelongMerchantId = client.WechatMerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "marketing", "busifavor", "stocks");

            return await client.SendRequestWithJsonAsync<Models.CreateMarketingBusifavorStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/busifavor/stocks/{stock_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "marketing", "busifavor", "stocks", request.StockId);

            return await client.SendRequestWithJsonAsync<Models.GetMarketingBusifavorStockByStockIdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /marketing/busifavor/stocks/{stock_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_12.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_12.shtml </para>
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
                .CreateRequest(request, new HttpMethod("PATCH"), "marketing", "busifavor", "stocks", request.StockId);

            return await client.SendRequestWithJsonAsync<Models.UpdateMarketingBusifavorStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /marketing/busifavor/stocks/{stock_id}/budget 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_11.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_11.shtml </para>
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
                .CreateRequest(request, new HttpMethod("PATCH"), "marketing", "busifavor", "stocks", request.StockId, "budget");

            return await client.SendRequestWithJsonAsync<Models.UpdateMarketingBusifavorStockBudgetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/stocks/{stock_id}/couponcodes 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_6.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_6.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "marketing", "busifavor", "stocks", request.StockId, "couponcodes");

            return await client.SendRequestWithJsonAsync<Models.UploadMarketingBusifavorStockCouponCodesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/busifavor/users/{openid}/coupons/{coupon_code}/appids/{appid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_5.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_5.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "marketing", "busifavor", "users", request.OpenId, "coupons", request.CouponCode, "appids", request.AppId);

            return await client.SendRequestWithJsonAsync<Models.GetMarketingBusifavorUserCouponByCouponCodeResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/busifavor/users/{openid}/coupons 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_4.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "marketing", "busifavor", "users", request.OpenId, "coupons")
                .SetQueryParam("appid", request.AppId);

            if (!string.IsNullOrEmpty(request.StockId))
                flurlReq.SetQueryParam("stock_id", request.StockId);

            if (!string.IsNullOrEmpty(request.CouponState))
                flurlReq.SetQueryParam("coupon_state", request.CouponState);

            if (!string.IsNullOrEmpty(request.CreatorMerchantId))
                flurlReq.SetQueryParam("creator_mchid", request.CreatorMerchantId);

            if (!string.IsNullOrEmpty(request.SenderMerchantId))
                flurlReq.SetQueryParam("sender_mchid", request.SenderMerchantId);

            if (!string.IsNullOrEmpty(request.BelongMerchantId))
                flurlReq.SetQueryParam("belong_merchant", request.BelongMerchantId);

            if (request.Limit.HasValue)
                flurlReq.SetQueryParam("limit", request.Limit.Value.ToString());

            if (request.Offset.HasValue)
                flurlReq.SetQueryParam("offset", request.Offset.Value.ToString());

            return await client.SendRequestWithJsonAsync<Models.QueryMarketingBusifavorUserCouponsResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/use 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_3.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "marketing", "busifavor", "coupons", "use");

            return await client.SendRequestWithJsonAsync<Models.SetMarketingBusifavorCouponUsedResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/associate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_9.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_9.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "marketing", "busifavor", "coupons", "associate");

            return await client.SendRequestWithJsonAsync<Models.AssociateMarketingBusifavorCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/disassociate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_10.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_10.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "marketing", "busifavor", "coupons", "disassociate");

            return await client.SendRequestWithJsonAsync<Models.DisassociateMarketingBusifavorCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/return 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_13.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_13.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "marketing", "busifavor", "coupons", "return");

            return await client.SendRequestWithJsonAsync<Models.CreateMarketingBusifavorCouponReturnResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/deactivate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_14.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_14.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "marketing", "busifavor", "coupons", "deactivate");

            return await client.SendRequestWithJsonAsync<Models.DeactivateMarketingBusifavorCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/{card_id}/send 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_6_1.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "marketing", "busifavor", "coupons", request.CardId, "send");

            return await client.SendRequestWithJsonAsync<Models.SendMarketingBusifavorCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/busifavor/callbacks 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_8.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_8.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingBusifavorCallbackResponse> ExecuteGetMarketingBusifavorCallbackAsync(this WechatTenpayClient client, Models.GetMarketingBusifavorCallbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.MerchantId))
                request.MerchantId = client.WechatMerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "marketing", "busifavor", "callbacks")
                .SetQueryParam("mchid", request.MerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetMarketingBusifavorCallbackResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/callbacks 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_7.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_7.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingBusifavorCallbackResponse> ExecuteUpdateMarketingBusifavorCallbackAsync(this WechatTenpayClient client, Models.UpdateMarketingBusifavorCallbackRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.MerchantId))
                request.MerchantId = client.WechatMerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "marketing", "busifavor", "callbacks");

            return await client.SendRequestWithJsonAsync<Models.UpdateMarketingBusifavorCallbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
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

            if (string.IsNullOrEmpty(request.PayerMerchantId))
                request.PayerMerchantId = client.WechatMerchantId;

            if (string.IsNullOrEmpty(request.PayeeMerchantId))
                request.PayeeMerchantId = client.WechatMerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "marketing", "busifavor", "subsidy", "pay-receipts");

            return await client.SendRequestWithJsonAsync<Models.CreateMarketingBusifavorSubsidyPayReceiptResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
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
                .CreateRequest(request, HttpMethod.Get, "marketing", "busifavor", "subsidy", "pay-receipts", request.SubsidyReceiptId);

            return await client.SendRequestWithJsonAsync<Models.GetMarketingBusifavorSubsidyPayReceiptBySubsidyReceiptIdResponse>(flurlReq, cancellationToken: cancellationToken);
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

            if (string.IsNullOrEmpty(request.PayerMerchantId))
                request.PayerMerchantId = client.WechatMerchantId;

            if (string.IsNullOrEmpty(request.PayeeMerchantId))
                request.PayeeMerchantId = client.WechatMerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "marketing", "busifavor", "subsidy", "return-receipts");

            return await client.SendRequestWithJsonAsync<Models.CreateMarketingBusifavorSubsidyReturnReceiptResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
