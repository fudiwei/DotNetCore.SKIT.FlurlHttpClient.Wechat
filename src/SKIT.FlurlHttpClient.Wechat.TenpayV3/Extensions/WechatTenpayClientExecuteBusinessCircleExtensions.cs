using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteBusinessCircleExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /businesscircle/points/notify 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/smart-business-circle/points/notify-points.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/smart-business-circle/points/notify-points.html </para>
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
        /// <para>异步调用 [POST] /businesscircle/parkings 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/smart-business-circle/parkings/update-parkings.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/smart-business-circle/parkings/update-parkings.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.NotifyBusinessCircleParkingsResponse> ExecuteNotifyBusinessCircleParkingsAsync(this WechatTenpayClient client, Models.NotifyBusinessCircleParkingsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "businesscircle", "parkings");

            return await client.SendRequestWithJsonAsync<Models.NotifyBusinessCircleParkingsResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /businesscircle/user-authorizations/{openid} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/smart-business-circle/user-authorizations/query-user-authorization.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/smart-business-circle/user-authorizations/query-user-authorization.html </para>
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

        /// <summary>
        /// <para>异步调用 [GET] /businesscircle/users/{openid}/points/commit_status 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/docs/merchant/apis/smart-business-circle/points/get-points-commit-status.html </para>
        /// <para>REF: https://pay.weixin.qq.com/docs/partner/apis/smart-business-circle/points/get-points-commit-status.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetBusinessCircleUserPointsCommitStatusByOpenIdResponse> ExecuteGetBusinessCircleUserPointsCommitStatusByOpenIdAsync(this WechatTenpayClient client, Models.GetBusinessCircleUserPointsCommitStatusByOpenIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "businesscircle", "users", request.OpenId, "points", "commit_status")
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("brandid", request.BrandId);

            if (request.SubMerchantId != null)
                flurlReq.SetQueryParam("sub_mchid", request.SubMerchantId);

            return await client.SendRequestWithJsonAsync<Models.GetBusinessCircleUserPointsCommitStatusByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
