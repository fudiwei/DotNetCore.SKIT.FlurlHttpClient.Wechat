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
    /// 为 <see cref="WechatTenpayClient"/> 提供电商收付通电商平台余额相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteMerchantFundBalanceExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /merchant/fund/balance/{account_type} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_7_3.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "merchant", "fund", "balance", request.AccountType);

            return await client.SendRequestWithJsonAsync<Models.GetMerchantFundBalanceResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /merchant/fund/dayendbalance/{account_type} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_7_4.shtml </para>
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
                .CreateRequest(request, HttpMethod.Get, "merchant", "fund", "dayendbalance", request.AccountType)
                .SetQueryParam("date", request.DateString);

            return await client.SendRequestWithJsonAsync<Models.GetMerchantFundDayendBalanceResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
