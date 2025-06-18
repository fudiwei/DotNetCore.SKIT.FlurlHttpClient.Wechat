using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecutePayScoreBillExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /payscore/merchant-bill 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_29.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetPayScoreMerchantBillResponse> ExecuteGetPayScoreMerchantBillAsync(this WechatTenpayClient client, Models.GetPayScoreMerchantBillRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "payscore", "merchant-bill")
                .SetQueryParam("bill_date", request.BillDateString)
                .SetQueryParam("algorithm", request.Algorithm)
                .SetQueryParam("tar_type", request.TarType)
                .SetQueryParam("algorithm", request.Algorithm);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetPayScoreMerchantBillResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
