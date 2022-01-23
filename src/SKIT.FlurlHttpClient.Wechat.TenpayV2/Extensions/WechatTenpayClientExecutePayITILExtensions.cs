using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecutePayITILExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /payitil/report 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/micropay.php?chapter=9_14&index=8 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SubmitPayITILReportResponse> ExecuteSubmitPayITILReportAsync(this WechatTenpayClient client, Models.SubmitPayITILReportRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "payitil", "report");

            return await client.SendRequestWithXmlAsync<Models.SubmitPayITILReportResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
