using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecuteRiskExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /risk/getviolation 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/mch_bank.php?chapter=9_28&index=1&p=902 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryRiskViolationResponse> ExecuteQueryRiskViolationAsync(this WechatTenpayClient client, Models.QueryRiskViolationRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "risk", "getviolation");

            return await client.SendRequestWithXmlAsync<Models.QueryRiskViolationResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
