using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMarketingWithdrawFavorExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/withdraw-favor/users/{openid}/coupons 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter3_2_1.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendMarketingWithdrawFavorUserCouponResponse> ExecuteSendMarketingWithdrawFavorUserCouponAsync(this WechatTenpayClient client, Models.SendMarketingWithdrawFavorUserCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "withdraw-favor", "users", request.OpenId, "coupons");

            return await client.SendFlurlRequestAsJsonAsync<Models.SendMarketingWithdrawFavorUserCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/withdraw-favor/users/{openid}/coupons 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter3_2_2.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingWithdrawFavorUserCouponsResponse> ExecuteQueryMarketingWithdrawFavorUserCouponsAsync(this WechatTenpayClient client, Models.QueryMarketingWithdrawFavorUserCouponsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "withdraw-favor", "users", request.OpenId, "coupons")
                .SetQueryParam("appid", request.AppId)
                .SetQueryParam("mchid", request.CreatorMerchantId)
                .SetQueryParam("stock_id", request.StockId)
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("offset", request.Offset);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingWithdrawFavorUserCouponsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
