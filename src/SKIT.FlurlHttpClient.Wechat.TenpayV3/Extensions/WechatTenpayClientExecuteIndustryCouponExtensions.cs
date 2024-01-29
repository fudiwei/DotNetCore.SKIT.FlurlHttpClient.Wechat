using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteIndustryCouponExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /industry-coupon/tokens 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_9_1.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter9_9_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateIndustryCouponTokenResponse> ExecuteCreateIndustryCouponTokenAsync(this WechatTenpayClient client, Models.CreateIndustryCouponTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "industry-coupon", "tokens");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateIndustryCouponTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
