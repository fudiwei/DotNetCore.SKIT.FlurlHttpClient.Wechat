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
    /// 为 <see cref="WechatTenpayClient"/> 提供电商收付通账单相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteEcommerceBillExtensions
    {
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
                .CreateRequest(HttpMethod.Get, "ecommerce", "bill", "fundflowbill")
                .SetOptions(request)
                .SetQueryParam("bill_date", request.BillDateString)
                .SetQueryParam("account_type", request.AccountType)
                .SetQueryParam("algorithm", request.Algorithm);

            if (!string.IsNullOrEmpty(request.TarType))
                flurlReq.SetQueryParam("tar_type", request.TarType);

            return await client.SendRequestAsync<Models.GetEcommerceBillFundflowBillResponse>(flurlReq, cancellationToken: cancellationToken);
        }
    }
}
