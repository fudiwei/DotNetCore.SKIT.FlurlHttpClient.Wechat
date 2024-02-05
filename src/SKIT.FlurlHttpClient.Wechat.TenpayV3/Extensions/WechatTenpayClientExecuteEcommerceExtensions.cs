using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    using SKIT.FlurlHttpClient.Primitives;

    public static class WechatTenpayClientExecuteEcommerceExtensions
    {
        #region Account
        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/account/cancel-applications 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-cancel/cancel-applications/create-cancel-application.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceAccountCancelApplicationResponse> ExecuteCreateEcommerceAccountCancelApplicationAsync(this WechatTenpayClient client, Models.CreateEcommerceAccountCancelApplicationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "account", "cancel-applications");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateEcommerceAccountCancelApplicationResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/account/cancel-applications/out-apply-no/{out_apply_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-cancel/cancel-applications/get-cancel-application.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceAccountCancelApplicationByOutApplyNumberResponse> ExecuteGetEcommerceAccountCancelApplicationByOutApplyNumberAsync(this WechatTenpayClient client, Models.GetEcommerceAccountCancelApplicationByOutApplyNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "account", "cancel-applications", "out-apply-no", request.OutApplyNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceAccountCancelApplicationByOutApplyNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/account/cancel-applications/media 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-cancel/media/upload-media.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UploadEcommerceAccountCancelApplicationMediaResponse> ExecuteUploadEcommerceAccountCancelApplicationMediaAsync(this WechatTenpayClient client, Models.UploadEcommerceAccountCancelApplicationMediaRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.FileName is null)
                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ".png";

            if (request.FileHash is null)
                request.FileHash = EncodedString.ToHexString(Utilities.SHA256Utility.Hash(request.FileBytes)).Value!.ToLower();

            if (request.FileContentType is null)
                request.FileContentType = Utilities.FileNameToContentTypeMapper.GetContentTypeForImage(request.FileName!) ?? "image/png";

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "account", "cancel-applications", "media");

            using var httpContent = Utilities.FileHttpContentBuilder.Build(fileName: request.FileName, fileBytes: request.FileBytes, fileContentType: request.FileContentType, fileMetaJson: client.JsonSerializer.Serialize(request));
            return await client.SendFlurlRequestAsync<Models.UploadEcommerceAccountCancelApplicationMediaResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Applyments
        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/applyments/ 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-merchant-application/applyment/submit-applyment.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceApplymentResponse> ExecuteCreateEcommerceApplymentAsync(this WechatTenpayClient client, Models.CreateEcommerceApplymentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            // NOTICE: 注意本接口 URL 结尾的反斜杠不能删除
            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "applyments", "");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateEcommerceApplymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/applyments/{applyment_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-merchant-application/applyment/get-applyment-state.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceApplymentByApplymentIdResponse> ExecuteGetEcommerceApplymentByApplymentIdAsync(this WechatTenpayClient client, Models.GetEcommerceApplymentByApplymentIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "applyments", request.ApplymentId.ToString());

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceApplymentByApplymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/applyments/out-request-no/{out_request_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-merchant-application/applyment/get-state-by-out-request-no.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceApplymentByOutRequestNumberResponse> ExecuteGetEcommerceApplymentByOutRequestNumberAsync(this WechatTenpayClient client, Models.GetEcommerceApplymentByOutRequestNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "applyments", "out-request-no", request.OutRequestNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceApplymentByOutRequestNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Bill
        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/bill/fundflowbill 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/bill-download/sub-merchant-fund-flow-bill/get-sub-merchant-fund-flow-bill.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-bill-download/get-sub-merchant-fund-flow-bill.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceBillFundflowBillResponse> ExecuteGetEcommerceBillFundflowBillAsync(this WechatTenpayClient client, Models.GetEcommerceBillFundflowBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "bill", "fundflowbill")
                .SetQueryParam("bill_date", request.BillDateString)
                .SetQueryParam("account_type", request.AccountType)
                .SetQueryParam("algorithm", request.Algorithm);

            if (request.TarType is not null)
                flurlReq.SetQueryParam("tar_type", request.TarType);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceBillFundflowBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Fund
        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/fund/balance/{sub_mchid} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-balance/accounts/query-e-commerce-balance.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter5_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceFundBalanceResponse> ExecuteGetEcommerceFundBalanceAsync(this WechatTenpayClient client, Models.GetEcommerceFundBalanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "fund", "balance", request.SubMerchantId);

            if (request.AccountType is not null)
                flurlReq.SetQueryParam("account_type", request.AccountType);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceFundBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/fund/enddaybalance/{sub_mchid} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-balance/accounts/query-e-commerce-day-end-balance.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter5_3.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceFundDayendBalanceResponse> ExecuteGetEcommerceFundDayendBalanceAsync(this WechatTenpayClient client, Models.GetEcommerceFundDayendBalanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "fund", "enddaybalance", request.SubMerchantId)
                .SetQueryParam("date", request.DateString);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceFundDayendBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/fund/withdraw 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-withdraw/with-draws/create-sub-merchant-withdraw.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter6_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceFundWithdrawResponse> ExecuteCreateEcommerceFundWithdrawAsync(this WechatTenpayClient client, Models.CreateEcommerceFundWithdrawRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "fund", "withdraw")
                ;

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateEcommerceFundWithdrawResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/fund/withdraw/out-request-no/{out_request_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-withdraw/with-draws/query-sub-merchant-by-out-request-no.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter6_2.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceFundWithdrawByOutRequestNumberResponse> ExecuteGetEcommerceFundWithdrawByOutRequestNumberAsync(this WechatTenpayClient client, Models.GetEcommerceFundWithdrawByOutRequestNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "fund", "withdraw", "out-request-no", request.OutRequestNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceFundWithdrawByOutRequestNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/fund/withdraw/{withdraw_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-withdraw/with-draws/query-sub-merchant-withdraw-by-id.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter6_2.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceFundWithdrawByWithdrawIdResponse> ExecuteGetEcommerceFundWithdrawByWithdrawIdAsync(this WechatTenpayClient client, Models.GetEcommerceFundWithdrawByWithdrawIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "fund", "withdraw", request.WithdrawId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceFundWithdrawByWithdrawIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ProfitSharing
        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/profitsharing/orders 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-profit-sharing/orders/create-order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceProfitSharingOrderResponse> ExecuteCreateEcommerceProfitSharingOrderAsync(this WechatTenpayClient client, Models.CreateEcommerceProfitSharingOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "profitsharing", "orders")
                ;

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateEcommerceProfitSharingOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/profitsharing/orders 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-profit-sharing/orders/query-order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceProfitSharingOrderByOutOrderNumberResponse> ExecuteGetEcommerceProfitSharingOrderByOutOrderNumberAsync(this WechatTenpayClient client, Models.GetEcommerceProfitSharingOrderByOutOrderNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "profitsharing", "orders")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("transaction_id", request.TransactionId)
                .SetQueryParam("out_order_no", request.OutOrderNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceProfitSharingOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/profitsharing/returnorders 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-profit-sharing/return-orders/create-return-order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceProfitSharingReturnOrderResponse> ExecuteCreateEcommerceProfitSharingReturnOrderAsync(this WechatTenpayClient client, Models.CreateEcommerceProfitSharingReturnOrderRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "profitsharing", "returnorders")
                ;

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateEcommerceProfitSharingReturnOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/profitsharing/returnorders 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-profit-sharing/return-orders/query-return-order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceProfitSharingReturnOrderByOutOrderNumberResponse> ExecuteGetEcommerceProfitSharingReturnOrderByOutOrderNumberAsync(this WechatTenpayClient client, Models.GetEcommerceProfitSharingReturnOrderByOutOrderNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "profitsharing", "returnorders")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("out_order_no", request.OutOrderNumber)
                .SetQueryParam("out_return_no", request.OutReturnNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceProfitSharingReturnOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/profitsharing/returnorders 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-profit-sharing/return-orders/query-return-order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceProfitSharingReturnOrderByOrderIdResponse> ExecuteGetEcommerceProfitSharingReturnOrderByOrderIdAsync(this WechatTenpayClient client, Models.GetEcommerceProfitSharingReturnOrderByOrderIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "profitsharing", "returnorders")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("order_id", request.OrderId)
                .SetQueryParam("out_return_no", request.OutReturnNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceProfitSharingReturnOrderByOrderIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/profitsharing/finish-order 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-profit-sharing/orders/finish-order.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SetEcommerceProfitSharingOrderFinishResponse> ExecuteSetEcommerceProfitSharingOrderFinishAsync(this WechatTenpayClient client, Models.SetEcommerceProfitSharingOrderFinishRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "profitsharing", "finish-order")
                ;

            return await client.SendFlurlRequestAsJsonAsync<Models.SetEcommerceProfitSharingOrderFinishResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/profitsharing/orders/{transaction_id}/amounts 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-profit-sharing/orders/query-order-amount.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceProfitSharingOrderAmountsResponse> ExecuteGetEcommerceProfitSharingOrderAmountsAsync(this WechatTenpayClient client, Models.GetEcommerceProfitSharingOrderAmountsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "profitsharing", "orders", request.TransactionId, "amounts")
                ;

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceProfitSharingOrderAmountsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/profitsharing/receivers/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-profit-sharing/receivers/add-receiver.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddEcommerceProfitSharingReceiverResponse> ExecuteAddEcommerceProfitSharingReceiverAsync(this WechatTenpayClient client, Models.AddEcommerceProfitSharingReceiverRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "profitsharing", "receivers", "add")
                ;

            return await client.SendFlurlRequestAsJsonAsync<Models.AddEcommerceProfitSharingReceiverResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/profitsharing/receivers/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-profit-sharing/receivers/delete-receiver.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteEcommerceProfitSharingReceiverResponse> ExecuteDeleteEcommerceProfitSharingReceiverAsync(this WechatTenpayClient client, Models.DeleteEcommerceProfitSharingReceiverRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "profitsharing", "receivers", "delete")
                ;

            return await client.SendFlurlRequestAsJsonAsync<Models.DeleteEcommerceProfitSharingReceiverResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Refunds
        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/refunds/apply 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-refund/refunds/create-refund.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceRefundResponse> ExecuteCreateEcommerceRefundAsync(this WechatTenpayClient client, Models.CreateEcommerceRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "refunds", "apply")
                ;

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateEcommerceRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/refunds/out-refund-no/{out_refund_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-refund/refunds/query-refund-by-out-refund-no.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceRefundByOutRefundNumberResponse> ExecuteGetEcommerceRefundByOutRefundNumberAsync(this WechatTenpayClient client, Models.GetEcommerceRefundByOutRefundNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "refunds", "out-refund-no", request.OutRefundNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceRefundByOutRefundNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/refunds/id/{refund_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-refund/refunds/query-refund.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceRefundByRefundIdResponse> ExecuteGetEcommerceRefundByRefundIdAsync(this WechatTenpayClient client, Models.GetEcommerceRefundByRefundIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "refunds", "id", request.RefundId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceRefundByRefundIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/refunds/{refund_id}/return-advance 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-refund/refunds/query-return-advance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceRefundReturnAdvanceResponse> ExecuteCreateEcommerceRefundReturnAdvanceAsync(this WechatTenpayClient client, Models.CreateEcommerceRefundReturnAdvanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "refunds", request.RefundId, "return-advance")
                ;

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateEcommerceRefundReturnAdvanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/refunds/{refund_id}/return-advance 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-refund/refunds/create-return-advance.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceRefundReturnAdvanceResponse> ExecuteGetEcommerceRefundReturnAdvanceAsync(this WechatTenpayClient client, Models.GetEcommerceRefundReturnAdvanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "refunds", request.RefundId, "return-advance")
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceRefundReturnAdvanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Subsidies
        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/subsidies/create 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-subsidy/subsidies/create.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceSubsidyResponse> ExecuteCreateEcommerceSubsidyAsync(this WechatTenpayClient client, Models.CreateEcommerceSubsidyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "subsidies", "create");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateEcommerceSubsidyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/subsidies/return 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-subsidy/subsidies/return.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceSubsidyReturnResponse> ExecuteCreateEcommerceSubsidyReturnAsync(this WechatTenpayClient client, Models.CreateEcommerceSubsidyReturnRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "subsidies", "return");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateEcommerceSubsidyReturnResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/subsidies/cancel 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/ecommerce-subsidy/subsidies/cancel.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CancelEcommerceSubsidyResponse> ExecuteCancelEcommerceSubsidyAsync(this WechatTenpayClient client, Models.CancelEcommerceSubsidyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "subsidies", "cancel");

            return await client.SendFlurlRequestAsJsonAsync<Models.CancelEcommerceSubsidyResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region CombinePAPPay
        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/combine-papay/contracts/pre-entrust-sign 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_5_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.PresignEcommerceCombinePAPayContractEntrustAppResponse> ExecutePresignEcommerceCombinePAPayContractEntrustAppAsync(this WechatTenpayClient client, Models.PresignEcommerceCombinePAPayContractEntrustAppRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "combine-papay", "contracts", "pre-entrust-sign");

            return await client.SendFlurlRequestAsJsonAsync<Models.PresignEcommerceCombinePAPayContractEntrustAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/combine-papay/contracts/plan-id/{plan_id}/out-contract-code/{out_contract_code} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_5_2.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceCombinePAPPayContractByOutContractCodeResponse> ExecuteGetEcommerceCombinePAPPayContractByOutContractCodeAsync(this WechatTenpayClient client, Models.GetEcommerceCombinePAPPayContractByOutContractCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "combine-papay", "contracts", "plan-id", request.PlanId, "out-contract-code", request.OutContractCode);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceCombinePAPPayContractByOutContractCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/combine-papay/contracts/plan-id/{plan_id}/out-contract-code/{out_contract_code}/terminate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_5_3.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminateEcommerceCombinePAPPayContractResponse> ExecuteTerminateEcommerceCombinePAPPayContractAsync(this WechatTenpayClient client, Models.TerminateEcommerceCombinePAPPayContractRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "combine-papay", "contracts", "plan-id", request.PlanId, "out-contract-code", request.OutContractCode, "terminate");

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminateEcommerceCombinePAPPayContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/combine-papay/transactions 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_5_4.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceCombinePAPPayTransactionResponse> ExecuteCreateEcommerceCombinePAPPayTransactionAsync(this WechatTenpayClient client, Models.CreateEcommerceCombinePAPPayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.CombineMerchantId is not null)
                request.CombineMerchantId = client.Credentials.MerchantId;

            if (request.SubOrderList is not null)
            {
                foreach (var subOrder in request.SubOrderList)
                {
                    if (subOrder.MerchantId is null)
                        subOrder.MerchantId = request.CombineMerchantId;
                }
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "combine-papay", "transactions");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateEcommerceCombinePAPPayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/combine-papay/transactions/{combine_out_trade_no}/reverse 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_5_5.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseEcommerceCombinePAPPayTransactionResponse> ExecuteReverseEcommerceCombinePAPPayTransactionAsync(this WechatTenpayClient client, Models.ReverseEcommerceCombinePAPPayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.SubOrderList is not null)
            {
                foreach (var subOrder in request.SubOrderList)
                {
                    if (subOrder.MerchantId is null)
                        subOrder.MerchantId = client.Credentials.MerchantId;
                }
            }

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "ecommerce", "combine-papay", "transactions", request.CombineOutTradeNumber, "reverse");

            return await client.SendFlurlRequestAsJsonAsync<Models.ReverseEcommerceCombinePAPPayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/combine-papay/transactions/{combine_out_trade_no} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_5_6.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetEcommerceCombinePAPPayTransactionByCombineOutTradeNumberResponse> ExecuteGetEcommerceCombinePAPPayTransactionByCombineOutTradeNumberAsync(this WechatTenpayClient client, Models.GetEcommerceCombinePAPPayTransactionByCombineOutTradeNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "ecommerce", "combine-papay", "transactions", request.CombineOutTradeNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetEcommerceCombinePAPPayTransactionByCombineOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
