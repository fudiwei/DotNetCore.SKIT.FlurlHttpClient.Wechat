using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMarketingMemberCardActivityExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-activity/activities 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter8_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingMemberCardActivityResponse> ExecuteCreateMarketingMemberCardActivityAsync(this WechatTenpayClient client, Models.CreateMarketingMemberCardActivityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "membercard-activity", "activities");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingMemberCardActivityResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/membercard-activity/activities/{activity_id}/terminate 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter8_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminateMarketingMemberCardActivityResponse> ExecuteTerminateMarketingMemberCardActivityAsync(this WechatTenpayClient client, Models.TerminateMarketingMemberCardActivityRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "membercard-activity", "activities", request.ActivityId, "terminate");

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminateMarketingMemberCardActivityResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/membercard-activity/activities 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter8_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingMemberCardActivitiesResponse> ExecuteQueryMarketingMemberCardActivitiesAsync(this WechatTenpayClient client, Models.QueryMarketingMemberCardActivitiesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "membercard-activity", "activities");

            if (request.CardId is not null)
                flurlReq.SetQueryParam("card_id", request.CardId);

            if (request.ActivityType is not null)
                flurlReq.SetQueryParam("activity_type", request.ActivityType);

            if (request.ActivityStatus is not null)
                flurlReq.SetQueryParam("activity_status", request.ActivityStatus);

            if (request.Limit is not null)
                flurlReq.SetQueryParam("limit", request.Limit.Value.ToString());

            if (request.Offset is not null)
                flurlReq.SetQueryParam("offset", request.Offset.Value.ToString());

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingMemberCardActivitiesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/membercard-activity/activities/{activity_id} 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/membercard_open/chapter8_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.GetMarketingMemberCardActivityByActivityIdResponse> ExecuteGetMarketingMemberCardActivityByActivityIdAsync(this WechatTenpayClient client, Models.GetMarketingMemberCardActivityByActivityIdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "membercard-activity", "activities", request.ActivityId);

            return await client.SendFlurlRequestAsJsonAsync<Models.GetMarketingMemberCardActivityByActivityIdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
