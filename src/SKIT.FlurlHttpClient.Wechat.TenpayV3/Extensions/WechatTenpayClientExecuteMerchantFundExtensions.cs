using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMerchantFundExtensions
    {
        #region Balance
        /// <summary>
        /// <para>异步调用 [GET] /merchant/fund/balance/{account_type} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-balance/accounts/query-balance.html </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer/chapter5_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantFundBalanceResponse> ExecuteGetMerchantFundBalanceAsync(this WechatTenpayClient client, Models.GetMerchantFundBalanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "merchant", "fund", "balance", request.AccountType);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantFundBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant/fund/dayendbalance/{account_type} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-balance/accounts/query-day-end-balance.html </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer/chapter5_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantFundDayendBalanceResponse> ExecuteGetMerchantFundDayendBalanceAsync(this WechatTenpayClient client, Models.GetMerchantFundDayendBalanceRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "merchant", "fund", "dayendbalance", request.AccountType)
                .SetQueryParam("date", request.DateString);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantFundDayendBalanceResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region IncomeRecords
        /// <summary>
        /// <para>异步调用 [GET] /merchantfund/merchant/income-records 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer/chapter3_7.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer/chapter3_7.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMerchantFundMerchantIncomeRecordsResponse> ExecuteQueryMerchantFundMerchantIncomeRecordsAsync(this WechatTenpayClient client, Models.QueryMerchantFundMerchantIncomeRecordsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "merchantfund", "merchant", "income-records")
                .SetQueryParam("account_type", request.AccountType)
                .SetQueryParam("date", request.DateString)
                .SetQueryParam("limit", request.Limit);

            if (request.Offset is not null)
                flurlReq.SetQueryParam("offset", request.Offset);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMerchantFundMerchantIncomeRecordsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchantfund/partner/income-records 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter3_6.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMerchantFundPartnerIncomeRecordsResponse> ExecuteQueryMerchantFundPartnerIncomeRecordsAsync(this WechatTenpayClient client, Models.QueryMerchantFundPartnerIncomeRecordsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "merchantfund", "partner", "income-records")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("account_type", request.AccountType)
                .SetQueryParam("date", request.DateString)
                .SetQueryParam("limit", request.Limit);

            if (request.Offset is not null)
                flurlReq.SetQueryParam("offset", request.Offset);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMerchantFundPartnerIncomeRecordsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Withdraw
        /// <summary>
        /// <para>异步调用 [POST] /merchant/fund/withdraw 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-withdraw/with-draws/create-withdraw.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMerchantFundWithdrawResponse> ExecuteCreateMerchantFundWithdrawAsync(this WechatTenpayClient client, Models.CreateMerchantFundWithdrawRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "merchant", "fund", "withdraw");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMerchantFundWithdrawResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant/fund/withdraw/out-request-no/{out_request_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-withdraw/with-draws/query-withdraw-by-out-request-no.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantFundWithdrawByOutRequestNumberResponse> ExecuteGetMerchantFundWithdrawByOutRequestNumberAsync(this WechatTenpayClient client, Models.GetMerchantFundWithdrawByOutRequestNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "merchant", "fund", "withdraw", "out-request-no", request.OutRequestNumber);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantFundWithdrawByOutRequestNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant/fund/withdraw/{withdraw_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-withdraw/with-draws/query-withdraw-by-id.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantFundWithdrawByWithdrawIdResponse> ExecuteGetMerchantFundWithdrawByWithdrawIdAsync(this WechatTenpayClient client, Models.GetMerchantFundWithdrawByWithdrawIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "merchant", "fund", "withdraw", request.WithdrawId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantFundWithdrawByWithdrawIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant/fund/withdraw/bill-type/{bill_type} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/ecommerce-withdraw/with-draws/query-withdraw-bill.html </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transfer_partner/chapter6_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMerchantFundWithdrawBillResponse> ExecuteGetMerchantFundWithdrawBillAsync(this WechatTenpayClient client, Models.GetMerchantFundWithdrawBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "merchant", "fund", "withdraw", "bill-type", request.BillType)
                .SetQueryParam("bill_date", request.BillDateString);

            if (request.TarType is not null)
                flurlReq.SetQueryParam("tar_type", request.TarType);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMerchantFundWithdrawBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
