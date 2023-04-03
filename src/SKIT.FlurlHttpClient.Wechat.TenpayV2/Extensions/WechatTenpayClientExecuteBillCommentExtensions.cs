using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    public static class WechatTenpayClientExecuteBillCommentExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /billcommentsp/batchquerycomment 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=9_17 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.BatchQueryBillCommentResponse> ExecuteBatchQueryBillCommentAsync(this WechatTenpayClient client, Models.BatchQueryBillCommentRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "billcommentsp", "batchquerycomment");

            return await client.SendRequestWithXmlAsync<Models.BatchQueryBillCommentResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
