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
    /// 为 <see cref="WechatTenpayClient"/> 提供电商收付通电商平台提现相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteMerchantFundWithdrawExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /merchant/fund/withdraw 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_8_5.shtml </para>
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
                .CreateRequest(request, HttpMethod.Post, "merchant", "fund", "withdraw");

            return await client.SendRequestWithJsonAsync<Models.CreateMerchantFundWithdrawResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant/fund/withdraw/out-request-no/{out_request_no} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_8_3.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "merchant", "fund", "withdraw", "out-request-no", request.OutRequestNumber);

            return await client.SendRequestWithJsonAsync<Models.GetMerchantFundWithdrawByOutRequestNumberResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant/fund/withdraw/{withdraw_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_8_3.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "merchant", "fund", "withdraw", request.WithdrawId);

            return await client.SendRequestWithJsonAsync<Models.GetMerchantFundWithdrawByWithdrawIdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant/fund/withdraw/bill-type/{bill_type} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_8_4.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "merchant", "fund", "withdraw", "bill-type", request.BillType)
                .SetQueryParam("bill_date", request.BillDateString);

            if (!string.IsNullOrEmpty(request.TarType))
                flurlReq.SetQueryParam("tar_type", request.TarType);

            return await client.SendRequestWithJsonAsync<Models.GetMerchantFundWithdrawBillResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
