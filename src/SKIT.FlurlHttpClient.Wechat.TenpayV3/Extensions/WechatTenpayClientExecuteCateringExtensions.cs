using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供微信点餐订单相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteCateringExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /catering/orders/sync-status 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/catering.php?chapter=26_1 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SyncCateringOrderStatusResponse> ExecuteSyncCateringOrderStatusAsync(this WechatTenpayClient client, Models.SyncCateringOrderStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId == null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "catering", "orders", "sync-status");

            return await client.SendRequestWithJsonAsync<Models.SyncCateringOrderStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
