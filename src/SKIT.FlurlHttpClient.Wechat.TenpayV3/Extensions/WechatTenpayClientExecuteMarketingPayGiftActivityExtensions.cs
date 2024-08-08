using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMarketingPayGiftActivityExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/paygiftactivity/unique-threshold-activity 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/gift-activity/activity/create-full-send-act.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/gift-activity/activity/create-full-send-act.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingPayGiftActivityUniqueThresholdActivityResponse> ExecuteCreateMarketingPayGiftActivityUniqueThresholdActivityAsync(this WechatTenpayClient client, Models.CreateMarketingPayGiftActivityUniqueThresholdActivityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "paygiftactivity", "unique-threshold-activity");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingPayGiftActivityUniqueThresholdActivityResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/paygiftactivity/activities/{activity_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/gift-activity/activity/get-act-detail.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/gift-activity/activity/get-act-detail.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingPayGiftActivityByActivityIdResponse> ExecuteGetMarketingPayGiftActivityByActivityIdAsync(this WechatTenpayClient client, Models.GetMarketingPayGiftActivityByActivityIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "paygiftactivity", "activities", request.ActivityId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingPayGiftActivityByActivityIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/paygiftactivity/activities 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/gift-activity/activity/list-activities.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/gift-activity/activity/list-activities.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingPayGiftActivitiesResponse> ExecuteQueryMarketingPayGiftActivitiesAsync(this WechatTenpayClient client, Models.QueryMarketingPayGiftActivitiesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "paygiftactivity", "activities")
                .SetQueryParam("activity_name", request.ActivityName)
                .SetQueryParam("activity_status", request.ActivityStatus)
                .SetQueryParam("award_type", request.AwardType)
                .SetQueryParam("limit", request.Limit.ToString())
                .SetQueryParam("offset", request.Offset.ToString());

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingPayGiftActivitiesResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/paygiftactivity/activities/{activity_id}/terminate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/gift-activity/activity/ter-minate-activity.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/gift-activity/activity/ter-minate-activity.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminateMarketingPayGiftActivityResponse> ExecuteTerminateMarketingPayGiftActivityAsync(this WechatTenpayClient client, Models.TerminateMarketingPayGiftActivityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "paygiftactivity", "activities", request.ActivityId, "terminate");

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminateMarketingPayGiftActivityResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/paygiftactivity/activities/{activity_id}/merchants/add 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/gift-activity/activity/add-activity-merchant.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/gift-activity/activity/add-activity-merchant.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AddMarketingPayGiftActivityMerchantResponse> ExecuteAddMarketingPayGiftActivityMerchantAsync(this WechatTenpayClient client, Models.AddMarketingPayGiftActivityMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "paygiftactivity", "activities", request.ActivityId, "merchants", "add");

            return await client.SendFlurlRequestAsJsonAsync<Models.AddMarketingPayGiftActivityMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/paygiftactivity/activities/{activity_id}/merchants 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/gift-activity/activity/list-activity-merchant.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/gift-activity/activity/list-activity-merchant.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingPayGiftActivityMerchantsResponse> ExecuteQueryMarketingPayGiftActivityMerchantsAsync(this WechatTenpayClient client, Models.QueryMarketingPayGiftActivityMerchantsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "paygiftactivity", "activities", request.ActivityId, "merchants")
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("offset", request.Offset);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingPayGiftActivityMerchantsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/paygiftactivity/activities/{activity_id}/merchants/delete 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/gift-activity/activity/delete-activity-merchant.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/gift-activity/activity/delete-activity-merchant.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DeleteMarketingPayGiftActivityMerchantResponse> ExecuteDeleteMarketingPayGiftActivityMerchantAsync(this WechatTenpayClient client, Models.DeleteMarketingPayGiftActivityMerchantRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "paygiftactivity", "activities", request.ActivityId, "merchants", "delete");

            return await client.SendFlurlRequestAsJsonAsync<Models.DeleteMarketingPayGiftActivityMerchantResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/paygiftactivity/activities/{activity_id}/goods 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/merchant/apis/gift-activity/activity/list-activity-sku.html ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/docs/partner/apis/gift-activity/activity/list-activity-sku.html ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingPayGiftActivityGoodsResponse> ExecuteQueryMarketingPayGiftActivityGoodsAsync(this WechatTenpayClient client, Models.QueryMarketingPayGiftActivityGoodsRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "paygiftactivity", "activities", request.ActivityId, "goods")
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("offset", request.Offset);

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingPayGiftActivityGoodsResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
