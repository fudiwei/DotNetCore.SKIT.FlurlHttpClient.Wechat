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
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012534698 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012474133 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "businesscircle", "points", "notify");

            return await client.SendFlurlRequestAsJsonAsync<Models.NotifyBusinessCirclePointsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /businesscircle/parkings 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012535502 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012474127 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "businesscircle", "parkings");

            return await client.SendFlurlRequestAsJsonAsync<Models.NotifyBusinessCircleParkingsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /businesscircle/user-authorizations/{openid} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012534848 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012474135 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "businesscircle", "user-authorizations", request.OpenId)
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("appid", request.AppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBusinessCircleUserAuthorizationByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /businesscircle/users/{openid}/points/commit_status 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012534994 ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4012474129 ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Get, "businesscircle", "users", request.OpenId, "points", "commit_status")
                .SetQueryParam("sub_mchid", request.SubMerchantId)
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("brandid", request.BrandId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetBusinessCircleUserPointsCommitStatusByOpenIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
