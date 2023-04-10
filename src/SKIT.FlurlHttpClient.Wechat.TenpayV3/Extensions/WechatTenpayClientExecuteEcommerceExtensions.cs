using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteEcommerceExtensions
    {
        #region Applyments
        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/applyments/ 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_1_1.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "applyments/");

            return await client.SendRequestWithJsonAsync<Models.CreateEcommerceApplymentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/applyments/{applyment_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_1_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "applyments", request.ApplymentId.ToString());

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceApplymentByApplymentIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/applyments/out-request-no/{out_request_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_1_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "applyments", "out-request-no", request.OutRequestNumber);

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceApplymentByOutRequestNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Bill
        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/bill/fundflowbill 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_9_5.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "bill", "fundflowbill")
                .SetQueryParam("bill_date", request.BillDateString)
                .SetQueryParam("account_type", request.AccountType)
                .SetQueryParam("algorithm", request.Algorithm);

            if (request.TarType != null)
                flurlReq.SetQueryParam("tar_type", request.TarType);

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceBillFundflowBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Fund
        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/fund/balance/{sub_mchid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_7_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_8_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter5_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter5_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "fund", "balance", request.SubMerchantId);

            if (request.AccountType != null)
                flurlReq.SetQueryParam("account_type", request.AccountType);

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceFundBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/fund/enddaybalance/{sub_mchid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_7_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter5_3.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "fund", "enddaybalance", request.SubMerchantId)
                .SetQueryParam("date", request.DateString);

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceFundDayendBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/fund/withdraw 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_8_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter6_1.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "fund", "withdraw")
                ;

            return await client.SendRequestWithJsonAsync<Models.CreateEcommerceFundWithdrawResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/fund/withdraw/out-request-no/{out_request_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_8_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter6_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "fund", "withdraw", "out-request-no", request.OutRequestNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceFundWithdrawByOutRequestNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/fund/withdraw/{withdraw_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_8_3.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter6_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "fund", "withdraw", request.WithdrawId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceFundWithdrawByWithdrawIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region ProfitSharing
        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/profitsharing/orders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_1.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "profitsharing", "orders")
                ;

            return await client.SendRequestWithJsonAsync<Models.CreateEcommerceProfitSharingOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/profitsharing/orders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "profitsharing", "orders")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("transaction_id", request.TransactionId)
                .SetQueryParam("out_order_no", request.OutOrderNumber);

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceProfitSharingOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/profitsharing/returnorders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_3.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "profitsharing", "returnorders")
                ;

            return await client.SendRequestWithJsonAsync<Models.CreateEcommerceProfitSharingReturnOrderResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/profitsharing/returnorders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_4.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "profitsharing", "returnorders")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("out_order_no", request.OutOrderNumber)
                .SetQueryParam("out_return_no", request.OutReturnNumber);

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceProfitSharingReturnOrderByOutOrderNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/profitsharing/returnorders 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_4.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "profitsharing", "returnorders")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("order_id", request.OrderId)
                .SetQueryParam("out_return_no", request.OutReturnNumber);

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceProfitSharingReturnOrderByOrderIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/profitsharing/finish-order 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_5.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "profitsharing", "finish-order")
                ;

            return await client.SendRequestWithJsonAsync<Models.SetEcommerceProfitSharingOrderFinishResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/profitsharing/orders/{transaction_id}/amounts 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_9.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "profitsharing", "orders", request.TransactionId, "amounts")
                ;

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceProfitSharingOrderAmountsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/profitsharing/receivers/add 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_7.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "profitsharing", "receivers", "add")
                ;

            return await client.SendRequestWithJsonAsync<Models.AddEcommerceProfitSharingReceiverResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/profitsharing/receivers/delete 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_4_8.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "profitsharing", "receivers", "delete")
                ;

            return await client.SendRequestWithJsonAsync<Models.DeleteEcommerceProfitSharingReceiverResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Refunds
        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/refunds/apply 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_6_1.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "refunds", "apply")
                ;

            return await client.SendRequestWithJsonAsync<Models.CreateEcommerceRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/refunds/out-refund-no/{out_refund_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_6_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "refunds", "out-refund-no", request.OutRefundNumber)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceRefundByOutRefundNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/refunds/id/{refund_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_6_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "refunds", "id", request.RefundId)
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceRefundByRefundIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/refunds/{refund_id}/return-advance 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_6_4.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "refunds", request.RefundId, "return-advance")
                ;

            return await client.SendRequestWithJsonAsync<Models.CreateEcommerceRefundReturnAdvanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/refunds/{refund_id}/return-advance 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_6_5.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "refunds", request.RefundId, "return-advance")
                .SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceRefundReturnAdvanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Subsidies
        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/subsidies/create 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_5_1.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "subsidies", "create");

            return await client.SendRequestWithJsonAsync<Models.CreateEcommerceSubsidyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/subsidies/return 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_5_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "subsidies", "return");

            return await client.SendRequestWithJsonAsync<Models.CreateEcommerceSubsidyReturnResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/subsidies/cancel 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_5_3.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "subsidies", "cancel");

            return await client.SendRequestWithJsonAsync<Models.CancelEcommerceSubsidyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region CombinePAPPay
        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/combine-papay/contracts/pre-entrust-sign 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_5_1.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "combine-papay", "contracts", "pre-entrust-sign");

            return await client.SendRequestWithJsonAsync<Models.PresignEcommerceCombinePAPayContractEntrustAppResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/combine-papay/contracts/plan-id/{plan_id}/out-contract-code/{out_contract_code} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_5_2.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "combine-papay", "contracts", "plan-id", request.PlanId, "out-contract-code", request.OutContractCode);

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceCombinePAPPayContractByOutContractCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/combine-papay/contracts/plan-id/{plan_id}/out-contract-code/{out_contract_code}/terminate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_5_3.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "combine-papay", "contracts", "plan-id", request.PlanId, "out-contract-code", request.OutContractCode, "terminate");

            return await client.SendRequestWithJsonAsync<Models.TerminateEcommerceCombinePAPPayContractResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/combine-papay/transactions 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_5_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateEcommerceCombinePAPPayTransactionResponse> ExecuteCreateEcommerceCombinePAPPayTransactionAsync(this WechatTenpayClient client, Models.CreateEcommerceCombinePAPPayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.CombineMerchantId != null)
                request.CombineMerchantId = client.Credentials.MerchantId;

            if (request.SubOrderList != null)
            {
                foreach (var subOrder in request.SubOrderList)
                {
                    if (subOrder.MerchantId == null)
                        subOrder.MerchantId = request.CombineMerchantId;
                }
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "combine-papay", "transactions");

            return await client.SendRequestWithJsonAsync<Models.CreateEcommerceCombinePAPPayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /ecommerce/combine-papay/transactions/{combine_out_trade_no}/reverse 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_5_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ReverseEcommerceCombinePAPPayTransactionResponse> ExecuteReverseEcommerceCombinePAPPayTransactionAsync(this WechatTenpayClient client, Models.ReverseEcommerceCombinePAPPayTransactionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.SubOrderList != null)
            {
                foreach (var subOrder in request.SubOrderList)
                {
                    if (subOrder.MerchantId == null)
                        subOrder.MerchantId = client.Credentials.MerchantId;
                }
            }

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "ecommerce", "combine-papay", "transactions", request.CombineOutTradeNumber, "reverse");

            return await client.SendRequestWithJsonAsync<Models.ReverseEcommerceCombinePAPPayTransactionResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/combine-papay/transactions/{combine_out_trade_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter5_5_6.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "ecommerce", "combine-papay", "transactions", request.CombineOutTradeNumber);

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceCombinePAPPayTransactionByCombineOutTradeNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
