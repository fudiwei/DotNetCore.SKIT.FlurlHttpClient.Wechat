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
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012534855 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012692931 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingBusifavorStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/busifavor/stocks/{stock_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012534928 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012693047 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingBusifavorStockByStockIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /marketing/busifavor/stocks/{stock_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012535020 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012696764 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingBusifavorStockResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /marketing/busifavor/stocks/{stock_id}/budget 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012465739 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012465809 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingBusifavorStockBudgetResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/stocks/{stock_id}/couponcodes 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012487038 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012492853 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.UploadMarketingBusifavorStockCouponCodesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/busifavor/users/{openid}/coupons/{coupon_code}/appids/{appid} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012535011 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012693103 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingBusifavorUserCouponByCouponCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/busifavor/users/{openid}/coupons 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012534963 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012693087 ]]>
        /// </para>
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
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("stock_id", request.StockId)
                .SetQueryParam("coupon_state", request.CouponState)
                .SetQueryParam("creator_merchant", request.CreatorMerchantId)
                .SetQueryParam("sender_merchant", request.SenderMerchantId)
                .SetQueryParam("belong_merchant", request.BelongMerchantId)
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("offset", request.Offset);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingBusifavorUserCouponsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/use 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012465292 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012465359 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.SetMarketingBusifavorCouponUsedResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/associate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012465596 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012465640 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.AssociateMarketingBusifavorCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/disassociate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012465673 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012465703 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.DisassociateMarketingBusifavorCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/return 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012465845 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012465865 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingBusifavorCouponReturnResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/coupons/deactivate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012465890 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012465924 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.DeactivateMarketingBusifavorCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
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

            return await client.SendFlurlRequestAsJsonAsync<Models.SendMarketingBusifavorCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/busifavor/callbacks 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012465507 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012465557 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingBusifavorCallbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/callbacks 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012465431 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012465425 ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingBusifavorCallbackResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/subsidy/pay-receipts 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_16.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_16.shtml ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingBusifavorSubsidyPayReceiptResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/busifavor/subsidy/pay-receipts 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_19.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_19.shtml ]]>
        /// </para>
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
                .SetQueryParam("coupon_code", request.CouponCode)
                .SetQueryParam("out_subsidy_no", request.OutSubsidyNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingBusifavorSubsidyPayReceiptsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/busifavor/subsidy/pay-receipts/{subsidy_receipt_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_18.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_18.shtml ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingBusifavorSubsidyPayReceiptBySubsidyReceiptIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/subsidy/return-receipts 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_2_17.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_2_17.shtml ]]>
        /// </para>
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

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingBusifavorSubsidyReturnReceiptResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/busifavor/product-coupons/send 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4015594964 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015595255 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendMarketingBusifavorProductCouponResponse> ExecuteSendMarketingBusifavorProductCouponAsync(this WechatTenpayClient client, Models.SendMarketingBusifavorProductCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "busifavor", "product-coupons", "send");

            return await client.SendFlurlRequestAsJsonAsync<Models.SendMarketingBusifavorProductCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
