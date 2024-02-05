using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteCateringExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /catering/orders/sync-status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3/catering.php?chapter=26_1 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SyncCateringOrderStatusResponse> ExecuteSyncCateringOrderStatusAsync(this WechatTenpayClient client, Models.SyncCateringOrderStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.MerchantId is null)
                request.MerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "catering", "orders", "sync-status");

            return await client.SendFlurlRequestAsJsonAsync<Models.SyncCateringOrderStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
