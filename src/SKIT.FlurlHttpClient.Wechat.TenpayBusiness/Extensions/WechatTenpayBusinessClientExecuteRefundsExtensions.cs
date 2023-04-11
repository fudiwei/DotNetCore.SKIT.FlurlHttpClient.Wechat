using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness
{
    public static class WechatTenpayBusinessClientExecuteRefundsExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /mse-pay/refunds 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E9%80%80%E6%AC%BE%E7%94%B3%E8%AF%B7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateRefundResponse> ExecuteCreateRefundAsync(this WechatTenpayBusinessClient client, Models.CreateRefundRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "mse-pay", "refunds");

            return await client.SendRequestWithJsonAsync<Models.CreateRefundResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/refunds/out-refund-id/{out_refund_id} 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E9%80%80%E6%AC%BE%E6%9F%A5%E8%AF%A2-%E5%A4%96%E5%8D%95%E5%8F%B7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetRefundByOutRefundIdResponse> ExecuteGetRefundByOutRefundIdAsync(this WechatTenpayBusinessClient client, Models.GetRefundByOutRefundIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "mse-pay", "refunds", "out-refund-id", request.OutRefundId);

            return await client.SendRequestWithJsonAsync<Models.GetRefundByOutRefundIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /mse-pay/refunds/refund-id/{refund_id} 接口。</para>
        /// <para>REF: https://businesspay.qq.com/p/doc/mse/api/server.html#%E9%80%80%E6%AC%BE%E6%9F%A5%E8%AF%A2-%E5%86%85%E5%8D%95%E5%8F%B7 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetRefundByRefundIdResponse> ExecuteGetRefundByRefundIdAsync(this WechatTenpayBusinessClient client, Models.GetRefundByRefundIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "mse-pay", "refunds", "refund-id", request.RefundId);

            return await client.SendRequestWithJsonAsync<Models.GetRefundByRefundIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
