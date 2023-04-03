using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 为 <see cref="WechatTenpayClient"/> 提供银行周周惠相关的 API 扩展方法。
    /// </summary>
    public static class WechatTenpayClientExecuteMerchantWeeklyDiscountExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/weekly-discount/activities/{activity_id}/apply 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter6_1_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ApplyMarketingWeeklyDiscountActivityResponse> ExecuteApplyMarketingWeeklyDiscountActivityAsync(this WechatTenpayClient client, Models.ApplyMarketingWeeklyDiscountActivityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "marketing", "weekly-discount", "activities", request.ActivityId, "apply");

            return await client.SendRequestWithJsonAsync<Models.ApplyMarketingWeeklyDiscountActivityResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/weekly-discount/activities 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter6_1_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryApplyMarketingWeeklyDiscountActivitiesResponse> ExecuteQueryApplyMarketingWeeklyDiscountActivitiesAsync(this WechatTenpayClient client, Models.QueryApplyMarketingWeeklyDiscountActivitiesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "marketing", "weekly-discount", "activities")
                .SetQueryParam("applying_merchant_id", request.ApplyingMerchantId)
                .SetQueryParam("activity_area_code", request.ActivityAreaCode)
                .SetQueryParam("activity_scene", request.ActivityScene)
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("offset", request.Offset);

            if (request.StoreId != null)
                flurlReq.SetQueryParam("store_id", request.StoreId.Value);

            return await client.SendRequestWithJsonAsync<Models.QueryApplyMarketingWeeklyDiscountActivitiesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/weekly-discount/activities/{activity_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3_partner/Offline/apis/chapter6_1_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetApplyMarketingWeeklyDiscountActivityByActivityIdResponse> ExecuteGetApplyMarketingWeeklyDiscountActivityByActivityIdAsync(this WechatTenpayClient client, Models.GetApplyMarketingWeeklyDiscountActivityByActivityIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "marketing", "weekly-discount", "activities", request.ActivityId);

            return await client.SendRequestWithJsonAsync<Models.GetApplyMarketingWeeklyDiscountActivityByActivityIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
