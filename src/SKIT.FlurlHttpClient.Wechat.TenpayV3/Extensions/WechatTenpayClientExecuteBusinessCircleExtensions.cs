using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供智慧商圈相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteBusinessCircleExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /businesscircle/points/notify 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter8_6_2.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_6_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NotifyBusinessCirclePointsResponse> ExecuteNotifyBusinessCirclePointsAsync(this WechatTenpayClient client, Models.NotifyBusinessCirclePointsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "businesscircle", "points", "notify");

            return await client.SendRequestWithJsonAsync<Models.NotifyBusinessCirclePointsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /businesscircle/user-authorizations/{openid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter8_6_4.shtml </para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_6_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBusinessCircleUserAuthorizationByOpenIdResponse> ExecuteGetBusinessCircleUserAuthorizationByOpenIdAsync(this WechatTenpayClient client, Models.GetBusinessCircleUserAuthorizationByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "businesscircle", "user-authorizations", request.OpenId)
                .SetQueryParam("appid", request.AppId);

            if (request.SubMerchantId != null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetBusinessCircleUserAuthorizationByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
