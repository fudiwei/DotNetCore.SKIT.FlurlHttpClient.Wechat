using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteMarketingPartnerDeliveryPlanExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/delivery-plan/delivery-plans 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016184554 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CreateMarketingPartnerDeliveryPlanResponse> ExecuteCreateMarketingPartnerDeliveryPlanAsync(this WechatTenpayClient client, Models.CreateMarketingPartnerDeliveryPlanRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "delivery-plan", "delivery-plans");

            return await client.SendFlurlRequestAsJsonAsync<Models.CreateMarketingPartnerDeliveryPlanResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [GET] /marketing/partner/delivery-plan/delivery-plans/{brand_id}/delivery-plans 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016184563 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryMarketingPartnerDeliveryPlansResponse> ExecuteQueryMarketingPartnerDeliveryPlansAsync(this WechatTenpayClient client, Models.QueryMarketingPartnerDeliveryPlansRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Get, "marketing", "partner", "delivery-plan", "delivery-plans", request.BrandId, "delivery-plans");

            return await client.SendFlurlRequestAsJsonAsync<Models.QueryMarketingPartnerDeliveryPlansResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [PATCH] /marketing/partner/delivery-plan/delivery-plans/{plan_id} 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016184594 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingPartnerDeliveryPlanResponse> ExecuteUpdateMarketingPartnerDeliveryPlanAsync(this WechatTenpayClient client, Models.UpdateMarketingPartnerDeliveryPlanRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, new HttpMethod("PATCH"), "marketing", "partner", "delivery-plan", "delivery-plans", request.PlanId);

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingPartnerDeliveryPlanResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/delivery-plan/delivery-plans/{plan_id}/terminate 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016184572 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.TerminateMarketingPartnerDeliveryPlanResponse> ExecuteTerminateMarketingPartnerDeliveryPlanAsync(this WechatTenpayClient client, Models.TerminateMarketingPartnerDeliveryPlanRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "delivery-plan", "delivery-plans", request.PlanId, "terminate");

            return await client.SendFlurlRequestAsJsonAsync<Models.TerminateMarketingPartnerDeliveryPlanResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <para>异步调用 [POST] /marketing/partner/delivery-plan/{sp_mchid}/notify-url 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4016184598 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.UpdateMarketingPartnerDeliveryPlanNotifyUrlResponse> ExecuteUpdateMarketingPartnerDeliveryPlanNotifyUrlAsync(this WechatTenpayClient client, Models.UpdateMarketingPartnerDeliveryPlanNotifyUrlRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateFlurlRequest(request, HttpMethod.Post, "marketing", "partner", "delivery-plan", client.Credentials.MerchantId, "notify-url");

            return await client.SendFlurlRequestAsJsonAsync<Models.UpdateMarketingPartnerDeliveryPlanNotifyUrlResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
