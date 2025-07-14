using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMarketingBankFavorExtensions
    {
        /// <summary>
        /// <para>异步调用 [GET] /marketing/bank-favor/users/{openid}/coupons/{coupon_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4014569864 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingBankFavorUserCouponResponse> ExecuteGetMarketingBankFavorUserCouponAsync(this WechatTenpayClient client, Models.GetMarketingBankFavorUserCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "bank-favor", "users", request.OpenId, "coupons", request.CouponId)
                .SetQueryParam("appid", request.AppId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingBankFavorUserCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/bank-favor/users/{openid}/bank-multi-activity 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4014569793 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.SendMarketingBankFavorUserBankMultipleActivityCouponResponse> ExecuteSendMarketingBankFavorUserBankMultipleActivityCouponAsync(this WechatTenpayClient client, Models.SendMarketingBankFavorUserBankMultipleActivityCouponRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.StockCreatorMerchantId is null)
                request.StockCreatorMerchantId = client.Credentials.MerchantId;

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "bank-favor", "users", request.OpenId, "bank-multi-activity");

            return await client.SendFlurlRequestAsJsonAsync<Models.SendMarketingBankFavorUserBankMultipleActivityCouponResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
