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
    /// 为 <see cref="WechatTenpayClient"/> 提供电商收付通二级商户余额相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteEcommerceFundBalanceExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/fund/balance/{sub_mchid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_7_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_8_1.shtml </para>
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

            if (!string.IsNullOrEmpty(request.AccountType))
                flurlReq.SetQueryParam("account_type", request.AccountType);

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceFundBalanceResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /ecommerce/fund/enddaybalance/{sub_mchid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_7_2.shtml </para>
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

            return await client.SendRequestWithJsonAsync<Models.GetEcommerceFundDayendBalanceResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
